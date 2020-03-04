using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVfinal.entities
{
    public class Cliente
    {
        int id;
        private string nome;
        private char sexo;
        private string telefone;
        private string email;
        private string nasc;
        private string cpf;

        public Cliente(int id , string nome , char sexo , string telefone , string email , string nasc , string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.sexo = sexo;
            this.telefone = telefone;
            this.email = email;
            this.nasc = nasc;
            this.cpf = cpf;
        }

        public Cliente()
        {

        }

        public int Id { get => this.id; set => this.id = value; }

        public string Nome { get => this.nome; set => this.nome = value; }

        public char Sexo { get => this.sexo; set => this.sexo = value; }

        public string Telefone { get => this.telefone; set => this.telefone = value; }

        public string Email { get => this.email; set => this.email = value; }

        public string Nasc { get => this.nasc; set => this.nasc = value; }

        public string Cpf { get => this.cpf ; set => this.cpf = value; }




    }
}
