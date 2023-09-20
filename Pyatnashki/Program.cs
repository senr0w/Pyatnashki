using System;

int[,] board = new int[4, 4];
int[] numbers = new int[16];

for (int i = 0; i < 15; i++)
{
    numbers[i] = i + 1;
}


Shuffle(numbers);

int index = 0;
for (int i = 0; i < board.GetLength(0); i++)
{
    for (int j = 0; j < board.GetLength(1); j++)
    {
        board[i, j] = numbers[index++];
    }
}



void Shuffle(int[] array)
{
    Random rand = new Random();
    for (int i = array.Length - 1; i > 0; i--)
    {
        int j = rand.Next(0, i + 1);
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
while () { 
   Random rand= new Random();
for(int i = 0; i < board.GetLength(0); i++)
{
    for (int j = 0; j < board.GetLength(1); j++)
    {
        Console.Write(board[i,j] + "\t");
    }
    Console.WriteLine();
}

    int a = 0;

    Console.WriteLine("Введите второе число для замены:");
    int b = Convert.ToInt32(Console.ReadLine());

    bebra(board, a, b);

    Console.WriteLine("\nПродолжаем");
}
void CheckWin(int[,] board)
{

}
void bebra(int[,] board, int hog,int sergey) 
{
    int anya = find(board,hog);
    int kolya=find(board,sergey);
    board[anya % 1000, anya / 1000] = sergey;
    board[kolya%1000,kolya/1000] = hog;

}

int  find(int[,] niggs, int slon) 
{
    int min = 0;
    for(int i=0; i < 4; i++)
    {
        for(int j=0; j< 4; j++)
        {
            if (niggs[i,j] == slon) 
            {
                min = i + j * 1000;
            }
        }
    }
    return min;
}
