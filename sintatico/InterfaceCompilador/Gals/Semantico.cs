using System;
using System.Collections;
using System.Text;

namespace InterfaceCompilador.Gals
{
    public class Semantico : Constants
    {
        StringBuilder codigo = new StringBuilder();
        Stack pilha = new Stack();
        string operadorRelacional;

        public void executeAction(int action, Token token)
        {
            int acaoSemantica = action - FIRST_SEMANTIC_ACTION;

            switch (acaoSemantica)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    acao10(token);
                    break;
                case 11:
                    break;
                case 12:
                    acao12();
                    break;
                case 13:
                    acao13();
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                default:
                    break;
            }
        }

        private void acao10(Token token)
        {
            operadorRelacional = token.lexema;
        }

        private void acao12()
        {
            codigo.AppendLine(".assembly extern mscorlib {}");
            codigo.AppendLine(".assembly codigo_objeto{}");
            codigo.AppendLine(".module codigo_objeto.exe");
            codigo.AppendLine("");
            codigo.AppendLine(".method static public void _principal(){");
            codigo.AppendLine(".entrypoint )");
        }

        private void acao13()
        {
            codigo.AppendLine("ret } }");
        }
    }
}
