namespace SistemaQuimicaOrganica
{
    partial class frmSignificadoNome
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
            this.lbConfirmar = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbCarbonos = new System.Windows.Forms.ComboBox();
            this.cbLigacao = new System.Windows.Forms.ComboBox();
            this.pbLigacao = new System.Windows.Forms.PictureBox();
            this.pbCarbonos = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.lbAvancar = new System.Windows.Forms.Label();
            this.lbAcertos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLigacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarbonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConfirmar
            // 
            this.lbConfirmar.AutoSize = true;
            this.lbConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmar.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmar.Location = new System.Drawing.Point(324, 437);
            this.lbConfirmar.Name = "lbConfirmar";
            this.lbConfirmar.Size = new System.Drawing.Size(153, 107);
            this.lbConfirmar.TabIndex = 9;
            this.lbConfirmar.Text = "    ";
            this.lbConfirmar.Click += new System.EventHandler(this.lbConfirmar_Click);
            // 
            // lbSair
            // 
            this.lbSair.AutoSize = true;
            this.lbSair.BackColor = System.Drawing.Color.Transparent;
            this.lbSair.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSair.Location = new System.Drawing.Point(92, 437);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(153, 107);
            this.lbSair.TabIndex = 10;
            this.lbSair.Text = "    ";
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Chocolate;
            this.lbNome.Location = new System.Drawing.Point(222, 132);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(363, 107);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Metano";
            // 
            // cbCarbonos
            // 
            this.cbCarbonos.BackColor = System.Drawing.Color.White;
            this.cbCarbonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCarbonos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarbonos.ForeColor = System.Drawing.Color.Chocolate;
            this.cbCarbonos.FormattingEnabled = true;
            this.cbCarbonos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCarbonos.Location = new System.Drawing.Point(528, 277);
            this.cbCarbonos.Name = "cbCarbonos";
            this.cbCarbonos.Size = new System.Drawing.Size(164, 35);
            this.cbCarbonos.TabIndex = 12;
            // 
            // cbLigacao
            // 
            this.cbLigacao.BackColor = System.Drawing.Color.White;
            this.cbLigacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLigacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLigacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLigacao.ForeColor = System.Drawing.Color.Chocolate;
            this.cbLigacao.FormattingEnabled = true;
            this.cbLigacao.Items.AddRange(new object[] {
            "Simples",
            "Dupla",
            "Tripla"});
            this.cbLigacao.Location = new System.Drawing.Point(421, 367);
            this.cbLigacao.Name = "cbLigacao";
            this.cbLigacao.Size = new System.Drawing.Size(271, 35);
            this.cbLigacao.TabIndex = 13;
            // 
            // pbLigacao
            // 
            this.pbLigacao.BackColor = System.Drawing.Color.White;
            this.pbLigacao.Location = new System.Drawing.Point(708, 367);
            this.pbLigacao.Name = "pbLigacao";
            this.pbLigacao.Size = new System.Drawing.Size(35, 35);
            this.pbLigacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLigacao.TabIndex = 15;
            this.pbLigacao.TabStop = false;
            // 
            // pbCarbonos
            // 
            this.pbCarbonos.BackColor = System.Drawing.Color.White;
            this.pbCarbonos.Location = new System.Drawing.Point(708, 277);
            this.pbCarbonos.Name = "pbCarbonos";
            this.pbCarbonos.Size = new System.Drawing.Size(35, 35);
            this.pbCarbonos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarbonos.TabIndex = 14;
            this.pbCarbonos.TabStop = false;
            // 
            // pbFundo
            // 
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = global::SistemaQuimicaOrganica.Properties.Resources.QualNomeSelecionar;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(784, 562);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 0;
            this.pbFundo.TabStop = false;
            // 
            // lbAvancar
            // 
            this.lbAvancar.AutoSize = true;
            this.lbAvancar.BackColor = System.Drawing.Color.Transparent;
            this.lbAvancar.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvancar.Location = new System.Drawing.Point(572, 437);
            this.lbAvancar.Name = "lbAvancar";
            this.lbAvancar.Size = new System.Drawing.Size(153, 107);
            this.lbAvancar.TabIndex = 16;
            this.lbAvancar.Text = "    ";
            this.lbAvancar.Click += new System.EventHandler(this.lbAvancar_Click);
            // 
            // lbAcertos
            // 
            this.lbAcertos.AutoSize = true;
            this.lbAcertos.BackColor = System.Drawing.Color.Transparent;
            this.lbAcertos.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcertos.ForeColor = System.Drawing.Color.Chocolate;
            this.lbAcertos.Location = new System.Drawing.Point(424, 88);
            this.lbAcertos.Name = "lbAcertos";
            this.lbAcertos.Size = new System.Drawing.Size(31, 33);
            this.lbAcertos.TabIndex = 17;
            this.lbAcertos.Text = "0";
            // 
            // frmSignificadoNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.lbAcertos);
            this.Controls.Add(this.lbAvancar);
            this.Controls.Add(this.pbLigacao);
            this.Controls.Add(this.pbCarbonos);
            this.Controls.Add(this.cbLigacao);
            this.Controls.Add(this.cbCarbonos);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.lbConfirmar);
            this.Controls.Add(this.pbFundo);
            this.Name = "frmSignificadoNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSignificadoNome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLigacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarbonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.Label lbConfirmar;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbCarbonos;
        private System.Windows.Forms.ComboBox cbLigacao;
        private System.Windows.Forms.PictureBox pbCarbonos;
        private System.Windows.Forms.PictureBox pbLigacao;
        private System.Windows.Forms.Label lbAvancar;
        private System.Windows.Forms.Label lbAcertos;
    }
}