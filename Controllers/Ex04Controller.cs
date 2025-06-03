using Microsoft.AspNetCore.Mvc;
/// <summary>
/// 演習-04 [FormQuery]属性を利用してクエリパラメータを受け取る
/// </summary>
[Route("Exercise04")]
public class Ex04Controller : Controller
{
    /// <summary>
    /// リクエストパラメータを加算した結果を返す
    /// </summary>
    /// <param name="value1">加算対象</param>
    /// <param name="value2">加算対象</param>
    /// <returns>加算結果</returns>
    [HttpGet("Calc")]
    public IActionResult Calc([FromQuery] int value1 ,[FromQuery] int value2)
    {
        var result = value1 + value2;
        return Content($"{value1} + {value2} = {result}");
    }
}