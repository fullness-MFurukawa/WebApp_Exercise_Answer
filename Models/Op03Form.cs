using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
/// <summary>
/// オプション演習-03 フォームデータを利用する
/// </summary>
public class Op03Form
{
    /// <summary>
    /// Data Annotationの追加 
    /// オプション演習-04
    /// </summary>

    [Display(Name = "値1")]
    [Required(ErrorMessage = "{0}は入力必須です。")]
    [Range(0, 1000, ErrorMessage = "{0}は{1}以上{2}以下で入力してください。")]
    public int Value1 { get; set; } = 0;
    [Display(Name = "値2")]
    [Required(ErrorMessage = "{0}は入力必須です。")]
    [Range(0, 1000, ErrorMessage = "{0}は{1}以上{2}以下で入力してください。")]
    public int Value2 { get; set; } = 0;
    [Display(Name = "計算の種類")]
    [Range(1, 5, ErrorMessage = "{0}が選択されていません。")]
    public int Opt { get; set; } = 0;

    /// <summary>
    /// プルダウン表示するリスト
    /// </summary>
    /// <value></value>
    public List<SelectListItem> OptList { get; set; } = new List<SelectListItem>
    {
        new SelectListItem{ Text="--選択されていません--", Value="0" , Selected = true },
        new SelectListItem{ Text= "加算(+)", Value= "1" },
        new SelectListItem{ Text= "減算(-)", Value= "2" },
        new SelectListItem{ Text= "乗算(*)", Value= "3" },
        new SelectListItem{ Text= "除算(/)", Value= "4" },
        new SelectListItem{ Text= "剰余(%)", Value= "5" },
    };
    
    /// <summary>
    /// 計算結果
    /// </summary>
    /// <value></value>
    public int Answer { get; set; }
}