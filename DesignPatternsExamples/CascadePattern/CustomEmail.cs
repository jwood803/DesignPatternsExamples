namespace CascadePattern
{
    public class CustomEmail
    {
        public CustomEmail To(string to)
        {
            System.Console.WriteLine("To");
        }

        public CustomEmail From(string from)
        {
            System.Console.WriteLine("From");
        }

        public CustomEmail Subject(string subject)
        {
            System.Console.WriteLine("Subject");
        }

        public CustomEmail MessageBody(string message)
        {
            System.Console.WriteLine("Message");
        }

        public void Send()
        {
            System.Console.WriteLine("Sending...");
        }
    }
}