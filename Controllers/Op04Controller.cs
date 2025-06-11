namespace WebApp_Exercise_Answer.Controllers;
using Microsoft.AspNetCore.Mvc;
/// <summary>
/// オプション演習-04 タグヘルパーを利用する
/// </summary>
[Route("Option04")]
public class Op04Controller : Controller
{
    /// <summary>
    /// 入力画面の表示
    /// </summary>
    /// <returns></returns>
    [HttpGet("Enter")]
    public IActionResult Enter()
    {
        var form = new Op03Form();
        return View(form);
    }

    /// <summary>
    /// 計算結果を表示
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    [HttpPost("Result")]
    public IActionResult Result(Op03Form form)
    {
        if (!ModelState.IsValid)
        {
            return View("Enter", form);
        }
        switch (form.Opt)
        {
            case 1:
                form.Answer = form.Value1 + form.Value2;
                break;
            case 2:
                form.Answer = form.Value1 - form.Value2;
                break;
            case 3:
                form.Answer = form.Value1 * form.Value2;
                break;
            case 4:
                form.Answer = form.Value1 / form.Value2;
                break;
            case 5:
                form.Answer = form.Value1 % form.Value2;
                break;
            default:
                ModelState.AddModelError("Opt", "不明な計算種別です。");
                break;
        }
        return View(form);
    }

      /// <summary>
    /// [戻る]ボタンクリックアクション
    /// </summary>
    /// <returns></returns>
    [HttpGet("Back")]
    public IActionResult Back()
    {
        var form = new Op03Form();
        return View("Enter", form);
    }
}
