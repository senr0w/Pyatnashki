using System;
int[,] board = new int[4, 4]
{
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12},
    {13,14,15,0}
};
int k= board.GetLength(0);
int h= board.GetLength(1);

 
while(true) { 
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

Console.WriteLine("Ввведите второе число для замены:");
int b = Convert.ToInt32(Console.ReadLine());

bebra(board, a, b);

    Console.WriteLine("\nПродолжаем");
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