namespace DesingPatterns.Behavorial.Observer
{
    //Observer
    public interface IObservador
    {
        public string Nome { get; set; }
        void Notificar(Investimento investimento);
    }
}
