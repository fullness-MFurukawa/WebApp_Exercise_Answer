using WebApp_Exercise_Answer.Applications.Domains;
namespace WebApp_Exercise_Answer.Applications.Repositories;
/// <summary>
/// ドメインオブジェクト:商品のCRUD操作インターフェイス
/// </summary>
public interface IItemRepository
{
    /// <summary>
    /// 引数Idに一致する商品を取得する
    /// </summary>
    /// <param name="id">商品Id</param>
    /// <returns>該当商品</returns>
    /// <exception cref="InternalException">データベースアクセスエラー</exception>
    Item FindById(int id);
}

