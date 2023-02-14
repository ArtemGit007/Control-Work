// Задача: Написать программу, которая из имеющегося массива строк формитрует массив из строк, 
// длина которых меньше, либо равна 3 символам.


// 1.Образование первого массива вводом строк с клавиатуры, 
// объявление второго массива тогс тем же числом элементов.
string[] array1 = new string[5] {"1567", "23", "hello", "god", "result"};
string[] array2 = new string[array1.Length];

// 2. Объявление метода в теле цикла которого проверка условия (<= 3).
void SecondArray(string[] array1, string[] array2)
{   

    int count = 0;  


    for (int i = 0; i < array1.Length; i++) 

    {
    if(array1[i].Length <= 3) 
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
// Вывод массива.
void PrintArray(string[] array)
{

    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 SecondArray(array1, array2);
PrintArray(array2);
