using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_1302223007.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mhs = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007", new List<string>{"KPL", "BasDat", "UX"}, 2022),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127", new List<string>{"KPL", "PBO", "UX"}, 2022),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042", new List<string>{"KPL", "DasJarKom", "Proting"}, 2022),
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public List<Mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mhs.Add(value);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}
