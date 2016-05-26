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
        private int linha;
        private int classe;
        private StringBuilder saidaAreaMensagem;
        Lexico lexico;
        Sintatico sintatico;
        Semantico semantico;

        private string[] palavrasReservadas = { "and", "false", "if", "in", "isFalseDo", "isTrueDo", "main", "module", "not", "or", "out", "true", "while" };

        public Main()
        {
            InitializeComponent();
            this.setArquivoNaoModificado();
            this.setAreaEditorFocus();
            this.saidaAreaMensagem = new StringBuilder();
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
            lexico = new Lexico(areaEditor.Text);
            sintatico = new Sintatico();
            semantico = new Semantico();

            try
            {
                this.compiladorLexico();
                sintatico.parse(lexico, semantico); 
            }
            catch (LexicalError e)
            {
                this.setTextoAreaMensagem(string.Format("Erro: {0}", e.Message));
            }
            catch (SyntaticError e)
            {
                this.setTextoAreaMensagem(string.Format("Erro: {0}", e.Message));
            }
            catch (SemanticError e)
            {
                this.setTextoAreaMensagem(string.Format("Erro: {0}", e.Message));
            }
        }

        private void compiladorLexico()
        {           
            this.linha = 10;
            this.classe = 20;

            try
            {
                montaCabecalhoGrid();
                Token token = lexico.nextToken();
                while (token != null)
                {
                    /*if (token.linha.ToString().Length > this.linha || token.classeNome.Length > this.classe)
                        remontaGrid(token.linha.ToString().Length, token.classeNome.Length);*/
                    if (token.classe != 30)
                    {
                        if(token.classe == 22 && !palavrasReservadas.Contains(token.lexema))
                        {
                            throw new LexicalError(string.Format("Erro na linha {0} - {1} palavra reservada inválida", token.linha, token.lexema));
                        }
                        this.saidaAreaMensagem.AppendLine(token.linha.ToString().PadRight(this.linha) + token.classeNome.ToString().PadRight(this.classe) + token.lexema);
                    }
                    else
                    {
                        int linhas = token.toString().Split('\n').Count() - 1;
                        lexico.linha += linhas;
                    }
                    token = lexico.nextToken();
                }

                this.setTextoAreaMensagem(this.saidaAreaMensagem.ToString());
            }
            catch (LexicalError e)
            {
                
                this.setTextoAreaMensagem(e.Message);
            }
        }

        private void montaCabecalhoGrid()
        {
            this.saidaAreaMensagem.Clear();
            this.saidaAreaMensagem.AppendLine("linha".PadRight(this.linha) + "classe".PadRight(this.classe) + "lexema");
        }

        /*private void remontaGrid(int linha, int classe)
        {
            if (linha <= this.linha)
                linha = this.linha;
            else
                linha++;

            if (classe <= this.classe)
                classe = this.classe;
            else
                classe++;

            StringBuilder stringBuilder = new StringBuilder();
            StringReader stringReader = new StringReader(this.saidaAreaMensagem.ToString());

            string linhaAtual;
            while ((linhaAtual = stringReader.ReadLine()) != null)
           {
                string linhaString = linhaAtual.Substring(0, this.linha).ToString().Trim();
                string classeString = linhaAtual.Substring(this.linha, this.classe).ToString().Trim();
                string lexemaString = linhaAtual.Substring(this.linha + this.classe, linhaAtual.Length - (this.linha + this.classe)).ToString().Trim();
                stringBuilder.AppendLine(linhaString.ToString().PadRight(linha) + classeString.ToString().PadRight(classe) + lexemaString.ToString());
            }
            this.linha = linha;
            this.classe = classe;
            this.saidaAreaMensagem = stringBuilder;
        }*/

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