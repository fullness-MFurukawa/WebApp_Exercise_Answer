using Microsoft.AspNetCore.Mvc;
/// <summary>
/// オプション演習-01 クエリパラメータを利用する
/// </summary>
[Route("Option01")]
public class Op01Controller : Controller
{
    [HttpGet("Calc")]
    public IActionResult Calc(int value1, int value2, int opt)
    {
        var answer = 0;
        var result = "";
        switch (opt)
        {
            case 1:
                answer = value1 + value2;
                result = $"{value1} + {value2} = {answer}";
                break;
            case 2:
                answer = value1 - value2;
                result = $"{value1} - {value2} = {answer}";
                break;
            case 3:
                answer = value1 * value2;
                result = $"{value1} * {value2} = {answer}";
                break;
            case 4:
                answer = value1 / value2;
                result = $"{value1} / {value2} = {answer}";
                break;
            case 5:
                answer = value1 % value2;
                result = $"{value1} % {value2} = {answer}";
                break;
            default:
                result = "不明な計算種別です。";
                break;
        }
        return Content(result);
    }
}