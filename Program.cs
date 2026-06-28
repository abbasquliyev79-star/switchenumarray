using System;

class Program
{
    static void Main()
    {
        string[] questions =
        {
            "Azerbaycanin paytaxti haradir?",
            "Dunyanin en boyuk okeani hansidir?",
            "2 + 5 = ?",
            "C# hansi proqramlasdirma dilidir?",
            "Azerbaycanin pul vahidi nedir?",
            "Gunesh hansi istiqametden dogur?",
            "1 baytda nece bit var?",
            "Turkiyenin paytaxti haradir?",
            "En uzun cay hansidir?",
            "HTML ne ucun istifade olunur?"
        };

        string[,] answers =
        {
            {"Baku","Ganja","Shaki"},
            {"Sakit okean","Atlantik okeani","Hind okeani"},
            {"7","8","6"},
            {"Proqramlasdirma dili","Emeliyyat sistemi","Oyun"},
            {"Manat","Dollar","Euro"},
            {"Sherq","Qerb","Cenub"},
            {"8","16","4"},
            {"Ankara","Istanbul","Izmir"},
            {"Nil","Kura","Volqa"},
            {"Veb sehife yaratmaq","Video montaj","Sekil cekmek"}
        };

        int[] correct =
        {
            0,0,0,0,0,0,0,0,0,0
        };

        Random rnd = new Random();
        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine((i + 1) + ". " + questions[i]);

            string[] option = new string[3];
            int[] index = { 0, 1, 2 };

            for (int j = 0; j < 3; j++)
            {
                int r = rnd.Next(j, 3);

                int t = index[j];
                index[j] = index[r];
                index[r] = t;
            }

            char[] letter = { 'A', 'B', 'C' };

            for (int j = 0; j < 3; j++)
            {
                option[j] = answers[i, index[j]];
                Console.WriteLine(letter[j] + ") " + option[j]);
            }

            Console.Write("Cavab: ");
            string user = Console.ReadLine().ToUpper();

            int choose = -1;

            if (user == "A") choose = 0;
            else if (user == "B") choose = 1;
            else if (user == "C") choose = 2;

            if (choose != -1 && index[choose] == correct[i])
            {
                Console.WriteLine("Duzdur!");
                score++;
            }
            else
            {
                Console.WriteLine("Sehv!");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Netice: " + score + " / " + questions.Length);
    }
}