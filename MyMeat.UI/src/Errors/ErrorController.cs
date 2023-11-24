using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMeat.Application.Exceptions;

namespace MyMeat.UI.Erros;

[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ControllerBase
{
    [Route("/Error")]
    public ActionResult OnGetError()
    {
        var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        var error = exceptionHandlerPathFeature?.Error;

        if (error is NotFoundException)
        {
            var ex = (NotFoundException)error;
            return StatusCode(404, ex.Message);
        }

        if (error is ValidationFailException)
        {
            var ex = (ValidationFailException)error;
            return StatusCode(400, new
            {
                Message = ex.Message,
                Erros = ex.Errors.Select(x => x.message)
            });
        }

        if (error is Exception)
        {
            var ex = error;
            return StatusCode(500, ex.Message);
        }

        return Ok("Everything is okay");
    }
}
