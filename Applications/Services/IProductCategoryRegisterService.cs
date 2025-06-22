using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Services;
public interface IProductCategoryRegisterService
{
    /// <summary>
    /// 引数に指定された商品カテゴリ名の有無を調べる
    /// </summary>
    /// <param name="name">商品カテゴリ名</param>
    /// <exception cref="ExistsExceotioin">存在する場合にスローする例外</exception>
    void Exists(string name);   
    /// <summary>
    /// 商品カテゴリを永続化する
    /// </summary>
    /// <param name="productCategory">永続化する商品カテゴリ</param>
    void Register(ProductCategory productCategory);
}