using ContaBancariaComExcecao.Entities;
using ContaBancariaComExcecao.Entities.Exeptions;
using System.Globalization;

namespace ContaBancariaComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int name = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("WithDraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(name, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(withDraw);
                Console.WriteLine(acc);
            }
            catch (DomainExeptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}