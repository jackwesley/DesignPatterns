namespace DesingPatterns.Adapter
{
    public class ExecucaoAdapter
    {
        //Para fins didaticos estamos passando tudo com o new. Mas isso tudo em um cenário real
        //é resolvido via injeção de dependencia e fica muito mais elegante.
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}
