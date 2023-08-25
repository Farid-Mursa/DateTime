using Microsoft.VisualBasic;

namespace AddDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter datetime in this type dd/MM/yyyy");
            string date = Console.ReadLine();
            DateTime addedTime = DateTime.ParseExact(date,"dd/MM/yyyy", null).AddDays(30).AddHours(6).AddMinutes(17);
            Console.WriteLine(addedTime.ToString());
            

        }
    }
}