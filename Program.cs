
using shirlitc;

namespace shirlitc
{
    internal class Заметки
    {
        public DateTime date;
        public string content;
        public string title;
        public int position;
    }
}


internal class Program
{
    static void Main()
    {
        List<Заметки> notes = new List<Заметки>();

        Заметки note = new Заметки();

        DateTime dateTime = DateTime.Today;

        note.title = "прятки";
        note.content = "В 8.00";
        note.date = dateTime;
        note.position = 1;
        notes.Add(note);

        Заметки note2 = new Заметки();

        note2.title = "Пойти сабаку";
        note2.content = "пред обедом";
        note2.date = dateTime.AddDays(+1);
        note2.position = 2;
        notes.Add(note2);

        Заметки note3 = new Заметки();

        note3.title = "Зайти к михаилу";
        note3.content = "перед парами";
        note3.date = dateTime.AddDays(+1);
        note3.position = 3;
        notes.Add(note3);

        Заметки note4 = new Заметки();

        note4.title = "поцибарить";
        note4.content = "на ахен";
        note4.date = dateTime.AddDays(+3);
        note4.position = 4;
        notes.Add(note4);

        Заметки note5 = new Заметки();

        note5.title = "Штирлиц в 1996";
        note5.content = "в 18:00";
        note5.date = dateTime.AddDays(+3);
        note5.position = 3;
        notes.Add(note5);

        Заметки note6= new Заметки();

        note6.title = "За гаражами все дела";
        note6.content = " На рыбалке";
        note6.date = dateTime.AddDays(-3);
        note6.position = 3;
        notes.Add(note6);

        DateTime date = DateTime.Now;
        int position = 1;

        while (true)
        {
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
            }
            else if (Key.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
            }
            Console.Clear();
            Console.WriteLine(date.ToString("dd.MM.yyyy"));
            foreach (Заметки zam in notes)
            {
                if (zam.date.Date == date.Date)
                {
                    Console.WriteLine("  " + zam.title);
                }
            }
            if (Key.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
            else if (Key.Key == ConsoleKey.DownArrow)
            {
                position++;
            }
            if (position < 2)
            {
                position = 1;
            }
            else if (position > 2)
            {
                position = 1;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            if (Key.Key == ConsoleKey.Enter)
            {
                foreach (Заметки pos in notes)
                {
                    if (note.position == position)
                    {
                        Console.Clear();
                        Console.WriteLine("Информация о заметке: ");
                        Console.WriteLine("Название: ");
                        Console.WriteLine(note.title);
                        Console.WriteLine("Содержание: ");
                        Console.WriteLine(note.content);
                    }
                    if (note2.position == position)
                    {
                        Console.Clear();
                        Console.WriteLine("Информация о заметке: ");
                        Console.WriteLine("Название: ");
                        Console.WriteLine(note.title);
                        Console.WriteLine("Содержание: ");
                        Console.WriteLine(note.content);
                    }
                    if (note3.position == position)
                    {
                        Console.Clear();
                        Console.WriteLine("Информация о заметке");
                    }
                }
            }
        }
    }
}