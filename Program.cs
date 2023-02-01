class a
{
    public string kon{ get; set; }  
    public a(string ww) 
    { 
        kon = ww; 
    }
    public a(string b) 
    {
        kon = b; 
    }
    public a(a copy) 
    { 
        kon = copy.kon; 
    } // Копирующий
    public a Clone() 
    { 
        return new a(kon); 
    } // Метод клонирования
}

internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine();
            a object1 = new a(s);
            Console.WriteLine(object1.kon);
            a object2 = new a();
            Console.WriteLine(object2.kon);
            a object3 = new a(object1);
            Console.WriteLine(object3.kon);
            a object4 = object2.Clone();
            Console.WriteLine(object4.kon);
            Console.WriteLine();

        // Пятый объект
        Console.Write("Введите информацию: ");
        string v = Console.ReadLine();
        Console.WriteLine();
        a Object5 = new a(v);

        // Создается коллекция
        List<a> Listok = new List<a>();
        Listok.Add(object1);
        Listok.Add(object2);
        Listok.Add(object3);
        Listok.Add(object4);
        Listok.Add(Object5);
        foreach (a objects in Listok)
        {
            Console.WriteLine(objects.kon);
        }
        Console.WriteLine();

        Listok.RemoveAt(1);
        Listok.RemoveAt(3);

        foreach (a objects in Listok)
        {
            Console.WriteLine(objects.kon);
        }
        Console.ReadKey();
    }
}

     

