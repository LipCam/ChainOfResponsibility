using AprovaPedidoChainOfRespWF.Entities;

namespace AprovaPedidoChainOfRespWF.Handler
{
    internal class AprovacaoCoordenador : PedidoHandler
    {
        public override void AprovarPedido(Pedido pedido)
        {
            if (pedido.Valor <= 500)
                pedido.Result = " aprovado pelo Coordenador.";
            else
                base.AprovarPedido(pedido);
        }
    }
}
