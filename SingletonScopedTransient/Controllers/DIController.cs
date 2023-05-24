using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingletonScopedTransient.BusinessEngine.Interfaces;
using SingletonScopedTransient.BusinessEngine.Services;

namespace SingletonScopedTransient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIController : ControllerBase
    {
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly IMyTransientService _transientService;
        private readonly AllManagementService _allmanagementService;

        public DIController(IMyScopedService myScopedService, IMyTransientService myTransientService, IMySingletonService mySingletonService, AllManagementService allManagementService)
        {
            _singletonService = mySingletonService;
            _transientService = myTransientService;
            _scopedService = myScopedService;
            _allmanagementService = allManagementService;
        }

        [HttpGet]
        [Route("firstRequest")]
        public IActionResult FirstRequest()
        {
            List<Guid> list1 = new List<Guid>
            {
                _singletonService.guidId,
                _scopedService.guidId,
                _transientService.guidId
            };
            List<Guid> list2 = new List<Guid>
            {
                _allmanagementService._singletonService.guidId,
                _allmanagementService._scopedService.guidId,
                _allmanagementService._transientService.guidId
            };
            list1.AddRange(list2);
            return Ok(list1);
        }

        [HttpGet]
        [Route("secondRequest")]
        public IActionResult SecondRequest()
        {
            List<Guid> list = new List<Guid>();
            list.Add(_singletonService.guidId);
            list.Add(_scopedService.guidId);
            list.Add(_transientService.guidId);
            return Ok(list);
        }
    }
}
