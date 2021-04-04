using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("12345678"))
            {
                Console.WriteLine("Atenção! Senha muito fraca.");
                return true;
            }

            return CheckNext(email, password);
        }
    }
}
