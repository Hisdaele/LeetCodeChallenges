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