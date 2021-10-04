using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using Reist_2021.Connection;
using MySql.Data.MySqlClient;

namespace Reist_2021.Models
{
    public class Usuario
    {
        public int id { get; set;}
        public string username { get; set; }
        public string senha { get; set; }
        public int nivel { get; set; }

        public void Inserir()
        {
            Hash hash = new Hash(SHA512.Create());


            using (Database database = new Database())
            {
                string command = string.Format("insert into usuario values(default, '{0}', '{1}', {2});", this.username,
                    hash.Criptografar(this.senha), this.nivel);
                database.ExecuteCommand(command);
            }
        }

        /*static public string teste()
        {
            using (Database database = new Database())
            {
                string command = string.Format("select * from usuario where id = 2;");
                MySqlDataReader reader = database.ReturnCommand(command);
                reader.Read();

                return reader["senha"].ToString();
            }
        }*/
    }

    public class Hash
    {
        private HashAlgorithm algorithm;
        public Hash(HashAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        //
        public string Criptografar(string senha)
        {
            var codificado = Encoding.UTF8.GetBytes(senha);
            var criptografado = this.algorithm.ComputeHash(codificado);

            var builder = new StringBuilder();
            foreach (var caracter in criptografado)
            {
                builder.Append(caracter.ToString("X2"));
            }

            return builder.ToString();
        }

        //
        public bool Verificar(string senhaDigitada, string senhaCodificada)
        {
            return this.Criptografar(senhaDigitada) == senhaCodificada;
        }
    }
}