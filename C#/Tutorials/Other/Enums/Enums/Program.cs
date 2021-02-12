using System;

namespace Enums

{
    public enum ShippingMethod
    {
    RegularAirMail = 1,
    RegisterAirMail = 2,
    Express = 3
    }





    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.RegisterAirMail;

            Console.WriteLine((int)method);

            Console.WriteLine((ShippingMethod)3);

            Console.WriteLine(method);



            var methName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methName)




        }
    }
}
