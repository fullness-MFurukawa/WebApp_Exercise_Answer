using Microsoft.EntityFrameworkCore;
using WebApp_Exercise_Answer.Infrastructures.Entities;
namespace WebApp_Exercise_Answer.Infrastructures.Context;
/// <summary>
/// アプリケーションで利用するDbContext継承クラス
/// </summary>
public class AppDbContext : DbContext 
{
    /// <summary>
    /// product_categoryテーブルにアクセスするプロパティ
    /// </summary>
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    /// <summary>
    /// productテーブルにアクセスするプロパティ
    /// </summary>
    public DbSet<ProductEntity> Products { get; set; }
    /// <summary>
    /// product_stockテーブルにアクセスするプロパティ
    /// </summary>
    public DbSet<ProductStockEntity> ProductStocks { get; set; }
    
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="options">
    ///  データベース接続情報 や ログ出力設定、トラッキング挙動の設定などのオプション
    /// </param>
    /// <returns></returns>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}