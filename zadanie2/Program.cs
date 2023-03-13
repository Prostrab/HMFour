// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
Random rnd = new Random();

int [] arr = GetArray(4);

Console.WriteLine($"Массив : [{string.Join("," , arr)}] , сумма чисел с четным индексом = {GetSumEvArr (arr)}");
int [] GetArray (int size)

{

int [] Array = new int [size];

    for (int i = 0; i<Array.Length; i++)
    
    {
        Array[i] = rnd.Next(0,10);

    }

return Array;

}

int GetSumEvArr (int [] array)

{   int sum = 0;
    for(int i = 1; i<array.Length; i+=2)
        
        {
        sum += array[i];
            
              

        }

return sum;

}

