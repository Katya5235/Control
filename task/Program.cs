// Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, либо равна 3 
//  символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//  выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Main();
 void Main()
{
    string [] sa =  Creation(); 
    string [] rez =  AmtString(sa);
    Console.WriteLine();
    Console.WriteLine("НОВЫЙ МАССИВ ИЗ СТРОК, ДЛИННА КОТРЫХ МЕНЬШЕ ЛИБО РАВНА 3: ");
    Print(rez);

  
}
string [] Creation ()
{
    string [] array = new string [5];

    Console.WriteLine("Заполните массив : ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Console.ReadLine();

       
    }
    for(int i =0; i < array.Length; i++ )
    {
        Console.Write($"[{array[i]+", "}]");
    }

return array;
}

string [ ] AmtString (string[] ar)
{
 int n = 0;
 for(int i = 0; i < ar.Length; i++)
 {
    if(ar[i].Length<=3) 
    n++;
 }
 string [] rez = new string [n];
 int j = 0;
  for (int i = 0;i<ar.Length;i++)
  {
    if(ar[i].Length <=3)
    {
        rez[j] = ar[i];
        j++;
    }
  }
  return rez;

}
 void Print (string[] stringarray)
 {
    for(int i = 0; i < stringarray.Length; i++ )
    {
        Console.Write($"[{stringarray[i]+", "}]");
    }

 }

