using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reist_2021.Connection;
using System.Security.Cryptography;
using System.Text;

namespace Reist_2021.Models
{
    public class Cliente
    {
        public long cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }        
        public string senha { get; set; }
        public long celular { get; set; }
        public string sexo { get; set; }
        //public DateTime nascimento { get; set; }
        public string nascimento { get; set; }
        public Endereco endereco { get; set; }

        public void Inserir()
        {
            Hash hash = new Hash(SHA512.Create());

            using (Database database = new Database())
            {
                string command = string.Format("insert into cliente values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, str_to_date('{7}', '%d/%m/%Y'), {8});",
                    this.cpf, this.nome, this.email, hash.Criptografar(this.senha), this.celular,
                    this.sexo, this.endereco.numero, this.nascimento, this.endereco.cep);
                database.ExecuteCommand(command);
            }
        }
    }
}