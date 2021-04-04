using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private IDictionary<string, string> users = new Dictionary<string, string>();

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public bool Login(string email, string password)
        {
            if(middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso.");
                Console.WriteLine("Seja bem-vindo!");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public bool HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            users.TryGetValue(email, out var value);

            return password == value;
        }
    }
}
