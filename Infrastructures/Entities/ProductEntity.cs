using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp_Exercise_Answer.Infrastructures.Entities;
/// <summary>
/// 商品テーブル(product)を扱うEntity Framework Coreのエンティティクラス
/// </summary>
[Table("product")]
public class ProductEntity
{
    /// <summary>
    /// 商品Id
    /// </summary>
    [Key]
    public int? Id { get; set; }
    /// <summary>
    /// 商品名
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// 単価
    /// </summary>
    public int? Price { get; set; }
    /// <summary>
    /// 商品カテゴリId
    /// </summary>
    /// <value></value>
    [Column("category_id")]
    public int? CategoryId { get; set; }
    /// <summary>
    /// 外部で結合する商品カテゴリ
    /// </summary>
    [ForeignKey("CategoryId")]
    public ProductCategoryEntity? Category { get; set; }
    /// <summary>
    /// ナビゲーション（1対1）
    /// 商品在庫
    /// </summary>
    public ProductStockEntity? Stock { get; set; }
}