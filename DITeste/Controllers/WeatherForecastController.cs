using Microsoft.AspNetCore.Mvc;

namespace DITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {

        private readonly IOperacao _operacao;
        private readonly ISobre _sobre;
        private readonly IEndereco _endereco;

        public OperacaoController(IOperacao operacao, IEndereco endereco)
        {
            _operacao = operacao;
            _sobre = new Sobre();
            _endereco = endereco;
        }

        [HttpGet("Contrutor")]
        public IActionResult Constructor()
        {
            return Ok(_operacao.Id);
        }

        [HttpGet("Sobre")]
        public IActionResult Sobre()
        {
            return Ok(this._sobre);
        }

        [HttpGet("Endereco")]
        public IActionResult Endereco()
        {
            return Ok(this._endereco);
        }




    }
}