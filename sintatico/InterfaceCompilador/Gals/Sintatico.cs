using System.Collections;
using System.Linq;

namespace InterfaceCompilador.Gals
{
    public class Sintatico : Constants
    {
        private Stack stack = new Stack();
        private Token currentToken;
        private Token previousToken;
        private Lexico scanner;
        private Semantico semanticAnalyser;

        private bool isTerminal(int x)
        {
            return x < FIRST_NON_TERMINAL;
        }

        private bool isNonTerminal(int x)
        {
            return x >= FIRST_NON_TERMINAL && x < FIRST_SEMANTIC_ACTION;
        }

        private bool isSemanticAction(int x)
        {
            return x >= FIRST_SEMANTIC_ACTION;
        }

        private bool step()
        {
            if (currentToken == null)
            {
                int posicao = 0;
                int linha = 1;
                if (previousToken != null) {
                    posicao = previousToken.posicao + previousToken.lexema.Length;
                    linha = previousToken.linha;
                }
                    

                currentToken = new Token(DOLLAR, "$", posicao, linha, "");
            }

            int x = ((int)stack.Pop());
            int a = currentToken.classe;

            if (x == EPSILON)
            {
                return false;
            }
            else if (isTerminal(x))
            {
                if (x == a)
                {
                    if (stack.Count == 0)
                        return true;
                    else
                    {
                        previousToken = currentToken;
                        currentToken = scanner.proximoToken();
                        return false;
                    }
                }
                else
                {
                    throw new SyntaticError(string.Format("Erro na linha {0} - encontrado {1} esperado {2}", currentToken.linha,
                                                                                                             currentToken.lexema.ToString().Replace("$", "fim de programa"),
                                                                                                             PARSER_ERROR[x]), currentToken.posicao);  
                     

                }
            }
            else if (isNonTerminal(x))
            {
                if (pushProduction(x, a))
                    return false;
                else
                {
                    throw new SyntaticError(string.Format("Erro na linha {0} - encontrado {1} esperado {2}", currentToken.linha,
                                                                                                             currentToken.lexema.ToString().Replace("$", "fim de programa"),
                                                                                                             PARSER_ERROR[x]), currentToken.posicao);
                }
            }
            else // isSemanticAction(x)
            {
                semanticAnalyser.executeAction(FIRST_SEMANTIC_ACTION, previousToken);
                return false;
            }
        }

        private bool pushProduction(int topStack, int tokenInput)
        {
            int p = PARSER_TABLE[topStack - FIRST_NON_TERMINAL, tokenInput - 1];
            if (p >= 0)
            {
                int[] linha = GetRow(PRODUCTIONS, p);
                int[] production;
                if (linha.Where(val => val != 0).ToArray().Count() > 0)
                {
                    production = linha.Where(val => val != 0).ToArray();
                }
                else
                {
                    production = new int[] { 0 };
                }
                //empilha a produção em ordem reversa
                for (int i = production.Length - 1; i >= 0; i--)
                {
                    stack.Push(production[i]);
                }
                return true;
            }
            else
                return false;
        }

        public static T[] GetRow<T>(T[,] matrix, int row)
        {
            var columns = matrix.GetLength(1);
            var array = new T[columns];
            for (int i = 0; i < columns; ++i)
                array[i] = matrix[row, i];
            return array;
        }

        public void analisar(Lexico scanner, Semantico semanticAnalyser)
        {
            this.scanner = scanner;
            this.semanticAnalyser = semanticAnalyser;

            stack.Clear();
            stack.Push(this.DOLLAR);
            stack.Push(this.START_SYMBOL);

            currentToken = scanner.proximoToken();

            while (!step());
        }
    }
}
