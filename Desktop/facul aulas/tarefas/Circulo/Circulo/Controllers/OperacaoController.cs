using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Circulo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacaoController : ControllerBase
    {   //area = PI * (raio * raio)
        [HttpGet]
        [Route("Circulo/{a:int}/{b:int}")]
        public int Ciculo(double a, double r, const double PI=3,1416 )
        {
            Operação Operacao = new Operação();
            return Operacao.Soma(a, r, PI);

        }

    }
}



