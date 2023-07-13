namespace UdemyExercise3;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 25;
        Console.WriteLine(myByte);
        sbyte mySbyte = -15;
        Console.WriteLine(mySbyte);
        int myInt = 12345678;
        Console.WriteLine(myInt);
        uint myUint = 123456;
        Console.WriteLine(myUint);
        short myShort = 323;
        Console.WriteLine(myShort);
        ushort myUshort = 2345;
        Console.WriteLine(myUshort);
        float myFloat = 32.15f;
        Console.WriteLine(myFloat);
        double myDouble = 3.14;
        Console.WriteLine(myDouble);
        char myLetter = 'a';
        Console.WriteLine(myLetter);
        bool myBool = true;
        Console.WriteLine(myBool);
        string myText = "my text";
        Console.WriteLine(myText);
        string numText = "15";
        Console.WriteLine(numText);

        int numFromText = int.Parse(numText);
        Console.WriteLine(numFromText);
        Console.ReadLine();


    }
}

