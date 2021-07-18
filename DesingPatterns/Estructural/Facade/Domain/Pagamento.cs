namespace DesingPatterns.Estructural.Facade.Domain
{
    public class Pagamento
    {
        public string CartaoCredito { get; set; }

        public decimal Valor { get; set; }

        public string Status { get; set; }

        public MeioPagamento MeioPagamento { get; set; }

        public string LinhaDigitavelBoleto { get; set; }

        public string ConfirmacaoTransferencia { get; set; }
    }
}
