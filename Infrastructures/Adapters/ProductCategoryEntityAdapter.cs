using WebApp_Exercise_Answer.Applications.Adapters;
using WebApp_Exercise_Answer.Applications.Domains;
using WebApp_Exercise_Answer.Infrastructures.Entities;
namespace WebApp_Exercise_Answer.Infrastructures.Adapters;
/// <summary>
/// ドメインオブジェクト:ProductCategroyとProductCategoryEntityの相互変換Adapter
/// </summary>
/// <typeparam name="TDomain">ProductCategory</typeparam>
/// <typeparam name="TTarget">ProductCategoryEntity</typeparam>
public class ProductCategoryEntityAdapter :
IConverter<ProductCategory, ProductCategoryEntity>,
IRestorer<ProductCategory, ProductCategoryEntity>
{
    /// <summary>
    /// ドメインオブジェクト:ProductCategoryをProductCategoryEntityに変換する
    /// </summary>
    /// <param name="domain">ドメインオブジェクト:ProductCategory</param>
    /// <returns>変換結果</returns>
    public ProductCategoryEntity Convert(ProductCategory domain)
    {
        ProductCategoryEntity entity = new ProductCategoryEntity();
        entity.Id = domain.Id;
        entity.Name = domain.Name;
        return entity;
    }

    /// <summary>
    ///  ProductCategoryEntityからドメインオブジェクト:ProductCategoryを復元する
    /// </summary>
    /// <typeparam name="target">ProductCategoryEntity</typeparam>
    /// <returns>ドメインオブジェクト:ProductCategory</returns>
    public ProductCategory Restore(ProductCategoryEntity target)
    {
        var domain = new ProductCategory(target.Id, target.Name);
        return domain;
    }
}