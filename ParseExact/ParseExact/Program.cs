namespace ParseExact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in this type dd | MM | yyyy");
            string date = Console.ReadLine();
            try
            {
                DateTime dateTime = DateTime.ParseExact(date, "dd | MM | yyyy", null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}