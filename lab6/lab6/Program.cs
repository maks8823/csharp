using System;
using System.IO;

class RealMatrix
{
    private double[,] data;
    private int rows;
    private int cols;

    public RealMatrix()
    {
        rows = 0;
        cols = 0;
        data = null;
    }

    public RealMatrix(int numRows, int numCols)
    {
        rows = numRows;
        cols = numCols;
        data = new double[numRows, numCols];
        Random rand = new Random();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                data[i, j] = Math.Round(rand.NextDouble(),3);
            }
        }
    }

    public RealMatrix(RealMatrix otherMatrix)
    {
        rows = otherMatrix.Rows;
        cols = otherMatrix.Cols;
        data = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                data[i, j] = otherMatrix.GetElement(i, j);
            }
        }
    }

    public int Rows
    {
        get { return rows; }
    }

    public int Cols
    {
        get { return cols; }
    }

    public double GetElement(int row, int col)
    {
        return data[row, col];
    }

    public void SetElement(int row, int col, double value)
    {
        data[row, col] = value;
    }

    public RealMatrix SubtractRow(int rowIndex)
    {
        RealMatrix result = new RealMatrix(this);
        for (int i = 0; i < rows; i++)
        {
            if (i != rowIndex)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.SetElement(i, j, result.GetElement(i, j) - result.GetElement(rowIndex, j));
                }
            }
        }
        return result;
    }

    public static RealMatrix operator -(RealMatrix matrix, int rowIndex)
    {
        return matrix.SubtractRow(rowIndex);
    }

    static void Main()
    {
        // Читаем количество строк и столбцов из файла
        string[] input = File.ReadAllText("input.txt").Split();
        int numRows = int.Parse(input[0]);
        int numCols = int.Parse(input[1]);

        // Создаем матрицу
        RealMatrix matrix = new RealMatrix(numRows, numCols);

        // Выводим матрицу на экран и в файл
        Console.WriteLine("Матрица:");
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            sw.WriteLine("Исходная матрица");
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(matrix.GetElement(i, j) + " ");
                    sw.Write(matrix.GetElement(i, j) + " ");
                }
                Console.WriteLine();
                sw.WriteLine();
            }
        }
        // Вычитаем строку матрицы с заданным номером из всех остальных строк
        int rowIndex;
        Console.WriteLine("Введите индекс строки:");
        while (!int.TryParse(Console.ReadLine(), out rowIndex) || rowIndex >= numRows)
        {
            Console.WriteLine("Ошибка");
        }
        RealMatrix result = matrix - rowIndex;

        // Выводим результат на экран и в файл
        Console.WriteLine("Результат:");
        using (StreamWriter sw = new StreamWriter("output.txt", true))
        {
            sw.WriteLine("Результат:");
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(result.GetElement(i, j) + " ");
                    sw.Write(result.GetElement(i, j) + " ");
                }
                Console.WriteLine();
                sw.WriteLine();
            }
        }
        Console.ReadLine();
    }
}