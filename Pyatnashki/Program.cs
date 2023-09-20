

using System;
using System.ComponentModel;

int[,] nums = new int[4, 4]{
    {1,2,3,4},    
    {5,6,7,8},
    {9,10,11,12},    
    {13,14,15,0}
};
int w = nums.GetLength(0); int h = nums.GetLength(1);
Random rand = new Random();
bool gameOver = false;
for (int i = w * h - 1; i > 0; i--)
{
    int line = i / w; int tab = i % h;
    int line2 = rand.Next(0, w);
    int tab2 = rand.Next(0, h);
    int temp = nums[line, tab]; nums[line, tab] = nums[line2, tab2];
    nums[line2, tab2] = temp;
}

while (!gameOver)
{
    Console.Clear();
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int num = 1;
    bool win = true; 

    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            if (nums[i, j] != num)
            {
                win = false; break;
            }
            num++;
        }
        if (!win)
            break;
    }  
    

    int a = 0; Console.WriteLine("Выберите число для заменки");
    int b = Convert.ToInt32(Console.ReadLine());
    int line3 = -1, tab3 = -1;
    int line4 = -1, tab4 = -1; for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            if (nums[i, j] == a)
            {
                line3 = i;
                tab3 = j;
            }
            if (nums[i, j] == b)
            {
                line4 = i; tab4 = j;
            }
        }
    }   

    if (Math.Abs(line3 - line4) + Math.Abs(tab3 - tab4) == 1)
    {
        int temp = nums[line3, tab3];
        nums[line3, tab3] = nums[line4, tab4]; nums[line4, tab4] = temp;
    }
    else
    {
        Console.WriteLine("Так нельзя");
    }
    if (win)
        {
            Console.WriteLine("WINNER!!!");
            gameOver = true;
            break;
        }
}
