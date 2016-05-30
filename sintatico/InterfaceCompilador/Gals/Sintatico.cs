using System.Collections;

namespace InterfaceCompilador.Gals
{
    public class Sintatico : Constants
    {
        private Stack stack = new Stack();
        private Token currentToken;
        private Token previousToken;
        private Lexico scanner;
        private Semantico semanticAnalyser;
        private string[] simbolosEsperados = { "", ",", ":", ";", "[", "]", "(", ")", "{", "}", "+", "-", "*", "/", "<-", "=", "!=", "<", "<=", ">", ">=", "", "identificador", "identificador", "identificador", "identificador", "constante", "constante", "constante", "", "and", "false", "if", "in", "isFalseDo", "isTrueDo", "main", "module", "not", "or", "out", "true", "while" };

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
                int pos = 0;
                if (previousToken != null)
                    pos = previousToken.posicao + previousToken.lexema.Length;

                currentToken = new Token(DOLLAR, "$", pos, 1, "");
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
                    throw new SyntaticError(string.Format("Erro na linha {0} - encontrado {1} " + PARSER_ERROR[x], currentToken.linha, currentToken.lexema), currentToken.posicao);
                }
            }
            else if (isNonTerminal(x))
            {
                if (pushProduction(x, a))
                    return false;
                else
                {
                    string esperado = retornaSimbolosEsperados(x, a);
                    esperado = string.IsNullOrEmpty(esperado) ? PARSER_ERROR[x] : "esperado " + esperado;
                    throw new SyntaticError(string.Format("Erro na linha {0} - encontrado {1} " + esperado, currentToken.linha, currentToken.lexema.ToString().Replace("$", "fim de programa")), currentToken.posicao);
                }
            }
            else // isSemanticAction(x)
            {
                semanticAnalyser.executeAction(FIRST_SEMANTIC_ACTION, previousToken);
                return false;
            }
        }

        private string retornaSimbolosEsperados(int topStack, int tokenInput)
        {
            string simbolosEsperados = "";
            int p;
            for (int i = 0; i < 43; i++)
            {
                p = PARSER_TABLE[topStack - FIRST_NON_TERMINAL, i];
                if (p > 0)
                {
                    if (this.simbolosEsperados[i].Equals("identificador") && simbolosEsperados.Contains("identificador") ||
                        this.simbolosEsperados[i].Equals("constante") && simbolosEsperados.Contains("constante"))
                        continue;

                    simbolosEsperados += this.simbolosEsperados[i] + " ";
                }
                    
            }
            return simbolosEsperados;
        }

        private bool pushProduction(int topStack, int tokenInput)
        {
            int p = PARSER_TABLE[topStack - FIRST_NON_TERMINAL, tokenInput - 1];
            if (p >= 0)
            {
                int[] production = GetRow(PRODUCTIONS, p);
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

            while (!step())
                ;
        }
    }
}
