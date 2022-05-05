using Dominio.ToDo.Compartilhado;
using Dominio.ToDo.ModuloContato;
using Infra.ToDo.Compartilhado;
using Infra.ToDo.Compartilhado.Serializador;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.ToDo.ModuloContato
{
    public class RepositorioContato : RepositorioBaseUnicoArquivo, IRepositorioContato
    {
        public RepositorioContato(DataContext contextBase, ISerializador serializador) : base(contextBase, serializador)
        {
            
            dataContext.Contatos = serializador.CarregarRegistrosDoArquivo().Contatos;

            if (dataContext.Contatos != null && dataContext.Contatos.Count > 0)
                contador = dataContext.Contatos.Max(x => x.Numero);
        }

        public string Editar(Contato registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Contatos.RemoveAll(x => x.Numero == registro.Numero);

                dataContext.Contatos.Add(registro);

                List<Contato> ordenarRegistros = dataContext.Contatos;

                dataContext.Contatos = ordenarRegistros.OrderBy(x => x.Numero).ToList();

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Excluir(Contato registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Contatos.Remove(registro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Inserir(Contato novoRegistro)
        {
            string dadosValidos = novoRegistro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                novoRegistro.Numero = ++contador;

                dataContext.Contatos.Add(novoRegistro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public List<Contato> ObterRegistrosOrdenadoPorCargo()
        {
            List<Contato> contatosOrdenadosPorCargo = dataContext.Contatos;

            contatosOrdenadosPorCargo.Sort((x, y) => string.Compare(x.cargo, y.cargo));

            return contatosOrdenadosPorCargo;
        }

        public List<Contato> SelecionarTodos()
        {
            return dataContext.Contatos.ToList();
        }

        public string ValidaCamposIguais(Contato contatoValidar)
        {
            string registroValido = "REGISTRO_VALIDO";
            foreach (var item in dataContext.Contatos)
            {
                if (contatoValidar.VerificaCamposIguais(item) == true)
                {
                    registroValido = "Campos NOME, EMAIL e TELEFONE devem ser únicos no sistema";
                    break;
                }
            }
            return registroValido;
        }
    }
}
