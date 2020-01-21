using Projeto01.Database;
using Projeto01.Model;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Projeto01.ViewModel
{
    public class TelaPrincipalViewModel : INotifyPropertyChanged
    {
        public Tarefa TarefaAtual { get; set; }
        public List<Tarefa> Tarefas { get; set; }
        public Command SalvarCommand { get; set; }

        public TelaPrincipalViewModel()
        {
            SalvarCommand = new Command(Salvar);
            TarefaAtual = new Tarefa();
            Tarefas = new TarefasDataAcess().GetTarefas();
        }       

        private void Salvar()
        {
            TarefaAtual.Finalizado = false;
            new TarefasDataAcess().SalvarTarefa(TarefaAtual);

            TarefaAtual = new Tarefa();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
 