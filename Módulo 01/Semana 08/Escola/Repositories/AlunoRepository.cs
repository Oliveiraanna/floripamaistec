using Escola.Models;
using Microsoft.AspNetCore.Mvc;
using Escola.Dtos;

namespace Escola.Repositories
{
    public class AlunosRepositorys
    {
        private static List<AlunoModel> _alunos = new List<AlunoModel>()
        {
            new AlunoModel { Id = 1, Nome= " Anna"},
            new AlunoModel { Id = 2, Nome= " Karina"},
            new AlunoModel { Id = 3, Nome= " Mauricio"}
        };
        public List<AlunoModel> ListarAlunosPorNome( string nome)
        {
            // trans para lowercase - objtivo de ignorar o case-sensitive
            nome = nome.ToLower();

            //Verificação se for informado algum nome, se não, apresenta a lista de alunos
            if(string.IsNullOrEmpty(nome))
            {
                return _alunos;
            }
            // Filtro: Alunos com base no nome
            var alunosFiltrados = _alunos
                .Where(aluno => aluno.Nome != null && aluno.Nome.ToLower().Contains(nome))
                .ToList();
            return alunosFiltrados;
        }
        public AlunoModel ObeterAlunoPorId (int Id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == Id);
            return  aluno ?? new AlunoModel();
        }
        private ActionResult<AlunoModel> Ok(AlunoModel aluno)
        {
            throw new NotImplementedException();
        }
        public AlunoModel CriarAluno(AlunoDto dto)
        {
            var Alunos = new AlunoModel();
            Alunos.Id = GerarId();
            Alunos.Nome = dto.Nome;
            _alunos.Add(Alunos);
            return Alunos;
        }
        
        public void ExcluirAluno(int Id)
        {
            var Alunos= _alunos.FirstOrDefault(a => a.Id == Id);
            if (Alunos != null)
            _alunos.Remove(Alunos);
        }
        private int GerarId()
        {
            return _alunos.Last().Id + 1;
        }
    }
}


