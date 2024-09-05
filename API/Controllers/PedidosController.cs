using Aplicacao.Handlers.Pedidos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/pedidos")]
    public class PedidosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PedidosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CriarPedido([FromBody] PostCriarPedidoRequest request) 
        {
            return Ok(_mediator.Send(request).Result);
        }
    }
}