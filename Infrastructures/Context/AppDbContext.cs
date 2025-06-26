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

    /// <summary>
    /// エンティティの結合
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ProductとProductCategory:多対1リレーション
        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            // 外部キーで参照されている親エンティティを削除しようとしたときに、エラーが発生して削除できない
            .OnDelete(DeleteBehavior.Restrict);

        // ProductとProductStock:1対1リレーション
        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.Stock)
            .WithOne(ps => ps.Product)
            .HasForeignKey<ProductStockEntity>(ps => ps.ProductId)
            // 親エンティティが削除されたときに、関連する子エンティティも自動的に削除される
            .OnDelete(DeleteBehavior.Cascade); 
    }
}