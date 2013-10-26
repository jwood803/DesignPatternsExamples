namespace CascadePattern
{
    public class CustomEmail
    {
        public CustomEmail To(string to)
        {
            System.Console.WriteLine("To");
            return this;
        }

        public CustomEmail From(string from)
        {
            System.Console.WriteLine("From");
            return this;
        }

        public CustomEmail Subject(string subject)
        {
            System.Console.WriteLine("Subject");
            return this;
        }

        public CustomEmail MessageBody(string message)
        {
            System.Console.WriteLine("Message");
            return this;
        }

        public void Send()
        {
            System.Console.WriteLine("Sending...");
        }
    }
}