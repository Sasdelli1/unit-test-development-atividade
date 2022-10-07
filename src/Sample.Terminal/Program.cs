using Sample.Extensions;
using System;

namespace Sample.Terminal
{
    class Program
    {
        static void Main()
        {
            //var dateNow = DateTime.Now;
            //double valuePayment = 100.54;
            var emailValue = "teste.teste.com";

            //Console.WriteLine(dateNow.ToStringShortPtBR());
            //Console.WriteLine(valuePayment.ToStringMoneyPtBR());
            Console.WriteLine(emailValue.IsValidMail());
        }
    }
}
