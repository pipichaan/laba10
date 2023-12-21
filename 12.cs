
Student mariya = new Student("Евстифеева Мария Николаевна", 2020, "ул. Ладожская 170 12", 89347658777, 1, "Менеджемт");
Student serega = new Student("Максимов Сергей Викторович", 2023, "ул. Лядова 43 2", 89127864583, 3, "Медицина");
Student lesha = new Student("Сюзюмов Алексей Сегреевич", 2022, "ул. Лермонтова 23 111", 89647365626, 2, "Компьюьерные технологии");
Student[] mass = new Student[3] { mariya, serega, lesha };
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"Ф.И.О. Студентa - {mass[i].fio}");
}
Console.WriteLine("Введите факультет - Менеджмент/Медицина/Компьютерные технологии");
string facyltet = Console.ReadLine();
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].faculty == facyltet)
    {
        Console.WriteLine($"Студент данного факультета - {mass[i].fio}");
    }
}
Console.WriteLine("Введите год постуления студента (2020/2022/2023)");
int dAtA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Студент, поступивший в данном году - ");
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].data > dAtA)
    {
        Console.WriteLine($"{mass[i].fio}");
    }
}
class Student
{
    private string FIO;
    private int Data;
    private string Address;
    private long Tel;
    private int Kurs;
    private string Faculty;
    public Student(string FIO, int Data, string Address, long Tel, int Course, string Faculty)
    {
        this.FIO = FIO;
        this.Data = Data;
        this.Address = Address;
        this.Tel = Tel;
        this.Kurs = Kurs;
        this.Faculty = Faculty;
    }
    public string fio
    {
        get
        {
            return FIO; // чтение Ф.И.О
        }
        set
        {
            FIO = value; // Запись Ф.И.О.
        }
    }
    public int data
    {
        get
        {
            return Data; // Чтение даты поступления
        }
        set
        {
            Data = value; // Запись даты поступления
        }
    }
    public string address
    {
        get
        {
            return Address; // Чтение адресса
        }
    }
    public long phonenumber
    {
        get
        {
            return Tel;  // Чтение номера телефон
        }
        set
        {
            Tel = value; // Запись номера телефона
        }
    }
    public int course
    {
        set
        {
            Kurs = value;  // Запись курсов
        }
    }
    public string faculty
    {
        get
        {
            return Faculty;  // Чтение  факультета
        }
    }
}