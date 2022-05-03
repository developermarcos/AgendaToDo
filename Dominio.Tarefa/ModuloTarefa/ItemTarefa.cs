using System;


namespace Dominio.ToDo.ModuloTarefa
{
    [Serializable]
    public class ItemTarefa
    {
        
        public ItemTarefa(string text)
        {
            this.Titulo=text;
        }

        public string Titulo { get; set; }

        public bool Concluido { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
