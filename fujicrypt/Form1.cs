using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CriptoDecripto
{
    public partial class Form1 : Form
    {
        private string chave = "";

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtTplano.Select();            
            
            tabControl1.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 30, Screen.PrimaryScreen.WorkingArea.Height - 50);
            tabControl1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - tabControl1.Width)/2,(Screen.PrimaryScreen.WorkingArea.Height - tabControl1.Height)/2);

            //Aba Criptografar
            txtTplano.Size = new Size(tabControl1.Width * 94 / 100, tabControl1.Height * 40 / 100);
            txtTplano.Location = new Point((tabControl1.Width - txtTplano.Width) / 2, tabControl1.Height * 3/100);
            txtTplano.BackColor = ColorTranslator.FromHtml("#FFE500");
            txtTplano.ScrollBars = ScrollBars.Vertical;
                        
            label1.Location = new Point(txtTplano.Left, txtTplano.Bottom + label1.Height);
            txtChaveCriptografar.Location = new Point(label1.Right + 100, txtTplano.Bottom + label1.Height);
            cboxLastKey.Location = new Point(txtChaveCriptografar.Right + 100, txtTplano.Bottom + label1.Height);
            btnPlano2Cripto.Location = new Point((tabControl1.Width - btnPlano2Cripto.Width) / 2, txtTplano.Bottom + btnPlano2Cripto.Height/2);
            
            txtCriptografado.Size = txtTplano.Size;
            txtCriptografado.Location = new Point(txtTplano.Left, txtTplano.Bottom + 50);
            txtCriptografado.ScrollBars = ScrollBars.Vertical;

            //Aba Decriptografar
            btnDecriptografar.Enabled = false;
            txtSecreto.Size = txtTplano.Size;
            txtSecreto.Location = txtTplano.Location;
            txtSecreto.BackColor = txtTplano.BackColor;
            txtSecreto.ScrollBars = ScrollBars.Vertical;

            btnSelecionaArquivo.Location = label1.Location;
            label2.Location = new Point(btnSelecionaArquivo.Right + 100, btnSelecionaArquivo.Top);
            txtChaveDecriptografadora.Location = new Point(label2.Right + 100, btnSelecionaArquivo.Top);
            btnDecriptografar.Location = new Point(txtCriptografado.Right - btnDecriptografar.Width, btnSelecionaArquivo.Top);

            txtLegivel.Size = txtCriptografado.Size;
            txtLegivel.Location = txtCriptografado.Location;
            txtLegivel.ScrollBars = ScrollBars.Vertical;
        }

        private void btnPlano2Cripto_Click(object sender, EventArgs e)
        {
            if (txtChaveCriptografar.Text.Length >= 4 && txtChaveCriptografar.Text.Length <= 8)
            {
                txtCriptografado.Text = "";
                Criptografadora cripto = new Criptografadora(txtTplano.Text);
                Byte[] ansi = cripto.FazSubstituicao();

                string binario = cripto.Decimal2Binary();

                //txtCriptografado.Text =  binario + "    binario \r\n";

                MapaDeBits mdb = new MapaDeBits(txtChaveCriptografar.Text);
                string chave = mdb.GeraChave();

                string textoPermutado = ""; //Executa a operação XOR 16 vezes
                for (int i = 0; i < 16; i++)
                {
                    textoPermutado = cripto.PermutaComChave(binario, chave);
                }

                //txtCriptografado.Text += textoPermutado + "    texto permutado \r\n";

                char[] textoCriptografado = cripto.Binary2Char(textoPermutado);

                FileStream fs = new FileStream("cripto.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < textoCriptografado.Length; i++)
                {
                    txtCriptografado.Text += textoCriptografado[i];
                    sw.Write(textoCriptografado[i]);
                }

                sw.Close();

                MapaDeBits mbits = new MapaDeBits(txtChaveCriptografar.Text);
                //mbits.PintaPixelsAleatoriamente();

                if (mbits.ConverteTextoEmPixels())
                {
                    MessageBox.Show("Arquivo criado com sucesso.");
                    //btnPlano2Cripto.Enabled = false;
                }
            }
          
            else
            {
                MessageBox.Show("A chave deve ter no mínimo 4 e no máximo 8 caracteres.");
            }
        }

        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Path.GetFileName(openFileDialog1.FileName);
                if (nomeArquivo.Equals("esteganografia.bmp"))
                {
                    btnDecriptografar.Enabled = true;
                    string arquivoEsteganografia = openFileDialog1.FileName;
                    RecuperaTexto rt = new RecuperaTexto(arquivoEsteganografia);
                    string textoDaImagem = rt.GetText();
                    string senhaDigitada = txtChaveDecriptografadora.Text.Trim();
                    //if (textoDaImagem.Equals(senhaDigitada))
                }
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            txtLegivel.Text = "";
            Criptografadora cripto = new Criptografadora(txtSecreto.Text);
            string binario = cripto.Decimal2Binary();
             //txtLegivel.Text = binario + "     binario \r\n";

            MapaDeBits mdb = new MapaDeBits(txtChaveDecriptografadora.Text);
            chave = mdb.GeraChave();

            string textoSemPermutacao = ""; //Executa a operação XOR 16 vezes
            for (int i = 0; i < 16; i++)
            {
                textoSemPermutacao = cripto.DesfazPermutacaoComChave(binario, chave);
            }
             //txtLegivel.Text += textoSemPermutacao + "     texto sem permutação \r\n";
            char[] binary2character = cripto.Binary2Char(textoSemPermutacao);
            Byte[] substituicaoDesfeita = cripto.DesfazSubstituicao(binary2character);

            string decimalParaBinario = cripto.Decimal2Binary(substituicaoDesfeita);

            char[] binariosLegiveis = cripto.Binary2Char(decimalParaBinario);
            //char[] binariosLegiveis = cripto.Binary2CharDecriptar(decimalParaBinario);

            for (int i = 0; i < binariosLegiveis.Length; i++)
            {   
                if (Convert.ToInt32(binariosLegiveis[i]) == 13)
                    txtLegivel.Text += "\r\n";
                
                if (Convert.ToInt32(binariosLegiveis[i]) == 20)
                    continue;

// Na versão 1.1 a logica XOR originou o caracter 150                
                //if (Convert.ToInt32(binariosLegiveis[i]) == 150)
                //    txtLegivel.Text += " ";

                //if (Convert.ToInt32(binariosLegiveis[i]) == 139)
                //    txtLegivel.Text += " ";
                    
                txtLegivel.Text += binariosLegiveis[i].ToString();
            }
        }
    }
}

/*
Versáo 1.2 - aumento da segurança executando a operação XOR 16 vezes 
Versão 1.1 - integração dos protótipos key2draw e draw2key exigindo que apresente o arquivo estenografia.bmp e a "senha".
Versão 1.0 - criptação com a chave fixa "10001000".
*/
