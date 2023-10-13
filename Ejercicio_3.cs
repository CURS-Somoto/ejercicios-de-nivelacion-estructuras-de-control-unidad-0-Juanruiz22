 int numero;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            } 
                    if (esPrimo)
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }
        }
}
