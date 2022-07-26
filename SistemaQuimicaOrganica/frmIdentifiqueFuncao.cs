using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaQuimicaOrganica
{
    public partial class frmIdentifiqueFuncao : Form
    {
        string funcao = "";
        int Questoes = 0;
        public int Acertos = 0;
        public frmIdentifiqueFuncao()
        {
            InitializeComponent();
        }

        public void EsconderLabel()
        {
            lbConfirmar.Parent = pbFundo;
            lbRecIdentif.Parent = pbFundo;
            lbSair.Parent = pbFundo;
        }

        public string GerarComposto()
        {
            int num = 0;
            funcao = "";
            Random rdm = new Random();
            num = Convert.ToInt32(rdm.Next(0, 10) + 1);
            switch (num)
            {
                case 1:
                    pbFuncao.Image = Properties.Resources.AcidoCarboxilico;
                    funcao = "Ácido Carboxílico";
                    break;
                case 2:
                    pbFuncao.Image = Properties.Resources.Alcool;
                    funcao = "Álcool";
                    break;
                case 3:
                    pbFuncao.Image = Properties.Resources.Amida;
                    funcao = "Amida";
                    break;
                case 4:
                    pbFuncao.Image = Properties.Resources.Amina;
                    funcao = "Amina";
                    break;
                case 5:
                    pbFuncao.Image = Properties.Resources.Cetona;
                    funcao = "Cetona";
                    break;
                case 6:
                    pbFuncao.Image = Properties.Resources.Enol;
                    funcao = "Enol";
                    break;
                case 7:
                    pbFuncao.Image = Properties.Resources.Ester;
                    funcao = "Éster";
                    break;
                case 8:
                    pbFuncao.Image = Properties.Resources.Eter;
                    funcao = "Eter";
                    break;
                case 9:
                    pbFuncao.Image = Properties.Resources.Fenol;
                    funcao = "Fenol";
                    break;
                case 10:
                    pbFuncao.Image = Properties.Resources.Hidrocarboneto;
                    funcao = "Hidrocarboneto";
                    break;
            }
            return funcao;
        }

        private void frmIdentifiqueFuncao_Load(object sender, EventArgs e)
        {
            EsconderLabel();
            GerarComposto();
            lbRecIdentif.Text = Acertos.ToString();
            cbSelecionarFuncao.SelectedIndex = -1;

            if (Questoes < 15)
            {
                Questoes += 1;
            }
            else
            {
                MessageBox.Show("Fim do jogo! Você acertou " + Acertos.ToString() + " questões de " + Questoes.ToString() + "!");
                this.Hide();
            }
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbConfirmar_Click(object sender, EventArgs e)
        {
            if (cbSelecionarFuncao.Text.Trim().Length  != 0)
            {
                if (cbSelecionarFuncao.Text == funcao)
                {
                    Acertos += 1;
                    MessageBox.Show("Acertou! Muito bem!");
                }
                else
                {
                    MessageBox.Show("Errou! Isto é um " + funcao);
                }
                frmIdentifiqueFuncao_Load(sender, e);    
            }
            else
            {
                MessageBox.Show("Selecione a função!");
            }            
        }
    }
}
