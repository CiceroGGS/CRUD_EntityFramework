using Microsoft.AspNetCore.Mvc;
using WebApiFuncionariosCRUD.Models;
using WebApiFuncionariosCRUD.Service;

namespace WebApiFuncionariosCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioInterface _funcionarioService;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioService = funcionarioInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _funcionarioService.GetFuncionarios());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario([FromBody] FuncionarioModel funcionario)
        {
            return Ok(await _funcionarioService.CreateFuncionario(funcionario));
        }

    }
}

