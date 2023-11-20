using AprovaPedidoChainOfRespWF.Entities;
using AprovaPedidoChainOfRespWF.Handler;
using System;
using System.Windows.Forms;

namespace AprovaPedidoChainOfRespWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if(txtDescriao.Text == "")
            {
                MessageBox.Show("Informe a Decrição.");
                txtDescriao.Focus();
                return;
            }

            decimal.TryParse(txtValor.Text, out decimal Valor);
            if (Valor <= 0)
            {
                MessageBox.Show("Valor deve ser maior que 0.");
                txtValor.Focus();
                return;

            }

            Pedido pedido = new Pedido();
            pedido.Descricao = txtDescriao.Text;
            pedido.Valor = Valor;

            IPedidoHandler pedidoHandler = new AprovacaoCoordenador();
            pedidoHandler.SetNext(new AprovacaoGerente())
                .SetNext(new AprovacaoPresidencia());

            pedidoHandler.AprovarPedido(pedido);

            if(string.IsNullOrEmpty(pedido.Result))
                pedido.Result = " sem aprovação pois passa do orçamento!";

            lblResult.Text = $"{pedido.Descricao} {pedido.Result}";



            //if (Valor <= 500)
            //{
            //    lblResult.Text = $"{pedido.Descricao} aprovado pelo Coordenador";
            //}
            //else if (Valor <= 5000)
            //{
            //    lblResult.Text = $"{pedido.Descricao} aprovado pelo Gerente";
            //}
            //else if (Valor <= 50000)
            //{
            //    lblResult.Text = $"{pedido.Descricao} aprovado pela Presidência";
            //}
            //else
            //{
            //    lblResult.Text = $"{pedido.Descricao} sem aprovação pois passa do orçamento!";
            //}
        }
    }
}
