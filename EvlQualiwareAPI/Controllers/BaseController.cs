using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EvlQualiwareAPI.Controllers
{
    public class BaseController<T> : ApiController where T : class
    {
        private readonly IBaseService<T> _baseService;
        private readonly ILogApplicationService _logApplication;

        public BaseController(IBaseService<T> baseService, ILogApplicationService logApplication)
        {
            _baseService = baseService;
            _logApplication = logApplication;
        }

        protected void SaveLog(T data, TypeProcess process, int? userId)
        {
            _logApplication.SaveLog(new LogApplication { Data = JsonConvert.SerializeObject(data), Process = process });
        }
    }
}