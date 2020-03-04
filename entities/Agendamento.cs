using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVfinal.entities
{
    public class Agendamento
    {
        private int id;
        private string clienteAgendado;
        private string data;
        private string hora;
        private double valorTotal;
        private List<Servico> servs = new List<Servico>();

        public Agendamento(int id , string cli , string data , string hora , double valorTotal)
        {
            this.id = id;
            this.clienteAgendado = cli;
            this.data = data;
            this.hora = hora;
            this.valorTotal = valorTotal;
        }

        public Agendamento() { }


        public int Id { get => this.id; set => this.id = value; }
        public string ClienteAgendado { get => this.clienteAgendado; set => this.clienteAgendado = value; }
        public string Data { get => this.data; set => this.data = value; }
        public string Hora { get => this.hora; set => this.hora = value; }
        public List<Servico> Servs { get => this.servs; set => this.servs = value; }
        public double ValorTotal { get => this.valorTotal; set => this.valorTotal = value; }

    }
}
