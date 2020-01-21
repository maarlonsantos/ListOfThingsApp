using Projeto01.Database;
using Projeto01.Model;
using Projeto01.ViewModel;
using System;
using Xamarin.Forms;

namespace Projeto01.View
{

    public partial class TelaPrincipal : ContentPage
    {
        public Tarefa TarefaEdicao { get; set; }
        
        public TelaPrincipal()
        {
            InitializeComponent();

            BindingContext = new TelaPrincipalViewModel();

            //BtnAdd.Clicked += delegate
            //{
            //    if (TarefaEdicao == null)
            //    {
            //        var tarefa = new Tarefa { Nome = Tarefa.Text, Finalizado = false };

            //        new TarefasDataAcess().SalvarTarefa(tarefa);

            //    }
            //    else
            //    {
            //        TarefaEdicao.Nome = Tarefa.Text;
            //        new TarefasDataAcess().AtualizarTarefa(TarefaEdicao);

            //        TarefaEdicao = null;
            //    }

            //    Tarefa.Text = "";

            //    BindingContext = new TelaPrincipalViewModel();
            //};
        }

        public void ExcluirTarefa(object sender , EventArgs e)
        {
            var tarefa = (((MenuItem)sender).CommandParameter) as Tarefa;

            new TarefasDataAcess().ExcluirTarefa(tarefa);

            BindingContext = new TelaPrincipalViewModel();
        }

        public void EditarTarefa(object sender, EventArgs e)
        {
            var tarefa = (((MenuItem)sender).CommandParameter) as Tarefa;

            Tarefa.Text = tarefa.Nome;

            TarefaEdicao = tarefa;
        }

        public void BtnMudarSituacao(object sender, EventArgs e)
        {
            var tarefa = (((Button)sender).CommandParameter) as Tarefa;

            if(tarefa.Finalizado == true)
            {
                tarefa.Finalizado = false;
                Tarefa.Text = "Aberto";
            }
            else
            {
                tarefa.Finalizado = true;
                Tarefa.Text = "Fechado";
            }
            new TarefasDataAcess().AtualizarTarefa(tarefa);

            BindingContext = new TelaPrincipalViewModel();
        }
    }
}