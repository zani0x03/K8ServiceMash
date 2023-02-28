
using K8ServiceMash.Core;
using K8ServiceMash.Service;
using Microsoft.AspNetCore.Mvc;

namespace K8ServiceMash.Main.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PodInfoController : ControllerBase
{

    private readonly ILogger<PodInfoController> _logger;
    private readonly IPodInfoService _podInfoService;
    public PodInfoController(ILogger<PodInfoController> logger,
        IPodInfoService podInfoService
    )
    {
        _logger = logger;
        _podInfoService = podInfoService;
    }

    [HttpGet]
    [Route("Info")]
    public PodInfo Info()
    {
        return _podInfoService.GetPodInfo();
    }
}