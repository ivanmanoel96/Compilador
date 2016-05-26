using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public class Constants : ScannerConstants
    {
        public int EPSILON = 0;
        public int DOLLAR = 1;

        public int t_TOKEN_2 = 2; //","
        public int t_TOKEN_3 = 3; //":"
        public int t_TOKEN_4 = 4; //";"
        public int t_TOKEN_5 = 5; //"["
        public int t_TOKEN_6 = 6; //"]"
        public int t_TOKEN_7 = 7; //"("
        public int t_TOKEN_8 = 8; //")"
        public int t_TOKEN_9 = 9; //"{"
        public int t_TOKEN_10 = 10; //"}"
        public int t_TOKEN_11 = 11; //"+"
        public int t_TOKEN_12 = 12; //"-"
        public int t_TOKEN_13 = 13; //"*"
        public int t_TOKEN_14 = 14; //"/"
        public int t_TOKEN_15 = 15; //"<-"
        public int t_TOKEN_16 = 16; //"="
        public int t_TOKEN_17 = 17; //"!="
        public int t_TOKEN_18 = 18; //"<"
        public int t_TOKEN_19 = 19; //"<="
        public int t_TOKEN_20 = 20; //">"
        public int t_TOKEN_21 = 21; //">="
        public int t_palavraReservada = 22;
        public int t_identificadorInt = 23;
        public int t_identificadorFloat = 24;
        public int t_identificadorString = 25;
        public int t_identificadorBool = 26;
        public int t_constanteInt = 27;
        public int t_constanteFloat = 28;
        public int t_constanteString = 29;
        public int t_comentarioBloco = 30;
        public int t_and = 31;
        public int t_false = 32;
        public int t_if = 33;
        public int t_in = 34;
        public int t_isFalseDo = 35;
        public int t_isTrueDo = 36;
        public int t_main = 37;
        public int t_module = 38;
        public int t_not = 39;
        public int t_or = 40;
        public int t_out = 41;
        public int t_true = 42;
        public int t_while = 43;

        public string[] classeTokens =
        {
            "",
            "",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "símbolo especial",
            "palavra reservada",
            "identificador",
            "identificador",
            "identificador",
            "identificador",
            "constante int",
            "constante float",
            "constante string",
            ""
        };
    }
}