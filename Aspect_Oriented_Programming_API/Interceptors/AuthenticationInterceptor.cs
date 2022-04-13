using Castle.DynamicProxy;

namespace Aspect_Oriented_Programming_API.Interceptors
{
    public class AuthenticationInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            // Get the type and name of method
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            Console.WriteLine($"Calling: {name}");

            Console.WriteLine("Authentication service started");
            Thread.Sleep(1000); // Wait 1 second

            // Throw random error if random number is 0
            int randomNumber = new Random().Next(0, 2);
            if (randomNumber == 0)
                throw new UnauthorizedAccessException("You don't have access to this module");

            Console.WriteLine("Authorization successfull");

            // Pass control to the method
            invocation.Proceed();

            Console.WriteLine($"Done: result was {invocation.ReturnValue ?? "void"}");
        }
    }
}
