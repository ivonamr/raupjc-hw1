using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1
{ 
    class Program
{
    private static void Main(string[] args)
    {
        //IIntegerList list = new IntegerList();
        //ListExample(list);
        IGenericList<string> stringList = new GenericList<string>();
        stringList.Add(" Hello ");
        stringList.Add(" World ");
        stringList.Add("!");
        foreach (string value in stringList)
        {
            Console.WriteLine(value);
        }

        }

    public static void ListExample(IIntegerList listOfIntegers)
    {

        listOfIntegers.Add(1); // [1]
            Console.WriteLine(listOfIntegers.Count); // 3
            listOfIntegers.Add(2); // [1 ,2]
            Console.WriteLine(listOfIntegers.Count); // 3
            listOfIntegers.Add(3); // [1 ,2 ,3]
            Console.WriteLine(listOfIntegers.Count); // 3
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            Console.WriteLine(listOfIntegers.Count); // 3
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            Console.WriteLine(listOfIntegers.Count); // 3
           listOfIntegers.Remove(5); //[2 ,3 ,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Count ) ; // 3
           Console.WriteLine(listOfIntegers.Remove (100) ) ; // false
            Console.WriteLine(listOfIntegers.RemoveAt (3) ) ; // false
        Console.WriteLine(listOfIntegers.Contains (5) ) ;
            listOfIntegers.Clear() ; // []
            Console.WriteLine(listOfIntegers.Count ) ; // 0
        Console.ReadLine();
    }
}
}

        
    




