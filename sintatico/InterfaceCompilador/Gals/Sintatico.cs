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
        private const char space = ' ';

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

            if (isNonTerminal(x) && a == DOLLAR)
                x = ((int)stack.Pop());

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
                    string esperado = string.IsNullOrEmpty(PARSER_ERROR[x]) ? retornaSimbolosEsperados(x, a) : PARSER_ERROR[x];
                    throw new SyntaticError(string.Format("Erro na linha {0} - encontrado {1} esperado {2}", currentToken.linha, 
                                                                                                             currentToken.lexema.ToString().Replace("$", "fim de programa"), 
                                                                                                             esperado), currentToken.posicao);
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
            
            for (int simbolo = 0; simbolo < this.simbolosEsperados.Length; simbolo++)
            {
                p = PARSER_TABLE[topStack - FIRST_NON_TERMINAL, simbolo];
                if (p > 0)
                {
                    if (this.simbolosEsperados[simbolo].Equals("identificador") && simbolosEsperados.Contains("identificador") ||
                        this.simbolosEsperados[simbolo].Equals("constante") && simbolosEsperados.Contains("constante"))
                        continue;

                    simbolosEsperados += this.simbolosEsperados[simbolo] + space;
                }

            }
            return simbolosEsperados.Trim();
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

            while (!step());
        }
    }
}
