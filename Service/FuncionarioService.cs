using WebApiFuncionariosCRUD.DataContext;
using WebApiFuncionariosCRUD.Models;

namespace WebApiFuncionariosCRUD.Service

{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel funcionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                if (funcionario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informardados";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }

                _context.Add(funcionario);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Funcionarios.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro principal: " + ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;

            }

            return serviceResponse;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                serviceResponse.Dados = _context.Funcionarios.ToList();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nem um dado encontrado";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
