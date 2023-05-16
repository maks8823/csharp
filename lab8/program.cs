using System;

interface Ix
{
    void F0();
    void F1(string w);
}

interface Iy
{
    void F0(string w);
    void F1(string w);
}

class Class1 : Ix, Iy
{
    private string field;

    public string Field
    {
        get { return field; }
        set { field = value; }
    }

    public Class1(string field)
    {
        this.field = field;
    }

    // Неявная реализация методов интерфейсов
    public void F0()
    {
        field = field.Substring(2);
        Console.WriteLine("Класс 1 неявн F0: " + Field);
    }

    public void F1(string w)
    {
        field = w.Substring(2);
        Console.WriteLine("Класс 1 неявн F1: " + Field);
    }

    void Iy.F0(string w)
    {
        field = "-" + w.Substring(1);
        Console.WriteLine("Класс 1 явн F0: " + Field);
    }
    void Iy.F1(string w)
    {
        field = "-" + w.Substring(1);
        Console.WriteLine("Класс 1 явн F1: " +Field);
    }
}

class Class2 : Ix, Iy
{
    private string field;

    public string Field
    {
        get { return field; }
        set { field = value; }
    }

    public Class2(string field)
    {
        this.field = field;
    }

    
    public void F0()
    {
        field = field.Substring(0, field.Length - 2);
        Console.WriteLine("Класс 2 неявн F0: " + Field);
    }
    public void F1(string w)
    {
        field = w.Substring(0, w.Length - 2);
        Console.WriteLine("Класс 2 неявн F1: " + Field);
    }
    void Iy.F0(string w)
    {
        field = "-";
        Console.WriteLine("Класс 2 явн F0: " + Field);
    }

    void Iy.F1(string w)
    {
        field = "-";
        Console.WriteLine("Класс 2 явн F1: " + Field);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string w;
        Console.WriteLine("Введите строку");
        w=Convert.ToString(Console.ReadLine());
        while (w.Length<2)
        {
            Console.WriteLine("Ошибка длина строки <2");
            w = Convert.ToString(Console.ReadLine());
            
        }
        Class1 class1 = new Class1(w);
        Class2 class2 = new Class2(w);
        class1.F0();

        class1.Field = w;
        class1.F1(w);

        class1.Field = w;
        ((Iy)class1).F0(w);
        
        class1.Field = w;
        ((Iy)class1).F1(w);
        
        class2.Field = w;
        class2.F0();

        class2.Field = w;
        class2.F1(w);

        class2.Field = w;
        ((Iy)class2).F0(w);

        class2.Field = w;
        ((Iy)class2).F1(w);

        class2.Field = w;

        // Вызов методов для объекта через интерфейсные ссылки
        Ix ix1 = class1;
        Iy iy1 = class1;
        
        Ix ix2 = class2;
        Iy iy2 = class2;

        class1.Field = w;
        ix1.F0();
        class1.Field = w;
        ix1.F1(w);
        class1.Field = w;
        iy1.F0(w);
        //и тд
        Console.ReadLine();
    }
}
