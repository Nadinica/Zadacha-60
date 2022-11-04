//  Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }

int[] arr = { 1, 9, 9, 0, 2, 8, 1, 9, 0 };
int Selectionsort(int[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
       for (int j = 0; j < arr.Length; j++)
       {
            if (arr[i] == arr [j]) count++;
            Console.WriteLine(count);
       }
       
    }
    
    return count;
}
int Count = Selectionsort(arr);
Console.WriteLine("0 встречается",Count);