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
        public string Valor { get { return valorNumerico.ToString(); } }

        /// <summary>
        /// Este metodo inicializara los valores del constructor. 
        /// </summary>
        /// <param name="valor">Recibe un string</param>
        /// <param name="sistema">Reciber un sistema</param>
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

        /// <summary>
        /// Este metodo permite realizar la conversión de un valor almacenado en una instancia de la clase a un sistema numérico diferente 
        /// (binario en este caso). Si sistema es ESistema.Binario, se realiza la conversión binaria, de lo contrario, se devuelve el valor 
        /// en su forma original.
        /// </summary>
        /// <param name="sistema">Recibe por parametros un sistema</param>
        /// <returns>Devuelve un string que contiene el resultado de la conversion.</returns>

        public string ConvetirA(ESistema sistema)
        {
            return sistema == ESistema.Binario ? Numeracion.DecimalABinario(this.Valor):this.Valor;
   
        }

        /// <summary>
        /// El metodo permite verificar si el valor ingresado por parametro es un numero binario o no. 
        /// </summary>
        /// <param name="valor">Recibe por parametros un string</param>
        /// <returns>Si el valor ingresado es binario retorna true. De lo contrario, retorna un false.</returns>

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

        /// <summary>
        /// Este metodo si es posible realizara la conversion de un numero bianario a decimal. 
        /// </summary>
        /// <param name="valor">Recibe por parametros un string</param>
        /// <returns>Retornara un double con el resultado de la conversion si el numero ingresado es un binario. De lo contrario retorna 0</returns>
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

        /// <summary>
        /// Este metodo si es posible realizara la conversion de un numero decimal a binario. 
        /// </summary>
        /// <param name="valor"> Recibe por parametros un numero entero</param>
        /// <returns>Retornara un string con el resultado de la conversion si el mismo es un numero positivo. De lo contrario retorna "Numero invalido"</returns>
        private static string DecimalABinario(int valor)
        {
            string binario = "";

            if (valor == 0)
            {
                return "0"; // El número 0 en binario es 0
            }
            else if (valor < 0)
            {
                return "Numero invalido"; 
            }
            else
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

        /// <summary>
        /// Este metodo si es posible realizara la conversion de un numero decimal a binario. 
        /// </summary>
        /// <param name="valor"> Recibe por parametros un string</param>
        /// <returns>Retornara un numero entero con el resultado de la conversion si el mismo es un numero positivo. De lo contrario retorna "Numero invalido"</returns>

        private static string DecimalABinario(string valor)
        {
            string binario = "";
            int valorNumero;
            int.TryParse(valor, out valorNumero);


            if (valorNumero == 0)
            {
                return "0"; // El número 0 en binario es 0
            }
            else if (valorNumero < 0)
            {
                return  "Numero invalido";
            }
            else
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

        /// <summary>
        /// Este metodo realizara la operacion correspondiente dependiendo del operador que se le ingrese por parametro.
        /// </summary>
        /// <param name="operador">Recibira un char.</param>
        /// <returns>Retorna el resultado de dicha operacion.</returns>
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
                    resultado = primerOperador + segundoOperador;
                    break;
            }

            return new Numeracion(resultado, ESistema.Decimal);
        }

    }
}