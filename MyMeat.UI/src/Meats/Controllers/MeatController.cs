using Microsoft.AspNetCore.Mvc;
using MyMeat.Application.App.Meats.UseCases;

namespace MyMeat.UI.Meats.Controllers;

[ApiController]
[Route("[controller]")]
public partial class MeatController : ControllerBase
{
    private readonly ILogger<MeatController> _logger;
    private readonly CreateMeatUseCase _createMeat;
    private readonly UpdateMeatUseCase _updateMeat;
    private readonly DeleteMeatUseCase _deleteMeat;
    private readonly SelectMeatsUseCase _selectMeat;

    public MeatController(ILogger<MeatController> logger, CreateMeatUseCase createMeat, UpdateMeatUseCase updateMeat, DeleteMeatUseCase deleteMeat, SelectMeatsUseCase selectMeat)
    {
        _logger = logger;
        _createMeat = createMeat;
        _updateMeat = updateMeat;
        _deleteMeat = deleteMeat;
        _selectMeat = selectMeat;
    }

}
