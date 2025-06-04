using Microsoft.AspNetCore.Mvc;
/// <summary>
/// オプション演習-03 フォームデータを利用する
/// </summary>
[Route("Option03")]
public class Op03Controller : Controller
{
    [HttpPost("Calc")]
    public IActionResult Calc(Op03Form form)
    {
        var answer = 0;
        var result = "";
        switch (form.Opt)
        {
            case 1:
                answer = form.Value1 + form.Value2;
                result = $"{form.Value1} + {form.Value2} = {answer}";
                break;
            case 2:
                answer = form.Value1 - form.Value2;
                result = $"{form.Value1} - {form.Value2} = {answer}";
                break;
            case 3:
                answer = form.Value1 * form.Value2;
                result = $"{form.Value1} * {form.Value2} = {answer}";
                break;
            case 4:
                answer = form.Value1 / form.Value2;
                result = $"{form.Value1} / {form.Value2} = {answer}";
                break;
            case 5:
                answer = form.Value1 % form.Value2;
                result = $"{form.Value1} % {form.Value2} = {answer}";
                break;
            default:
                result = "不明な計算種別です。";
                break;
        }
        return Content(result);
    }
}