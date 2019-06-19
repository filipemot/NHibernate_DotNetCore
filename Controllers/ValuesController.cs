using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using NHibernate_DotNetCore.Models;
using NHibernate_DotNetCore.Service;

namespace NHibernate_DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ISession session;
        private readonly CidadeService cidadeService;

        public ValuesController(ISession session){
            this.session = session;
            this.cidadeService = new CidadeService(session);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Cidade>> Get() => cidadeService.getCidades();

    }
}
