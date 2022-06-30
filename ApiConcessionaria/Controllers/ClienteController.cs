using ApiConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiConcessionaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClienteController(ApiContext context)
        {
            _context = context;
        }
        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var qry = from  cliente in _context.Cliente 
                       join carro in _context.Carro   on cliente.IdCarro equals carro.Id
                      select new Cliente
                      {
                          Id = cliente.Id,
                          Cpf = cliente.Cpf,
                          Nome = cliente.Nome,
                          Email = cliente.Email,
                          Telefone = cliente.Telefone,
                          Cnh = cliente.Cnh,   
                          IdCarro = cliente.IdCarro,
                          Carro = carro
                      };
            return qry;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _context.Cliente.Where(x=>x.Id == id).FirstOrDefault();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post(Cliente _cliente)
        {
            _context.Cliente.Add(_cliente);
            _context.SaveChanges();
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(Cliente _cliente, int id)
        {
            _cliente.Id = id;
            _context.Cliente.Update(_cliente);
            _context.SaveChanges();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Cliente.Remove(_context.Cliente.Where(x => x.Id == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}
