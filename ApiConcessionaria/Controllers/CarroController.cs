using ApiConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiConcessionaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ApiContext _context;

        public CarroController(ApiContext context)
        {
            _context = context;
        }
        // GET: api/<CarroController>
        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _context.Carro;
        }

        // GET api/<CarroController>/5
        [HttpGet("{id}")]
        public Carro Get(int id)
        {
            return _context.Carro.Where(x=>x.Id == id).FirstOrDefault();
        }

        // POST api/<CarroController>
        [HttpPost]
        public void Post(Carro _carro)
        {
            _context.Carro.Add(_carro);
            _context.SaveChanges();
        }

        // PUT api/<CarroController>/5
        [HttpPut("{id}")]
        public void Put(Carro _carro,int id)
        {
            _carro.Id = id;
            _context.Carro.Update(_carro);
            _context.SaveChanges();
        }

        // DELETE api/<CarroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Carro.Remove(_context.Carro.Where(x => x.Id == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}
