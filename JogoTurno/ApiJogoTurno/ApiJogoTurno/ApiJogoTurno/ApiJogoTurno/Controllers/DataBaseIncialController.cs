﻿
using ApiJogoTurno.Context;
using ApiJogoTurno.Entidade;
using Microsoft.AspNetCore.Mvc;
//using System.Management.Automation.PowerShell;

namespace ApiJogoTurno.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataBaseIncialController : ControllerBase
    {
        //efetuar as migrations antes de executar Migrations Entity
      

        public ILogger<ClientesController> _logger;
        public DataContext db;

        public DataBaseIncialController(DataContext conect, ILogger<ClientesController> logger)
        {
            db = conect;
            _logger = logger;
        }

        //POST api/DataBaseIncial/CriarBancoCadastroInicial
        [HttpPost]
        public string CriarBancoCadastroUsuarioTeste()
        {
            // arranje  
            var cli = new Cliente()
            {
                NumberCpf = "111.444.777-35",
                Nome = "teste",
                Nascimento = DateTime.Now,
            };

            var obj = db.Clientesdb.Add(cli);

            db.SaveChanges();
            return "Cadastro efetuado no banco" + cli;
        }

     
    }
}