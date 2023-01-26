using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories;

namespace UnitOfShop.Controllers
{
    [Route("v1/pedidos")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Pedido Post([FromServices] IClienteRepository clienteRepository, [FromServices] IPedidoRepository pedidoRepository, [FromServices] IUnitOfWork uow)
        {
            try
            {
                var cliente = new Cliente { Nome = "Danilo Silva" };
                var pedido = new Pedido { Numero = "123", Cliente = cliente };

                clienteRepository.Salvar(cliente);
                pedidoRepository.Salvar(pedido);

                uow.Commit();

                return pedido;
            }
            catch
            {
                uow.Rollback();
                return null;
            }
        }
    }
}
