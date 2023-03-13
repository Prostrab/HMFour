//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
Random rnd = new Random();
int [] Arr = GetArray (6);
int  min = getEvenNumbers (Arr);

Console.WriteLine($"Массив : {string.Join("," , Arr)} , четных чисел = {getEvenNumbers (Arr)} ");


int [] GetArray (int size)

{

int [] Array = new int [size];


for (int i = 0; i<Array.Length; i++)
{
Array[i] = rnd.Next(100,1000);

}

return Array;


}

int  getEvenNumbers (int [] Array)

{
    int count = 0;
    foreach (int Num in Array)

    {
        int diff = Num % 2;
        
        if (diff == 0)
        {
           count ++;
        }

        
    }
return count;
}
