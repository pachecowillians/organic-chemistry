namespace SistemaQuimicaOrganica
{
    partial class frmIdentifiqueFuncao
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
            this.lbRecIdentif = new System.Windows.Forms.Label();
            this.cbSelecionarFuncao = new System.Windows.Forms.ComboBox();
            this.lbConfirmar = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.pbFuncao = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecIdentif
            // 
            this.lbRecIdentif.AutoSize = true;
            this.lbRecIdentif.BackColor = System.Drawing.Color.Transparent;
            this.lbRecIdentif.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecIdentif.ForeColor = System.Drawing.Color.Chocolate;
            this.lbRecIdentif.Location = new System.Drawing.Point(426, 113);
            this.lbRecIdentif.Name = "lbRecIdentif";
            this.lbRecIdentif.Size = new System.Drawing.Size(31, 33);
            this.lbRecIdentif.TabIndex = 5;
            this.lbRecIdentif.Text = "0";
            // 
            // cbSelecionarFuncao
            // 
            this.cbSelecionarFuncao.BackColor = System.Drawing.Color.White;
            this.cbSelecionarFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelecionarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelecionarFuncao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarFuncao.ForeColor = System.Drawing.Color.Chocolate;
            this.cbSelecionarFuncao.FormattingEnabled = true;
            this.cbSelecionarFuncao.Items.AddRange(new object[] {
            "Ácido Carboxílico",
            "Álcool",
            "Amida",
            "Amina",
            "Cetona",
            "Enol",
            "Éster",
            "Eter",
            "Fenol",
            "Hidrocarboneto"});
            this.cbSelecionarFuncao.Location = new System.Drawing.Point(153, 408);
            this.cbSelecionarFuncao.Name = "cbSelecionarFuncao";
            this.cbSelecionarFuncao.Size = new System.Drawing.Size(499, 35);
            this.cbSelecionarFuncao.TabIndex = 6;
            // 
            // lbConfirmar
            // 
            this.lbConfirmar.AutoSize = true;
            this.lbConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmar.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmar.Location = new System.Drawing.Point(674, 400);
            this.lbConfirmar.Name = "lbConfirmar";
            this.lbConfirmar.Size = new System.Drawing.Size(67, 40);
            this.lbConfirmar.TabIndex = 7;
            this.lbConfirmar.Text = "     ";
            this.lbConfirmar.Click += new System.EventHandler(this.lbConfirmar_Click);
            // 
            // lbSair
            // 
            this.lbSair.AutoSize = true;
            this.lbSair.BackColor = System.Drawing.Color.Transparent;
            this.lbSair.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSair.Location = new System.Drawing.Point(383, 481);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(84, 72);
            this.lbSair.TabIndex = 8;
            this.lbSair.Text = "   ";
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pbFuncao
            // 
            this.pbFuncao.BackColor = System.Drawing.Color.White;
            this.pbFuncao.Location = new System.Drawing.Point(270, 172);
            this.pbFuncao.Name = "pbFuncao";
            this.pbFuncao.Size = new System.Drawing.Size(280, 200);
            this.pbFuncao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncao.TabIndex = 9;
            this.pbFuncao.TabStop = false;
            // 
            // pbFundo
            // 
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = global::SistemaQuimicaOrganica.Properties.Resources.QualComposto;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(784, 562);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 0;
            this.pbFundo.TabStop = false;
            // 
            // frmIdentifiqueFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pbFuncao);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.lbConfirmar);
            this.Controls.Add(this.cbSelecionarFuncao);
            this.Controls.Add(this.lbRecIdentif);
            this.Controls.Add(this.pbFundo);
            this.Name = "frmIdentifiqueFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIdentifiqueFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.Label lbRecIdentif;
        private System.Windows.Forms.ComboBox cbSelecionarFuncao;
        private System.Windows.Forms.Label lbConfirmar;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pbFuncao;
    }
}