
class Program {
    static void Main(string[] arg)
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        
        int[] population = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int maxCustomers = 0;

        for (int i = 0; i <= N - K; i++)
        {
            int customers = 0;

            for (int j = i; j < i + K; j++)
            {
                customers += population[j];
            }

            if (customers > maxCustomers)
            {
                maxCustomers = customers;
            }
        }
        Console.WriteLine(maxCustomers);
    }
}