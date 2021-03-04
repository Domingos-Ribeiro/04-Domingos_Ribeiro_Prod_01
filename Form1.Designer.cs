
namespace _04_Domingos_Ribeiro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtValorBase = new System.Windows.Forms.TextBox();
            this.chkboxEscalao = new System.Windows.Forms.CheckBox();
            this.chkboxSocio = new System.Windows.Forms.CheckBox();
            this.chkboxAgravamento = new System.Windows.Forms.CheckBox();
            this.painelDois = new System.Windows.Forms.Panel();
            this.painelUm = new System.Windows.Forms.Panel();
            this.painelTres = new System.Windows.Forms.Panel();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.painelQuatro = new System.Windows.Forms.Panel();
            this.cmbConcelho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label_erros = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelDois.SuspendLayout();
            this.painelUm.SuspendLayout();
            this.painelTres.SuspendLayout();
            this.painelQuatro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁLCULO DO VALOR DA AVENÇA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANO DE NASCIMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "VALOR BASE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(177, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(178, 78);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(59, 20);
            this.txtAnoNascimento.TabIndex = 4;
            this.txtAnoNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorBase
            // 
            this.txtValorBase.Location = new System.Drawing.Point(178, 131);
            this.txtValorBase.Name = "txtValorBase";
            this.txtValorBase.Size = new System.Drawing.Size(60, 20);
            this.txtValorBase.TabIndex = 5;
            this.txtValorBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkboxEscalao
            // 
            this.chkboxEscalao.AutoSize = true;
            this.chkboxEscalao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxEscalao.Location = new System.Drawing.Point(12, 17);
            this.chkboxEscalao.Name = "chkboxEscalao";
            this.chkboxEscalao.Size = new System.Drawing.Size(188, 19);
            this.chkboxEscalao.TabIndex = 6;
            this.chkboxEscalao.Text = "Desconto de Escalão?  (10%)";
            this.chkboxEscalao.UseVisualStyleBackColor = true;
            // 
            // chkboxSocio
            // 
            this.chkboxSocio.AutoSize = true;
            this.chkboxSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxSocio.Location = new System.Drawing.Point(213, 17);
            this.chkboxSocio.Name = "chkboxSocio";
            this.chkboxSocio.Size = new System.Drawing.Size(165, 19);
            this.chkboxSocio.TabIndex = 7;
            this.chkboxSocio.Text = "Desconto de Sócio? (5%)";
            this.chkboxSocio.UseVisualStyleBackColor = true;
            // 
            // chkboxAgravamento
            // 
            this.chkboxAgravamento.AutoSize = true;
            this.chkboxAgravamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxAgravamento.Location = new System.Drawing.Point(394, 17);
            this.chkboxAgravamento.Name = "chkboxAgravamento";
            this.chkboxAgravamento.Size = new System.Drawing.Size(193, 19);
            this.chkboxAgravamento.TabIndex = 8;
            this.chkboxAgravamento.Text = "Tem Agravamento? (12 Euros)";
            this.chkboxAgravamento.UseVisualStyleBackColor = true;
            // 
            // painelDois
            // 
            this.painelDois.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.painelDois.Controls.Add(this.chkboxSocio);
            this.painelDois.Controls.Add(this.chkboxAgravamento);
            this.painelDois.Controls.Add(this.chkboxEscalao);
            this.painelDois.Location = new System.Drawing.Point(57, 325);
            this.painelDois.Name = "painelDois";
            this.painelDois.Size = new System.Drawing.Size(590, 55);
            this.painelDois.TabIndex = 9;
            // 
            // painelUm
            // 
            this.painelUm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.painelUm.Controls.Add(this.label_erros);
            this.painelUm.Controls.Add(this.label4);
            this.painelUm.Controls.Add(this.pictureBox1);
            this.painelUm.Controls.Add(this.txtValorBase);
            this.painelUm.Controls.Add(this.label2);
            this.painelUm.Controls.Add(this.txtAnoNascimento);
            this.painelUm.Controls.Add(this.label3);
            this.painelUm.Controls.Add(this.txtNome);
            this.painelUm.Location = new System.Drawing.Point(57, 100);
            this.painelUm.Name = "painelUm";
            this.painelUm.Size = new System.Drawing.Size(590, 172);
            this.painelUm.TabIndex = 10;
            // 
            // painelTres
            // 
            this.painelTres.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.painelTres.Controls.Add(this.rdbNao);
            this.painelTres.Controls.Add(this.rdbSim);
            this.painelTres.Controls.Add(this.label5);
            this.painelTres.Location = new System.Drawing.Point(57, 446);
            this.painelTres.Name = "painelTres";
            this.painelTres.Size = new System.Drawing.Size(273, 55);
            this.painelTres.TabIndex = 11;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNao.Location = new System.Drawing.Point(199, 21);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(48, 19);
            this.rdbNao.TabIndex = 14;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSim.Location = new System.Drawing.Point(136, 21);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(47, 19);
            this.rdbSim.TabIndex = 13;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reside no Distrito?";
            // 
            // painelQuatro
            // 
            this.painelQuatro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.painelQuatro.Controls.Add(this.cmbConcelho);
            this.painelQuatro.Controls.Add(this.label6);
            this.painelQuatro.Location = new System.Drawing.Point(397, 446);
            this.painelQuatro.Name = "painelQuatro";
            this.painelQuatro.Size = new System.Drawing.Size(250, 55);
            this.painelQuatro.TabIndex = 12;
            // 
            // cmbConcelho
            // 
            this.cmbConcelho.FormattingEnabled = true;
            this.cmbConcelho.Items.AddRange(new object[] {
            "Amares",
            "Braga",
            "Guimarães"});
            this.cmbConcelho.Location = new System.Drawing.Point(114, 18);
            this.cmbConcelho.Name = "cmbConcelho";
            this.cmbConcelho.Size = new System.Drawing.Size(121, 21);
            this.cmbConcelho.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "CONCELHO";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(398, 554);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 46);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(569, 560);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(78, 30);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_erros
            // 
            this.label_erros.AutoSize = true;
            this.label_erros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erros.Location = new System.Drawing.Point(245, 101);
            this.label_erros.Name = "label_erros";
            this.label_erros.Size = new System.Drawing.Size(143, 22);
            this.label_erros.TabIndex = 16;
            this.label_erros.Text = "Dados Errados";
            this.label_erros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_erros.Click += new System.EventHandler(this.label_erros_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 631);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.painelQuatro);
            this.Controls.Add(this.painelTres);
            this.Controls.Add(this.painelUm);
            this.Controls.Add(this.painelDois);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "04 - Domingos Ribeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelDois.ResumeLayout(false);
            this.painelDois.PerformLayout();
            this.painelUm.ResumeLayout(false);
            this.painelUm.PerformLayout();
            this.painelTres.ResumeLayout(false);
            this.painelTres.PerformLayout();
            this.painelQuatro.ResumeLayout(false);
            this.painelQuatro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtValorBase;
        private System.Windows.Forms.CheckBox chkboxEscalao;
        private System.Windows.Forms.CheckBox chkboxSocio;
        private System.Windows.Forms.CheckBox chkboxAgravamento;
        private System.Windows.Forms.Panel painelDois;
        private System.Windows.Forms.Panel painelUm;
        private System.Windows.Forms.Panel painelTres;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel painelQuatro;
        private System.Windows.Forms.ComboBox cmbConcelho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label_erros;
        private System.Windows.Forms.Timer timer1;
    }
}

