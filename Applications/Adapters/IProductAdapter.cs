using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Adapters;
/// <summary>
/// ドメインモデル:商品と他のクラスの相互変換インターフェイス
/// </summary>
/// <typeparam name="T">相互変換クラス</typeparam>
public interface IProductAdapter<T>
{
    /// <summary>
    /// ドメインモデル:商品を他のクラスに変換する
    /// </summary>
    /// <param name="domain">ドメインモデル:商品</param>
    /// <returns>変換先クラス</returns>
    T Convert(Product domain);

    /// <summary>
    /// 他のクラスからドメインモデル:商品を復元する
    /// </summary>
    /// <param name="othre">変換元クラス</param>
    /// <returns>ドメインモデル:商品</returns>
    Product Restore(T other);
}