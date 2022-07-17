// Console.WriteLine("Digite seu nome: ");
// // Testando
// string name = Console.ReadLine();
// Console.Write("Digite o ano do seu nascimento: ");
// int year = int.Parse(Console.ReadLine());
// int age = 2022 - year;
// Console.WriteLine($"Olá {name}! Você tem {age} anos.");

// if(age >= 18 || name == "Suzyanne"){

//     Console.WriteLine(" Você é maior de idade");

// }
// else {
//     Console.WriteLine("Você é menor de idade.");
// }

namespace LearningCSharp {
class Program
{
    static void Main(string[] args)
    {
        // string[] names = { "Fred", "Márcio", "Alessandra" }; //Syntatic sugar
        // string[] array = new string[2];
        // array[0] = "Fred";
        // array[1] = "Suzyanne";
        // string[] array2 = array;

        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // foreach(string name in names){
        //     Console.WriteLine(name);
        // }

        // string[] meuNome = {"Suzyanne", "Xavier", "Maciel"};
        // Console.WriteLine(string.Join(" ", meuNome));

        //Tipos de referência e Tipo de Valor:
        int i = 10;
        int i2 = i;
        i2 = 20;

        Test t = new Test();
        t.X = 10;

        Test t2 = t;
        t2.X = 20;

        Console.WriteLine(i);
        Console.WriteLine(t.X);
        
    }

    class Test {

        public int X;


    }
}
}