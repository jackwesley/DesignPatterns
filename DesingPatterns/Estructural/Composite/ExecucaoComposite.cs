namespace DesingPatterns.Estructural.Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado");

            var usuarioFormErro = new Mensagem("O usuario informou nome invalido");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracters");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir numero");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro do usuario");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O email informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
