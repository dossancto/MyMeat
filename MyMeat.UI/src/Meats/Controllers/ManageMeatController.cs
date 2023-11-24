using Microsoft.AspNetCore.Mvc;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Application.App.Meats.UseCases;

namespace MyMeat.UI.Meats.Controllers;

public partial class MeatController
{
    [HttpPost("new")]
    public async Task<ActionResult<Meat>> CreateMeat(CreateMeatDto meat)
    {
        var createdMeat = await _createMeat.Execute(meat);
        return Created("/", createdMeat);
    }
    [HttpPut("edit/{id:Guid}")]
    public async Task<ActionResult<Meat>> EditMeat(Guid id, [FromBody] UpdateMeatDto meat)
    {
        var createdMeat = await _updateMeat.Execute(id, meat);
        return Created("/", createdMeat);
    }

    [HttpDelete("delete/{id:GuiD}")]
    public async Task<IActionResult> DeleteMeat(Guid id)
    {
        await _deleteMeat.Execute(id);
        return Ok("Carne deletada com sucesso");
    }
}
