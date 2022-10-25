using NotePad__;

static void Menu(DateTime date) //вывод мейн менюшки
{
    Console.WriteLine($"{date.ToString("D")}");
    Console.WriteLine("   1. Посмотреть все заметки на этот день");
    Console.WriteLine("   2. Создать заметку на этот день");
    Console.WriteLine("   3. Выйти из программы");
}

static void ReadNotes(DateTime date, IEnumerable<Note> DayNotes)
{
    Console.Clear();
    Console.WriteLine($"Дата заметок - {date.ToString("D")}");
    foreach (Note note in DayNotes)
    {
        Console.WriteLine($"   {note.name}");
    }
    Console.WriteLine("   ");
    Console.WriteLine("   Выход в меню");
}

static void AbouteNote(DateTime date, Note note)
{
    Console.Clear();
    Console.WriteLine($"{date.ToString("D")}");
    Console.WriteLine("=========================================");
    Console.WriteLine($"{note.name}"); //Вывод названия заметки
    Console.WriteLine($"{note.text}"); //Вывод содержимого заметки
    Console.WriteLine("=========================================");
    Console.WriteLine("Нажмите любую клавишу, чтобы выйти из этого меню");
    Console.ReadKey();
}

static void AppendNotes(DateTime date, List<Note> notes) //создание заметок
{
    Console.Clear();
    Console.WriteLine("Введите название заметки:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите основной текст заметки:");
    string text = Console.ReadLine();
    notes.Add(new Note() { date = date, name = name, text = text });
}

static int UpdateCursorPos(int VerPos, int MaxVerPos, int MinVerPos, ConsoleKey key) //Изменение позиции курсора
{
    switch (key)
    {
        case ConsoleKey.W:
            VerPos--;
            if (VerPos < MinVerPos)
            {
                VerPos = MinVerPos;
            }
            break;
        case ConsoleKey.S:
            VerPos++;
            if (VerPos > MaxVerPos)
            {
                VerPos = MaxVerPos;
            };
            break;
    }
    return VerPos;
}

static void WriteCursor(int VerPos) //создание курсора в позиции
{
    Console.SetCursorPosition(0, VerPos);
    Console.WriteLine("-->");
}
