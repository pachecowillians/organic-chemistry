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
    public partial class frmGerarComposto : Form
    {
        public frmGerarComposto()
        {
            InitializeComponent();
        }

        public void EsconderLabel()
        {
            lbGerar.Parent = pbFundo;
            lbSair.Parent = pbFundo;
        }

        public string GerarNome(int prefixo, string infixo)
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
                case "Simples":
                    nome += "ano";
                    break;
                case "Dupla":
                    nome += "eno";
                    break;
                case "Tripla":
                    nome += "ino";
                    break;
            }
            return nome;
        }

        public void SelecionarFoto(string nome) 
        {
            switch (nome)
            {
                case "Metano":
                    pbComposto.Image = Properties.Resources.Metano;
                    break;
                case "Etano":
                    pbComposto.Image = Properties.Resources.Etano;
                    break;
                case "Eteno":
                    pbComposto.Image = Properties.Resources.Eteno;
                    break;
                case "Etino":
                    pbComposto.Image = Properties.Resources.Etino;
                    break;
                case "Propano":
                    pbComposto.Image = Properties.Resources.Propano;
                    break;
                case "Propeno":
                    pbComposto.Image = Properties.Resources.Propeno;
                    break;
                case "Propino":
                    pbComposto.Image = Properties.Resources.Propino;
                    break;
                case "Butano":
                    pbComposto.Image = Properties.Resources.Butano;
                    break;
                case "Buteno":
                    pbComposto.Image = Properties.Resources.Buteno;
                    break;
                case "Butino":
                    pbComposto.Image = Properties.Resources.Butino;
                    break;
                case "Pentano":
                    pbComposto.Image = Properties.Resources.Pentano;
                    break;
                case "Penteno":
                    pbComposto.Image = Properties.Resources.Penteno;
                    break;
                case "Pentino":
                    pbComposto.Image = Properties.Resources.Pentino;
                    break;
                case "Hexano":
                    pbComposto.Image = Properties.Resources.Hexano;
                    break;
                case "Hexeno":
                    pbComposto.Image = Properties.Resources.Hexeno;
                    break;
                case "Hexino":
                    pbComposto.Image = Properties.Resources.Hexino;
                    break;
                case "Heptano":
                    pbComposto.Image = Properties.Resources.Heptano;
                    break;
                case "Hepteno":
                    pbComposto.Image = Properties.Resources.Hepteno;
                    break;
                case "Heptino":
                    pbComposto.Image = Properties.Resources.Heptino;
                    break;
                case "Octano":
                    pbComposto.Image = Properties.Resources.Octano;
                    break;
                case "Octeno":
                    pbComposto.Image = Properties.Resources.Octeno;
                    break;
                case "Octino":
                    pbComposto.Image = Properties.Resources.Octino;
                    break;
                case "Nonano":
                    pbComposto.Image = Properties.Resources.Nonano;
                    break;
                case "Noneno":
                    pbComposto.Image = Properties.Resources.Noneno;
                    break;
                case "Nonino":
                    pbComposto.Image = Properties.Resources.Nonino;
                    break;
                case "Decano":
                    pbComposto.Image = Properties.Resources.Decano;
                    break;
                case "Deceno":
                    pbComposto.Image = Properties.Resources.Deceno;
                    break;
                case "Decino":
                    pbComposto.Image = Properties.Resources.Decino;
                    break;
            }
        }

        private void frmGerarComposto_Load(object sender, EventArgs e)
        {
            EsconderLabel();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbGerar_Click(object sender, EventArgs e)
        {
            if (cbCarbonos.Text.Trim().Length != 0 && cbLigacao.Text.Trim().Length != 0)
            {
                if (cbLigacao.Text != "Simples" && cbCarbonos.Text == "1")
                {
                    if (cbLigacao.Text == "Dupla")
                    {
                        MessageBox.Show("Não se pode ter ligação dupla com um carbono apenas!");
                    }
                    if (cbLigacao.Text == "Tripla")
                    {
                        MessageBox.Show("Não se pode ter ligação tripla com um carbono apenas!");
                    }
                }
                else
                {
                    SelecionarFoto(GerarNome(Convert.ToInt32(cbCarbonos.Text), cbLigacao.Text));
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            

        }
    }
}
