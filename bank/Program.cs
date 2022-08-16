using System;
namespace bank
{
    public class Program
    {
        public static void Main()
        {
            bankAcount acount1 = new bankAcount("Jane", 120);
            acount1.makeDeposit(200, DateTime.Now, "Money from grandpa");
            acount1.makeWithdraw(100, DateTime.Now, "I bought some coke");
            acount1.makeDeposit(300, DateTime.Now, "I sold the coke");
            Console.WriteLine(acount1.getAcountHistory());
        }
    }
}
