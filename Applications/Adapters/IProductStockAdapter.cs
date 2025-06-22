using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Adapters;
/// <summary>
/// ドメインモデル:商品在庫と他のクラスの相互変換インターフェイス
/// </summary>
/// <typeparam name="T">相互変換クラス</typeparam>
public interface IProductStockAdapter<T>
{
    /// <summary>
    /// ドメインモデル:商品在庫を他のクラスに変換する
    /// </summary>
    /// <param name="domain">ドメインモデル:商品在</param>
    /// <returns>変換先クラス</returns>
    T Convert(ProductStock domain);

    /// <summary>
    /// 他のクラスからドメインモデル:商品在を復元する
    /// </summary>
    /// <param name="othre">変換元クラス</param>
    /// <returns>ドメインモデル:商品在</returns>
    Product Restore(T other);
}