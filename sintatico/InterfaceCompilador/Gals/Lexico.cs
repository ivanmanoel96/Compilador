using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public class Lexico : Constants
    {
        public int posicao;
        public int linha = 1;
        public string entrada;

        public Lexico(string entrada)
        {
            this.entrada = entrada;
            this.posicao = 0;
        }

        public void setPosicao(int posicao)
        {
            this.posicao = posicao;
        }

        public Token proximoToken()
        {
            if (!this.possuiEntrada())
                return null;

            if (this.entrada.Substring(this.posicao, 1).Equals("\n"))
                this.linha++;

            int inicio = this.posicao;

            int estado = 0;
            int estadoFinal = 0;
            int fimEstado = -1;
            int fim = -1;
            int fimErro = -1;

            while (this.possuiEntrada())
            {
                estadoFinal = estado;
                estado = this.proximoEstado(proximoCaracter(), estado);

                if (estado < 0)
                {
                    fimErro = this.posicao;
                    break;
                }
                else
                {
                    if (this.retornaTokenEstado(estado) >= 0)
                    {
                        fimEstado = estado;
                        fim = this.posicao;
                    }
                }
            }

            if (fimEstado < 0 || (fimEstado != estado && this.retornaTokenEstado(estadoFinal) == -2))
            {
                string lexema = string.Empty;
                if (estadoFinal == 0)
                    if (fimErro < 0)
                        lexema = this.entrada.Substring(inicio, 1).TrimEnd() + " ";
                    else
                        lexema = this.entrada.Substring(inicio, fimErro - inicio).TrimEnd() + " ";

                throw new LexicalError(string.Format("Erro na linha {0} - {1}{2}", this.linha, lexema, this.SCANNER_ERROR[estadoFinal]), inicio);
            }

            this.posicao = fim;

            int classe = this.retornaTokenEstado(fimEstado);

            if (classe == 0)
                return this.proximoToken();
            else
            {
                string lexema = this.entrada.Substring(inicio, fim - inicio);
                classe = retornaTokenEspecial(classe, lexema);
                return new Token(classe, lexema, inicio, this.linha, classeTokens[classe]);
            }
        }

        private int proximoEstado(char c, int estado)
        {
            int inicio = this.SCANNER_TABLE_INDEXES[estado];
            int fim = this.SCANNER_TABLE_INDEXES[estado + 1] - 1;

            while (inicio <= fim)
            {
                int metade = (inicio + fim) / 2;

                if (this.SCANNER_TABLE[metade, 0] == c)
                    return this.SCANNER_TABLE[metade, 1];
                else if (this.SCANNER_TABLE[metade, 0] < c)
                    inicio = metade + 1;
                else  //(SCANNER_TABLE[metade][0] > c)
                    fim = metade - 1;
            }
            return -1;
        }

        private int retornaTokenEstado(int estado)
        {
            if (estado < 0 || estado >= this.TOKEN_STATE.Length)
                return -1;

            return this.TOKEN_STATE[estado];
        }

        public int retornaTokenEspecial(int classe, string lexema)
        {
            int inicio = SPECIAL_CASES_INDEXES[classe];
            int fim = SPECIAL_CASES_INDEXES[classe + 1] - 1;

            while (inicio <= fim)
            {
                int metade = (inicio + fim) / 2;
                int comp = SPECIAL_CASES_KEYS[metade].CompareTo(lexema);

                if (comp == 0)
                    return SPECIAL_CASES_VALUES[metade];
                else if (comp < 0)
                    inicio = metade + 1;
                else  //(comp > 0)
                    fim = metade - 1;
            }
            return classe;
        }

        private bool possuiEntrada()
        {
            return this.posicao < this.entrada.Length;
        }

        private char proximoCaracter()
        {
            if (this.possuiEntrada())
                return this.entrada[posicao++];
            else
                return new Char();
        }

        public void analisar()
        {
            Token token = this.proximoToken();
            while (token != null)
            {
                if (token.classe != 30)
                {
                    if (token.classe == 22 && !SPECIAL_CASES_KEYS.Contains(token.lexema))
                    {
                        throw new LexicalError(string.Format("Erro na linha {0} - {1} palavra reservada inválida", token.linha, token.lexema));
                    }
                }
                token = this.proximoToken();
            }
            this.posicao = 0;
            this.linha = 1;
        }
    }
}
