using Castle.DynamicProxy;
using System.Diagnostics;

namespace Aspect_Oriented_Programming_API.Interceptors
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            // Get the type and name of method
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            // Get the args/parameters of method
            var args = string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()));
            
            Console.WriteLine($"Calling: {name}");
            Console.WriteLine($"Parameters: {args}");

            var watch = Stopwatch.StartNew();
            // Pass control to the method
            invocation.Proceed();
            watch.Stop();
            var executionTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Done: result was {invocation.ReturnValue ?? "void"}");
            Console.WriteLine($"Execution Time: {executionTime} ms.");
        }
    }
}
