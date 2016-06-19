using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCompilador.Gals
{
    public class Semantico : Constants
    {
        public string codigo
        {
            get
            {
                return codigoFonte.ToString();
            }
        }
        StringBuilder codigoFonte = new StringBuilder();
        Stack<string> pilhaTipos = new Stack<string>();
        string operadorRelacional;

        string INT64 = "int64";
        string FLOAT64 = "float64";
        string BOOL = "bool";
        string STRING = "string";

        public void executeAction(int action, Token token)
        {
            int acaoSemantica = action - FIRST_SEMANTIC_ACTION;

            switch (acaoSemantica)
            {
                case 1:
                    acao1();
                    break;
                case 2:
                    acao2();
                    break;
                case 3:
                    acao3();
                    break;
                case 4:
                    acao4();
                    break;
                case 5:
                    acao5(token);
                    break;
                case 6:
                    acao6(token);
                    break;
                case 7:
                    acao7();
                    break;
                case 8:
                    acao8();
                    break;
                case 9:
                    acao9();
                    break;
                case 10:
                    acao10(token);
                    break;
                case 11:
                    acao11();
                    break;
                case 12:
                    acao12();
                    break;
                case 13:
                    acao13();
                    break;
                case 14:
                    acao14();
                    break;
                case 15:
                    acao15();
                    break;
                case 16:
                    acao16();
                    break;
                case 17:
                    acao17();
                    break;
                case 18:
                    acao18(token);
                    break;
                case 19:
                    acao19(token);
                    break;
                default:
                    break;
            }
        }

        private void acao1()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == FLOAT64 || tipo2 == FLOAT64)
                    pilhaTipos.Push(FLOAT64);
                else
                    pilhaTipos.Push(INT64);
                codigoFonte.AppendLine("add");
            }
            catch(Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 1. Erro: {0}", e.Message));
            }
        }

        private void acao2()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == FLOAT64 || tipo2 == FLOAT64)
                    pilhaTipos.Push(FLOAT64);
                else
                    pilhaTipos.Push(INT64);
                codigoFonte.AppendLine("sub");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 2. Erro: {0}", e.Message));
            }
        }

        private void acao3()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == FLOAT64 || tipo2 == FLOAT64)
                    pilhaTipos.Push(FLOAT64);
                else
                    pilhaTipos.Push(INT64);
                codigoFonte.AppendLine("mul");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 3. Erro: {0}", e.Message));
            }
        }

        private void acao4()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == tipo2)
                    pilhaTipos.Push(tipo1);
                else
                    throw new SemanticError("Erro semântico na acao 4.");
                codigoFonte.AppendLine("div");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 4. Erro: {0}", e.Message));
            }
        }

        private void acao5(Token token)
        {
            try
            {
                pilhaTipos.Push(INT64);
                codigoFonte.AppendLine(string.Format("ldc.i8 {0}", token.lexema));
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 5. Erro: {0}", e.Message));
            }
        }

        private void acao6(Token token)
        {
            try
            {
                pilhaTipos.Push(FLOAT64);
                codigoFonte.AppendLine(string.Format("ldc.r8 {0}", token.lexema));
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 6. Erro: {0}", e.Message));
            }
        }

        private void acao7()
        {
            try
            {
                string tipo = pilhaTipos.Pop();
                if (tipo == INT64 || tipo == INT64)
                    pilhaTipos.Push(tipo);
                else
                    throw new SemanticError("Erro semântico na acao 7.");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 7. Erro: {0}", e.Message));
            }
        }

        private void acao8()
        {
            try
            {
                string tipo = pilhaTipos.Pop();
                if (tipo == INT64 || tipo == INT64)
                    pilhaTipos.Push(tipo);
                else
                    throw new SemanticError("Erro semântico na acao 8.");
                codigoFonte.AppendLine("ldc.i8 -1");
                codigoFonte.AppendLine("mul");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 8. Erro: {0}", e.Message));
            }
        }

        private void acao9()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == tipo2)
                    pilhaTipos.Push(BOOL);
                else
                    throw new SemanticError("Erro semantico na acao 9");
                switch (operadorRelacional)
                {
                    case "=":
                        codigoFonte.AppendLine("ceq");
                        break;
                    case ">":
                        codigoFonte.AppendLine("cgt");
                        break;
                    case "<":
                        codigoFonte.AppendLine("clt");
                        break;
                    default:
                        throw new SemanticError("Erro semantico na acao 9");
                }
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 9. Erro: {0}", e.Message));
            }
        }

        private void acao10(Token token)
        {
            try
            {
                operadorRelacional = token.lexema;
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 10. Erro: {0}", e.Message));
            }
        }

        private void acao11()
        {
            try
            {
                string tipo = pilhaTipos.Pop();
                codigoFonte.AppendLine(string.Format("call void [mscorlib]System.Console::Write({0})", tipo));
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 11. Erro: {0}", e.Message));
            }
        }

        private void acao12()
        {
            try
            {
                codigoFonte.AppendLine(".assembly extern mscorlib {}");
                codigoFonte.AppendLine(".assembly codigo_objeto{}");
                codigoFonte.AppendLine(".module codigo_objeto.exe");
                codigoFonte.AppendLine(".class public _Principal {");
                codigoFonte.AppendLine(".method static public void _principal(){");
                codigoFonte.AppendLine(".entrypoint");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 12. Erro: {0}", e.Message));
            }
        }

        private void acao13()
        {
            try
            {
                codigoFonte.AppendLine("ret");
                codigoFonte.AppendLine("}");
                codigoFonte.AppendLine("}");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 13. Erro: {0}", e.Message));
            }
        }

        private void acao14()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == BOOL && tipo2 == BOOL)
                    pilhaTipos.Push(BOOL);
                else
                    throw new SemanticError("Erro semantico na acao 14. Erro: tipos incompatíveis");
                codigoFonte.AppendLine("and");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 14. Erro: {0}", e.Message));
            }
        }

        private void acao15()
        {
            try
            {
                string tipo1 = pilhaTipos.Pop();
                string tipo2 = pilhaTipos.Pop();
                if (tipo1 == BOOL && tipo2 == BOOL)
                    pilhaTipos.Push(BOOL);
                else
                    throw new SemanticError("Erro semantico na acao 15. Erro: tipos incompatíveis");
                codigoFonte.AppendLine("or");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 15. Erro: {0}", e.Message));
            }
        }

        private void acao16()
        {
            try
            {
                pilhaTipos.Push(BOOL);
                codigoFonte.AppendLine("ldc.i4.1");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 16. Erro: {0}", e.Message));
            }
        }

        private void acao17()
        {
            try
            {
                pilhaTipos.Push(BOOL);
                codigoFonte.AppendLine("ldc.i4.0");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 17. Erro: {0}", e.Message));
            }
        }

        private void acao18(Token token)
        {
            try
            {
                pilhaTipos.Push(BOOL);
                string tipo = pilhaTipos.Pop();
                if (tipo == BOOL)
                {
                    if (token.lexema == "true")
                        codigoFonte.AppendLine("ldc.i4.0");
                    else
                        codigoFonte.AppendLine("ldc.i4.1");
                }
                else
                    throw new SemanticError("Erro semantico na acao 18. Erro: tipos incompatíveis");
                codigoFonte.AppendLine("or");
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 18. Erro: {0}", e.Message));
            }
        }

        private void acao19(Token token)
        {
            try
            {
                pilhaTipos.Push(STRING);
                codigoFonte.AppendLine(string.Format("ldstr {0}", token.lexema));
            }
            catch (Exception e)
            {
                throw new SemanticError(string.Format("Erro semantico na acao 19. Erro: {0}", e.Message));
            }
        }
    }
}
