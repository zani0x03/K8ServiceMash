using K8ServiceMesh.Service;
using Microsoft.AspNetCore.Mvc;

namespace K8ServiceMesh.Main.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
 
    private readonly ILogger<HealthCheckController> _logger;
    private readonly IPodInfoService _podService;
    public HealthCheckController(ILogger<HealthCheckController> logger,
        IPodInfoService podInfoService
    )
    {
        _logger = logger;
        _podService = podInfoService;
    }

    [HttpGet]
    [Route("Live")]
    public void Live()
    {
        var podInfo = _podService.GetPodInfo();
        _logger.LogInformation($"POD Online; {podInfo.Namespace}, {podInfo.Name}, {podInfo.IP}");
    }
}