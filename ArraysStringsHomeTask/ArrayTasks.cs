using System;
namespace ArraysStringsHomeTask
{
    public class ArrayTasks
    {
        public void taskOne()
        {

            int[] arrNumbers = new int[8] { 1, 2, -4, 5, 6, -6, 9, 10 };
            int indexOfLastNegativeNumber = 0;
            int valueOfLastNegativeNumber = 0;

            for(int i = 0; i < arrNumbers.Length; i++)
            {
                    if(arrNumbers[i] < 0)
                {
                    indexOfLastNegativeNumber = i;
                    valueOfLastNegativeNumber = arrNumbers[i];
                }
            }
            Console.WriteLine($"Последний отрицательный элемент в массиве: {valueOfLastNegativeNumber}, его индекс {indexOfLastNegativeNumber}");
        }
		public static void taskTwo()
		{
			int[,] arr = new int[2, 2] {
			{30,10},
			{15,4}
		};

			for (int i = 0; i < 2; i++)
			{
				int index = 0;
				int max = arr[i, index];
				for (int j = 1; j < 2; j++)
				{
					if (arr[i, j] > max)
					{
						max = arr[i, j];
						index = j;
					}
				}
				for (int k = index + 1; k < 2; k++)
				{
					arr[i, k] = 0;

				}
			}
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.WriteLine(arr[i, j]);
				}
			}

		}

	}
}
