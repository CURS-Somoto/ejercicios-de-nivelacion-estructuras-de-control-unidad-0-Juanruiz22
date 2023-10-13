 int numero1, numero2;

            
            Console.WriteLine("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

           
            if (numero1 > numero2)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
