using AgendaToDo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace AgendaToDo.ConsoleApp.ModuloContato
{
    public class TelaContato : TelaBase, ICadastroBase
    {
        RepositorioContato repositorioContato;
        Notificador notificador;
        public TelaContato(Notificador notificador,RepositorioContato repositorioContato) : base("Tela Contato")
        {
            this.repositorioContato = repositorioContato;
            this.notificador = notificador;
        }

        public override string ApresentarMenu()
        {
            string opcaoSelecionada;

            MostrarTitulo(this.titulo);

            Console.WriteLine("Digite 1 para Cadastrar");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Visualizar Ordenado Cargo");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando Contato");

            bool temContatoCadastrado = VisualizarRegistros("Pesquisando");

            if (temContatoCadastrado == false)
            {
                notificador.ApresentarMensagem("Nenhum contato cadastrado para poder editar", TipoMensagem.Atencao);
                return;
            }

            int numeroContato = ObterNumeroCaixa();

            Contato contatoAtualizado = ObterContato();

            string mensagemValidacao = repositorioContato.Editar(numeroContato, contatoAtualizado);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Contato editado com sucesso!", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem("Contato não editado, erro na validação dos campos", TipoMensagem.Erro);

        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo Contato");

            bool temContatoCadastrado = VisualizarRegistros("Pesquisando");

            if (temContatoCadastrado == false)
            {
                notificador.ApresentarMensagem("Nenhum contato cadastrado para poder excluir", TipoMensagem.Atencao);
                return;
            }

            int numeroCaixa = ObterNumeroCaixa();

            repositorioContato.Excluir(numeroCaixa);

            notificador.ApresentarMensagem("Caixa excluída com sucesso", TipoMensagem.Sucesso);
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo novo contato");

            Contato novoContato = ObterContato();

            string mensagemValidacao = repositorioContato.Inserir(novoContato);

            if(mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Contato inserido com sucesso!", TipoMensagem.Sucesso);
            
            else
                notificador.ApresentarMensagem("Contato não inserido, erro na validação dos campos", TipoMensagem.Erro);
        }

        public bool VisualizarRegistros(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de Contato");

            List<Contato> contatos = repositorioContato.ObterTodosRegistros();

            if (contatos.Count == 0)
                return false;

            foreach (Contato contato in contatos)
            {
                Console.WriteLine(contato.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public bool VisualizarRegistrosOrdenador(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Contato");

            List<Contato> contatos = repositorioContato.ObterRegistrosOrdenadoPorCargo();

            if (contatos.Count == 0)
                return false;

            string cargo = "";

            foreach (Contato contato in contatos)
            {
                if (contato.cargo != cargo)
                {
                    cargo = contato.cargo;
                    Console.WriteLine("Cargo "+cargo);
                }
                Console.WriteLine(contato.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public void PopularContatos()
        {
            Contato contato1 = new Contato("Marcos", "m@m.com", "(49)99999-0000", "google", "Team leader");
            Contato contato2 = new Contato("Joao", "j@m.com", "(49)44444-0000", "google", "Caixa");
            Contato contato3 = new Contato("Ana", "a@m.com", "(49)55555-0000", "google", "Gerente");
            Contato contato4 = new Contato("Bruna", "b@m.com", "(49)77777-0000", "google", "Caixa");
            Contato contato5 = new Contato("Zé", "z@m.com", "(49)11111-0000", "google", "Cozinheiro");

            repositorioContato.Inserir(contato1);
            repositorioContato.Inserir(contato2);
            repositorioContato.Inserir(contato3);
            repositorioContato.Inserir(contato4);
            repositorioContato.Inserir(contato5);
        }


        #region métodos privados

        private Contato ObterContato()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nO email deve ser informado seguindo o seguinte padrão (conta@dominio.com)");
            Console.Write("\nDigite o email : ");
            string email = Console.ReadLine();

            Console.Write("\nO telefone deve ser informado seguindo o seguinte padrão (00)00000-0000");
            Console.Write("\nDigite o telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite a empresa: ");
            string empresa = Console.ReadLine();

            Console.Write("Digite o cargo: ");
            string cargo = Console.ReadLine();

            
            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            return contato;
        }

        private int ObterNumeroCaixa()
        {
            int numeroContato;
            bool numeroContatoEncontrado;

            do
            {
                Console.Write("Digite o número do contato que deseja editar: ");
                numeroContato = Convert.ToInt32(Console.ReadLine());

                numeroContatoEncontrado = repositorioContato.RegistroExiste(numeroContato);

                if (numeroContatoEncontrado == false)
                    notificador.ApresentarMensagem("Número do contato não encontrado, digite novamente", TipoMensagem.Atencao);

            } while (numeroContatoEncontrado == false);
            return numeroContato;
        }

        #endregion


    }
}
