using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Silva",
                Telefone = "71 999887766"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Paulo",
                Sobrenome = "Silva",
                Telefone = "71 999887766"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Vinicius",
                Sobrenome = "Silva",
                Telefone = "71 999887766"
            }
        };

        public AlunoController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var aluno = Alunos.Where(w => w.Id == id).FirstOrDefault();

                if (aluno == null)
                {
                    return NotFound("Aluno não encontrado!");
                }

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("nome/{nome}/sobrenome/{sobrenome}")]
        public async Task<IActionResult> GetByName(string nome, string sobrenome)
        {
            try
            {
                var aluno = Alunos.Where(w => w.Nome.ToLower().Contains(nome.ToLower()) && w.Sobrenome.ToLower().Contains(sobrenome.ToLower())).FirstOrDefault();

                if (aluno == null)
                {
                    return NotFound("Aluno não encontrado!");
                }

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Aluno aluno)
        {
            try
            {

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Aluno aluno)
        {
            try
            {

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, Aluno aluno)
        {
            try
            {

                return Ok(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
