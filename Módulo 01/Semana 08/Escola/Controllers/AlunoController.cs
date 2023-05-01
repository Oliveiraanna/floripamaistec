using Escola.Dtos;
using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;
using Escola.Models;


namespace Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
        {
            private readonly AlunosRepositorys _alunosRepository;
            public AlunoController()
            {
                _alunosRepository = new AlunosRepositorys();
            }

            [HttpGet]
            public ActionResult<List<AlunoModel>> Get([FromQuery] string nome)
            {
                var alunos = _alunosRepository.ListarAlunosPorNome(nome);
                return Ok(alunos);
            }

            // aluno por id
            [HttpGet("{id}")]
            public ActionResult<AlunoModel> Get(int id)
            {
                var aluno = _alunosRepository.ObeterAlunoPorId(id);
                if (aluno == null)
                {
                    return NotFound(); //Status 404
                }
                return Ok(aluno); // Status 200
            }

            // criação do aluno
            [HttpPost]
            public ActionResult<AlunoModel> CriarAluno([FromBody] AlunoDto alunoDto)
            {
                var repository = new AlunosRepositorys();
                var aluno = repository.CriarAluno(alunoDto);
                return CreatedAtAction(nameof(AlunoController.Get), new{id = aluno.Id},aluno);
            }
            
        
        
        
        // Exclui
            [HttpDelete] 
            [Route("{id}")]
            public ActionResult<AlunoModel> Excluir(int id)
            {
                var repository = new AlunosRepositorys();
                repository.ExcluirAluno(id);
                return NoContent();                
            }

        }
}