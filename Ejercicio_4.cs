           int numero;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial del número es: " + factorial);
        }
    }
}
