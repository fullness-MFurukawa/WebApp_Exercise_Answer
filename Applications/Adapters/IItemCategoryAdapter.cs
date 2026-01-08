using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Adapters;
/// <summary>
/// ドメインモデル:商品カテゴリと他のクラスの相互変換インターフェイス
/// </summary>
/// <typeparam name="T">相互変換クラス</typeparam>
public interface IItemCategoryAdapter<T>
{
    /// <summary>
    /// ドメインモデル:商品カテゴリを他のクラスに変換する
    /// </summary>
    /// <param name="domain">ドメインモデル:商品カテゴリ</param>
    /// <returns>変換先クラス</returns>
    T Convert(ItemCategory domain);
    
    /// <summary>
    /// 他のクラスからドメインモデル:商品カテゴリを復元する
    /// </summary>
    /// <param name="othre">変換元クラス</param>
    /// <returns>ドメインモデル:商品カテゴリ</returns>
    ItemCategory Restore(T other);
}
