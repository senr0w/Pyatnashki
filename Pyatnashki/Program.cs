using System;

int[,] nums = new int[4, 4]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 0}
};

Random random = new Random();
int w = nums.GetLength(0);
int h = nums.GetLength(1);
int n = w * h;
int moves = 0; // Счётчик ходов

// Перемешивание элементов в матрице
while (n > 1)
{
    n--;
    int k = random.Next(n + 1);
    int temp = nums[n / h, n % h];
    nums[n / h, n % h] = nums[k / h, k % h];
    nums[k / h, k % h] = temp;
}

bool isCorrectOrder = false;

// Основной цикл игры
while (!isCorrectOrder)
{
    // Вывод текущего состояния матрицы
    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            Console.Write(nums[i, j] + "\t");
        }
        Console.WriteLine();
    }
       //Вывод количества ходов
     Console.WriteLine("Количество ходов: " + moves);
    // Пользователь вводит число для замены
    Console.WriteLine("Число для замены:");    
     int b = Convert.ToInt32(Console.ReadLine());
 
    int line3 = -1, tab3 = -1;
    int line4 = -1, tab4 = -1;

    // Поиск позиции пустой ячейки и выбранного числа b
    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            if (nums[i, j] == 0)
            {
                line3 = i;
                tab3 = j;
            }
            if (nums[i, j] == b)
            {
                line4 = i;
                tab4 = j;
            }
        }
    }
    Console.Clear();
    // Проверка возможности перемещения и, если возможно, перемещение
    if ((Math.Abs(line3 - line4) == 1 && tab3 == tab4) || (Math.Abs(tab3 - tab4) == 1 && line3 == line4))
    {
        int temp = nums[line3, tab3];
        nums[line3, tab3] = nums[line4, tab4];
        nums[line4, tab4] = temp;
        moves++; // Увеличение счётчика ходов
       
    }
    else
    {
        Console.WriteLine("Так нельзя");
    }

    // Проверка правильного порядка чисел в матрице
    isCorrectOrder = CheckCorrectOrder(nums);
}

// Вывод сообщения о победе
Console.WriteLine("Поздравляем! Вы выиграли!");

// Функция для проверки правильного порядка чисел в матрице
bool CheckCorrectOrder(int[,] array)
{
    int value = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != value % (w * h))
            {
                return false;
            }
            value++;
        }
    }
    return true;
}