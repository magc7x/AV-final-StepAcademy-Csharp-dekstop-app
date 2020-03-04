using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVfinal.entities
{
    public class Servico
    {
        private int id;
        private string nome;
        private double valor;

        public Servico(int id , string nome , double valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }

        public Servico()
        {

        }


        public int Id { get => this.id; set => this.id = value; }

        public string Nome { get => this.nome; set => this.nome = value; }

        public double Valor { get => this.valor; set => this.valor = value; }

    }
}
