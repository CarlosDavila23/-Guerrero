using System;

class Program
{
    // Variables globales
    static int fuerza = 10;
    static int resistencia = 10;
    static int energia = 100;
    static int experiencia = 0;
    static int nivel = 1;

    static void Main()
    {
        bool seguirJugando = true;

        do
        {
            MostrarMenu();
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    VerEstado();
                    break;
                case "2":
                    EntrenarFuerza();
                    break;
                case "3":
                    EntrenarResistencia();
                    break;
                case "4":
                    Pelear();
                    break;
                case "5":
                    Descansar();
                    break;
                case "6":
                    seguirJugando = false;
                    Console.WriteLine("¡Hasta luego, guerrero!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            SubirDeNivel();

        } while (seguirJugando);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n--- MENÚ ---");
        Console.WriteLine("1. Ver estado");
        Console.WriteLine("2. Entrenar fuerza");
        Console.WriteLine("3. Entrenar resistencia");
        Console.WriteLine("4. Pelear");
        Console.WriteLine("5. Descansar");
        Console.WriteLine("6. Salir");
    }

    static void VerEstado()
    {
        Console.WriteLine("\n--- ESTADO DEL GUERRERO ---");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Resistencia: {resistencia}");
        Console.WriteLine($"Energía: {energia}");
        Console.WriteLine($"Experiencia: {experiencia}/100");
    }

    static void EntrenarFuerza()
    {
        Console.Write("¿Cuántas horas quieres entrenar fuerza? (máx. 6): ");
        int horas = int.Parse(Console.ReadLine());

        if (horas <= 6 && energia >= horas * 10)
        {
            for (int i = 0; i < horas; i++)
            {
                fuerza += 1;
                experiencia += 5;
                energia -= 10;
            }
            Console.WriteLine($"Entrenaste fuerza durante {horas} horas.");
        }
        else
        {
            Console.WriteLine("No puedes entrenar tantas horas o no tienes suficiente energía.");
        }
    }

    static void EntrenarResistencia()
    {
        Console.Write("¿Cuántas horas quieres entrenar resistencia? (máx. 6): ");
        int horas = int.Parse(Console.ReadLine());

        if (horas <= 6 && energia >= horas * 10)
        {
            for (int i = 0; i < horas; i++)
            {
                resistencia += 1;
                experiencia += 5;
                energia -= 10;
            }
            Console.WriteLine($"Entrenaste resistencia durante {horas} horas.");
        }
        else
        {
            Console.WriteLine("No puedes entrenar tantas horas o no tienes suficiente energía.");
        }
    }

    static void Pelear()
    {
        if (energia >= 20)
        {
            Console.WriteLine("¡Vas a pelear!");

            Random rand = new Random();
            int resultado = rand.Next(0, 2); // 0 pierde, 1 gana

            if (resultado == 1)
            {
                experiencia += 20;
                energia -= 20;
                Console.WriteLine("¡Ganaste la pelea! +20 de experiencia.");
            }
            else
            {
                energia -= 30;
                Console.WriteLine("Perdiste la pelea... -30 de energía.");
            }
        }
        else
        {
            Console.WriteLine("No tienes suficiente energía para pelear.");
        }
    }

    static void Descansar()
    {
        Console.Write("¿Cuántas horas quieres descansar? (máx. 6): ");
        int horas = int.Parse(Console.ReadLine());

        if (horas <= 6)
        {
            for (int i = 0; i < horas; i++)
            {
                energia += 15;
                if (energia > 100)
                    energia = 100;
            }
            Console.WriteLine($"Descansaste {horas} horas y recuperaste energía.");
        }
        else
        {
            Console.WriteLine("No puedes descansar más de 6 horas.");
        }
    }

    static void SubirDeNivel()
    {
        if (experiencia >= 100)
        {
            nivel += 1;
            experiencia = 0;
            fuerza += 2;
            resistencia += 2;
            Console.WriteLine("\n🎉 ¡Subiste de nivel! Tus estadísticas han mejorado.");
        }
    }
}

