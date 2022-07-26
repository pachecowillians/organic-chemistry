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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void EsconderLabel() 
        {
            lbGerarComposto.Parent = pbFundo;
            lbIndiqueFuncao.Parent = pbFundo;
            lbSignificadoNome.Parent = pbFundo;
            lbRecIdentif.Parent = pbFundo;
            lbRecSignificado.Parent = pbFundo;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            EsconderLabel();
        }

        private void lbSignificadoNome_Click(object sender, EventArgs e)
        {
            frmSignificadoNome significado = new frmSignificadoNome();
            this.Hide();
            significado.ShowDialog();
            if (Convert.ToDouble(lbRecSignificado.Text) < significado.Acertos)
            {
                lbRecSignificado.Text = significado.Acertos.ToString();
            }            
            significado.Dispose();
            this.Show();
        }

        private void lbIndiqueFuncao_Click(object sender, EventArgs e)
        {
            frmIdentifiqueFuncao identifique = new frmIdentifiqueFuncao();
            this.Hide();
            identifique.ShowDialog();
            if (Convert.ToInt32(lbRecIdentif.Text) < identifique.Acertos)
            {
                lbRecIdentif.Text = identifique.Acertos.ToString();
            }
            identifique.Dispose();
            this.Show();
        }

        private void lbGerarComposto_Click(object sender, EventArgs e)
        {
            frmGerarComposto gerar = new frmGerarComposto();
            this.Hide();
            gerar.ShowDialog();
            this.Show();
        }
    }
}
