using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp_Exercise_Answer.Infrastructures.Entities;
/// <summary>
/// 商品カテゴリテーブル(product_category)を扱うEntity Framework Coreのエンティティクラス
/// </summary>
[Table("product_category")]
public class ProductCategoryEntity {
    /// <summary>
    /// 商品カテゴリId
    /// </summary>
    /// <value></value>
    [Key]
    public int? Id { get; set; }
    /// <summary>
    /// 商品カテゴリ名
    /// </summary>
    /// <value></value>
    [MaxLength(20)]
    public string? Name { get; set; }
    /// <summary>
    /// ナビゲーションプロパティ（1対多）
    /// 商品
    /// </summary>
    public List<ProductEntity> Products { get; set; }
}