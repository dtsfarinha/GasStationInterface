using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_17_18
{
    public struct Bomba
    {
        public float Quantidade;
        public string Tipo;
        public Estado state;
        public float Pagar;
    }

    public partial class Abastecimento : Form
    {
        private int i = 0;
        public Bomba[] b = new Bomba[4];
        Preços pr;
        Estado es;

        public Abastecimento()
        {
            InitializeComponent();
        }

       // private void MostraDados(Bomba bo)
       // {
       //     txtQuantidade.Text = bo.Quantidade.ToString();
       //     lbxTipo.Text = bo.Tipo;
       //     txtPagar.Text = bo.Pagar.ToString();
       //
       // }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            b[i].state = Estado.idle;
            lblEstado.Text = i + 1 + " " + "-" + "    " +  b[i].state.ToString();
             txtQuantidade.Text = "";
             txtPagar.Text = "";
                b[i].Pagar = float.Parse("0");
                b[i].Quantidade = float.Parse("0");

            
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            b[i].state = Estado.abastecer;
            lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (b[i].Tipo == null)
            {
                MessageBox.Show("Não selecionou nunhum tipo de Combustivel!");
                return;
            }

            if (!string.IsNullOrEmpty(txtQuantidade.Text) && !string.IsNullOrEmpty(txtPagar.Text))
            { 
               MessageBox.Show("So pode introduzir ou a Quantidade ou o valor a pagar, nunca os dois! ");
               return;
            }


            if (!string.IsNullOrEmpty(txtPagar.Text) && txtPagar.Text != "0" && string.IsNullOrEmpty(txtQuantidade.Text))
            {
                b[i].Pagar = float.Parse(txtPagar.Text);
                if (b[i].Tipo == "Gasolina")
                {
                    txtQuantidade.Text = (b[i].Pagar / pr.p.ga).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " +"-" + "    " + b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasolina+")
                {
                    txtQuantidade.Text = (b[i].Pagar / pr.p.gap).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " +"-" + "    " + b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasóleo")
                {
                    txtQuantidade.Text = (b[i].Pagar / pr.p.go).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " + "-" + "    "+ b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasóleo+")
                {
                    txtQuantidade.Text = (b[i].Pagar / pr.p.gop).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " +"-" + "    " + b[i].state.ToString();
                }
                b[i].Quantidade = float.Parse(txtQuantidade.Text);
            }

            if (!string.IsNullOrEmpty(txtQuantidade.Text) && txtQuantidade.Text != "0" && string.IsNullOrEmpty(txtPagar.Text))
            {
                b[i].Quantidade = float.Parse(txtQuantidade.Text);
                if (b[i].Tipo == "Gasolina")
                {
                    txtPagar.Text = (pr.p.ga * b[i].Quantidade).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasolina+")
                {
                    txtPagar.Text = (pr.p.gap * b[i].Quantidade).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasóleo")
                {
                    txtPagar.Text = (pr.p.go * b[i].Quantidade).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
                }

                if (b[i].Tipo == "Gasóleo+")
                {
                    txtPagar.Text = (pr.p.gop * b[i].Quantidade).ToString();
                    b[i].state = Estado.abastecer;
                    lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
                }
                b[i].Pagar = float.Parse(txtPagar.Text);
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            i = 0;
            lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
            txtPagar.Text = b[i].Pagar.ToString();
            txtQuantidade.Text = b[i].Quantidade.ToString();
            lbxTipo.Text = b[i].Tipo;
            if (txtPagar.Text == "0")
                txtPagar.Text = "";
            if (txtQuantidade.Text == "0")
                txtQuantidade.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            i = 1;
            lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
            txtPagar.Text = b[i].Pagar.ToString();
            txtQuantidade.Text = b[i].Quantidade.ToString();
            lbxTipo.Text = b[i].Tipo;
            if (txtPagar.Text == "0")
                txtPagar.Text = "";
            if (txtQuantidade.Text == "0")
                txtQuantidade.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            i = 2;
            lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
            txtPagar.Text = b[i].Pagar.ToString();
            txtQuantidade.Text = b[i].Quantidade.ToString();
            lbxTipo.Text = b[i].Tipo;
            if (txtPagar.Text == "0")
                txtPagar.Text = "";
            if (txtQuantidade.Text == "0")
                txtQuantidade.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            i = 3;
            lblEstado.Text = i + 1 + " " + "-" + "    " + b[i].state.ToString();
            txtPagar.Text = b[i].Pagar.ToString();
            txtQuantidade.Text = b[i].Quantidade.ToString();
            lbxTipo.Text = b[i].Tipo;
            if (txtPagar.Text == "0")
                txtPagar.Text = "";
            if (txtQuantidade.Text == "0")
                txtQuantidade.Text = "";
        }

        private void lbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            b[i].Tipo = lbxTipo.SelectedItem.ToString();
        }

        private void Abastecimento_Shown(object sender, EventArgs e)
        {
            pr = (Preços)this.Owner;
        }
    }
}
