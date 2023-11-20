using AprovaPedidoChainOfRespWF.Entities;

namespace AprovaPedidoChainOfRespWF.Handler
{
    public class AprovacaoGerente : PedidoHandler
    {
        public override void AprovarPedido(Pedido pedido)
        {
            if (pedido.Valor <= 5000)
                pedido.Result = " aprovado pelo Gerente";
            else
                base.AprovarPedido(pedido);
        }
    }
}
