
//Task 1
//using System;

//public class Student
//{
//    public string Name;
//    public string Surname;
//    public string Group;
//    public int Point;
//    public bool IsGraduated;

//    public Student(string name, string surname, string group, int point)
//    {
//        Name = name;
//        Surname = surname;
//        Group = group;
//        Point = point;
//        IsGraduated = CalculateGraduation(point);
//    }


//    public void CheckGraduation()
//    {
//        if (IsGraduated)
//        {
//            Console.WriteLine($"{Name} {Surname} mezun oldu.");
//        }
//        else
//        {
//            Console.WriteLine($"{Name} {Surname} mezun olmadı.");
//        }
//    }


//    public void GetDiplomaDegree()
//    {
//        if (Point < 65)
//        {
//            Console.WriteLine("Diplom Derecesi: Yok");
//        }
//        else if (Point >= 65 && Point < 80)
//        {
//            Console.WriteLine("Diplom Derecesi: Adi");
//        }
//        else if (Point >= 80 && Point < 90)
//        {
//            Console.WriteLine("Diplom Derecesi: Şeref");
//        }
//        else if (Point >= 90)
//        {
//            Console.WriteLine("Diplom Derecesi: Yüksek Şeref");
//        }
//    }


//    public void GetInfo()
//    {
//        Console.WriteLine($"Ad: {Name}");
//        Console.WriteLine($"Soyad: {Surname}");
//        Console.WriteLine($"Grup: {Group}");
//        Console.WriteLine($"BallI: {Point}");
//        CheckGraduation();
//        GetDiplomaDegree();
//    }


//    private bool CalculateGraduation(int point)
//    {
//        return (point >= 65);
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Student student1 = new Student("Nihat", "Reshimzade", "AB104", 99);


//        student1.GetInfo();
//    }
//}
//Task 2 class ve method ile

//using System;

//public class Competition
//{
//    private int[] rəşadXalları = new int[3];
//    private int[] aydanXalları = new int[3];

//    public void EnterScores()
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($"Reşadın {i + 1}-ci idman növü üçün xalını daxil edin: ");
//            rəşadXalları[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($"Aydanın {i + 1}-ci idman növü üçün xalını daxil edin: ");
//            aydanXalları[i] = Convert.ToInt32(Console.ReadLine());
//        }
//    }

//    public void CalculateAndDisplayResults()
//    {
//        int rəşadDərəcəsi = 0;
//        int aydanDərəcəsi = 0;

//        for (int i = 0; i < 3; i++)
//        {
//            if (rəşadXalları[i] > aydanXalları[i])
//            {
//                rəşadDərəcəsi++;
//            }
//            else if (rəşadXalları[i] < aydanXalları[i])
//            {
//                aydanDərəcəsi++;
//            }
//        }

//        Console.WriteLine($"Reşadın Dərəcəsi: {rəşadDərəcəsi}");
//        Console.WriteLine($"Aydanın Dərəcəsi: {aydanDərəcəsi}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Competition competition = new Competition();

//        competition.EnterScores();
//        competition.CalculateAndDisplayResults();
//    }
//}

//using System;

//public class Competition
//{
//    public static void CompareScores(int[] rəşadXalları, int[] aydanXalları)
//    {
//        int rəşadDərəcəsi = 0;
//        int aydanDərəcəsi = 0;

//        for (int i = 0; i < 3; i++)
//        {
//            if (rəşadXalları[i] > aydanXalları[i])
//            {
//                rəşadDərəcəsi++;
//            }
//            else if (rəşadXalları[i] < aydanXalları[i])
//            {
//                aydanDərəcəsi++;
//            }
//        }

//        Console.WriteLine($"Reşadın Dərəcəsi: {rəşadDərəcəsi}");
//        Console.WriteLine($"Aydanın Dərəcəsi: {aydanDərəcəsi}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] rəşadXalları = new int[3];
//        int[] aydanXalları = new int[3];

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($"Reşadın {i + 1}-ci idman növü üçün xalını daxil edin: ");
//            rəşadXalları[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($"Aydanın {i + 1}-ci idman növü üçün xalını daxil edin: ");
//            aydanXalları[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Competition.CompareScores(rəşadXalları, aydanXalları);
//    }
//}


//Task 3
//using System;

//public class Program
//{
//    public static string[] ExtractWords(string text)
//    {

//        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//        return words;
//    }

//    public static void Main()
//    {
//        Console.WriteLine("Metni daxil edin:");
//        string inputText = Console.ReadLine();

//        string[] words = ExtractWords(inputText);

//        Console.WriteLine("Metnde tapılan sozler:");
//        for (int i = 0; i < words.Length; i++)
//        {
//            Console.WriteLine(words[i]);
//        }
//    }
//}
//Task 4
//using System;

//public class Program
//{
//    public static string TrimStartCustom(string input, char[] trimChars)
//    {
//        int startIndex = 0;
//        while (startIndex < input.Length && Array.IndexOf(trimChars, input[startIndex]) != -1)
//        {
//            startIndex++;
//        }
//        return input.Substring(startIndex);
//    }

//    public static string TrimEndCustom(string input, char[] trimChars)
//    {
//        int endIndex = input.Length - 1;
//        while (endIndex >= 0 && Array.IndexOf(trimChars, input[endIndex]) != -1)
//        {
//            endIndex--;
//        }
//        return input.Substring(0, endIndex + 1);
//    }

//    public static string TrimCustom(string input, char[] trimChars)
//    {
//        int startIndex = 0;
//        while (startIndex < input.Length && Array.IndexOf(trimChars, input[startIndex]) != -1)
//        {
//            startIndex++;
//        }

//        int endIndex = input.Length - 1;
//        while (endIndex >= 0 && Array.IndexOf(trimChars, input[endIndex]) != -1)
//        {
//            endIndex--;
//        }

//        if (startIndex > endIndex)
//        {
//            return string.Empty;
//        }

//        return input.Substring(startIndex, endIndex - startIndex + 1);
//    }

//    public static void Main()
//    {
//        string text = "xxyyxxNihat bir COD telebesidiraaayyxx";

//        char[] trimChars = { 'x', 'y', 'a' };

//        string trimmedStart = TrimStartCustom(text, trimChars);
//        string trimmedEnd = TrimEndCustom(text, trimChars);
//        string trimmed = TrimCustom(text, trimChars);

//        Console.WriteLine("Başdan Temizlenmiş: " + trimmedStart);
//        Console.WriteLine("Sonundan Temizlenmiş: " + trimmedEnd);
//        Console.WriteLine("Her İki Taraftan Temizlenmiş: " + trimmed);
//    }
//}
//Task 5
//int[,] array = CreateTwoDimensionalArray();

//SetArrayElements(array);

//PrintArrayElements(array);

//static int[,] CreateTwoDimensionalArray()
//{
//    Console.Write("Massivin setr sayini daxil edin: ");
//    byte rowSize = byte.Parse(Console.ReadLine());

//    Console.Write("Massivin sutun sayini daxil edin: ");
//    byte colSize = byte.Parse(Console.ReadLine());

//    return new int[rowSize, colSize];
//}

//static void SetArrayElements(int[,] array)
//{
//    Console.WriteLine("Massivin elementlerini daxil edin:");
//    for (int i = 0; i < array.GetLength(0); i++)
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write($"array[{i},{j}]: ");
//            array[i, j] = int.Parse(Console.ReadLine());
//        }
//}

//static void PrintArrayElements(int[,] array)
//{
//    Console.WriteLine();
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//            Console.Write($"{array[i, j],-4}");

//        Console.WriteLine();
//    }
//}