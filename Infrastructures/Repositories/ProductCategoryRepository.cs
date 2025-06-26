using Microsoft.EntityFrameworkCore;
using WebApp_Exercise_Answer.Applications.Domains;
using WebApp_Exercise_Answer.Applications.Repositories;
using WebApp_Exercise_Answer.Exceptions;
using WebApp_Exercise_Answer.Infrastructures.Adapters;
using WebApp_Exercise_Answer.Infrastructures.Context;
namespace WebApp_Exercise_Answer.Infrastructures.Repositories;
/// <summary>
/// ドメインオブジェクト:商品カテゴリのCRUD操作インターフェイスの実装
/// </summary>
public class ProductCategoryRepository : IProductCategoryRepository
{
    // DbContext継承クラス
    private readonly AppDbContext _appDbContext;
    // ドメインオブジェクト:ProductCategroyとProductCategoryEntityの相互変換Adapter
    private readonly ProductCategoryEntityAdapter _adapter;
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="adapter">ドメインオブジェクト:ProductCategroyとProductCategoryEntityの相互変換Adapter</param>
    public ProductCategoryRepository(
        AppDbContext appDbContext ,
        ProductCategoryEntityAdapter adapter)
    {
        _appDbContext = appDbContext;
        _adapter = adapter;
    }

    /// <summary>
    /// 商品カテゴリを永続化する
    /// </summary>
    /// <param name="productCategory">永続化する商品カテゴリ</param>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    public void Create(ProductCategory productCategory)
    {
        try
        {
            // ProductCategoryをProductCategoryEntityに変換する
            var entity = _adapter.Convert(productCategory);
            // 商品カテゴリを登録する
            _appDbContext.ProductCategories.Add(entity);
            // 登録を確定する
            _appDbContext.SaveChanges();
        }
        catch (Exception e)
        {
            throw new InternalException("商品カテゴリを永続化できませんでした。", e);
        }
    }

    /// <summary>
    /// 引数に指定された商品カテゴリ名の存在有無を取得する
    /// </summary>
    /// <param name="name">商品カテゴリ名</param>
    /// <returns>true:存在する false:存在しない</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    public bool ExistsByName(string name)
    {
        try
        {
            // 指定された商品カテゴリ名の有無を取得する
            var result = _appDbContext.ProductCategories
                .Where(c => c.Name == name).Any();  
            return result;
        }
        catch (Exception e)
        {
            throw new InternalException(
                "商品カテゴリ名の存在有無を取得できませんでした。", e);
        }
    }

    /// <summary>
    /// すべての商品カテゴリを取得する
    /// </summary>
    /// <returns>すべての商品カテゴリ</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    public List<ProductCategory> FindAll()
    {
        try
        {
            // すべての商品カテゴリを取得する
            var entities = _appDbContext.ProductCategories
                .AsNoTracking().ToList();
            // ProductCategoryのリストを作成する
            var productCategories = new List<ProductCategory>();
            //　取得したEntityからドメインオブジェクトを復元してリストに追加する
            foreach (var entity in entities)
            {
                productCategories.Add(_adapter.Restore(entity));
            }
            return productCategories;
        }
        catch (Exception e)
        {
            throw new InternalException(
                "すべての商品カテゴリを取得できませんでした。", e);
        }
    }
    /// <summary>
    /// 引数Idに一致する商品カテゴリを取得する
    /// </summary>
    /// <param name="id">商品カテゴリId</param>
    /// <returns>該当商品カテゴリ</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    public ProductCategory? FindById(int id)
    {
        try
        {
            // Idで商品カテゴリを取得する
            var entity = _appDbContext.ProductCategories
            .Where(c => c.Id == id).FirstOrDefault();
            // 存在しない場合はnullを返す
            if (entity == null)
            {
                return null;
            }
            //　取得したEntityからドメインオブジェクトを復元して返す
            return _adapter.Restore(entity);
        }
        catch (Exception e)
        {
            throw new InternalException(
                "引数Idに一致する商品カテゴリを取得できませんでした。", e);
        }
    }
}