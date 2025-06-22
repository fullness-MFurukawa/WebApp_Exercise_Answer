using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp_Exercise_Answer.Infrastructures.Entities;
/// <summary>
/// 商品在庫テーブル(product_stock)を扱うEntity Framework Coreのエンティティクラス
/// </summary>
[Table("product_stock")]
public class ProductStockEntity {
    /// <summary>
    /// 商品在庫Id
    /// </summary>
    [Key]
    public int? Id { get; set; }
    /// <summary>
    /// 在庫数
    /// </summary>
    public int? Stock { get; set;  }
    /// <summary>
    /// 商品番号
    /// </summary>
    [Column("product_id")]
    public int ProductId { get; set; }  
    /// <summary>
    /// 外部キーで結合する商品
    /// </summary>
    [ForeignKey("ProductId")]
    public ProductEntity? Product { get; set; }
}