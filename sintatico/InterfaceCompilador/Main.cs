using InterfaceCompilador.Gals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceCompilador
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.setArquivoNaoModificado();
            this.setAreaEditorFocus();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            this.novo();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            this.abrir();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            this.salvar();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            this.areaEditor.Copy();
        }

        private void colar_Click(object sender, EventArgs e)
        {
            this.areaEditor.Paste();
        }

        private void recortar_Click(object sender, EventArgs e)
        {
            this.areaEditor.Cut();
        }

        private void compilar_Click(object sender, EventArgs e)
        {
            this.compilar();
        }

        private void gerarCodigo_Click(object sender, EventArgs e)
        {
            this.gerarCodigo();
        }

        private void salvar(string localArquivo)
        {
            using (StreamWriter streamWriter = new StreamWriter(localArquivo))
            {
                streamWriter.Write(areaEditor.Text.Replace("\n", "\r\n"));
                streamWriter.Flush();
                this.areaMensagem.Clear();
                this.setLocalArquivo(localArquivo);
                this.setArquivoNaoModificado();
            }
        }

        private void setArquivoNaoModificado()
        {
            this.statusEditor.Text = "Não modificado";
        }

        private void setArquivoModificado()
        {
            this.statusEditor.Text = "Modificado";
        }

        private void setLocalArquivo(string localArquivo)
        {
            this.localArquivo.Text = localArquivo;
        }

        private void setTextoAreaMensagem(string texto)
        {
            this.areaMensagem.Text = texto;
        }

        private void setAreaEditorFocus()
        {
            this.areaEditor.Focus();
        }

        private void equipe_Click(object sender, EventArgs e)
        {
            this.equipe();
        }

        private void areaEditor_TextChanged(object sender, EventArgs e)
        {
            this.setArquivoModificado();
        }

        private void novo()
        {
            this.areaEditor.Clear();
            this.areaMensagem.Clear();
            this.setLocalArquivo("");
            this.setArquivoNaoModificado();
            this.setAreaEditorFocus();
        }

        private void abrir()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo de texto | *.txt";
            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    this.areaEditor.Text = streamReader.ReadToEnd();
                    this.areaMensagem.Clear();
                    this.setLocalArquivo(openFileDialog.FileName);
                    this.setArquivoNaoModificado();
                }
        }

        private void salvar()
        {
            if (!File.Exists(this.localArquivo.Text))
            {
                this.setLocalArquivo("");
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo de texto | *.txt";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    this.salvar(saveFileDialog.FileName);
            }
            else
                this.salvar(this.localArquivo.Text);
        }

        private void compilar()
        {
            this.setTextoAreaMensagem("");
            Lexico lexico = new Lexico(this.areaEditor.Text);
            Sintatico sintatico = new Sintatico();
            Semantico semantico = new Semantico();

            try
            {
                lexico.analisar();
                sintatico.analisar(lexico, semantico);
                this.setTextoAreaMensagem("programa compilado com sucesso");
            }
            catch (LexicalError e)
            {
                this.setTextoAreaMensagem(e.Message);
            }
            catch (SyntaticError e)
            {
                this.setTextoAreaMensagem(e.Message);
            }
            catch (SemanticError e)
            {
                this.setTextoAreaMensagem(string.Format("Erro: {0}", e.Message));
            }
        }

        private void gerarCodigo()
        {
            this.setTextoAreaMensagem("geração de código ainda não foi implementada");
        }

        private void equipe()
        {
            this.setTextoAreaMensagem("Ivan Manoel da Silva Filho e Cleyson Gustavo Reinhold");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                switch (e.KeyCode)
                {
                    case Keys.N:
                        this.novo();
                        break;

                    case Keys.A:
                        this.abrir();
                        break;

                    case Keys.S:
                        this.salvar();
                        break;
                }
            else
            {
                if (e.KeyCode == Keys.F8)
                    this.compilar();

                if (e.KeyCode == Keys.F9)
                    this.gerarCodigo();

                if (e.KeyCode == Keys.F1)
                    this.equipe();
            }
        }
    }
}
