using UnitOfShop.Data;
using UnitOfShop.Models;

namespace UnitOfShop.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public void Salvar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }
    }
}
