using WebApp_Exercise_Answer.Applications.Adapters;
using WebApp_Exercise_Answer.Applications.Domains;
using WebApp_Exercise_Answer.Infrastructures.Entities;
namespace WebApp_Exercise_Answer.Infrastructures.Adapters;
/// <summary>
/// ドメインオブジェクト:ItemCategoryとItemCategoryEntityの相互変換Adapter
/// </summary>
/// <typeparam name="TDomain">ItemCategory</typeparam>
/// <typeparam name="TTarget">ItemCategoryEntity</typeparam>
public class ItemCategoryEntityAdapter :
IConverter<ItemCategory, ItemCategoryEntity>,
IRestorer<ItemCategory, ItemCategoryEntity>
{
    /// <summary>
    /// ドメインオブジェクト:ItemCategoryをItemCategoryEntityに変換する
    /// </summary>
    /// <param name="domain">ドメインオブジェクト:ItemCategory</param>
    /// <returns>変換結果</returns>
    public ItemCategoryEntity Convert(ItemCategory domain)
    {
        ItemCategoryEntity entity = new ItemCategoryEntity();
        entity.Id = domain.Id;
        entity.Name = domain.Name;
        return entity;
    }

    /// <summary>
    ///  ItemCategoryEntityからドメインオブジェクト:ItemCategoryを復元する
    /// </summary>
    /// <typeparam name="target">ItemCategoryEntity</typeparam>
    /// <returns>ドメインオブジェクト:ItemCategory</returns>
    public ItemCategory Restore(ItemCategoryEntity target)
    {
        var domain = new ItemCategory(target.Id, target.Name);
        return domain;
    }
}