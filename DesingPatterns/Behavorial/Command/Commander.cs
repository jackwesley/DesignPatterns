namespace DesingPatterns.Behavorial.Command
{
    //Command Interface 
    public abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
