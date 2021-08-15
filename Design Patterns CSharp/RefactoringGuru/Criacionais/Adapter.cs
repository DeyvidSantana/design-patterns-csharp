namespace RefactoringGuru.Criacionais
{
    // O Alvo define a interface específica do domínio usada pelo código do cliente.
    public interface ITarget
    {
        string ObterRequisicao();
    }

    class Adaptee
    {
        public string ObterRequisicaoEspecifica()
        {
            return "Requisição específica.";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string ObterRequisicao()
        {
            return $"Esta é a '{this._adaptee.ObterRequisicaoEspecifica()}'";
        }
    }
}
