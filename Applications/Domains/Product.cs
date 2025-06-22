using WebApp_Exercise_Answer.Exceptions;
namespace WebApp_Exercise_Answer.Applications.Domains;
/// <summary>
/// 商品を表すドメインオブジェクト
/// </summary>
public class Product 
{
    /// <summary>
    /// 商品Id
    /// </summary>
    public int? Id { get; private set; }      
    /// <summary>
    /// 商品名
    /// </summary>
    public string? Name { get; private set; } = string.Empty;    
    /// <summary>
    /// 単価
    /// </summary>
    public int? Price { get; private set; } = 0;
    /// <summary>
    /// 商品カテゴリ
    /// </summary>
    public ProductCategory? ProductCategory { get; private set; } = null;
    /// <summary>
    /// 商品在庫
    /// </summary>
    public ProductStock? ProductStock { get; private set; } = null;
    
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id">商品Id</param>
    /// <param name="name">商品名</param>
    /// <param name="price">単価</param>
    public Product(int? id , string? name , int? price)
    {
        ValidateId(id);
        ValidateName(name);
        ValidatePrice(price);
        Id = id;
        Name = name;
        Price = price;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="name">商品名</param>
    /// <param name="price">単価</param>
    public Product(string? name , int? price) :this (null , name , price) {}

    /// <summary>
    /// 商品Idのルール検証
    /// </summary>
    /// <param name="id"></param>
    private void ValidateId(int? id)
    {
        if (id == null)
        {
            return;
        }
        if (id < 1)
        {
            throw new DomainException("商品Idは1以上でなければなりません。");
        }
    }

    /// <summary>
    /// 商品名のルール検証
    /// </summary>
    private void ValidateName(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainException("商品名は必須です。");
        if (name.Length > 30)
            throw new DomainException("商品名は30文字以内で指定してください。");
    }

    /// <summary>
    /// 価格のルール検証
    /// </summary>
    private void ValidatePrice(int? price)
    {
        if (price == null)
        {
            return;
        }
        if (price < 0)
        {
            throw new DomainException("価格は0以上でなければなりません。");
        }
    }

    /// <summary>
    /// 商品名の変更
    /// </summary>
    public void ChangeName(string? name)
    {
        ValidateName(name);
        Name = name;
    }

    /// <summary>
    /// 価格の変更
    /// </summary>
    public void ChangePrice(int price)
    {
        ValidatePrice(price);
        Price = price;
    }

    /// <summary>
    /// 商品カテゴリの変更
    /// </summary>
    public void ChangeProductCategory(ProductCategory? productCategory)
    {
        ProductCategory = productCategory;
    }

    /// <summary>
    /// 等価性の検証（Idが一致していれば同一とみなす）
    /// </summary>
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not Product other) return false;
        return Id == other.Id;
    }

    public override int GetHashCode() => Id?.GetHashCode() ?? 0;

    public override string ToString()
    {
        var idText = Id?.ToString() ?? "未登録";
        var nameText = string.IsNullOrWhiteSpace(Name) ? "未登録" : Name;
        var priceText = Price?.ToString() ?? "未登録";
        var categoryText = ProductCategory?.ToString() ?? "未登録";
        var stockText = ProductStock?.ToString() ?? "未登録"; 
        return $"商品Id={idText},商品名={nameText},単価={priceText},商品カテゴリ={categoryText},商品在庫={stockText}";
    }   
}