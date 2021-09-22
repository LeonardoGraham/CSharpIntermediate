using System;

namespace CSharpIntermediate
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
}
