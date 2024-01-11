using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIExplained.Models;
using DIExplained.Interfaces;
using System.Text;
using DIExplained.Services;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace DIExplained.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IScopedGuidService scope_1;
    private readonly IScopedGuidService scope_2;

    private readonly ITransientGuidService transient_1;
    private readonly ITransientGuidService transient_2;

    private readonly ISingletonGuidService singleton_1;
    private readonly ISingletonGuidService singleton_2;

    private readonly IKeyedServiceFactory keyedServiceFactory;

    private readonly IWeatherService weatherService;

    private readonly IEnvService envService;

    public HomeController(ILogger<HomeController> logger, IScopedGuidService scope_1, IScopedGuidService scope_2, ITransientGuidService transient_1, ITransientGuidService transient_2, ISingletonGuidService singleton_1, ISingletonGuidService singleton_2, IKeyedServiceFactory keyedServiceFactory, IWeatherService weatherService, IEnvService envService)
    {
        _logger = logger;
        this.scope_1= scope_1;
        this.scope_2 = scope_2;
        this.transient_1 = transient_1;
        this.transient_2 = transient_2;
        this.singleton_1 = singleton_1;
        this.singleton_2 = singleton_2;
        this.keyedServiceFactory = keyedServiceFactory;
        this.weatherService = weatherService;
        this.envService = envService;
    }

    public IActionResult Index()
    {
        IKeyedService keyedServiceA = keyedServiceFactory.GetService("KeyA");
        string keyedServiceA_Implementation = "";
        string keyedServiceB_Implementation = "";
        if (keyedServiceA != null)
        {
            keyedServiceA_Implementation = keyedServiceA.PerformKeyedAction();
        }
        IKeyedService keyedServiceB = keyedServiceFactory.GetService("KeyB");

        if (keyedServiceB != null)
        {
            keyedServiceB_Implementation = keyedServiceB.PerformKeyedAction();
        }

        ViewBag.scope_1 = scope_1.GetGuid();
        ViewBag.scope_2 = scope_2.GetGuid();
        ViewBag.transient_1 = transient_1.GetGuid();
        ViewBag.transient_2 = transient_2.GetGuid();
        ViewBag.singleton_1 = singleton_1.GetGuid();
        ViewBag.singleton_2 = singleton_2.GetGuid();
        ViewBag.keyedServiceA_Implementation = keyedServiceA_Implementation;
        ViewBag.keyedServiceB_Implementation = keyedServiceB_Implementation;
        ViewBag.weatherService = weatherService;
        ViewBag.envService = envService;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

