
namespace Assignment5
{
    // Accept 10 numbers and sort the data in ascending order and display it.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Elements are: {i + 1}");
                int lists= int.Parse(Console.ReadLine());
                list.Add(lists);
            }
            list.Sort();
            foreach (var num in list)
            {
                Console.Write(num+" ");
            }
        }
    }
}
