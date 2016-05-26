using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public class LexicalError : AnalysisError
    {
        public LexicalError(string msg, int posicao) : base(msg, posicao)
        {
        }

        public LexicalError(String msg) : base(msg)
        {
        }
    }
}