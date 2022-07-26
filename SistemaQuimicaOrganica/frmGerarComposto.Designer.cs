namespace SistemaQuimicaOrganica
{
    partial class frmGerarComposto
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
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.cbCarbonos = new System.Windows.Forms.ComboBox();
            this.cbLigacao = new System.Windows.Forms.ComboBox();
            this.lbSair = new System.Windows.Forms.Label();
            this.lbGerar = new System.Windows.Forms.Label();
            this.pbComposto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComposto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFundo
            // 
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = global::SistemaQuimicaOrganica.Properties.Resources.GerarComposto;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(784, 562);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 0;
            this.pbFundo.TabStop = false;
            // 
            // cbCarbonos
            // 
            this.cbCarbonos.BackColor = System.Drawing.Color.White;
            this.cbCarbonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCarbonos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbCarbonos.Location = new System.Drawing.Point(471, 139);
            this.cbCarbonos.Name = "cbCarbonos";
            this.cbCarbonos.Size = new System.Drawing.Size(180, 30);
            this.cbCarbonos.TabIndex = 13;
            // 
            // cbLigacao
            // 
            this.cbLigacao.BackColor = System.Drawing.Color.White;
            this.cbLigacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLigacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLigacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLigacao.ForeColor = System.Drawing.Color.Chocolate;
            this.cbLigacao.FormattingEnabled = true;
            this.cbLigacao.Items.AddRange(new object[] {
            "Simples",
            "Dupla",
            "Tripla"});
            this.cbLigacao.Location = new System.Drawing.Point(401, 217);
            this.cbLigacao.Name = "cbLigacao";
            this.cbLigacao.Size = new System.Drawing.Size(250, 30);
            this.cbLigacao.TabIndex = 14;
            // 
            // lbSair
            // 
            this.lbSair.AutoSize = true;
            this.lbSair.BackColor = System.Drawing.Color.Transparent;
            this.lbSair.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSair.Location = new System.Drawing.Point(244, 429);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(126, 107);
            this.lbSair.TabIndex = 15;
            this.lbSair.Text = "   ";
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // lbGerar
            // 
            this.lbGerar.AutoSize = true;
            this.lbGerar.BackColor = System.Drawing.Color.Transparent;
            this.lbGerar.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerar.Location = new System.Drawing.Point(441, 429);
            this.lbGerar.Name = "lbGerar";
            this.lbGerar.Size = new System.Drawing.Size(126, 107);
            this.lbGerar.TabIndex = 16;
            this.lbGerar.Text = "   ";
            this.lbGerar.Click += new System.EventHandler(this.lbGerar_Click);
            // 
            // pbComposto
            // 
            this.pbComposto.BackColor = System.Drawing.Color.White;
            this.pbComposto.Location = new System.Drawing.Point(211, 277);
            this.pbComposto.Name = "pbComposto";
            this.pbComposto.Size = new System.Drawing.Size(380, 130);
            this.pbComposto.TabIndex = 17;
            this.pbComposto.TabStop = false;
            // 
            // frmGerarComposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pbComposto);
            this.Controls.Add(this.lbGerar);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.cbLigacao);
            this.Controls.Add(this.cbCarbonos);
            this.Controls.Add(this.pbFundo);
            this.Name = "frmGerarComposto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGerarComposto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComposto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.ComboBox cbCarbonos;
        private System.Windows.Forms.ComboBox cbLigacao;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Label lbGerar;
        private System.Windows.Forms.PictureBox pbComposto;
    }
}