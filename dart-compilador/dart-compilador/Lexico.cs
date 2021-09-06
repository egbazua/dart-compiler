using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dart_compilador
{
    class Lexico
    {
        public List<Error> listaErrorLexico;
        public List<Token> listaToken;

        private string codigoFuente;
        private int linea;
        //public char enterAux = Convert.ToChar(ConsoleKey.Enter);

        private int[,] matrizTransicion =
        {
                    //   0       1       2       3       4       5       6       7       8       9      10      11      12      13      14      15      16       17     18      19      20      21      22      23      24      25      26       27      28      29     30   //
                    //  dig  ║  pal  ║   "   ║   '   ║   +   ║   -   ║   *   ║   /   ║   <   ║   >   ║   =   ║   !   ║   &   ║   {   ║   }   ║   (   ║   )   ║   [   ║   ]   ║   .   ║   ,   ║   ;   ║   :   ║   ?   ║   _   ║   $   ║  esp  ║  ent  ║  eof  ║  tab  ║ desc 
            /* 0 */  {   2   ,   1   ,   5   ,   6   ,   8   ,   9   ,  10   ,  11   ,  12   ,  13   ,  14   ,  15   ,  16   , -26   , -27   , -24   , -25   , -28   , -29   , -35   , -30   , -31   , -32   , -33   , -37   , -36   ,   0   ,   0   ,   0   ,   0   , -500  },
            /* 1 */  {   1   ,   1   , -500  , -500  ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   , -500  ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   , -500  ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   , -500  },
            /* 2 */  {   2   , -501  , -501  , -501  ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   , -501  ,  -2   , -501  ,  -2   , -501  ,  -2   , -501  ,  -2   ,   3   ,  -2   ,  -2   , -501  , -501  , -501  , -501  ,  -2   ,  -2   ,  -2   ,  -2   , -500  },
            /* 3 */  {   4   , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -502  , -500  },
            /* 4 */  {   4   , -502  , -502  , -502  ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   , -502  ,  -3   , -502  ,  -3   , -502  ,  -3   , -502  ,  -3   , -502  ,  -3   ,  -3   , -502  , -502  ,  -3   , -502  ,  -3   ,  -3   ,  -3   ,  -3   , -500  },
            /* 5 */  {   5   ,   5   ,  -4   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   ,   5   , 5/*-503*/  , 5/*-503*/  ,   5   , -500  },
            /* 6 */  {   6   ,   6   ,   6   ,  -5   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6   ,   6  ,    6  ,    6   ,    6  },
            /* 7 */  { -504  , -504  , -504  ,  -5   , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -504  , -500  },
            /* 8 */  {  -6   ,  -6   ,  -6   ,  -6   ,  -18  ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -20  ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   ,  -6   , -500  },
            /* 9 */  {  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -19  ,  -7   ,  -7   ,  -7   ,  -7   ,  -21  ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   ,  -7   , -500  },
            /* 10 */ {  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -22  ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   ,  -8   , -500  },
            /* 11 */ {  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,   19  ,  18   ,  -9   ,  -9   ,  -23  ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   ,  -9   , -500  },
            /* 12 */ {  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -13  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  ,  -10  , -500  },
            /* 13 */ {  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -12  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  ,  -11  , -500  },
            /* 14 */ {  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -14  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  ,  -34  , -500  },
            /* 15 */ { -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  ,  -15  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -507  , -500  },
            /* 16 */ { -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  ,  -16  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -500  },
            /* 17 */ { -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  ,  -17  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -508  , -500  },
            /* 18 */ {  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,  18   ,   0   ,   0   ,   18  , -500  },
            /* 19 */ {  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  20   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   , -505  ,   19  , -500  },
            /* 20 */ {  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,   0   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   ,  19   , -505  ,   19  , -500  }
        };

        public Lexico(String codigoFuenteInterface)
        {
            codigoFuente = codigoFuenteInterface + " ";
            listaToken = new List<Token>();
            listaErrorLexico = new List<Error>(); 
        }

        private int PalabraReservada(string lexema)
        {
            switch (lexema)
            {
                case "void":
                    return -50;

                case "String":
                    return -51;

                case "int":
                    return -52;

                case "double":
                    return -53;

                case "bool":
                    return -54;

                case "List":
                    return -55;

                case "Map":
                    return -56;

                case "dynamic":
                    return -57;

                case "final":
                    return -58;

                case "new":
                    return -59;

                case "class":
                    return -60;

                case "this":
                    return -61;

                case "set":
                    return -62;

                case "get":
                    return -63;

                case "if":
                    return -64;

                case "throw":
                    return -65;

                case "implements":
                    return -66;

                case "extends":
                    return -67;

                case "abstract":
                    return -68;

                case "Future":
                    return -69;

                case "import":
                    return -70;

                case "static":
                    return -71;

                case "const":
                    return -72;

                case "return":
                    return -73;

                case "in":
                    return -74;

                case "else":
                    return -75;

                case "for":
                    return -76;

                case "while":
                    return -77;

                case "do":
                    return -78;

                case "null":
                    return -79;

                case "True":
                    return -80;

                case "False":
                    return -81;

                case "switch":
                    return -82;

                case "case":
                    return -83;

                case "break":
                    return -84;

                case "var":
                    return -85;

                default:
                    return -1;
            }
        }

        private char SiguienteCaracter(int i)
        {
            return Convert.ToChar(codigoFuente.Substring(i, 1));
        }

        //private void enterChar(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        RegresarColumna(e.KeyChar);
        //    }
        //}

        private int RegresarColumna(char caracter, object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(caracter))
            {
                return 0;
            }
            else if (char.IsLetter(caracter))
            {
                return 1;
            }
            else if (caracter.Equals('"'))
            {
                return 2;
            }
            else if (caracter.Equals('\''))
            {
                return 3;
            }
            else if (caracter.Equals('+'))
            {
                return 4;
            }
            else if (caracter.Equals('-'))
            {
                return 5;
            }
            else if (caracter.Equals('*'))
            {
                return 6;
            }
            else if (caracter.Equals('/'))
            {
                return 7;
            }
            else if (caracter.Equals('<'))
            {
                return 8;
            }
            else if (caracter.Equals('>'))
            {
                return 9;
            }
            else if (caracter.Equals('='))
            {
                return 10;
            }
            else if (caracter.Equals('!'))
            {
                return 11;
            }
            else if (caracter.Equals('&'))
            {
                return 12;
            }
            else if (caracter.Equals('{'))
            {
                return 13;
            }
            else if (caracter.Equals('}'))
            {
                return 14;
            }
            else if (caracter.Equals('('))
            {
                return 15;
            }
            else if (caracter.Equals(')'))
            {
                return 16;
            }
            else if (caracter.Equals('['))
            {
                return 17;
            }
            else if (caracter.Equals(']'))
            {
                return 18;
            }
            else if (caracter.Equals('.'))
            {
                return 19;
            }
            else if (caracter.Equals(','))
            {
                return 20;
            }
            else if (caracter.Equals(';'))
            {
                return 21;
            }
            else if (caracter.Equals(':'))
            {
                return 22;
            }
            else if (caracter.Equals('?'))
            {
                return 23;
            }
            else if (caracter.Equals('_'))
            {
                return 24;
            }
            else if (caracter.Equals('$'))
            {
                return 25;
            }
            else if (caracter.Equals(' '))
            {
                return 26;
            }
            else if (e.KeyChar == (char)13)
            {
                return 27;
            }
            //else if (caracter.Equals('eof'))
            //{
            //    return 28;
            //}
            else if (caracter.Equals('\t'))
            {
                return 29;
            }
            //else if (caracter.Equals('desc'))
            //{
            //    return 30;
            //}
            else
            {
                return 30;
            }
        }

        private TipoToken Tipo(int estado)
        {
            switch (estado)
            {
                case -1:
                    return TipoToken.Identificador;

                case -2:
                    return TipoToken.NumeroEntero;

                case -3:
                    return TipoToken.NumeroDecimal;

                case -4:
                    return TipoToken.Cadena;

                case -5:
                    return TipoToken.Caracter;

                case -6:
                    return TipoToken.OperadorAritmetico;

                case -7:
                    return TipoToken.OperadorAritmetico;

                case -8:
                    return TipoToken.OperadorAritmetico;

                case -9:
                    return TipoToken.OperadorAritmetico;

                case -10:
                    return TipoToken.OperadorRelacional;

                case -11:
                    return TipoToken.OperadorRelacional;

                case -12:
                    return TipoToken.OperadorRelacional;

                case -13:
                    return TipoToken.OperadorRelacional;

                case -14:
                    return TipoToken.OperadorRelacional;

                case -15:
                    return TipoToken.OperadorRelacional;

                case -16:
                    return TipoToken.OperadorLogico;

                case -17:
                    return TipoToken.OperadorLogico;

                case -18:
                    return TipoToken.SimboloDoble;

                case -19:
                    return TipoToken.SimboloDoble;

                case -20:
                    return TipoToken.OperadorAsignacion;

                case -21:
                    return TipoToken.OperadorAsignacion;

                case -22:
                    return TipoToken.OperadorAsignacion;

                case -23:
                    return TipoToken.OperadorAsignacion;

                case -24:
                    return TipoToken.SimboloSimple;

                case -25:
                    return TipoToken.SimboloSimple;

                case -26:
                    return TipoToken.SimboloSimple;

                case -27:
                    return TipoToken.SimboloSimple;

                case -28:
                    return TipoToken.SimboloSimple;

                case -29:
                    return TipoToken.SimboloSimple;

                case -30:
                    return TipoToken.SimboloSimple;

                case -31:
                    return TipoToken.SimboloSimple;

                case -32:
                    return TipoToken.SimboloSimple;

                case -33:
                    return TipoToken.SimboloSimple;

                case -34:
                    return TipoToken.SimboloSimple;

                case -35:
                    return TipoToken.SimboloSimple;

                case -36:
                    return TipoToken.SimboloSimple;

                case -37:
                    return TipoToken.SimboloSimple;

                case -50:
                    return TipoToken.PalabraReservada;

                case -51:
                    return TipoToken.PalabraReservada;

                case -52:
                    return TipoToken.PalabraReservada;

                case -53:
                    return TipoToken.PalabraReservada;

                case -54:
                    return TipoToken.PalabraReservada;

                case -55:
                    return TipoToken.PalabraReservada;

                case -56:
                    return TipoToken.PalabraReservada;

                case -57:
                    return TipoToken.PalabraReservada;

                case -58:
                    return TipoToken.PalabraReservada;

                case -59:
                    return TipoToken.PalabraReservada;

                case -60:
                    return TipoToken.PalabraReservada;

                case -61:
                    return TipoToken.PalabraReservada;

                case -62:
                    return TipoToken.PalabraReservada;

                case -63:
                    return TipoToken.PalabraReservada;

                case -64:
                    return TipoToken.PalabraReservada;

                case -65:
                    return TipoToken.PalabraReservada;

                case -66:
                    return TipoToken.PalabraReservada;

                case -67:
                    return TipoToken.PalabraReservada;

                case -68:
                    return TipoToken.PalabraReservada;

                case -69:
                    return TipoToken.PalabraReservada;

                case -70:
                    return TipoToken.PalabraReservada;

                case -71:
                    return TipoToken.PalabraReservada;

                case -72:
                    return TipoToken.PalabraReservada;

                case -73:
                    return TipoToken.PalabraReservada;

                case -74:
                    return TipoToken.PalabraReservada;

                case -75:
                    return TipoToken.PalabraReservada;

                case -76:
                    return TipoToken.PalabraReservada;

                case -77:
                    return TipoToken.PalabraReservada;

                case -78:
                    return TipoToken.PalabraReservada;

                case -79:
                    return TipoToken.PalabraReservada;

                case -80:
                    return TipoToken.PalabraReservada;

                case -81:
                    return TipoToken.PalabraReservada;

                case -82:
                    return TipoToken.PalabraReservada;

                case -83:
                    return TipoToken.PalabraReservada;

                case -84:
                    return TipoToken.PalabraReservada;

                case -85:
                    return TipoToken.PalabraReservada;

                default:
                    return TipoToken.Nada;
            }
        }

        private Error ManejoErrores(int estado)
        {
            string mensajeError;

            switch (estado)
            {
                case -500:
                    mensajeError = "Identificador no válido.";
                    break;

                case -501:
                    mensajeError = "Número Entero no válido.";
                    break;

                case -502:
                    mensajeError = "Número decimal no válido.";
                    break;

                case -503:
                    mensajeError = "Formato de cadena inválida: se esperaba una \"";
                    break;

                case -504:
                    mensajeError = "Se esperaba un carácter.";
                    break;

                case -505:
                    mensajeError = "Se esperaba fin de comentario.";
                    break;

                case -507:
                    mensajeError = "Se esperaba: =";
                    break;

                case -508:
                    mensajeError = "Se esperaba un operador lógico.";
                    break;

                default:
                    mensajeError = "Error inesperado.";
                    break;
            }

            return new Error()
            {
                Codigo = estado,
                MensajeError = mensajeError,
                Tipo = tipoError.Lexico,
                Linea = linea
            };

        }

        public List<Token> EjecutarLexico()
        {
            int estado = 0;
            int columna = 0;

            bool entrar = false; 

            char caracterActual;
           // String caracterActualAux ="";
            string lexema = string.Empty;
            linea = 1;

            for (int i = 0; i < codigoFuente.ToCharArray().Length; i++) 
            {
                entrar = false;
                caracterActual = SiguienteCaracter(i);

                if (caracterActual.Equals('\n'))
                {
                    linea++;    
                }

                lexema += caracterActual;
                columna = RegresarColumna(caracterActual, null, new KeyPressEventArgs(Convert.ToChar(Keys.Enter)));
                estado = matrizTransicion[estado, columna];
                
                if(estado < 0 && estado > -499)
                {

                    if (lexema.Length > 1)
                    {
                        lexema = lexema + " ";
                        //lexema = lexema.Remove(lexema.Length - 2);
                        //lexema = lexema.Remove(lexema.Length - 1);
                        lexema = lexema.Remove(lexema.Length - 1);
                        //i--;
                    }

                    Token nuevoToken = new Token()
                    {
                        ValorToken = estado,
                        Lexema = lexema,
                        Linea = linea
                    };

                    if (estado == -1)
                    {
                        nuevoToken.ValorToken = PalabraReservada(lexema.Remove(lexema.Length - 1));
                        //nuevoToken.ValorToken = PalabraReservada(nuevoToken.Lexema);
                        //lexema = caracterActualAux;
                        //nuevoToken.TipoToken = Tipo(nuevoToken.ValorToken);
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                        //listaToken.Add(nuevoToken);
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                        entrar = true;
                    } else if (estado == -2 || estado == -6 || estado == -7 || estado == -8 || estado == -37 || estado == -10 || estado == -11 || estado == -12 || estado == -13 ||estado == -14 || estado == -15) {
                        entrar = true;
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                    } else if (estado == -3) {
                        entrar = true;
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                    } else if (estado <= -10 && estado >= -17)
                    {
                        entrar = true;
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                    } else if (estado <= -20&& estado >=-23) {
                        entrar = true;
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                    }else if (estado <= -16 && estado >= -17)
                    {
                        entrar = true;
                        nuevoToken.Lexema = lexema.Remove(lexema.Length - 1);
                    }

                    nuevoToken.TipoToken = Tipo(nuevoToken.ValorToken);
                    //nuevoToken.Lexema = caracterActualAux;

                    listaToken.Add(nuevoToken);

                    if (entrar == true)
                    {
                        i--;
                    }

                    estado = 0;
                    columna = 0;
                    lexema = string.Empty;
                }
                else if(estado <= -499)
                {
                    listaErrorLexico.Add(ManejoErrores(estado));
                    estado = 0;
                    columna = 0;
                    lexema = string.Empty;
                }
                else if (estado == 0)
                {
                    columna = 0;
                    lexema = string.Empty;
                }
            }

            //if (estado != 0)
            //{
            //    if (estado == 5)
            //    {
            //        listaErrorLexico.Add(ManejoErrores(-503));
            //    }
            //    else
            //    {
            //        //listaErrorLexico.Add(ManejoErrores(-509));
            //    }
            //}

            return listaToken;
        }
    }
}
