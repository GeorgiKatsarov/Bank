using System;
namespace bank
{
    public class Program
    {
        public static void Main()
        {
            var acount1 = new bankAcount("Kendra", 11111111);
            var acount2 = new bankAcount("Kemal", 2222222);
            
            Console.WriteLine($"Acount {acount1.Number} was created for {acount1.Owner} and has a balance of {acount1.Balance}");
            Console.WriteLine($"Acount {acount2.Number} was created for {acount2.Owner} and has a balance of {acount2.Balance}");
            acount1.makeDeposit(123, DateTime.Now, "I love you");
            acount2.makeDeposit(12345, DateTime.Now, "I love you");
            Console.WriteLine($"Acount {acount1.Number} was created for {acount1.Owner} and has a balance of {acount1.Balance}");
            Console.WriteLine($"Acount {acount2.Number} was created for {acount2.Owner} and has a balance of {acount2.Balance}");
            acount1.makeWithdraw(123, DateTime.Now, "I love you");
            acount2.makeWithdraw(12345, DateTime.Now, "I love you");
            Console.WriteLine($"Acount {acount1.Number} was created for {acount1.Owner} and has a balance of {acount1.Balance}");
            Console.WriteLine($"Acount {acount2.Number} was created for {acount2.Owner} and has a balance of {acount2.Balance}");
            Console.WriteLine(acount2.getAcountHistory());
            Console.WriteLine(acount1.getAcountHistory());


        }
    }
}
