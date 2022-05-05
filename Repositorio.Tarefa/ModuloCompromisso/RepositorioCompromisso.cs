using Dominio.ToDo.ModuloCompromisso;
using Dominio.ToDo.ModuloContato;
using Infra.ToDo.Compartilhado;
using Infra.ToDo.Compartilhado.Serializador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBaseUnicoArquivo, IRepositorioCompromisso
    {
        public RepositorioCompromisso(DataContext contextBase, ISerializador serializador) : base(contextBase, serializador)
        {
            dataContext.Compromissos = serializador.CarregarRegistrosDoArquivo().Compromissos;

            if (dataContext.Compromissos != null && dataContext.Compromissos.Count > 0)
                contador = dataContext.Compromissos.Max(x => x.Numero);
        }

        public bool ContatoTemCompromisso(Contato contatoInformado)
        {
            if (dataContext.Compromissos.Exists(x => x.contato.Numero == contatoInformado.Numero) == true)
                return true;

            return false;
        }

        public string Editar(Compromisso registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Compromissos.RemoveAll(x => x.Numero == registro.Numero);

                dataContext.Compromissos.Add(registro);

                List<Compromisso> ordenarRegistros = dataContext.Compromissos;

                dataContext.Compromissos = ordenarRegistros.OrderBy(x => x.Numero).ToList();

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Excluir(Compromisso registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Compromissos.Remove(registro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Inserir(Compromisso novoRegistro)
        {
            string dadosValidos = novoRegistro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                novoRegistro.Numero = ++contador;

                dataContext.Compromissos.Add(novoRegistro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime inicio, DateTime fim)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (var item in dataContext.Compromissos)
            {
                if (item.CompromissoFuturo(inicio, fim))
                    compromissosFuturos.Add(item);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (var item in dataContext.Compromissos)
            {
                if (item.CompromissoPassado())
                    compromissosPassados.Add(item);
            }

            return compromissosPassados;
        }

        public List<Compromisso> SelecionarTodos()
        {
            return dataContext.Compromissos.ToList();
        }

        public bool VerificarConflitoCompromissos(Compromisso compromisso)
        {
            foreach (var item in dataContext.Compromissos)
            {
                if (compromisso.VerificaDiasIgual(item.dataCompromisso) == true && compromisso.VerificaHorasEmComplito(item))
                    return true;
            }
            return false;
        }
    }
}
