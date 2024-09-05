using Aplicacao.DTOs;
using MediatR;

namespace Aplicacao.Handlers.Pedidos
{
    public class PostCriarPedidoRequest : PedidoDTO, IRequest<PostCriarPedidoResponse>
    {
    }

    public class PostCriarPedidoResponse
    {
    }

    public class PostCriarPedidoHandler : IRequestHandler<PostCriarPedidoRequest, PostCriarPedidoResponse>
    {
        public PostCriarPedidoHandler() { }

        public Task<PostCriarPedidoResponse> Handle(PostCriarPedidoRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PostCriarPedidoResponse());
        }
    }
}
