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

        int t_TOKEN_2 = 2; //","
        int t_TOKEN_3 = 3; //":"
        int t_TOKEN_4 = 4; //";"
        int t_TOKEN_5 = 5; //"["
        int t_TOKEN_6 = 6; //"]"
        int t_TOKEN_7 = 7; //"("
        int t_TOKEN_8 = 8; //")"
        int t_TOKEN_9 = 9; //"{"
        int t_TOKEN_10 = 10; //"}"
        int t_TOKEN_11 = 11; //"+"
        int t_TOKEN_12 = 12; //"-"
        int t_TOKEN_13 = 13; //"*"
        int t_TOKEN_14 = 14; //"/"
        int t_TOKEN_15 = 15; //"<-"
        int t_TOKEN_16 = 16; //"="
        int t_TOKEN_17 = 17; //"!="
        int t_TOKEN_18 = 18; //"<"
        int t_TOKEN_19 = 19; //"<="
        int t_TOKEN_20 = 20; //">"
        int t_TOKEN_21 = 21; //">="
        int t_palavraReservada = 22;
        int t_identificadorInt = 23;
        int t_identificadorFloat = 24;
        int t_identificadorString = 25;
        int t_identificadorBool = 26;
        int t_constanteInt = 27;
        int t_constanteFloat = 28;
        int t_constanteString = 29;
        int t_and = 30;
        int t_false = 31;
        int t_if = 32;
        int t_in = 33;
        int t_isFalseDo = 34;
        int t_isTrueDo = 35;
        int t_main = 36;
        int t_module = 37;
        int t_not = 38;
        int t_or = 39;
        int t_out = 40;
        int t_true = 41;
        int t_while = 42;

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
            "",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada",
            "palavra reservada"
        };
    }
}
