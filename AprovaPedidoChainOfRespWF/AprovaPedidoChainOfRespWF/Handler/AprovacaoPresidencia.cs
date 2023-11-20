using AprovaPedidoChainOfRespWF.Entities;

namespace AprovaPedidoChainOfRespWF.Handler
{
    internal class AprovacaoPresidencia : PedidoHandler
    {
        public override void AprovarPedido(Pedido pedido)
        {
            if (pedido.Valor <= 50000)
                pedido.Result = " aprovado pelo Presidência."; 
        }
    }
}
