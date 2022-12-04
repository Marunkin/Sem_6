//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
/*
int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Положительных чисел в массиве: {Array(array)}");

//--------------------------------------МЕТОДЫ----------------------------------------------------
int [] GetArray(int size, int minValue, int maxValue){
    int [] result = new int[size];
    for (int i = 0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int Array(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]>0) count++;
    }
    return count;
}
*/
//Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100,
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] array = GetArray(10, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
selectionSort(array);
Console.WriteLine($"[{String.Join(", ", array)}]");

//--------------------------------------МЕТОДЫ----------------------------------------------------
int [] GetArray(int size, int minValue, int maxValue){
    int [] result = new int[size];
    for (int i = 0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

void selectionSort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++){
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}