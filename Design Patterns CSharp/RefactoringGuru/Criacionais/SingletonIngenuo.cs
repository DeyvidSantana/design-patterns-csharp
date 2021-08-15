namespace RefactoringGuru.Criacionais
{
    class SingletonIngenuo
    {
        private SingletonIngenuo(){ }

        private static SingletonIngenuo _instancia;

        public static SingletonIngenuo ObterInstancia()
        {
            if(_instancia is null)
            {
                _instancia = new SingletonIngenuo();
            }

            return _instancia;
        }
    }
}
