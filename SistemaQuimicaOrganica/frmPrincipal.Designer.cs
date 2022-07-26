namespace SistemaQuimicaOrganica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lbSignificadoNome = new System.Windows.Forms.Label();
            this.lbIndiqueFuncao = new System.Windows.Forms.Label();
            this.lbGerarComposto = new System.Windows.Forms.Label();
            this.lbRecIdentif = new System.Windows.Forms.Label();
            this.lbRecSignificado = new System.Windows.Forms.Label();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSignificadoNome
            // 
            this.lbSignificadoNome.AutoSize = true;
            this.lbSignificadoNome.BackColor = System.Drawing.Color.Transparent;
            this.lbSignificadoNome.Font = new System.Drawing.Font("Arial", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignificadoNome.Location = new System.Drawing.Point(40, 128);
            this.lbSignificadoNome.Name = "lbSignificadoNome";
            this.lbSignificadoNome.Size = new System.Drawing.Size(296, 208);
            this.lbSignificadoNome.TabIndex = 1;
            this.lbSignificadoNome.Text = "    ";
            this.lbSignificadoNome.Click += new System.EventHandler(this.lbSignificadoNome_Click);
            // 
            // lbIndiqueFuncao
            // 
            this.lbIndiqueFuncao.AutoSize = true;
            this.lbIndiqueFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lbIndiqueFuncao.Font = new System.Drawing.Font("Arial", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndiqueFuncao.Location = new System.Drawing.Point(367, 104);
            this.lbIndiqueFuncao.Name = "lbIndiqueFuncao";
            this.lbIndiqueFuncao.Size = new System.Drawing.Size(400, 208);
            this.lbIndiqueFuncao.TabIndex = 2;
            this.lbIndiqueFuncao.Text = "      ";
            this.lbIndiqueFuncao.Click += new System.EventHandler(this.lbIndiqueFuncao_Click);
            // 
            // lbGerarComposto
            // 
            this.lbGerarComposto.AutoSize = true;
            this.lbGerarComposto.BackColor = System.Drawing.Color.Transparent;
            this.lbGerarComposto.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerarComposto.Location = new System.Drawing.Point(30, 393);
            this.lbGerarComposto.Name = "lbGerarComposto";
            this.lbGerarComposto.Size = new System.Drawing.Size(322, 149);
            this.lbGerarComposto.TabIndex = 3;
            this.lbGerarComposto.Text = "       ";
            this.lbGerarComposto.Click += new System.EventHandler(this.lbGerarComposto_Click);
            // 
            // lbRecIdentif
            // 
            this.lbRecIdentif.AutoSize = true;
            this.lbRecIdentif.BackColor = System.Drawing.Color.Transparent;
            this.lbRecIdentif.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecIdentif.ForeColor = System.Drawing.Color.Chocolate;
            this.lbRecIdentif.Location = new System.Drawing.Point(676, 462);
            this.lbRecIdentif.Name = "lbRecIdentif";
            this.lbRecIdentif.Size = new System.Drawing.Size(31, 33);
            this.lbRecIdentif.TabIndex = 4;
            this.lbRecIdentif.Text = "0";
            // 
            // lbRecSignificado
            // 
            this.lbRecSignificado.AutoSize = true;
            this.lbRecSignificado.BackColor = System.Drawing.Color.Transparent;
            this.lbRecSignificado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecSignificado.ForeColor = System.Drawing.Color.Chocolate;
            this.lbRecSignificado.Location = new System.Drawing.Point(676, 397);
            this.lbRecSignificado.Name = "lbRecSignificado";
            this.lbRecSignificado.Size = new System.Drawing.Size(31, 33);
            this.lbRecSignificado.TabIndex = 5;
            this.lbRecSignificado.Text = "0";
            // 
            // pbFundo
            // 
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = ((System.Drawing.Image)(resources.GetObject("pbFundo.Image")));
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(784, 562);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 0;
            this.pbFundo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbRecSignificado);
            this.Controls.Add(this.lbRecIdentif);
            this.Controls.Add(this.lbGerarComposto);
            this.Controls.Add(this.lbIndiqueFuncao);
            this.Controls.Add(this.lbSignificadoNome);
            this.Controls.Add(this.pbFundo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Química Orgânica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.Label lbSignificadoNome;
        private System.Windows.Forms.Label lbIndiqueFuncao;
        private System.Windows.Forms.Label lbGerarComposto;
        private System.Windows.Forms.Label lbRecIdentif;
        public System.Windows.Forms.Label lbRecSignificado;
    }
}

