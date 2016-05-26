using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public class AnalysisError : Exception
    {
        private int posicao;

        public AnalysisError(string msg, int posicao) : base(msg)
        {
            this.posicao = posicao;
        }

        public AnalysisError(string msg) : base(msg)
        {
            this.posicao = -1;
        }

        public int getPosition()
        {
            return posicao;
        }

        public string toString()
        {
            return base.ToString() + ", @ " + posicao;
        }
    }
}
