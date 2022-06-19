using Microsoft.AspNetCore.Mvc;

namespace DITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {

        private readonly IOperacao _operacao;
        private readonly ISobre _sobre;

        public OperacaoController(IOperacao operacao)
        {
            _operacao = operacao;
            _sobre = new Sobre();
        }

        [HttpGet("Contrutor")]
        public IActionResult Constructor()
        {
            return Ok(_operacao.Id);
        }

        [HttpGet("Sobre")]
        public IActionResult SObre()
        {
            return Ok(this._sobre);
        }




    }
}