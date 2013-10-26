namespace CascadePattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var email = new CustomEmail();

            // Not cascading
            //email.To("Me");
            //email.From("You");
            //email.Subject("Hi");
            //email.MessageBody("Hello there");

            //email.Send();

            email.To("Me")
                 .From("You")
                 .Subject("Hi")
                 .MessageBody("Hello there");

            Console.ReadLine();
        }
    }
}