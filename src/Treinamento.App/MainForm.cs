using System;
using System.Windows.Forms;

namespace Treinamento.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.tsiProdutos.Click += TsiProdutos_Click;
            this.tsiClientes.Click += TsiClientes_Click;
        }

        private void TsiClientes_Click(object sender, EventArgs e)
        {

            var form = new ChldForms.CustomerForm();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void TsiProdutos_Click(object sender, EventArgs e)
        {
            // chamada de um form filhos
            // verifica se o form já esta aberto

            var  form = new ChldForms.ProductForm();  
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

        }

     
    }
}
