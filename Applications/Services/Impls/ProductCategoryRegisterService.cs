using WebApp_Exercise_Answer.Applications.Domains;
using WebApp_Exercise_Answer.Applications.Repositories;
using WebApp_Exercise_Answer.Exceptions;
namespace WebApp_Exercise_Answer.Applications.Services.Impls;
/// <summary>
/// 商品カテゴリ登録サービスインターフェイスの実装
/// </summary>
public class ProductCategoryRegisterService : IProductCategoryRegisterService
{
    // ドメインオブジェクト:商品カテゴリのCRUD操作インターフェイス
    //private readonly IProductCategoryRepository _repository;
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="repository">商品カテゴリのCRUD操作インターフェイス</param>
    //public ProductCategoryRegisterService(IProductCategoryRepository repository)
    //{
    //    _repository = repository;
    //}

    /// <summary>
    /// 引数に指定された商品カテゴリ名の有無を調べる
    /// </summary>
    /// <param name="name">商品カテゴリ名</param>
    /// <exception cref="ExistsExceotioin">存在する場合にスローする例外</exception>
    /*
    public void Exists(string name)
    {
        // 商品カテゴリを有無を調べる
        var result = _repository.ExistsByName(name);
        // 商品カテゴリが存在する
        if (result)
        {
            throw new ExistsException($"商品カテゴリ:{name}は、既に存在します。");
        }
    }
    */
    /// <summary>
    /// 商品カテゴリを永続化する
    /// </summary>
    /// <param name="productCategory">永続化する商品カテゴリ</param>
    /*
    public void Register(ProductCategory productCategory)
    {
        // 新しい商品カテゴリを永続化する
        _repository.Create(productCategory);
    }
    */
}