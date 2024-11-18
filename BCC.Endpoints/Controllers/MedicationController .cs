
namespace BCC.Endpoints;

[ApiController]
[Route("api/[controller]")]
public class MedicationController : ControllerBase
{
    private readonly IMediator _mediator;

    public MedicationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ApiResult<List<MedicationViewModel>>> GetMedications(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetMedicationsQuery(), cancellationToken);
        return result.ToApiResult();
    }

    [HttpPost]
    public async Task<ApiResult> CreateMedication(CreateMedicationCommand command, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(command, cancellationToken);
        return response.ToApiResult();
    }

    [HttpPut]
    public async Task<ApiResult> DeleteMedication(DeleteMedicationCommand command, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(command, cancellationToken);
        return response.ToApiResult();
    }
}

