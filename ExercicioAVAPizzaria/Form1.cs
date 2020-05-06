using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAVAPizzaria
{
    public partial class FrmPizzaria : Form
    {
        public FrmPizzaria()
        {
            InitializeComponent();
        }

        private void FrmPizzaria_Load(object sender, EventArgs e)
        {
            //preenche o ComboBox com os sabores das Pizzas
            cboSabor.Items.Add("Mussarela");
            cboSabor.Items.Add("Palmito");
            cboSabor.Items.Add("Atum");
            cboSabor.Items.Add("Calabresa");

            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;

            //coloca o cursor no comboBox
            cboSabor.Focus();

            //Deixa os CheckBox sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //deixa o RadioButton rdbSemBorda selecionado
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // variável para armazernar o sabor
            // atribuindo o Texto do ComboBox a essa variável
            String strSabor = cboSabor.Text;

            // variável para concatenar os textos
            String strPedido = null;

            //verififca se há item do ComboBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usuário e coloca o foco do cursor no cboSabor

            if (string.IsNullOrEmpty(cboSabor.Text))
            {
                /* essa função só pode ser testada quando a propriedade 
                 * DropDownStyle do ComboBox está como DropDown */

                // mostrando a mensagem
                MessageBox.Show("Selecione um sabor de pizza!", 
                    "Pizzaria", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                // retornar com o foco para o ComboBox
                cboSabor.Focus();
                return;
            }


            // adicionando o texto do Sabor da pizza à variável do pedido
            switch (strSabor)
            {
                case "Atum":
                    strPedido = strSabor;
                    break;
                case "Mussarela":
                    strPedido = strSabor;
                    break;
                case "Calabresa":
                    strPedido = strSabor;
                    break;
                case "Palmito":
                    strPedido = strSabor;
                    break;
            }

            // verificando os ingredientes adicionais

            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }

            if(chkAzeitona.Checked)
            {
                strPedido = strPedido + " com Azeitonas";
            }

            // verificação do tipo de borda
            if(rdbComBorda.Checked)
            {
                strPedido = strPedido + " com Borda";
            }
            else
            {
                strPedido = strPedido + " sem Borda";
            }


            // emite mensagem do pedido formulado
            MessageBox.Show(strPedido, "Pizzaria", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
