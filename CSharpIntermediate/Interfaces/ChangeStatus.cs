using System;

namespace CSharpIntermediate
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status");
        }
    }
}
