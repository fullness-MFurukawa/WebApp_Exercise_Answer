using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Repositories;
/// <summary>
/// ドメインオブジェクト:商品カテゴリのCRUD操作インターフェイス
/// </summary>
public interface IProductCategoryRepository
{
    /// <summary>
    /// すべての商品カテゴリを取得する
    /// </summary>
    /// <returns>すべての商品カテゴリ</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    List<ProductCategory> FindAll();

    /// <summary>
    /// 引数Idに一致する商品カテゴリを取得する
    /// </summary>
    /// <param name="id">商品カテゴリId</param>
    /// <returns>該当商品カテゴリ</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    ProductCategory? FindById(int id);

    /// <summary>
    /// 引数に指定された商品カテゴリ名の存在有無を取得する
    /// </summary>
    /// <param name="name">商品カテゴリ名</param>
    /// <returns>true:存在する false:存在しない</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    bool ExistsByName(string name);

    /// <summary>
    /// 商品カテゴリを永続化する
    /// </summary>
    /// <param name="productCategory">永続化する商品カテゴリ</param>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    void Create(ProductCategory productCategory);
}