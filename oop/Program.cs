
using oop;

public class Cats
{
    public string CatColor { get; set; }
    public Cats(){
        CatColor = "black";
    }
}

internal class Program
{
    static int PlusMethod(int x, int y){
        return x + y;
    }

    static double PlusMethod(double x, double y){
        return x + y;
    }

    static void CatMethod() {
        Console.WriteLine("This is ciciness");
    }

    static void CatInfo(string name, int age){
        Console.WriteLine(name + " is " + age);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CatMethod();
        CatMethod();
        CatMethod();
        CatInfo("cici", 3);

        // method overloading   
        int myNum1 = PlusMethod(8, 5);
        Console.WriteLine(myNum1);

        double myNum2 = PlusMethod(8.5, 9.85);
        Console.WriteLine(myNum2);

        // class
        Cats myCat1 = new Cats();
        Cats myCat2 = new Cats();
        Console.WriteLine(myCat1.CatColor);
        Console.WriteLine(myCat2.CatColor);

        FirstCats myCat = new FirstCats();
        Console.WriteLine(myCat.color);
    }
}