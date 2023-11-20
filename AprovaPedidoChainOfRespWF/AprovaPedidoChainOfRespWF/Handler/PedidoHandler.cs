using AprovaPedidoChainOfRespWF.Entities;

namespace AprovaPedidoChainOfRespWF.Handler
{
    public interface IPedidoHandler
    {
        IPedidoHandler SetNext(IPedidoHandler handler);
        void AprovarPedido(Pedido pedido);
    }

    public abstract class PedidoHandler : IPedidoHandler
    {
        IPedidoHandler nextHandler;

        public IPedidoHandler SetNext(IPedidoHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual void AprovarPedido(Pedido pedido)
        {
            nextHandler?.AprovarPedido(pedido);
        }
    }
}
