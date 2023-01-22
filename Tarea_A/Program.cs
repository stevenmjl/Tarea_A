
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    public static double dolar = 56.75;
    public static double euro = 61.73;

    static void Main(string[] args)
    {
        int valor;  //Para selecionar la acción del Switch
        string lector; //Para leer el texto en consola

        //Repetición para recorrer cada capítulo.
        do
        {
            Console.WriteLine("\n\n1. Capitulo 1." +
                          "\n2. Capitulo 2." +
                          "\n3. Capitulo 3." +
                          "\n4. Capitulo 4." +
                          "\n5. Salir." +
                          "\nElija una opcion: ");

            lector = LeerSoloNumeros();
            valor = Convert.ToInt32(lector);

            switch (valor)
            {
                case 1:
                    Capitulo1();
                    break;
                case 2:
                    Capitulo2();
                    break;
                case 3:
                    Capitulo3();
                    break;
                case 4:
                    Capitulo4();
                    break;
                case 5:
                    Console.WriteLine("\n\nSaliendo...");
                    break;
                default:
                    Console.WriteLine("\n\nOpcion no encontrada...");
                    break;
            }
        } while (valor != 5);
        //Console.ReadKey();
    }

    static string LeerSoloNumeros() // Permite no leer letras ni carecteres especiales
    {
        double val = 0;
        string numero = "";
        ConsoleKeyInfo chr;
        do
        {
            chr = Console.ReadKey(true);
            if (chr.Key != ConsoleKey.Backspace)
            {
                bool control = double.TryParse(chr.KeyChar.ToString(), out val);
                if (control)
                {
                    numero += chr.KeyChar;
                    Console.Write(chr.KeyChar);
                }
            }
            else
            {
                if (chr.Key == ConsoleKey.Backspace && numero.Length > 0)
                {
                    numero = numero.Substring(0, (numero.Length - 1));
                    Console.Write("\b \b");
                }
            }
        }
        while (chr.Key != ConsoleKey.Enter);

        return numero;
    }
    static void Capitulo1()
    {
        Console.WriteLine("\nCapítulo 1:");

        //Ejer.1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.
        Console.WriteLine("\nSteven Michael Javier Lopez");
        //Ejer.5 Agregue más mensajes a la aplicación que ha creado.
        Console.WriteLine("Es mi nombre y este es el proyecto que se ha creado.");
        Console.WriteLine("No tengo más mensajes de relleno...");
    }
    static void Capitulo2()
    {
        string lector;
        int lado, numeroDeLados;
        double grados, centigrados, peso;

        Console.WriteLine("\nCapítulo 2:");

        //Ejer.1 Hacer un programa que calcule el perímetro de cualquier polígono regular.
        Console.WriteLine("\nEjercicio 1:");
        Console.WriteLine("\nIngrese la cantidad de lados:");
        lector = LeerSoloNumeros();
        numeroDeLados = Convert.ToInt32(lector);
        Console.WriteLine("\nIngrese el tamaño del lado:");
        lector = LeerSoloNumeros();
        lado = Convert.ToInt32(lector);
        Console.WriteLine("\nEl perímetro es de: {0}", (lado * numeroDeLados));

        //Ejer.3 Hacer un programa que transforme de grados a radianes.
        Console.WriteLine("\nEjercicio 3:");
        Console.WriteLine("\nIngrese los grados:");
        lector = LeerSoloNumeros();
        grados = Convert.ToDouble(lector);
        Console.WriteLine("\nEn rádian es: {0}", (grados * Math.PI / 180));

        //Ejer.4 Hacer un programa que transforme de grados centígrados a grados Fahrenheit.
        Console.WriteLine("\nEjercicio 4:");
        Console.WriteLine("\nIngrese grados centígrados:");
        lector = LeerSoloNumeros();
        centigrados = Convert.ToDouble(lector);
        Console.WriteLine("\nEn grados Fahrenheit es: {0}", ((centigrados * 9 / 5) + 32));

        //Ejer.5 Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.
        Console.WriteLine("\nEjercicio 5:");
        Console.WriteLine("\nIngrese la cantidad de pesos:");
        lector = LeerSoloNumeros();
        peso = Convert.ToDouble(lector);
        Console.WriteLine("\nDe peso a dolar es: {0}\nDe peso a euro es: {1}", (peso / dolar), (peso / euro));
        Console.WriteLine("\nDe dolar a peso es: {0}\nDe euro a peso es: {1}", (peso * dolar), (peso * euro));
    }
    static void Capitulo3()
    {
        string lector;
        int opcion;
        double numero, largo;

        Console.WriteLine("\nCapítulo 3:");

        //Ejer.1 Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.
        Console.WriteLine("\nEjercicio 1:");
        Console.WriteLine("\nIngrese un número para saber si es par o impar:");
        lector = LeerSoloNumeros();
        numero = Convert.ToDouble(lector);
        if (numero%2 == 0)
            Console.WriteLine("\nEs par.");
        else
            Console.WriteLine("\nEs impar.");

        //Ejer.4 Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.
        Console.WriteLine("\nEjercicio 4:");
        Console.WriteLine("\nIngrese número del 1 al 7:");
        lector = LeerSoloNumeros();
        opcion = Convert.ToInt32(lector);
        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nEs domingo."); break;
            case 2:
                Console.WriteLine("\nEs lunes."); break;
            case 3:
                Console.WriteLine("\nEs martes."); break;
            case 4:
                Console.WriteLine("\nEs miércoles."); break;
            case 5:
                Console.WriteLine("\nEs jueves."); break;
            case 6:
                Console.WriteLine("\nEs viernes."); break;
            case 7:
                Console.WriteLine("\nEs sábado."); break;
            default:
                Console.WriteLine("\nSOLO NUMEROS DEL 1 AL 7."); break;
        }

        //Ejer.5 Hacer una programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular.
        Console.WriteLine("\nEjercicio 5:");
        Console.WriteLine("\n1 para calcular area y 2 para perimetro:");
        lector = LeerSoloNumeros();
        opcion = Convert.ToInt32(lector);

        Console.WriteLine("\nIngrese numero de lados:");
        lector = LeerSoloNumeros();
        numero = Convert.ToDouble(lector);
        Console.WriteLine("\nIngrese el valor del lado:");
        lector = LeerSoloNumeros();
        largo = Convert.ToDouble(lector);
        if (opcion == 1)
            Console.WriteLine("\nEl área es: {0}", largo * numero * (6.28319/numero) / 2);
        else if(opcion == 2)
            Console.WriteLine("\nEl perímetro es: {0}", largo * numero);
    }
    static void Capitulo4()
    {
        string lector;
        int numero, max = 0, min = 320000;
        double numeroLargo, resultado = 1;
        // For, do while, while
        //Ejer.1 Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.        Console.WriteLine("\nCapítulo 4:");
        Console.WriteLine("\nEjercicio 1:");
        Console.WriteLine("\nIngrese número para mostrar su tabla:");
        lector = LeerSoloNumeros();
        numero = Convert.ToInt32(lector);
        Console.WriteLine("");
        for (int i = 0; i < 10; i++){
            Console.WriteLine("\t{0} x {1} = {2}",i+1,numero,((i+1)*numero));
        }

        //Ejer.2 Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.
        Console.WriteLine("\nEjercicio 2:");
        Console.WriteLine("\nIngrese número base:");
        lector = LeerSoloNumeros();
        numeroLargo = Convert.ToInt32(lector);
        Console.WriteLine("\nIngrese la potencia:");
        lector = LeerSoloNumeros();
        numero = Convert.ToInt32(lector);
        for (int i = 0; i < numero; i++)
        {
            resultado *= numeroLargo;
        }
        Console.WriteLine("\nResultado es: {0}", resultado);
        
        //Ejer.5 Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven.
        Console.WriteLine("\nIngrese la cantidad de personas:");
        lector = LeerSoloNumeros();
        numeroLargo = Convert.ToInt32(lector);
        resultado = 0;
        for (int i = 0; i < numeroLargo; i++)
        {
            Console.WriteLine("\nIngrese edad {0}:",i+1);
            lector = LeerSoloNumeros();
            numero = Convert.ToInt32(lector);
            resultado += numero;
            if (numero > max)
                max = numero;
            if (numero < min)
                min = numero;
        }
        Console.WriteLine("\nEl promedio es {0}, el minimo es {1} y el maximo es {2}",(resultado/numeroLargo),min,max);
    }
}