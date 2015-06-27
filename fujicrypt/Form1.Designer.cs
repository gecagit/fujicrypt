namespace CriptoDecripto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxLastKey = new System.Windows.Forms.CheckBox();
            this.txtChaveCriptografar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlano2Cripto = new System.Windows.Forms.Button();
            this.txtCriptografado = new System.Windows.Forms.TextBox();
            this.txtTplano = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.txtChaveDecriptografadora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLegivel = new System.Windows.Forms.TextBox();
            this.txtSecreto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 291);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboxLastKey);
            this.tabPage1.Controls.Add(this.txtChaveCriptografar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPlano2Cripto);
            this.tabPage1.Controls.Add(this.txtCriptografado);
            this.tabPage1.Controls.Add(this.txtTplano);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criptografar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboxLastKey
            // 
            this.cboxLastKey.AutoSize = true;
            this.cboxLastKey.Location = new System.Drawing.Point(336, 123);
            this.cboxLastKey.Name = "cboxLastKey";
            this.cboxLastKey.Size = new System.Drawing.Size(122, 17);
            this.cboxLastKey.TabIndex = 5;
            this.cboxLastKey.Text = "Manter última chave";
            this.cboxLastKey.UseVisualStyleBackColor = true;
            this.cboxLastKey.Visible = false;
            // 
            // txtChaveCriptografar
            // 
            this.txtChaveCriptografar.Location = new System.Drawing.Point(187, 121);
            this.txtChaveCriptografar.Name = "txtChaveCriptografar";
            this.txtChaveCriptografar.Size = new System.Drawing.Size(92, 20);
            this.txtChaveCriptografar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a chave:";
            // 
            // btnPlano2Cripto
            // 
            this.btnPlano2Cripto.Location = new System.Drawing.Point(480, 116);
            this.btnPlano2Cripto.Name = "btnPlano2Cripto";
            this.btnPlano2Cripto.Size = new System.Drawing.Size(75, 24);
            this.btnPlano2Cripto.TabIndex = 2;
            this.btnPlano2Cripto.Text = "Criptografar";
            this.btnPlano2Cripto.UseVisualStyleBackColor = true;
            this.btnPlano2Cripto.Click += new System.EventHandler(this.btnPlano2Cripto_Click);
            // 
            // txtCriptografado
            // 
            this.txtCriptografado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriptografado.Location = new System.Drawing.Point(25, 186);
            this.txtCriptografado.Multiline = true;
            this.txtCriptografado.Name = "txtCriptografado";
            this.txtCriptografado.Size = new System.Drawing.Size(100, 20);
            this.txtCriptografado.TabIndex = 1;
            // 
            // txtTplano
            // 
            this.txtTplano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTplano.Location = new System.Drawing.Point(25, 27);
            this.txtTplano.Multiline = true;
            this.txtTplano.Name = "txtTplano";
            this.txtTplano.Size = new System.Drawing.Size(100, 20);
            this.txtTplano.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSelecionaArquivo);
            this.tabPage2.Controls.Add(this.btnDecriptografar);
            this.tabPage2.Controls.Add(this.txtChaveDecriptografadora);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtLegivel);
            this.tabPage2.Controls.Add(this.txtSecreto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decriptografar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(29, 99);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(131, 23);
            this.btnSelecionaArquivo.TabIndex = 5;
            this.btnSelecionaArquivo.Text = "Seleciona Arquivo";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.btnSelecionaArquivo_Click);
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(529, 100);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(97, 23);
            this.btnDecriptografar.TabIndex = 4;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // txtChaveDecriptografadora
            // 
            this.txtChaveDecriptografadora.Location = new System.Drawing.Point(381, 99);
            this.txtChaveDecriptografadora.Name = "txtChaveDecriptografadora";
            this.txtChaveDecriptografadora.Size = new System.Drawing.Size(100, 20);
            this.txtChaveDecriptografadora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chave decriptografadora:";
            // 
            // txtLegivel
            // 
            this.txtLegivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegivel.Location = new System.Drawing.Point(29, 180);
            this.txtLegivel.Multiline = true;
            this.txtLegivel.Name = "txtLegivel";
            this.txtLegivel.Size = new System.Drawing.Size(100, 20);
            this.txtLegivel.TabIndex = 1;
            // 
            // txtSecreto
            // 
            this.txtSecreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecreto.Location = new System.Drawing.Point(29, 27);
            this.txtSecreto.Multiline = true;
            this.txtSecreto.Name = "txtSecreto";
            this.txtSecreto.Size = new System.Drawing.Size(100, 20);
            this.txtSecreto.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 365);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Criptografia v1.2 03/06/2015";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTplano;
        private System.Windows.Forms.TextBox txtCriptografado;
        private System.Windows.Forms.Button btnPlano2Cripto;
        private System.Windows.Forms.TextBox txtChaveCriptografar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboxLastKey;
        private System.Windows.Forms.Button btnDecriptografar;
        private System.Windows.Forms.TextBox txtChaveDecriptografadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegivel;
        private System.Windows.Forms.TextBox txtSecreto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelecionaArquivo;
    }
}

