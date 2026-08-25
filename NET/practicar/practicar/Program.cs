
using Microsoft.AspNetCore.Http;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text.Json;
using static HelloWorld.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            //inicio();
            //GetInput();
            //sumaDosNumeros();
            //temperaturaParser();
            //DivisionSeguraBasica();
            //SalidaFormateada();
            //NumeroPositivoONegativoOCero();
            //ParOImpar();
            //MayorDeTresNumeros();
            //CalculoDeDescuento();
            //AñoBisiesto();
            //TablaDeMultiplicar();
            //SumaDeNPrimerosNumeros();
            //ContadorDeDigitos();
            //AdivinaElNumero();
            //FizzBuzz();
            //Primos();
            //CalculadoraBasica();
            //Factorial();
            //Potencia();
            //Vocales();
            //Palindromo();
            //MenuInteractivo();
            //PromedioArreglo();
            //NumeroMayorArreglo();
            //NumeroMenorArreglo();
            //BusquedaNumeroArreglo();
            //ContarParesArreglo();
            //InvertirArreglo();
            //SegundoNumeroMayorArreglo();
            //EliminarDuplicadosArreglo();
            //RotarArreglo();
            //Diccionario();
            //HashSet();
            //FrutasDiccionario();
            //FrecuenciaDiccionario();
            //PrimeraClase();
            //ConociendoConstructores();
            //PruebasDeCuentaBancaria();
            //PruebasDeHerencia();
            //PruebasDePolimorfismo();
            //PruebasDeAbstracta();
            //PruebasDeInterfaces();
            //PrueDeGenericos();
            //PruebaClaseGenerica();
            //PruebaDelegados();
            //PruebasDeLambda();
            //MetodoSelect();
            //MetodoWhere();
            //MetodoSelectConObjetos();
            //MetodoOrderBy();
            //MetodoOrderByDescending();
            //MetodoThenBy();
            //MetodosFirstYFirstorDefault();
            //MetodosAnyAllCount();
            //ElEmpleadoMasGrandeLINQ();
            //ElSegundoEmpleadoMasGrandeLINQ();
            //MetodoDistinc();
            //MetodoGroupBy();
            //MetodoGroupByYSUM();
            //MetodoGroupByYSUMYFirst();
            //MinMaxAverageMetod();
            //LINQyLogicaNegocio();
            //LINQEntrevista();
            //LINQMasCaroDisponible();
            //PruebasYild();
            //PruebaYieldHastaNumeroDefinido();
            //GroupBySelectLINQ();
            //DepartamentoConEmpleadosRicosLINQ();
            //LinqAvanzado();
            //LinqFirstSingle();
            //ReporteDepartamentos();
            //ReporteProblemasSalariales();
            //ReporteDepartamentosSalariales();
            //LINQGroupJoin();
            LinqJoinGroupJoin();


        }



        #region Nivel 0: Sintaxis, variables, entrada y salida.

        static void inicio()
        {
            var nombre = "rafael";
            var edad = 24;
            var añosExprirence = 5;
            var lenguajePrincipal = "C#";


            Console.WriteLine($"Mi nombre es {nombre}, tengo {edad} años, cuento con {añosExprirence} años de experiencia y mi lenguaje principal es {lenguajePrincipal}");
        }
        static void GetInput()
        {
            Console.WriteLine("Cuantos años tienes");
            string input = Console.ReadLine();
            Console.WriteLine($"tienes {input} años");
        }
        static void sumaDosNumeros()
        {
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("dime el Primer Numero");
            var numero1 = Console.ReadLine();
            Console.WriteLine("dime el segundo Numero");
            var numero2 = Console.ReadLine();
            var suma = Convert.ToInt16(numero1) + Convert.ToInt16(numero2);
            Console.WriteLine($"La suma de {numero1} y {numero2} es igual a {suma}.");
        }
        static void temperaturaParser()
        {
            Console.WriteLine("Ingresa los grados Celsius");
            double numero = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((numero * 9) / 5) + 32;
            Console.WriteLine($"{numero} °C equivalen a {fahrenheit} °F.");

        }
        static void DivisionSeguraBasica()
        {
            Console.WriteLine("Division de dos numeros");
            Console.WriteLine("dime el Primer Numero a dividir");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dime el segundo Numero que sera el divisor");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
                return;
            }

            var resultado = numero1 / numero2;
            Console.WriteLine($"La division de {numero1} y {numero2} es igual a {resultado}.");

        }
        static void SalidaFormateada()
        {
            Console.WriteLine("Salida formateada");
            Console.WriteLine("Dime el Nombre del Producto");
            var nombre = Console.ReadLine();
            Console.WriteLine("Dime el precio del Producto");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dime la Cantidad de Producto");
            var cantidad = Convert.ToInt32(Console.ReadLine());

            var total = precio * cantidad;

            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Precio unitario: ${precio:N2}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total: ${total:N2}");

        }

        #endregion

        #region Nivel 1: Condicionales y operadores.

        public static void NumeroPositivoONegativoOCero()
        {
            Console.WriteLine("Dime el Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine($"El Numero {numero} es POSITIVO");
                return;
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El Numero {numero} es NEGATIVO");
                return;
            }
            else if (numero == 0)
            {
                Console.WriteLine($"El Numero {numero} es CERO");
            }
        }
        public static void ParOImpar()
        {
            Console.WriteLine("Dime el Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero % 2;
            if (resultado == 1)
            {
                Console.WriteLine($"el numero {numero} es IMPAR");

            }
            else if (resultado == 0)
            {
                Console.WriteLine($"el numero {numero} es PAR");
            }

        }
        public static void MayorDeTresNumeros()
        {
            Console.WriteLine("Dime el Primer Numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el Segundo Numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el Tercer Numero");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2 && n3 == n1)
            {
                Console.WriteLine("Son Iguales todos los numeros");

            }
            if (n1 == n2 && n1 >= n3)
            {
                Console.WriteLine("El Pirmer y segundo numero son iguales y mayores al tercero");

            }
            if (n1 == n3 && n1 >= n3)
            {
                Console.WriteLine("El Pirmer y Tercer numero son iguales y mayores al Segundo numero");

            }
            if (n2 == n3 && n2 >= n1)
            {
                Console.WriteLine("El Segundo y Tercer numero son iguales y mayores al Pirmer numero");

            }
            else if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El Pirmer numero es mayor");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("El Segundo numero es mayor");
            }
            else if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine("El Tercer numero es mayor");
            }
        }

        public static void CalculoDeDescuento()
        {
            Console.WriteLine("Calculadora de Descuentos");
            Console.WriteLine("Dime el Total de la Compra");
            decimal subtotal = Convert.ToDecimal(Console.ReadLine());

            decimal descuento;
            decimal desc;
            decimal total;

            Console.WriteLine($"Subtotal: ${subtotal:N2}");

            if (subtotal < 1000)
            {
                descuento = 0;
                desc = 0;
                total = subtotal;
                Console.WriteLine($"Descuento: ${desc:N2}");
                Console.WriteLine($"Total: ${total:N2}");


            }
            else if (subtotal >= 1000 && subtotal < 4999)
            {
                descuento = 0.1m;
                desc = subtotal * descuento;
                total = subtotal - desc;
                Console.WriteLine($"Descuento: ${desc:N2}");
                Console.WriteLine($"Total: ${total:N2}");

            }
            else if (subtotal >= 5000)
            {
                descuento = 0.2m;
                desc = subtotal * descuento;
                total = subtotal - desc;
                Console.WriteLine($"Descuento: ${desc:N2}");
                Console.WriteLine($"Total: ${total:N2}");
            }

        }
        public static void AñoBisiesto()
        {
            Console.WriteLine("Dime el Año");
            int año = Convert.ToInt32(Console.ReadLine());
            int resultado4 = año % 4;
            int resultado400 = año % 400;
            int resultado100 = año % 100;

            if (resultado4 == 0 && resultado100 != 0 || resultado400 == 0)
            {
                Console.WriteLine($"El año {año} es Bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {año}  NO es Bisiesto");


            }
        }

        #endregion

        #region Nivel 2: Ciclos.

        public static void TablaDeMultiplicar()
        {
            Console.WriteLine("Tabla de Multiplicar");
            Console.WriteLine("Ingresa un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                var resultado = i * numero;
                Console.WriteLine($"la tabla del numero {numero} x {i} es igual a {resultado}");
            }
        }
        public static void SumaDeNPrimerosNumeros()
        {
            Console.WriteLine("Suma De los N Primeros Numeros");
            Console.WriteLine("Ingresa un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma = suma + i;
                Console.WriteLine($"suma {suma} numero {i}");
            }

        }
        public static void ContadorDeDigitos()
        {
            Console.WriteLine("Contador De Digitos");
            Console.WriteLine("Ingresa un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
            }


        }
        public static void NumeroInvertido()
        {
            Console.WriteLine("Numero Invertido");
            Console.WriteLine("Ingresa un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
            }


        }
        public static void AdivinaElNumero()
        {
            Console.WriteLine("Contador De Digitos");
            int secreto = 17;
            int numero;
            int contador = 0;
            do
            {
                Console.WriteLine("Adivina el Numero");
                numero = Convert.ToInt32(Console.ReadLine());
                contador++;
                Console.WriteLine($"el numero es diferente");

            }
            while (numero != secreto);

            Console.WriteLine($"¡Felicidades!\r\n");
            Console.WriteLine($"¡lo lograste en {contador} intentos!\r\n");

        }
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        public static void Primos()
        {
            Console.WriteLine("dime  el Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= numero; i++)
            {
                int resultado = numero % i;
                if (resultado == 0)
                {
                    Console.WriteLine("es un numero primo");
                }

            }

        }



        #endregion

        #region Nivel 3: Métodos.

        public static void CalculadoraBasica()
        {
            Console.WriteLine("Primer Numero");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo Numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione la Operacion");
            Console.WriteLine("Oprima el numero 1 para Sumar +");
            Console.WriteLine("Oprima el numero 2 para Restar -");
            Console.WriteLine("Oprima el numero 3 para Multiplicar X");
            Console.WriteLine("Oprima el numero 4 para Dividir / ");
            int op = Convert.ToInt32(Console.ReadLine());
            int r;
            switch (op)
            {
                case 1:
                    r = n1 + n2;
                    Console.WriteLine($"El resultado es {r}");
                    break;
                case 2:
                    r = n1 - n2;
                    Console.WriteLine($"El resultado es {r}");
                    break;
                case 3:
                    r = n1 * n2;
                    Console.WriteLine($"El resultado es {r}");
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        r = n1 / n2;
                        Console.WriteLine($"El resultado es {r}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        public static void Factorial()
        {
            Console.WriteLine("Ingrese un Numero");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r = r * i;
                Console.WriteLine($"{r}");
            }
            Console.WriteLine($"El factorial de {n} es {r}");


        }

        public static void Potencia()
        {
            Console.WriteLine("Ingrese un Numero");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un el exponente");
            int e = Convert.ToInt32(Console.ReadLine());
            int r = b;
            for (int i = 1; i < e; i++)
            {
                r = r * b;
            }

            Console.WriteLine($"resultado: {r}");

        }
        public static void Vocales()
        {
            string frase = "hola mundo";
            int n = frase.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                char c = char.ToUpper(frase[i]);
                if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    count++;

                }
            }
            Console.WriteLine($"La frase contiene {count} vocales.");
        }
        public static void Palindromo()
        {
            string frase = "hola mundo";
            int n = frase.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                char c = char.ToUpper(frase[i]);
                if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    count++;

                }
            }
            Console.WriteLine($"La frase contiene {count} vocales.");
        }
        public static void MenuInteractivo()
        {
            int b = 0;
            do
            {
                Console.WriteLine("Ingrese un Numero");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar fecha");
                Console.WriteLine("3. Sumar dos números");
                Console.WriteLine("4. Salir");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b != 4);
        }
        public static void Estadisticas()
        {
            int b = 0;
            do
            {
                Console.WriteLine("Ingrese un Numero");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar fecha");
                Console.WriteLine("3. Sumar dos números");
                Console.WriteLine("4. Salir");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b != 4);
        }

        #endregion

        #region Nivel 4: Arreglos, listas y cadenas.

        public static void PromedioArreglo()
        {
            int[] numeros = { 8, 10, 7, 9, 6 };
            int suma = 0;
            int cantidad = numeros.Length;
            int prom = 0;

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");
                suma = suma + i;
            }
            prom = suma / cantidad;
            Console.WriteLine($"suma: {suma}");
            Console.WriteLine($"Promedio: {prom}");

        }
        public static void NumeroMayorArreglo()
        {
            int[] numeros = { 15, 4, 30, 8, 22 };
            int mayor = 0;

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");
                if (i > mayor)
                {
                    mayor = i;
                }
            }
            Console.WriteLine($"mayor: {mayor}");

        }
        public static void NumeroMenorArreglo()
        {
            int[] numeros = { 15, 4, 30, 8, 22 };
            int menor = numeros[0];

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");
                if (i < menor)
                {
                    menor = i;
                }
            }
            Console.WriteLine($"menor: {menor}");

        }
        public static void BusquedaNumeroArreglo()
        {
            Console.WriteLine("dime un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numeros = { 10, 25, 30, 41, 50 };
            bool ex = false;

            foreach (int i in numeros)
            {
                if (i == n)
                {
                    ex = true;
                }

            }
            if (ex)
            {
                Console.WriteLine("Número encontrado");
            }
            else
            {
                Console.WriteLine("no existe");
            }

        }
        public static void ContarParesArreglo()
        {
            int[] numeros =
            {
                2,
                5,
                8,
                7,
                10,
                13,
                20,10
            };
            int count = 0;
            foreach (int i in numeros)
            {
                if (i % 2 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine($"Hay {count} números pares.");


        }
        public static void InvertirArreglo()
        {
            int[] numeros =
            {
                5,
                10,
                15,
                20,
                25
            };
            int cant = numeros.Length;
            for (int i = cant - 1; i >= 0; i--)
            {

                Console.WriteLine($"{numeros[i]}");

            }
        }
        public static void SegundoNumeroMayorArreglo()
        {
            int[] numeros =
            {
                8,
                15,
                30,
                22,
                30,
                10
            };
            int mayor = numeros[0];
            int segundo = mayor;

            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}");
                if (i > mayor)
                {
                    segundo = mayor;
                    mayor = i;
                } else if (i < mayor && i > segundo)
                {
                    segundo = i;
                }
            }
            Console.WriteLine($"mayor: {mayor}");
            Console.WriteLine($"segundo: {segundo}");

        }
        public static void EliminarDuplicadosArreglo()
        {
            int[] numeros =
            {
                2,
                4,
                2,
                8,
                5,
                4,
                9,
                8
            };
            List<int> unicos = new List<int>();
            foreach (int numero in numeros)
            {
                bool exis = false;
                foreach (int n in unicos)
                {
                    if (n == numero)
                    {
                        exis = true;
                        break;
                    }
                }
                if (!exis)
                {
                    unicos.Add(numero);
                }

            }
            foreach (int numero in unicos)
            {
                Console.WriteLine(numero);
            }
        }
        public static void RotarArreglo()
        {
            int[] numeros =
            {
                1,2,3,4,5,6,7,8,9,
            };
            List<int> rotados = new List<int>();
            int ultimo = numeros[numeros.Length - 1];
            int cant = numeros.Length;

            Console.WriteLine($"ultimo {ultimo}");


            for (int i = cant - 1; i > 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
                numeros[i] = numeros[i - 1];


            }
            numeros[0] = ultimo;

            for (int i = 0; i <= cant - 1; i++)
            {
                Console.WriteLine($"{numeros[i]}");
                //numeros[i] = numeros[i - 1];


            }
        }


        #endregion

        #region Nivel 5: Diccionarios, conjuntos y colecciones.
        public static void Diccionario()
        {
            var diccionario = new Dictionary<string, int>()
            {
                {"juan",25 },
                {"maria",25 },
                {"pedro",25 },
                {"oablo",25 },

            };
            foreach (var par in diccionario)
            {
                Console.WriteLine($"{par.Key} tiene {par.Value} años");
            }
        }
        public static void HashSet()
        {
            HashSet<int> numeros = new HashSet<int>();

            numeros.Add(5);
            numeros.Add(8);
            numeros.Add(5);
            numeros.Add(3);
            numeros.Add(8);
            numeros.Add(9);

            // 3. Imprimir el contenido
            Console.WriteLine("Contenido del HashSet:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
        public static void FrutasDiccionario()
        {
            var frutas = new Dictionary<string, string>()
            {
                { "A", "Apple" },
                { "B", "Banana" },
                { "C", "Cherry" }
            };

            // 2. Pedir una letra al usuario
            Console.Write("Introduce una letra: ");
            string entrada = Console.ReadLine()?.Trim().ToUpper();

            // 3. Verificar si existe la clave y mostrar el resultado
            //if (frutas.TryGetValue(entrada, out string fruta))
            //{
            //    Console.WriteLine(fruta);
            //}
            //else
            //{
            //    Console.WriteLine("No encontrada.");
            //}
            // 1. Verificamos si la clave existe con ContainsKey
            if (frutas.ContainsKey(entrada))
            {
                // 2. Accedemos directamente al valor usando el indexador [ ]
                Console.WriteLine(frutas[entrada]);
            }
            else
            {
                Console.WriteLine("No encontrada.");
            }
        }
        public static void FrecuenciaDiccionario()
        {
            string palabra = "programacion";

            //dicccionario para almacenar los caracteres y su frecuencia
            Dictionary<char, int> frecuencias = new Dictionary<char, int>();

            foreach (char c in palabra)
            {
                if (frecuencias.ContainsKey(c))
                {
                    frecuencias[c]++;
                }
                else
                {
                    // Si es la primera vez que aparece, la agregamos con valor 1
                    frecuencias[c] = 1;
                }
            }
            foreach (var par in frecuencias)
            {
                Console.WriteLine($"{par.Key} = {par.Value}");
            }

        }

        #endregion

        #region Nivel 6: Programación orientada a objetos.

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public void MostrarInfo()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Edad: {Edad}");

            }
            public Persona(string nombre, int edad)
            {
                this.Nombre = nombre;
                Edad = edad;

            }
        }
        //comentado por error al compilar por el constructor

        //public static void PrimeraClase()
        //{
        //    Persona persona = new Persona();
        //    persona.Nombre = "rafai";
        //    persona.Edad = 1;
        //    persona.MostrarInfo();
        //}
        public static void ConociendoConstructores()
        {
            Persona p = new Persona("rafai", 5);
            p.MostrarInfo();

        }

        public class CuentaBancaria
        {
            private decimal Saldo { get; set; }
            public void Depositar(decimal saldo)
            {
                Console.WriteLine($"depositando el saldo {saldo}");
                Saldo = +saldo;
                Console.WriteLine($"Nuevo saldo: {Saldo}");


            }
            public void Retirar(decimal retiro)
            {
                Console.WriteLine($"Retirando el saldo de {retiro}");

                if (Saldo < retiro)
                {
                    Console.WriteLine($"No se puede retirar el saldo de {retiro} porque tienes {Saldo}");
                    return;
                }
                Saldo = -retiro;
                Console.WriteLine($"Tu nuevo saldo es de {Saldo}");

            }

            public void ConsultarSaldo()
            {
                Console.WriteLine($"Tu saldo actual es de {Saldo}");


            }

        }
        public static void PruebasDeCuentaBancaria()
        {
            CuentaBancaria c = new CuentaBancaria();
            c.Depositar(100);
            c.ConsultarSaldo();
            c.Retirar(1000);
            c.ConsultarSaldo();

        }

        public class Animal
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public virtual void HacerSonido()
            {
                Console.WriteLine($"{Nombre} hace un sonido genérico.");
            }
        }
        public class Perro : Animal
        {
            public Perro(string nombre, int edad)
            {
                this.Nombre = nombre;
                this.Edad = edad;
            }
            public override void HacerSonido()
            {
                Console.WriteLine($"{Nombre} dice: Guau guau!");
            }
        }
        public static void PruebasDeHerencia()
        {
            Perro p = new Perro("firulais", 4);
            Console.WriteLine(p.Nombre);
            p.HacerSonido();

        }
        public static void PruebasDePolimorfismo()
        {
            Perro p = new Perro("firulais", 4);
            Console.WriteLine(p.Nombre);
            p.HacerSonido();

        }

        //public abstract class Empleado
        //{
        //    public string Nombre { get; set; }
        //    public abstract decimal CalcularSalario();
        //    public Empleado(string nombre)
        //    {
        //        Nombre = nombre;
        //    }

        //}
        //public class EmpleadoTiempoCompleto : Empleado
        //{
        //    public decimal SalarioMensual { get; set; }

        //    public EmpleadoTiempoCompleto(string nombre, decimal salarioMensual)
        //        : base(nombre)
        //    {
        //        SalarioMensual = salarioMensual;
        //    }

        //    // Implementación obligatoria del método abstracto
        //    public override decimal CalcularSalario()
        //    {
        //        return SalarioMensual;
        //    }
        //}

        //public class EmpleadoPorHoras : Empleado
        //{
        //    public int HorasTrabajadas { get; set; }
        //    public decimal TarifaPorHora { get; set; }

        //    public EmpleadoPorHoras(string nombre, int horasTrabajadas, decimal tarifaPorHora)
        //        : base(nombre)
        //    {
        //        HorasTrabajadas = horasTrabajadas;
        //        TarifaPorHora = tarifaPorHora;
        //    }

        //    // Implementación obligatoria del método abstracto
        //    public override decimal CalcularSalario()
        //    {
        //        return HorasTrabajadas * TarifaPorHora;
        //    }
        //}
        //public static void PruebasDeAbstracta()
        //{
        //    List<Empleado> empleados = new List<Empleado>()
        //{
        //    new EmpleadoTiempoCompleto("Carlos", 2500.00m),
        //    new EmpleadoPorHoras("Ana", 80, 15.50m)
        //};

        //    // Recorremos la lista calculando el salario de cada uno sin importar su tipo específico
        //    foreach (Empleado emp in empleados)
        //    {
        //        Console.WriteLine($"Empleado: {emp.Nombre}");
        //        Console.WriteLine($"Salario: ${emp.CalcularSalario():F2}");
        //        Console.WriteLine("-----------------------");
        //    }

        //}

        public interface IVehiculo
        {
            public void Encender();
            public void Apagar();

        }
        public class Carro : IVehiculo
        {
            public void Encender()
            {
                Console.WriteLine("Carro Encendido");
            }
            public void Apagar()
            {
                Console.WriteLine("Carro Apagado");
            }


        }
        public static void PruebasDeInterfaces()
        {
            Carro c = new Carro();
            c.Encender();

        }

        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

            public Producto(string nombre, decimal precio)
            {
                Nombre = nombre;
                Precio = precio;
            }
        }
        public class Carrito
        {
            private List<Producto> Productos;
            public void AgregarProductos(Producto producto)
            {
                Productos.Add(producto);
            }
            public void EliminarProducto(string nombre)
            {
                Producto productoEncontrado = Productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            }
            public void MostrarProductos()
            {
                Console.WriteLine("\n--- Productos en el Carrito ---");
                if (Productos.Count == 0)
                {
                    Console.WriteLine("El carrito está vacío.");
                    return;

                }
                foreach (Producto producto in Productos)
                {
                    Console.WriteLine($"- {producto.Nombre}: ${producto.Precio:F2}");
                }
            }
            public decimal calcularTotal()
            {
                decimal total = 0;
                foreach (Producto producto in Productos)
                {
                    total = +producto.Precio;
                }
                return total;
            }

        }
        #endregion

        #region Nivel 7: Excepciones, genéricos y delegates y LINQ

        public static void Imprimir<T>(T dato)
        {
            Console.WriteLine($"Tipo: {typeof(T).Name} | Valor: {dato}");
        }
        public static void PrueDeGenericos()
        {
            Imprimir(10);
            Imprimir("Hola");
            Imprimir(true);
            Imprimir(new Persona("Carlos", 30));

        }
        public class Caja<T>
        {
            public List<T> caja = new List<T>();
            public void Guardar(T dato)
            {
                caja.Add(dato);
            }
            public List<T> Obtener()
            {
                return caja.ToList();

            }
        }
        public static void PruebaClaseGenerica()
        {
            Caja<int> caja = new Caja<int>();
            caja.Guardar(1);
            caja.Guardar(2);
            caja.Guardar(3);
            caja.Guardar(4);
            caja.Guardar(5);
            caja.Guardar(6);
            caja.Guardar(7);
            caja.Guardar(8);
            var resultado = caja.Obtener();

            foreach (var i in resultado)
            {
                Console.WriteLine(i);
            }


        }
        delegate int Operacion(int a, int b);
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static bool EsPar(int a)
        {
            return (a % 2 == 0);
        }
        public static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola triple hijoputa {nombre}");
        }
        public static void PruebaDelegados()
        {
            Operacion operacion = Sumar;
            operacion = Multiplicar;
            var resultado = operacion(5, 5);
            Console.WriteLine(resultado);

            //funcion generica de delegados que retorna un valor
            Func<int, int, int> op = Multiplicar;
            Console.WriteLine(op(5, 5));

            //accion generica de delegados que no retorna nada
            Action<string> s = Saludar;
            s("rafael");

            Predicate<int> pred = EsPar;

            Console.WriteLine(pred(5));

        }
        #endregion

        #region Nivel 8: LINQ

        public static void PruebasDeLambda()
        {
            //List<int> list = new List<int>();
            List<int> list = [10, 15, 20, 35, 40];
            var result = list.Where(x => x % 2 == 0);

            foreach (int x in result)
            {
                Console.WriteLine($"{x}");
            }

        }

        public static void MetodoSelect()
        {
            List<int> numeros = [1, 2, 3, 4, 5];
            var res = numeros.Select(x => x * 10);

            foreach (int x in res)
            {
                Console.WriteLine(x);
            }

        }
        public static void MetodoWhere()
        {
            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 15),
                new Persona("Maria", 28)
            ];
            var res = personas.Where(x => x.Edad >= 18);
            foreach (Persona persona in res)
            {
                Console.WriteLine($"{persona.Nombre} con {persona.Edad} años");
            }

        }
        public static void MetodoSelectConObjetos()
        {
            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 15),
                new Persona("Maria", 28)
            ];
            var res = personas.Where(x => x.Edad >= 18).Select(x => x.Nombre);
            foreach (string persona in res)
            {
                Console.WriteLine(persona);
            }

        }
        public static void MetodoOrderBy()
        {
            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 15),
                new Persona("Maria", 28)
            ];
            var res = personas.OrderBy(x => x.Edad).Where(x => x.Edad >= 18).Select(x => $"{x.Nombre} - {x.Edad}");
            foreach (string persona in res)
            {
                Console.WriteLine(persona);
            }

        }

        public static void MetodoOrderByDescending()
        {

            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 15),
                new Persona("Maria", 28)
            ];
            var result = personas
                .Where(x => x.Edad >= 18)
                .OrderByDescending(x => x.Edad)
                .Select(x => $"{x.Nombre} - {x.Edad}");
            foreach (string persona in result)
            {
                Console.WriteLine($"{persona}");

            }

        }
        public static void MetodoThenBy()
        {
            List<Persona> personas =
            [
                new Persona("bald", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("bol", 24),
                new Persona("Maria", 30),
                new Persona("Pedro", 17)
            ];
            var res = personas
                .Where(x => x.Edad >= 18)
                .OrderBy(x => x.Edad)
                .ThenBy(x => x.Nombre)
                .Select(x => $"{x.Nombre} - {x.Edad}");
            foreach (string persona in res)
            {
                Console.WriteLine(persona);
            }
        }

        public static void MetodosFirstYFirstorDefault()
        {
            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 24),
                new Persona("Maria", 30)
            ];

            //Metodo First devuelve el primer objeto que encuentre, si no encuentra lanzara excepcion 
            var res = personas.First(x => x.Edad >= 18);
            //Metodo FirstOrDefault devuelve el primer objeto que encuentre, si no encuentra Devolvera NULL 
            var res2 = personas.FirstOrDefault(x => x.Edad >= 108);
            Console.WriteLine(res2);

        }
        public static void MetodosAnyAllCount()
        {
            List<Persona> personas =
            [
                new Persona("Rafael", 24),
                new Persona("Carlos", 17),
                new Persona("Ana", 30),
                new Persona("Luis", 24),
                new Persona("Maria", 30)
            ];
            //el metodo Any Devuelve un Bool si en una lista determinada existe algun objeto que cumpla con la Condicion Determinada
            var res = personas.Any(x => x.Edad >= 25);
            Console.WriteLine("¿Existe alguna persona mayor de 25 años?");
            Console.WriteLine(res);

            //el metodo All Devuelve un Bool si en una lista determinada SI Todos los objeto que cumplen con la Condicion Determinada
            var res2 = personas.All(x => x.Edad >= 18);
            Console.WriteLine("¿Todas las personas son mayores de 18?");
            Console.WriteLine(res2);

            //el metodo Count Cuenta Todos los objeto que cumplen con la Condicion Determinada y te devuelve Cuantos fueron
            var res3 = personas.Count(x => x.Edad >= 18);
            Console.WriteLine("¿Cuántas personas son mayores de 18?");
            Console.WriteLine(res3);

        }
        public class Empleado2
        {
            public string Nombre { get; set; }
            public string Departamento { get; set; }
            public decimal Salario { get; set; }

            public Empleado2(string nombre, string departamento, decimal salario)
            {
                Nombre = nombre;
                Departamento = departamento;
                Salario = salario;
            }
        }
        public static void ElEmpleadoMasGrandeLINQ()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000)
            ];
            var res = empleados.Where(x => x.Departamento == "TI").OrderByDescending(x => x.Salario).First();
            Console.WriteLine($"El empleado de {res.Departamento} con el salario más alto es {res.Nombre} ganando {res.Salario}");

        }
        public static void ElSegundoEmpleadoMasGrandeLINQ()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000),
            ];
            var res = empleados.OrderByDescending(x => x.Salario).Skip(1).First();
            Console.WriteLine($"El empleado de {res.Departamento} con el segundo salario más alto es {res.Nombre} ganando {res.Salario}");

        }
        public static void MetodoDistinc()
        {
            List<int> salarios =
            [
                25000,
                32000,
                28000,
                32000,
                25000,
                50000,
                28000
            ];
            var res = salarios.Distinct().OrderByDescending(x => x).ToList();
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }


        }
        public static void MetodoGroupBy()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000),
            ];
            var grupos = empleados.GroupBy(x => x.Departamento);
            foreach (var f in grupos)
            {
                Console.WriteLine($"{f.Key}: {f.Count()}");
            }

        }
        public static void MetodoGroupByYSUM()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000),
            ];
            var grupos = empleados.GroupBy(x => x.Departamento);
            foreach (var f in grupos)
            {

                Console.WriteLine($"Departamento{f.Key}: con {f.Count()} empleados ganan en total el departamento {f.Sum(x => x.Salario)}");
            }

        }
        public static void MetodoGroupByYSUMYFirst()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000),
            ];

            var res = empleados.GroupBy(x => x.Departamento)
                .Select(x => new
                {
                    Departamento = x.Key,
                    Total = x.Sum(x => x.Salario),
                })
                .OrderByDescending(x => x.Total)
                .First();
            Console.WriteLine($"{res.Departamento} - {res.Total}");
        }

        public static void MinMaxAverageMetod()
        {
            List<Empleado2> empleados =
            [
                new Empleado2("Rafael", "TI", 25000),
                new Empleado2("Carlos", "Ventas", 18000),
                new Empleado2("Ana", "TI", 32000),
                new Empleado2("Luis", "RH", 21000),
                new Empleado2("Maria", "TI", 28000),
                new Empleado2("Pedro", "Ventas", 15000),
                new Empleado2("Juan", "RH", 50000),
            ];
            var mayor = empleados.Max(x => x.Salario);
            var menor = empleados.Min(x => x.Salario);
            var promedio = empleados.Average(x => x.Salario);

            Console.WriteLine($"{mayor} - {menor} - {promedio}");


        }
        public class Producto2
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }

            public Producto2(string nombre, string categoria, decimal precio, int stock)
            {
                Nombre = nombre;
                Categoria = categoria;
                Precio = precio;
                Stock = stock;
            }
        }
        public static void LINQyLogicaNegocio()
        {
            List<Producto2> productos =
            [
                new Producto2("Laptop", "Tecnologia", 25000, 5),
                new Producto2("Mouse", "Tecnologia", 500, 20),
                new Producto2("Teclado", "Tecnologia", 1200, 10),
                new Producto2("Monitor", "Tecnologia", 8000, 3),
                new Producto2("Silla", "Muebles", 4500, 8),
                new Producto2("Escritorio", "Muebles", 7000, 4),
                new Producto2("Lampara", "Muebles", 1500, 15),
            ];
            //var categorias=productos.GroupBy(x=>x.Categoria);
            var res = productos.GroupBy(x => x.Categoria)
                .Select(x =>
                new
                {
                    Categoria = x.Key,
                    Total = x.Sum(x => (x.Stock * x.Precio)),
                })
                .OrderByDescending(x => x.Total)
                .First();
            Console.WriteLine(res);

        }

        public static void LINQEntrevista()
        {
            List<Producto2> productos =
            [
                new Producto2("Laptop", "Tecnologia", 25000, 5),
                new Producto2("Mouse", "Tecnologia", 500, 20),
                new Producto2("Teclado", "Tecnologia", 1200, 10),
                new Producto2("Monitor", "Tecnologia", 8000, 3),
                new Producto2("Silla", "Muebles", 4500, 8),
                new Producto2("Escritorio", "Muebles", 7000, 4),
                new Producto2("Lampara", "Muebles", 1500, 15),
            ];
            var caros = productos.Where(x => x.Precio >= 5000);
            var res = caros.GroupBy(x => x.Categoria).Select(x => new { Categoria = x.Key, Cantidad = x.Count() }).OrderByDescending(x => x.Cantidad).First();
            Console.WriteLine(res);
        }

        public static void LINQMasCaroDisponible()
        {
            List<Producto2> productos =
            [
                new Producto2("Laptop", "Tecnologia", 25000, 5),
                new Producto2("Mouse", "Tecnologia", 500, 20),
                new Producto2("Teclado", "Tecnologia", 1200, 10),
                new Producto2("Monitor", "Tecnologia", 8000, 0),

                new Producto2("Silla", "Muebles", 4500, 8),
                new Producto2("Escritorio", "Muebles", 7000, 4),
                new Producto2("Lampara", "Muebles", 1500, 15),

                new Producto2("Telefono", "Tecnologia", 12000, 0),
            ];
            var res = productos.Where(x => x.Stock > 0).OrderByDescending(x => x.Precio).FirstOrDefault();

            if (res != null)
            {
                Console.WriteLine(res.Nombre + res.Precio);

            }
            else
            {
                Console.WriteLine("no hay disponibilidad");
            }


        }
        #endregion

        #region Nivel 8.2: yield return

        public static IEnumerable<int> ObtenerPares()
        {
            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }

        }
        public static void PruebasYild()
        {
            foreach (var numero in ObtenerPares())
            {
                Console.WriteLine(numero);
            }
        }
        public static IEnumerable<int> ObtenerNumerosHasta(int limite)
        {
            for (int i = 1; i <= limite; i++)
            {
                yield return i;
            }

        }
        public static void PruebaYieldHastaNumeroDefinido()
        {
            foreach (var numero in ObtenerNumerosHasta(5))
            {
                Console.WriteLine(numero);
            }

        }









        #endregion

        #region Nivel 8.3: LINQ JOIN & GROUPBY

        public static void GroupBySelectLINQ()
        {
            List<Empleado2> empleados =
            [
                new("Rafael", "TI", 25000),
                new("Carlos", "Ventas", 18000),
                new("Ana", "TI", 32000),
                new("Luis", "RH", 21000),
                new("Maria", "TI", 28000),
                new("Pedro", "Ventas", 15000),
                new("Juan", "RH", 50000)
            ];
            var res = empleados
                .GroupBy(x => x.Departamento).Select(x => new
                {
                    Departamento = x.Key,
                    Promedio = x.Average(x => x.Salario),
                })
                .OrderByDescending(x => x.Promedio)
                .ToList();

            foreach (var numero in res)
            {
                Console.WriteLine(numero);
            }

        }
        public static void DepartamentoConEmpleadosRicosLINQ()
        {
            List<Empleado2> empleados =
            [
                new("Rafael", "TI", 25000),
                new("Carlos", "Ventas", 18000),
                new("Ana", "TI", 32000),
                new("Luis", "RH", 21000),
                new("Maria", "TI", 28000),
                new("Pedro", "Ventas", 15000),
                new("Juan", "RH", 50000)
            ];
            var res = empleados
                .Where(x => x.Salario >= 20000)
                .GroupBy(x => x.Departamento)
                .Select(x => new
                {
                    Departamento = x.Key,
                    NumeroEmpleados = x.Count(),
                })
                .OrderByDescending(x => x.NumeroEmpleados)
                .First();
            Console.WriteLine(res);
        }

        #endregion

        #region Nivel 8.5: LINQ Avanzado
        //public class Empleado
        //{
        //    public int Id { get; set; }
        //    public string Nombre { get; set; }
        //    public string Departamento { get; set; }
        //    public decimal Salario { get; set; }
        //    public string Puesto { get; set; }

        //}
        //public static void LinqAvanzado()
        //{
        //    List<Empleado> empleados =
        //    [
        //        new() { Id = 1, Nombre = "Rafael", Departamento = "TI", Salario = 25000 },
        //        new() { Id = 2, Nombre = "Ana", Departamento = "TI", Salario = 32000 },
        //        new() { Id = 3, Nombre = "Carlos", Departamento = "Ventas", Salario = 18000 },
        //        new() { Id = 4, Nombre = "Luis", Departamento = "RH", Salario = 21000 },
        //        new() { Id = 5, Nombre = "Maria", Departamento = "Ventas", Salario = 28000 }
        //    ];
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    //El metodo where devulve todos aquellos objetos de una lista que cumplan con una determinada condicion
        //    var mayora25k = empleados.Where(x => x.Salario >= 25000);
        //    Console.WriteLine("Empleados con sueldo mayor a 25,000");
        //    foreach (var em in mayora25k)
        //    {
        //        Console.WriteLine(em.Nombre);
        //    }

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");


        //    Console.WriteLine("Metodo select devuelve los nombres");
        //    //El metodo Select devulve la informacion seleeccionada de una lista
        //    var nombresDeEmpleados = empleados.Select(x => x.Nombre).ToList();
        //    foreach (var n in nombresDeEmpleados)
        //    {
        //        Console.WriteLine(n);

        //    }
        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    Console.WriteLine("Obtener los nombres de los empleados de TI que ganan más de $25,000.");

        //    var nombresDeTiGananMas = empleados
        //        .Where(x => x.Departamento == "TI" && x.Salario >= 25000)
        //        .Select(x => x.Nombre);

        //    foreach (var n in nombresDeTiGananMas)
        //    {
        //        Console.WriteLine(n);
        //    }
        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    Console.WriteLine("Obtener todos los empleados ordenados por salario de mayor a menor.");

        //    //el metodo order by ordena los objetos dependiendo de la condicion o propiedad determinada (x=>x.Salario)
        //    var salarioOrdenado = empleados.OrderByDescending(x => x.Salario)
        //        .Select(x => $"{x.Nombre} - {x.Salario} ");
        //    foreach (var n in salarioOrdenado)
        //    {
        //        Console.WriteLine(n);
        //    }

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    Console.WriteLine("Ordenar primero por departamento alfabéticamente y dentro de cada departamento ordenar por salario de mayor a menor.");
        //    var ejercicio5 = empleados.OrderBy(x => x.Departamento).ThenByDescending(x => x.Salario);
        //    foreach(var n in ejercicio5)
        //    {
        //        Console.WriteLine($"{n.Departamento} - {n.Nombre} - {n.Salario}");

        //    }

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");


        //    Console.WriteLine("Obtener el empleado con el salario más alto.");
        //    var ejercio6=empleados.OrderByDescending(x=>x.Salario).FirstOrDefault();
        //    Console.WriteLine(ejercio6.Nombre);

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");


        //    //var ejerciocio5 = empleados
        //    //    .GroupBy(x => x.Departamento)
        //    //    .OrderBy(x => x.Key)
        //    //    .ThenByDescending(x => x.Select(x => x.Salario)).Select(x => new
        //    //    {
        //    //        Departamento = x.Key,
        //    //        Nombre=x.Select(x=>x.Nombre),
        //    //        salario=x.Select(x=>$"{x.Salario}"),

        //    //    });
        //    //    //.ThenBy(x=>x.Salario)
        //    //    //.Select(x=>$"{x.Nombre} - {x.Salario}");
        //    //foreach(var n in ejerciocio5) { Console.WriteLine(n); }




        //}

        //public static void LinqFirstSingle()
        //{
        //    List<Empleado> empleados =
        //    [
        //        new() { Id = 1, Nombre = "Rafael", Departamento = "TI", Salario = 25000 },
        //        new() { Id = 2, Nombre = "Ana", Departamento = "TI", Salario = 32000 },
        //        new() { Id = 3, Nombre = "Carlos", Departamento = "Ventas", Salario = 18000 },
        //        new() { Id = 4, Nombre = "Luis", Departamento = "RH", Salario = 21000 },
        //        new() { Id = 5, Nombre = "Maria", Departamento = "Ventas", Salario = 28000 }
        //    ];
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    //el metodo first trae el primer objeto, si no encuentra lanzara una excepcion
        //    var primero=empleados.First();
        //    Console.WriteLine("El primer empleado de una lista");
        //    Console.WriteLine(primero.Nombre);

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    //el metodo FirstOrDefault trae el primer objeto, si no encuentra sera null
        //    var ejer8 = empleados.FirstOrDefault(x => x.Departamento == "TI");
        //    Console.WriteLine("El primer empledo que su departamento sea ti");
        //    Console.WriteLine($"{ejer8?.Nombre}");

        //    Console.WriteLine("");
        //    Console.WriteLine("============================================================");
        //    Console.WriteLine("");

        //    var ejer9=empleados.FirstOrDefault(x=>x.Id== 99);
        //    Console.WriteLine("Buscar un empleado cuyo Id sea 99.");

        //    if (ejer9!=null)
        //    {
        //        Console.WriteLine($"el empleado es {ejer9.Nombre} con el id {ejer9.Id}");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"No existe empledo con el id 99");

        //    }

        //    var res = empleados.SingleOrDefault(x => x.Id == 1);
        //    Console.WriteLine(res.Nombre);






        //}

        #endregion

        #region Nivel 8.6 — LINQ avanzado REAL

        //public static void ReporteDepartamentos()
        //{
        //    List<Empleado> empleados =
        //    [
        //        new() { Id = 1, Nombre = "Rafael", Departamento = "TI", Salario = 25000 },
        //        new() { Id = 2, Nombre = "Ana", Departamento = "TI", Salario = 32000 },
        //        new() { Id = 3, Nombre = "Carlos", Departamento = "Ventas", Salario = 18000 },
        //        new() { Id = 4, Nombre = "Luis", Departamento = "RH", Salario = 21000 },
        //        new() { Id = 5, Nombre = "Maria", Departamento = "Ventas", Salario = 28000 },
        //        new() { Id = 6, Nombre = "Pedro", Departamento = "TI", Salario = 40000 },
        //        new() { Id = 7, Nombre = "Laura", Departamento = "RH", Salario = 35000 },
        //        new() { Id = 8, Nombre = "Jorge", Departamento = "Ventas", Salario = 22000 }
        //    ];
        //    var res = empleados
        //        .GroupBy(x => x.Departamento)
        //        .Where(x=>x.Average(x=>x.Salario)>=25000)
        //        .Select(x => new
        //        {
        //            Departamento = x.Key,
        //            CantidadEmpleados=x.Count(),
        //            SalarioPromedio=x.Average(x=>x.Salario),
        //            EmpleadoMayorSalario=x.OrderByDescending(x=>x.Salario).Select(x=>$"{x.Nombre} con {x.Salario}").FirstOrDefault(),

        //        })
        //        ;
        //    foreach(var x in res)
        //    {
        //        Console.WriteLine(x);
        //    }

        //}
        //public static void ReporteProblemasSalariales()
        //{
        //    List<Empleado> empleados =
        //    [
        //        new() { Id = 1, Nombre = "Rafael", Departamento = "TI", Salario = 25000 },
        //        new() { Id = 2, Nombre = "Ana", Departamento = "TI", Salario = 32000 },
        //        new() { Id = 6, Nombre = "Pedro", Departamento = "TI", Salario = 40000 },

        //        new() { Id = 3, Nombre = "Carlos", Departamento = "Ventas", Salario = 18000 },
        //        new() { Id = 5, Nombre = "Maria", Departamento = "Ventas", Salario = 28000 },
        //        new() { Id = 8, Nombre = "Jorge", Departamento = "Ventas", Salario = 22000 },
                
        //        new() { Id = 4, Nombre = "Luis", Departamento = "RH", Salario = 21000 },
        //        new() { Id = 7, Nombre = "Laura", Departamento = "RH", Salario = 35000 },
        //    ];

        //    var res = empleados
        //        .GroupBy(x => x.Departamento)
        //        .Where(x => 
        //            x.Count() >= 3 && 
        //            x.Average(x => x.Salario) > 25000 && 
        //            x.Any(x => x.Salario > 35000)
        //        )
        //        .Select(x => new
        //        {
        //            Departamento=x.Key,
        //            CantidadEmpleados=x.Count(),
        //            SalarioPromedio=x.Average(x=>x.Salario),
        //            EmpleadoMasRico=x.OrderByDescending(x=>x.Salario).Select(x=>x.Nombre).FirstOrDefault(),
        //            CantidadEmpleadosRicos=x.Count(x=>x.Salario>30000),
        //        });
        //    foreach(var item in res)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

        //public static void ReporteDepartamentosSalariales()
        //{
        //    List<Empleado> empleados =
        //    [
        //        new() { Id = 1, Nombre = "Rafael", Departamento = "TI", Puesto = "Junior", Salario = 22000 },
        //        new() { Id = 2, Nombre = "Ana", Departamento = "TI", Puesto = "Senior", Salario = 38000 },
        //        new() { Id = 3, Nombre = "Pedro", Departamento = "TI", Puesto = "Senior", Salario = 45000 },
        //        new() { Id = 4, Nombre = "Laura", Departamento = "TI", Puesto = "Junior", Salario = 24000 },

        //        new() { Id = 5, Nombre = "Carlos", Departamento = "Ventas", Puesto = "Junior", Salario = 18000 },
        //        new() { Id = 6, Nombre = "Maria", Departamento = "Ventas", Puesto = "Senior", Salario = 32000 },
        //        new() { Id = 7, Nombre = "Jorge", Departamento = "Ventas", Puesto = "Senior", Salario = 35000 },

        //        new() { Id = 8, Nombre = "Luis", Departamento = "RH", Puesto = "Junior", Salario = 21000 },
        //        new() { Id = 9, Nombre = "Sofia", Departamento = "RH", Puesto = "Senior", Salario = 36000 },
        //    ];
        //    var res = empleados
        //    .GroupBy(x => x.Departamento)
        //    .SelectMany(departamento =>
        //        departamento
        //            .GroupBy(x => x.Puesto)
        //            .Where(x=>
        //                x.Count()>=2 && 
        //                x.Average(x=>x.Salario)>25000 &&
        //                x.Any(x=>x.Salario>40000)
        //            )
        //            .Select(puesto => new
        //            {
        //                Departamento = departamento.Key,
        //                Puesto = puesto.Key,
        //                CantidadEmpleados = puesto.Count(),
        //                SalarioPromedio = puesto.Average(x=>x.Salario),
        //                EmpleadoMayorSalario = puesto.OrderByDescending(x=>x.Salario).Select(x=>x.Nombre).FirstOrDefault(),
        //                SalarioMayor = puesto.OrderByDescending(x => x.Salario).Select(x => x.Salario).FirstOrDefault(),
        //            }));

        //    foreach (var x in res)
        //    {
        //        Console.WriteLine(x);
        //    }
            
        //}


        #endregion

        #region Nivel 9:Asincronía y concurrencia.
        public class Producto3
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Stock { get; set; }
            public byte[] RowVersion { get; set; }
        }

        //public async Task<bool> ComprarProducto(
        //    int productoId,
        //    int cantidad
        //)
        //{
        //    var producto =db.productos.Where(x=>x.Id == productoId).FirstOrDefault();
        //    await using var transaction =
        //        await db.Database.BeginTransactionAsync();


        //    if (producto != null)
        //    {
        //        try
        //        {
        //            db.Ventas.Add(venta);

        //            db.productos.


        //        }
        //        catch (Exception ex)
        //        {

        //        }


        //    }

        //}
        //private static Dictionary<string, string> pagosProcesados = new();
        //public async Task<string> ProcesarPago(
        //   string idempotencyKey,
        //   decimal monto
        //)
        //{
        //    if (!pagosProcesados.ContainsKey(idempotencyKey))
        //    {
        //        // procesar
        //        pagosProcesados.Add(idempotencyKey, "pagada");
        //        return "pagada";

        //    }
        //    else if (pagosProcesados.ContainsKey(idempotencyKey))
        //    {
        //        return "pagada";

        //    }

        //}
        //private static readonly ConcurrentDictionary<string, string> pagosProcesados = new();

        //public async Task<string> ProcesarPago(
        //    string idempotencyKey,
        //    decimal monto)
        //{
        //    var pago= pagosProcesados.TryGetValue(idempotencyKey, "procesando");

        //    if (pago != null)
        //    {
        //        return "procesando";
        //    }

        //    if (pagosProcesados.TryAdd(idempotencyKey, "procesando"))
        //    {
        //        // Solo una solicitud consigue entrar aquí
        //        var res = _pagos.add(pago);//procesa pago
        //        if (res == "pagada")
        //        {
        //            pagosProcesados.TryGetValue(idempotencyKey, "procesando");
        //            pagosProcesados.TryUpdate(idempotencyKey, res);
        //            return res;

        //        }
        //        else if (res == "fallida")
        //        {
        //            pagosProcesados.TryGetValue(idempotencyKey, "procesando");
        //            pagosProcesados.TryUpdate(idempotencyKey, res);
        //            return res;
        //        }
        //    }


        //}

        #endregion

        #region nivel 9.1: LINQ, join groupjoin
        public class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int DepartamentoId { get; set; }
            public decimal Salario { get; set; }
        }

        public class Departamento
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        public class Proyecto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Presupuesto { get; set; }
        }

        public class Asignacion
        {
            public int EmpleadoId { get; set; }
            public int ProyectoId { get; set; }
        }
        public static void LINQGroupJoin()
        {
            List<Departamento> departamentos =
            [
                new() { Id = 1, Nombre = "TI" },
                new() { Id = 2, Nombre = "Ventas" },
                new() { Id = 3, Nombre = "RH" },
                new() { Id = 4, Nombre = "Finanzas" }
            ];

            List<Empleado> empleados =
            [
                new() { Id = 1, Nombre = "Rafael", DepartamentoId = 1, Salario = 30000 },
                new() { Id = 2, Nombre = "Ana", DepartamentoId = 1, Salario = 42000 },
                new() { Id = 3, Nombre = "Pedro", DepartamentoId = 1, Salario = 45000 },

                new() { Id = 4, Nombre = "Carlos", DepartamentoId = 2, Salario = 22000 },
                new() { Id = 5, Nombre = "Maria", DepartamentoId = 2, Salario = 35000 },

                new() { Id = 6, Nombre = "Laura", DepartamentoId = 3, Salario = 28000 }
            ];
            var res = departamentos
                .GroupJoin(
                empleados,
                departamento => departamento.Id,
                empleado => empleado.DepartamentoId,
                (departamentos, empleados) => new
                {
                    Departamento = departamentos.Nombre,
                    CantidadEmpleados = empleados?.Count(),
                    SalarioPromedio = empleados.Any()
                        ? empleados.Average(x => x.Salario)
                        : 0,

                    EmpleadoMejorPagado = empleados?.OrderByDescending(x=>x.Salario).Select(x=>x.Nombre).FirstOrDefault(),


                }
                );
            foreach( var item in res)
            {
                Console.WriteLine( item );
            }


        }

        public static void LinqJoinGroupJoin()
        {
            List<Departamento> departamentos =
            [
                new() { Id = 1, Nombre = "TI" },
                new() { Id = 2, Nombre = "Ventas" },
                new() { Id = 3, Nombre = "RH" },
                new() { Id = 4, Nombre = "Finanzas" }
            ];

            List<Empleado> empleados =
            [
                new() { Id = 1, Nombre = "Rafael", DepartamentoId = 1, Salario = 30000 },
                new() { Id = 2, Nombre = "Ana", DepartamentoId = 1, Salario = 42000 },
                new() { Id = 3, Nombre = "Pedro", DepartamentoId = 1, Salario = 45000 },

                new() { Id = 4, Nombre = "Carlos", DepartamentoId = 2, Salario = 22000 },
                new() { Id = 5, Nombre = "Maria", DepartamentoId = 2, Salario = 35000 },

                new() { Id = 6, Nombre = "Laura", DepartamentoId = 3, Salario = 28000 }
            ];

            List<Proyecto> proyectos =
            [
                new() { Id = 1, Nombre = "Migración ERP", Presupuesto = 500000 },
                new() { Id = 2, Nombre = "App móvil", Presupuesto = 250000 },
                new() { Id = 3, Nombre = "Portal Web", Presupuesto = 150000 },
            ];

            List<Asignacion> asignaciones =
            [
                new() { EmpleadoId = 1, ProyectoId = 1 },
                new() { EmpleadoId = 1, ProyectoId = 2 },

                new() { EmpleadoId = 2, ProyectoId = 1 },
                new() { EmpleadoId = 2, ProyectoId = 3 },

                new() { EmpleadoId = 3, ProyectoId = 3 },

                new() { EmpleadoId = 4, ProyectoId = 1 },
                new() { EmpleadoId = 4, ProyectoId = 3 },

            ];

            var resultado = departamentos.GroupJoin(
                empleados,
                departamento => departamento.Id,
                empleado => empleado.DepartamentoId,
                (departamento, empleadosDepartamento) => new
                {
                    Departamento = departamento.Nombre,
                    Empleados = empleadosDepartamento
                }
            );
            //foreach (var i in resultado)
            //{
            //    Console.WriteLine(i);
            //}


            var res = departamentos
              .GroupJoin(
                  empleados,    //"Por cada departamento, busca todos los empleados que pertenezcan a ese departamento."
                  departamento => departamento.Id,  //Se esta relaciconando por el id del departamento
                  empleado => empleado.DepartamentoId,  //Se esta relaciconando por el id del departamento
                  (departamento,                        //El primer parámetro siempre es solo un objeto
                  empleadosDepartamento)                //el segundo parametro es una coleeccion, en este caso de empleados del departamento
                  => new
                  {
                      Departamento = departamento.Nombre,


                      Asignaciones = empleadosDepartamento.GroupJoin(
                          asignaciones,
                          empleado => empleado.Id,
                          asignacion => asignacion.EmpleadoId,
                          (empleado, asignacionesEmpleado) => new
                          {
                              Empleado = empleado.Nombre,

                              Asignaciones = asignacionesEmpleado.Count()
                          }
                      )
                  });
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}
            var resu = departamentos
             .GroupJoin(
                 empleados,
                 d => d.Id,
                 e => e.DepartamentoId,
                 (d, empleadosDepartamento) => new
                 {
                     Departamento = d,
                     Empleados = empleadosDepartamento
                 }
             )
             .SelectMany(
                 x => x.Empleados,
                 (x, empleado) => new
                 {
                     Departamento = x.Departamento,
                     Empleado = empleado
                 }
             )
             .GroupJoin(
                 asignaciones,
                 x => x.Empleado.Id,
                 a => a.EmpleadoId,
                 (x, asignacionesEmpleado) => new
                 {
                     x.Departamento,
                     x.Empleado,
                     Asignaciones = asignacionesEmpleado
                 }
             )
             .SelectMany(
                 x => x.Asignaciones,
                 (x, asignacion) => new
                 {
                     Departamento = x.Departamento.Nombre,
                     Empleado = x.Empleado.Nombre,
                     ProyectoId = asignacion.ProyectoId
                 }
             )
             .GroupJoin(
                 proyectos,
                 a => a.ProyectoId,
                 p => p.Id,
                 (a, proyectos) => new
                 {
                     Asignacion = a,
                     Proyectos = proyectos
                 }
             )
             .SelectMany(
                 x => x.Proyectos,
                 (x, proyecto) => new
                 {
                     Departamento = x.Asignacion.Departamento,
                     Empleado = x.Asignacion.Empleado,
                     ProyectoId = x.Asignacion.ProyectoId,
                     Proyecto = proyecto.Nombre,
                     Presupuesto = proyecto.Presupuesto
                 }
             );

            //foreach (var item in resu)
            //{
            //    Console.WriteLine(
            //        $"{item.Departamento} | " +
            //        $"{item.Empleado} | " +
            //        $"{item.ProyectoId} | " +
            //        $"{item.Proyecto} | " +
            //        $"{item.Presupuesto}"
            //    );
            //}
            //foreach ( var item in resu)
            //{
            //    Console.WriteLine( item );
            //}

            var result = departamentos
                .GroupJoin(
                    empleados,
                    d => d.Id,
                    e => e.DepartamentoId,
                    (departamento, empleadosDepartamento) => new
                    {
                        Departamento = departamento,
                        Empleados = empleadosDepartamento,
                    }
                )
                .SelectMany(
                    x => x.Empleados,
                    (x, empleado) => new
                    {
                        Departamento = x.Departamento,
                        Empleado = empleado

                    }

                )
                .GroupJoin(
                    asignaciones,
                    x => x.Empleado.Id,
                    a => a.EmpleadoId,
                    (x, empleadoAsignaciones) => new
                    {

                        x.Departamento,
                        x.Empleado,
                        Asignaciones = empleadoAsignaciones,

                    }

                )
                .SelectMany(
                    x => x.Asignaciones,
                    (x, asignacion) => new
                    {
                        Departamento = x.Departamento,
                        //Empleado = x.Empleado.Nombre,
                        ProyectoId = asignacion.ProyectoId

                    }
                )
                .GroupJoin(
                    proyectos,
                    x => x.ProyectoId,
                    p => p.Id,
                    (x, proyectos) => new
                    {
                        x.Departamento.Nombre,
                        //x.Empleado,
                        //CantidadProyectos = proyectos.Count(),
                        Proyectos = proyectos
                    }
                )
                .SelectMany(
                    x => x.Proyectos,
                    (x, proyectos) => new
                    {
                        Departamento = x.Nombre,
                        //x.Empleado,
                        //x.CantidadProyectos,
                        nombreproyecto = proyectos.Nombre

                    }
                )
                .Distinct()
                .GroupBy(x => x.Departamento)
            //.SelectMany(
            //    x => x.
            //);
            .Select(x => new
            {
                Departamento = x.Key,
                CantidadProyectos = x.Count(),
                Proyectos = x.Select(p => p.nombreproyecto)


            });
            foreach ( var item in result)
            {
                Console.WriteLine(
       $"{item.Departamento} - {item.CantidadProyectos}"
   );
                foreach (var proyecto in item.Proyectos)
                {
                    Console.WriteLine($"   {proyecto}");
                }

            }

        }
        #endregion


        #region Nivel 10: CQRS
        public class CrearEmpleadoCommand
        {
            // ¿qué propiedades necesita?
            public string Nombre { get; set; }
            public string Departamento { get; set; }
            public decimal Salario { get; set; }
        }
        //public async Task<int> Handle(CrearEmpleadoCommand command)
        //{
        //    var nombre = command.Nombre;
        //    var departamento = command.Departamento;
        //    var exist = await db.Empleados
        //            .AnyAsync(x =>
        //                x.Departamento == command.Departamento &&
        //                x.Nombre == command.Nombre);
        //    if (exist)
        //    {
        //        return 0;
        //    }
        //    else 
        //    {

        //        var empleado = new Empleado2
        //        {
        //            Nombre = command.Nombre,
        //            Departamento = command.Departamento,
        //            Salario = command.Salario,

        //        };
        //        db.Empleados.Add(empleado);

        //        await db.SaveChangesAsync();
        //        return empleado.Id;
        //    }

        //}
        public interface IEmpleadoRepository
        {
            Task<bool> ExisteAsync(string nombre, string departamento);

            Task<int> CrearAsync(Empleado2 empleado);
        }
        public class CrearEmpleadoHandler
        {
            private readonly IEmpleadoRepository repository;

            public CrearEmpleadoHandler(IEmpleadoRepository repository)
            {
                this.repository = repository;
            }

            public async Task<int> Handle(CrearEmpleadoCommand command)
            {
                // aquí ya NO existe db
                var nombre = command.Nombre;
                var departamento = command.Departamento;
                var exist = await repository.ExisteAsync(nombre, departamento);
                if (exist)
                {
                    return 0;
                }
                else
                {


                    var empleado = new Empleado2
                    (
                        command.Nombre, command.Departamento, command.Salario

                    );
                     var id=await repository.CrearAsync(empleado);
                    return id;
                }
            }
        }
        public class InMemoryEmpleadoRepository : IEmpleadoRepository
        {
            private readonly List<Empleado2> empleados = new();

            public async Task<bool> ExisteAsync(
                string nombre,
                string departamento)
            {
                var res= empleados.Where(x=>x.Departamento==departamento&& x.Nombre==nombre).Any();
                if (res)
                {
                    return true;
                }
                return false;
                
            }

            public async Task<int> CrearAsync(Empleado2 empleado)
            {
                var nombre=empleado.Nombre;
                var dep=empleado.Departamento;
                var exist=await ExisteAsync(nombre, dep);
                if (exist)
                {
                    return 0;
                }
                else
                {

                    var empleado3 = new Empleado2
                     (
                         empleado.Nombre, empleado.Departamento, empleado.Salario

                     );
                    empleados.Add(empleado);
                    return 1;
                }

            }
        }


        #endregion

        #region Nivel Middlewares
        //public class ExceptionMiddleware
        //{
        //    private readonly RequestDelegate _next;

        //    public ExceptionMiddleware(RequestDelegate next)
        //    {
        //        _next = next;
        //    }

        //    public async Task InvokeAsync(HttpContext context)
        //    {
        //        try
        //        {
        //            // ¿qué va aquí?
        //            await _next(context);

        //        }
        //        catch (Exception ex)
        //        {
        //            // ¿qué hacemos aquí?
        //            if(ex.Message== "Algo salió mal")
        //            {
        //                var mensaje = new
        //                {
        //                    mensaje = "algo salio mal"
        //                };
        //                return context.Response(500,mensaje);
        //            }
        //        }
        //    }
        //}
        public class ExceptionMiddleware
        {
            private readonly RequestDelegate _next;

            public ExceptionMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task InvokeAsync(HttpContext context)
            {
                try
                {
                    await _next(context);
                }
                catch (EmpleadoNoEncontradoException ex)
                {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    context.Response.ContentType = "application/json";

                    var mensaje = new
                    {
                        mensaje = "No se Encontro el USUARIO"
                    };
                    var json = JsonSerializer.Serialize(mensaje);


                    await context.Response.WriteAsync(json);

                }
                catch (SaldoInsuficienteException ex)
                {
                    context.Response.StatusCode = StatusCodes.Status409Conflict;
                    context.Response.ContentType = "application/json";

                    var mensaje = new
                    {
                        mensaje = "No TIENES suficiente SALDO"
                    };
                    var json = JsonSerializer.Serialize(mensaje);


                    await context.Response.WriteAsync(json);

                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = "application/json";

                    var mensaje = new
                    {
                        mensaje = "Ocurrió un error interno."
                    };
                    var json = JsonSerializer.Serialize(mensaje);


                    await context.Response.WriteAsync(json);
                }
                
            }
        }
        public class EmpleadoNoEncontradoException : Exception
        {
        }
        public class SaldoInsuficienteException : Exception
        {
        }
        public abstract class DomainException : Exception
        {
            public int StatusCode { get; }

            protected DomainException(string message, int statusCode): base(message)
            {
                StatusCode = statusCode;
            }
        }
        public class ProductoNoEncontradoException : DomainException
        {
            public ProductoNoEncontradoException() : base("El producto no existe.", StatusCodes.Status404NotFound)
            {
            }
        }
        #endregion

        #region HackerRank

        //class Result
        //{

        //    /*
        //     * Complete the 'reverseArray' function below.
        //     *
        //     * The function is expected to return an INTEGER_ARRAY.
        //     * The function accepts INTEGER_ARRAY a as parameter.
        //     */

        //    public static List<int> reverseArray(List<int> a)
        //    {
        //        int count = a.Count;
        //        List<int> res = new List<int>();
        //        for (var i = a.Count - 1; i >= 0; i--)
        //        {
        //            Console.WriteLine(a[i]);
        //            res.Add(a[i]);

        //        }
        //        return res;

        //    }

        //}

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //        //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        //        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        //        List<int> arr = [1, 2, 3];

        //        List<int> res = Result.reverseArray(arr);

        //        //textWriter.WriteLine(System.String.Join(" ", res));

        //        //textWriter.Flush();
        //        //textWriter.Close();
        //    }
        //}
        //static int solveMeFirst(int a, int b)
        //{
        //    // Hint: Type return a+b; below  
        //    return a + b;


        //}

        //static void Main(System.String[] args)
        //{
        //    int val1 = Convert.ToInt32(Console.ReadLine());
        //    int val2 = Convert.ToInt32(Console.ReadLine());
        //    int sum = solveMeFirst(val1, val2);
        //    Console.WriteLine(sum);
        //}

        //class Result
        //{

        //    /*
        //     * Complete the 'simpleArraySum' function below.
        //     *
        //     * The function is expected to return an INTEGER.
        //     * The function accepts INTEGER_ARRAY ar as parameter.
        //     */

        //    public static int simpleArraySum(List<int> ar)
        //    {
        //        int sum = 0;
        //        for(int i = 0; i < ar.Count; i++)
        //        {
        //            Console.WriteLine (ar[i]);
        //            sum =sum + ar[i];
        //        }
        //        return sum;

        //    }

        //}

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        string? outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");

        //        TextWriter textWriter = string.IsNullOrEmpty(outputPath)
        //            ? Console.Out
        //            : new StreamWriter(outputPath, true);

        //        //int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        //        //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        //        List<int> ar = [1, 2, 3];

        //        int result = Result.simpleArraySum(ar);

        //        textWriter.WriteLine(result);

        //        textWriter.Flush();
        //        textWriter.Close();
        //    }
        //}

        //class Result
        //{

        //    /*
        //     * Complete the 'compareTriplets' function below.
        //     *
        //     * The function is expected to return an INTEGER_ARRAY.
        //     * The function accepts following parameters:
        //     *  1. INTEGER_ARRAY a
        //     *  2. INTEGER_ARRAY b
        //     */

        //    public static List<int> compareTriplets(List<int> arr1, List<int> arr2)
        //    {
        //        //int coun1 = a.Count;
        //        //int coun2 = b.Count;
        //        List<int> result = new List<int>();
        //        int sum1=0, sum2=0;

        //        for (int i=0;i<= arr1.Count-1; i++)
        //        {
        //            int cal = arr1[i];
        //            //Console.WriteLine($"valor de calificacion a {arr1[i]}");
        //            Console.WriteLine($"valor de calificacion a {cal}"); 

        //            for (int j = 0; j <= arr2.Count - 1; j++)
        //            {
        //                int calb = arr2[j];
        //                //Console.WriteLine($"valor de calificacion a {arr2[j]}");
        //                Console.WriteLine($"valor de calificacion b {calb}");


        //                if (cal > calb)
        //                {
        //                    sum1++;
        //                    Console.WriteLine($"El mayor es CAL A {cal}");
        //                    Console.WriteLine($"Valor Actual de suma de A {sum1}");
        //                    Console.WriteLine($"===========================================");

        //                    break;
        //                }
        //                else if (cal<calb)
        //                {
        //                    sum2++;
        //                    Console.WriteLine($"El mayor es B {calb}");
        //                    Console.WriteLine($"Valor Actual de suma de BBBBB {sum1}");
        //                    Console.WriteLine($"===========================================");



        //                    break;

        //                }
        //            }

        //        }
        //        result.Add(sum1);
        //        result.Add(sum2);
        //        Console.WriteLine($"suma1 {sum1}");
        //        Console.WriteLine($"sum2 {sum2}");
        //        //Console.WriteLine(sum2);
        //        return result;

        //    }

        //}

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //        //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //        //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        //        List<int> ar = [1, 20, 3];
        //        List<int> ar2 = [10, 2, 3];


        //        List<int> result = Result.compareTriplets(ar, ar2);

        //        //textWriter.WriteLine(String.Join(" ", result));

        //        //textWriter.Flush();
        //        //textWriter.Close();
        //    }
        //}

        //class Result
        //{
        //    public static long aVeryBigSum(List<long> ar)
        //    {
        //        long result= 0;
        //        foreach(long v in ar)
        //        {
        //            result += v;
        //        }
        //        return result;

        //    }

        //}

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //        //int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        //        //List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
        //        List<long> ar = [1000000001, 1000000000000000, 1000000000000000];
        //        //        List<int> ar2 = [10, 2, 3];

        //        long result = Result.aVeryBigSum(ar);

        //        Console.WriteLine(result);

        //    }
        //}

        //class Result
        //{

        //    /*
        //     * Complete the 'diagonalDifference' function below.
        //     *
        //     * The function is expected to return an INTEGER.
        //     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        //     */

        //    public static int diagonalDifference(List<List<int>> arr)
        //    {
        //        int diagonal1 = 0;
        //        int diagonal2 = 0;

        //        for (int i = 0; i < arr.Count; i++)
        //        {
        //            diagonal1 += arr[i][i];

        //            diagonal2 += arr[i][arr.Count - 1 - i];
        //        }

        //        return Math.Abs(diagonal1 - diagonal2);

        //    }

        //}

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {

        //        List<List<int>> arr = new List<List<int>>
        //        {
        //            new List<int> { 1, 2, 3 },
        //            new List<int> { 4, 5, 6 },
        //            new List<int> { 9, 8, 9 }
        //        };



        //        //int result = Result.diagonalDifference(arr);

        //        //Console.WriteLine(result);

        //        List<List<int>> matriz = new List<List<int>>
        //        {
        //            new List<int> { 10, 20, 30 },
        //            new List<int> { 40, 50, 60 },
        //            new List<int> { 70, 80, 90 }
        //        };

        //        Console.WriteLine(matriz[0][0]);//10
        //        Console.WriteLine(matriz[0][2]);//30
        //        Console.WriteLine(matriz[1][1]);//50
        //        Console.WriteLine(matriz[2][0]);//70

        //    }
        //}


        #endregion

        #region Nivel: incidentes
        [HttpGet("reporte-empleados?page={}&pageSize=50")]
        public async Task<IActionResult> ReporteEmpleados([FromQuery] int page, [FromQuery] int pageSize)
        {
            var quey = await _context.Empleados
                .Where(e => e.Activo)
                .OrderBy(e => e.Nombre)
                .Select(e => new ReporteEmpleadoDto
                {
                    Id = e.Id,
                    Nombre = e.Nombre,
                    Departamento = e.Departamento.Nombre,
                    Puesto = e.Puesto.Nombre,
                    Usuario = e.Usuario.Nombre,
                    CantidadProyectos = e.Proyectos.Count()
                })
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            var totalItems = await query.CountAsync();
            var totalPages=totalItems/pageSize;
            var res = new
            {
                Items=quey,
                page=page,
                pageSize=pageSize,
                totalItems=totalItems,
                totalPages=totalPages

            }


            return Ok(resultado);
        }
        #endregion

    }
}
