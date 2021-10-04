using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reist_2021.Connection;

namespace Reist_2021.Models
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }

        public void Inserir()
        {
            using(Database database = new Database())
            {
                string command = string.Format("insert into cliente values('{0}', '{1}');", this.nome, this.email);
                database.ExecuteCommand(command);
            }
        }
    }
}