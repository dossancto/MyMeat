using Microsoft.AspNetCore.Mvc;
using MyMeat.Application.App.Meats.Entities;

namespace MyMeat.UI.Meats.Controllers;

public partial class MeatController
{
    [HttpGet("List/")]
    public async Task<ActionResult<List<Meat>>> All()
         => await _selectMeat.All();

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<Meat>> ById(Guid id)
         => await _selectMeat.ById(id);
}
