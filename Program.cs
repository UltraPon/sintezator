class Program
{
    static void Main(string[] args)
    {
        Octave();
    }
    static void Octave()
    {
        Console.WriteLine("Для выбора октавы нажмите f1 или f2. ");
        ConsoleKeyInfo key = Console.ReadKey();
        List<int[]> Octave = new()
        {
            new int[] {131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247},
            new int[] {262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494}
        };
        if (key.Key == ConsoleKey.F1)
        {
            ThirdOctave(Octave[0]);
        }
        if (key.Key == ConsoleKey.F2)
        {
            FourthOctave(Octave[1]);
        }
    }
    static void ThirdOctave(int[] Sound)
    {
        Console.WriteLine("Третья октава, белые клавиши: a-h; чёрные клавиши: q-y. Для возвращения к выбору октав, клавиша: Tab.");
        for (ConsoleKeyInfo sound = Console.ReadKey(); sound.Key != ConsoleKey.Tab;)
        {
            if (sound.Key == ConsoleKey.A)
            {
                Console.Beep(Sound[0], 500);
            }
            if (sound.Key == ConsoleKey.S)
            {
                Console.Beep(Sound[2], 500);
            }
            if (sound.Key == ConsoleKey.D) 
            {
                Console.Beep(Sound[4], 500);
            }
            if (sound.Key == ConsoleKey.F) 
            {
                Console.Beep(Sound[6], 500);
            }
            if (sound.Key == ConsoleKey.G) 
            {
                Console.Beep(Sound[8], 500);
            }
            if (sound.Key == ConsoleKey.H) 
            {
                Console.Beep(Sound[10], 500);
            }
            if (sound.Key == ConsoleKey.Q)
            {
                Console.Beep(Sound[1], 500);
            }
            if (sound.Key == ConsoleKey.W)
            {
                Console.Beep(Sound[3], 500);
            }
            if (sound.Key == ConsoleKey.E) 
            {
                Console.Beep(Sound[5], 500);
            }
            if (sound.Key == ConsoleKey.R) 
            {
                Console.Beep(Sound[7], 500);
            }
            if (sound.Key == ConsoleKey.T) 
            {
                Console.Beep(Sound[9], 500);
            }
            if (sound.Key == ConsoleKey.Y) 
            {
                Console.Beep(Sound[11], 500);
            }
            sound = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Третья октава, белые клавиши: a-h; чёрные клавиши: q-y. Для возвращения к выбору октав, клавиша: Tab.");  
        }
    Octave();
    }
    static void FourthOctave(int[] Sound)
    {
        Console.WriteLine("Четвёртая октава, белые клавиши: a-h; чёрные клавиши: q-y. Для возвращения к выбору октав, клавиша: Tab.");
        for (ConsoleKeyInfo sound = Console.ReadKey(); sound.Key != ConsoleKey.Tab;)
        {
            if (sound.Key == ConsoleKey.A)
            {
                Console.Beep(Sound[0], 500);
            }
            if (sound.Key == ConsoleKey.S)
            {
                Console.Beep(Sound[2], 500);
            }
            if (sound.Key == ConsoleKey.D) 
            {
                Console.Beep(Sound[4], 500);
            }
            if (sound.Key == ConsoleKey.F) 
            {
                Console.Beep(Sound[6], 500);
            }
            if (sound.Key == ConsoleKey.G) 
            {
                Console.Beep(Sound[8], 500);
            }
            if (sound.Key == ConsoleKey.H) 
            {
                Console.Beep(Sound[10], 500);
            }
            if (sound.Key == ConsoleKey.Q)
            {
                Console.Beep(Sound[1], 500);
            }
            if (sound.Key == ConsoleKey.W)
            {
                Console.Beep(Sound[3], 500);
            }
            if (sound.Key == ConsoleKey.E) 
            {
                Console.Beep(Sound[5], 500);
            }
            if (sound.Key == ConsoleKey.R) 
            {
                Console.Beep(Sound[7], 500);
            }
            if (sound.Key == ConsoleKey.T) 
            {
                Console.Beep(Sound[9], 500);
            }
            if (sound.Key == ConsoleKey.Y) 
            {
                Console.Beep(Sound[11], 500);
            }
            sound = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Четвёртая октава, белые клавиши: a-h; чёрные клавиши: q-y. Для возвращения к выбору октав, клавиша: Tab.");
        }
    Octave();
    }   
}