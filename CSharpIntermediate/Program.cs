using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 - StopWatch
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine($"Duration: {stopWatch.Duration}");

            Console.WriteLine();

            //Exercise 2 - Post
            var post = new Post("This is a title.", "This is a message.");
            post.UpVote();
            post.DownVote();
            post.UpVote();
            Console.WriteLine($"\"{post.Title}\" votes: {post.VoteValue}");

            Console.WriteLine();

            // Exercise 3 - Stack
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine();

            // Exercise 4 - Database
            var instruction = "Instruction for database.";
            var sql = new SqlConnection("SQL Connection String");
            var oracle = new OracleConnection("Oracle Connection String");

            var dbCommand1 = new DbCommand(sql, instruction);
            var dbCommand2 = new DbCommand(oracle, instruction);
            dbCommand1.Execute();
            Console.WriteLine();
            dbCommand2.Execute();

            Console.WriteLine();

            // Exercise 5 - Workflow Engine
            var workflow = new Workflow();

            workflow.Add(new UploadVideo());
            workflow.Add(new SendEmail());
            workflow.Add(new CallWebService());
            workflow.Add(new ChangeStatus());

            var workflowEngine = new WorkflowEngine(workflow);

            workflowEngine.Run();

            Console.WriteLine();
        }
    }
}
