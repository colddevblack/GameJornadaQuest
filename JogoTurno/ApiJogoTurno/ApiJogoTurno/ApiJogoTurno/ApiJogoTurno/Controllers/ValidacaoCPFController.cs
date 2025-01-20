using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using ApiJogoTurno.Validador;
using ApiJogoTurno.Context;


namespace ApiJogoTurno.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValidacaoCPFController : ControllerBase
    {
       

        // GET api/ValidacaoCPFController/ValidarGet

        [HttpGet]
        public string ValidarGet(string CPF)
        {
            var excut = new CpfUtils();
            excut.IsValid(CPF);

            if (excut.IsValid(CPF) == true)
            {
                return "CPF Valido " + CPF;
            }
            else
            {
                return "CPF Invalido ";
            }

        }

    }
}
