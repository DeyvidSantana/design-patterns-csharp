namespace RefactoringGuru.Criacionais
{
    class SingletonSeguroThreads
    {
        private SingletonSeguroThreads() { }

        private static SingletonSeguroThreads _instancia;

        // Agora temos um objeto de bloqueio que será usado para sincronizar as threads durante o primeiro acesso ao Singleton 
        private static readonly object _lock = new object();

        public static SingletonSeguroThreads ObterInstancia(string valor)
        {
            // Essa condicional é necessária para evitar que os threads tropecem no bloqueio quando a instância estiver pronta.
            if (_instancia is null)
            {
                /* Agora, imagine que o programa acabou de ser lançado. Como ainda não existe uma instância de Singleton, 
                 * vários threads podem passar simultaneamente pela condicional anterior e atingir esse ponto quase ao mesmo tempo. 
                 * O primeiro deles adquirirá bloqueio e prosseguirá, enquanto o restante aguardará aqui. */
                lock (_lock)
                {
                    /* O primeiro thread a adquirir o bloqueio, atinge o condicional, entra e cria a instância Singleton. 
                     * Uma vez que ele deixa o bloco de bloqueio, um segmento que pode estar esperando pela liberação do bloqueio pode então entrar nesta seção. 
                     * Mas, como o campo Singleton já foi inicializado, o thread não criará um novo objeto. */
                    if (_instancia is null)
                    {
                        _instancia = new SingletonSeguroThreads();
                        _instancia.Valor = valor;
                    }
                }
            }

            return _instancia;
        }

        public string Valor { get; set;  }
    }
}
