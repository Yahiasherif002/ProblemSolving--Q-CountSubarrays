internal class Program
{
    static int countSybarrays(int[] arr)
    {
        int n = arr.Length;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int subarrayMin= arr[i]; 
            for (int j = i; j < n; j++)
            {
                if (arr[j] >= subarrayMin) {
                    count++;
                    subarrayMin = arr[j];

                }
                else
                {
                    break;
                }
                
            }
        }   
        return count;
    }
    private static void Main(string[] args)
    {
        int turns=Convert.ToInt32(Console.ReadLine());
        while (turns-- > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            Console.WriteLine(countSybarrays(arr));
        }


    }
}