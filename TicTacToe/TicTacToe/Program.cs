﻿using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;
        }

        static void StartGame()
        {
            int[,] matrix = new int[,]
            {
              {0, 1, 2 },
              {3, 4, 5 },
              {6, 7, 8 }
            };

        }
    }
}
    
