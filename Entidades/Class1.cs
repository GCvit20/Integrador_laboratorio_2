using System.Drawing;
using static Entidades.Numeracion;

namespace Entidades
{
    public class Numeracion
    {
        private double valorNumerico;
        private ESistema sistema;
        public enum ESistema { Decimal, Binario };

        public ESistema Sistema { get { return this.sistema; } }
        public string Valor { get { return this.valorNumerico.ToString(); } }

        private void InicializarValores(string valor, ESistema sistema) 
        {
       
            this.sistema = sistema;

            if(this.sistema == ESistema.Decimal)
            {
                double valorNumero;
                double.TryParse(valor, out valorNumero);
                this.valorNumerico = valorNumero;
            }
            else if(this.sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }

        }

        public Numeracion(double valor, ESistema sistema)
        {
            this.sistema = sistema;
            this.valorNumerico = valor;
        }

        public Numeracion(string valor, ESistema sistema)
        {
           InicializarValores (valor, sistema);
        }

        public string ConvetirA(ESistema sistema)
        {

            if(ESistema.Decimal == this.sistema)
            {
                return valorNumerico.ToString();
            }
            else if (ESistema.Binario == this.sistema)
            {
                return DecimalABinario((int)valorNumerico);
            }

            return "";
        }


        private static bool EsBinario(string valor)
        {
            // Supongamos inicialmente que la cadena es binaria
            bool respuesta = true;

            foreach (char caracter in valor)
            {
                // Verifica si el carácter no es '0' ni '1'
                if (caracter != '0' && caracter != '1')
                {
                    // Si encuentra un carácter que no es binario, cambia la respuesta a false
                    respuesta = false;
                    break; // Puedes salir del bucle porque ya sabes que no es binario
                }
            }

            return respuesta;
        }

        
        private static double BinarioADecimal(string valor)
        {
            double decimalResultado = 0;

            if(EsBinario(valor) == true)
            {
                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        decimalResultado += (double)Math.Pow(2, valor.Length - 1 - i);
                    }
                }
            }
  
            return decimalResultado;
        }
        

        private static string DecimalABinario(int valor)
        {
            string binario = "";

            if (valor == 0)
            {
                return "0"; // El número 0 en binario es 0
            }
            else if (EsBinario(valor.ToString()) == true)
            {
                return "Numero invalido"; 
            }
            else if (valor > 0)
            {

                // Mientras el número sea mayor que 0, continuamos dividiendo y agregando los residuos al principio de la cadena
                while (valor > 0)
                {
                    int residuo = valor % 2; // Obtener el residuo de la división por 2
                    binario = residuo + binario; // Agregar el residuo al principio de la cadena
                    valor /= 2; // Dividir el número entre 2 para continuar el proceso
                }

            }

            return binario;

        }

        private static string DecimalABinario(string valor)
        {
            string binario = "";
            int valorNumero;
            int.TryParse(valor, out valorNumero);


            if (valorNumero == 0)
            {
                return "0"; // El número 0 en binario es 0
            }
            else if (EsBinario(valor.ToString()) == true)
            {
                return "Numero invalido";
            }
            else if (valorNumero > 0)
            {

                // Mientras el número sea mayor que 0, continuamos dividiendo y agregando los residuos al principio de la cadena
                while (valorNumero > 0)
                {
                    int residuo = valorNumero % 2; // Obtener el residuo de la división por 2
                    binario = residuo + binario; // Agregar el residuo al principio de la cadena
                    valorNumero /= 2; // Dividir el número entre 2 para continuar el proceso
                }

            }

            return binario;

        }

        public static bool operator != (ESistema sistema, Numeracion numeracion)
        {
            return sistema != numeracion;
        }

        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return (n1 != n2);
        }

        public static bool operator == (ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return (n1.Sistema == n2.Sistema);
        }

        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico - n2.valorNumerico;

            return new Numeracion(resultado, ESistema.Decimal); 
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico + n2.valorNumerico;

            return new Numeracion(resultado, ESistema.Decimal);
        }

        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico * n2.valorNumerico;

            return new Numeracion(resultado, ESistema.Decimal);
        }
        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico / n2.valorNumerico;

            return new Numeracion(resultado, ESistema.Decimal);
        }


    }

    public class Operacion
    {
        private Numeracion primerOperador;
        private Numeracion segundoOperador;

        public Numeracion PrimerOperador { get { return this.primerOperador; } set {  primerOperador = value; } }
        public Numeracion SegundoOperador { get { return this.segundoOperador; } set {  segundoOperador = value; } }


        public Operacion(Numeracion primerOperador, Numeracion segundoOperador)
        {
            this.primerOperador = primerOperador;
            this.segundoOperador = segundoOperador;
        }

        
        public Numeracion Operar(char operador)
        {
            double resultado;
            double primerOperador;
            double segundoOperador;
            double.TryParse(PrimerOperador.Valor, out primerOperador);
            double.TryParse(SegundoOperador.Valor, out segundoOperador);

            switch (operador)
            {
                case '+':
                    resultado = primerOperador + segundoOperador;
                    break;
                case '-':
                    resultado = primerOperador - segundoOperador;
                    break;
                case '*':
                    resultado = primerOperador * segundoOperador;
                    break;
                case '/':
                    resultado = primerOperador / segundoOperador;
                    break;
                default:
                    // Si el operador no es válido, ejecuta una suma por defecto
                    resultado = primerOperador + segundoOperador;
                    break;
            }

            return new Numeracion(resultado, ESistema.Decimal);
        }

    }
}