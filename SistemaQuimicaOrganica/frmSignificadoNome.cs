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
    public partial class frmSignificadoNome : Form
    {
        int Prefixo = 0;
        int Infixo = 0;
        public int Questoes = 0;
        public double Acertos = 0;

        public frmSignificadoNome()
        {
            InitializeComponent();
        }

        public void EsconderLabel()
        {
            lbConfirmar.Parent = pbFundo;
            lbNome.Parent = pbFundo;
            lbSair.Parent = pbFundo;
            lbAvancar.Parent = pbFundo;
            lbAcertos.Parent = pbFundo;
        }

        public int GerarPrefixo()
        {
            Random rdm = new Random();
            return Convert.ToInt32(rdm.Next(0, 10) + 1);
        }

        public int GerarInfixo()
        {
            Random rdm = new Random();
            return Convert.ToInt32(rdm.Next(0, 3) + 1);
        }

        public string GerarNome(int prefixo, int infixo)
        {
            string nome = "";
            switch (prefixo)
            {
                case 1:
                    nome = "Met";
                    break;
                case 2:
                    nome = "Et";
                    break;
                case 3:
                    nome = "Prop";
                    break;
                case 4:
                    nome = "But";
                    break;
                case 5:
                    nome = "Pent";
                    break;
                case 6:
                    nome = "Hex";
                    break;
                case 7:
                    nome = "Hept";
                    break;
                case 8:
                    nome = "Oct";
                    break;
                case 9:
                    nome = "Non";
                    break;
                case 10:
                    nome = "Dec";
                    break;
            }
            switch (infixo)
            {
                case 1:
                    nome += "ano";
                    break;
                case 2:
                    nome += "eno";
                    break;
                case 3:
                    nome += "ino";
                    break;
            }
            return nome;
        }

        public void ModoExibicao(int cod) 
        {
            switch (cod)
            {
                case 1:
                    pbFundo.Image = Properties.Resources.QualNomeSelecionar;
                    cbCarbonos.Enabled = true;
                    cbLigacao.Enabled = true;
                    cbLigacao.SelectedIndex = -1;
                    cbCarbonos.SelectedIndex = -1;
                    lbAvancar.Enabled = false;
                    lbConfirmar.Enabled = true;
                    break;
                case 2:
                    pbFundo.Image = Properties.Resources.QualNomeDesabiitado;
                    cbCarbonos.Enabled = false;
                    cbLigacao.Enabled = false;
                    lbAvancar.Enabled = true;
                    lbConfirmar.Enabled = false;
                    break;
            }
        }

        private void frmSignificadoNome_Load(object sender, EventArgs e)
        {
            if (Questoes < 15)
            {
                Questoes += 1;
            }
            else
            {
                MessageBox.Show("Fim do jogo! Você acertou " + Acertos.ToString() + " de "+Questoes.ToString()+" questões no total!");
                this.Hide();
                
            }
            EsconderLabel();
            Prefixo = GerarPrefixo();
            Infixo = GerarInfixo();
            lbNome.Text = GerarNome(Prefixo, Infixo);
            pbCarbonos.Image = null;
            pbLigacao.Image = null;
            ModoExibicao(1);
            
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbConfirmar_Click(object sender, EventArgs e)
        {
            if (cbCarbonos.Text.Trim().Length != 0 && cbLigacao.Text.Trim().Length != 0)
            {
                ModoExibicao(2);
                string ligacao = "";
                if (cbCarbonos.Text == Prefixo.ToString())
                {
                    pbCarbonos.Image = Properties.Resources.Certo;
                    Acertos += 0.5;
                }
                else
                {
                    pbCarbonos.Image = Properties.Resources.Errado;
                }

                if (Infixo == 1)
                {
                    ligacao = "Simples";
                }

                if (Infixo == 2)
                {
                    ligacao = "Dupla";
                }

                if (Infixo == 3)
                {
                    ligacao = "Tripla";
                }

                if (cbLigacao.Text == ligacao)
                {
                    pbLigacao.Image = Properties.Resources.Certo;
                    Acertos += 0.5;
                }
                else
                {
                    pbLigacao.Image = Properties.Resources.Errado;
                }
                lbAcertos.Text = Acertos.ToString();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }

        private void lbAvancar_Click(object sender, EventArgs e)
        {
            frmSignificadoNome_Load(sender,e);
        }
    }
}
