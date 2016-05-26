using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public class Token
    {
        public int classe;
        public string lexema;
        public int posicao;
        public int linha;
        public string classeNome;

        public Token(int classe, string lexema, int posicao, int linha, string classeNome)
        {
            this.classe = classe;
            this.lexema = lexema;
            this.posicao = posicao;
            this.linha = linha;
            this.classeNome = classeNome;
        }

        public string toString()
        {
            return classe+" ( "+lexema+" ) @ "+posicao;
        }
    }
}
