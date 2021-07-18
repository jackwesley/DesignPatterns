namespace DesingPatterns.Estructural.Facade.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
