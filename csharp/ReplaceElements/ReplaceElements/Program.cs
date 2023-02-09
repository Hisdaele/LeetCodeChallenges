namespace ReplaceElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 17, 18, 5, 4, 6, 1 };
            arr = ReplaceElements(arr);
            foreach(int i in arr) 
            {
                Console.WriteLine(i);
            }
        }

        private static int[] ReplaceElements(int[] arr)
        {
            int size = arr.Length;
            /*for(int i = 0; i < size; i++)
            {
                int max = -1;
                for(int j = i+1; j < size; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                }
                arr[i] = max;
            }*/
            int currentMax = -1;
            for(int i = size - 1; i >= 0; i--)
            {
                int tempo = arr[i];
                arr[i] = currentMax;
                if(tempo > currentMax)
                {
                    currentMax = tempo;
                }
            }
            return arr;
        }
    }
}