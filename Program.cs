
public class Calculadora
{
    public static void Main(String[] args)
    {   
        //Variables
        double operador1;
        double operador2;
        string operacion;
        double resultadoOperacion;

        
        // Primer operador
        operador1 = NumeroPositivo("\nPor favor, introduce el primer operador:");

        // Segundo operador
        operador2 = NumeroPositivo("\nPor favor, introduce el segundo operador:");

        Console.WriteLine($"\nLos operadores introducidos son {operador1} y {operador2}\n");

        //Menú interactivo
        while(true)
        {
            Console.WriteLine("\nMENÚ DE OPERACIONES:");
            Console.WriteLine("  Suma (+)");
            Console.WriteLine("  Resta (-)");
            Console.WriteLine("  Multiplicación (*)");
            Console.WriteLine("  División (/)");
            Console.WriteLine("  Salir\n");


            Console.Write("Selecciona una operación: \n");
            operacion = Console.ReadLine().Trim().ToLower();

            //Selección de la operación
            switch (operacion)
            {
                case "suma":
                case "+":
                    resultadoOperacion = Operacion(0, operador1, operador2);
                    Console.WriteLine($"\nEl resultado de la suma de {operador1} + {operador2} es igual a: {resultadoOperacion}\n");
                    break;

                case "resta":
                case "-":
                    resultadoOperacion = Operacion(1, operador1, operador2);
                    Console.WriteLine($"\nEl resultado de la resta de {operador1} - {operador2} es igual a: {resultadoOperacion}\n");
                    break;

                case "multiplicación":
                case "multiplicacion":
                case "*":
                    resultadoOperacion = Operacion(2, operador1, operador2);
                    Console.WriteLine($"\nEl resultado de la multiplicación de {operador1} * {operador2} es igual a: {resultadoOperacion}\n");
                    break;

                case "división":
                case "division":
                case "/":
                    resultadoOperacion = Operacion(3, operador1, operador2);
                    Console.WriteLine($"\nEl resultado de la división de {operador1} / {operador2} es igual a: {resultadoOperacion}\n");
                    break;

                case "salir":
                    Console.WriteLine("\nPrograma finalizado.\n");
                    return;

                default:
                    Console.WriteLine("\nOperación no válida.\n");
                    break;
            }
        } 
    }

//Método de entrada de los operadores
   static double NumeroPositivo(string textoMensajeNumeroPositivo)
    {
        while (true)
        {
            Console.WriteLine(textoMensajeNumeroPositivo);
            try
            {
                double numero = Convert.ToDouble(Console.ReadLine());
                //Validación número positivo
                if (numero > 0) {
                    return numero;
                }
                else {
                    Console.WriteLine("\nEntrada inválida. El número debe ser mayor que 0.\n");
                }
            }
            catch (FormatException)
            {
                //Control de excepciones
                Console.WriteLine("\nEntrada inválida. Debes escribir un número.\n");
            }
        }
    }

//Método de cálculo 
    public static double Operacion(int operacion, double operador1, double operador2)
    {
        double resultado = 0;
        switch (operacion)
        {   //Suma
            case 0: 
            resultado = operador1 + operador2;
            break;

            //Resta
            case 1:
            resultado = operador1 - operador2;
            break;

            //Multiplicación
            case 2:
            resultado = operador1 * operador2;
            break;

            //División
            case 3:
            resultado = operador1 / operador2;
            break;
        }

        return resultado;
    }    
}