using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace Reist_2021.Models
{
    public class Endereco
    {
        public string cep { get; set;}
        public string uf { get; set;}
        public string cidade { get; set;}
        public string bairro { get; set;}
        public string logradouro { get; set;}
        public string numero { get; set;}
    }

    /*static class Test
    {
        static async Task<Endereco> Teste()
        {
            HttpClient client = new HttpClient();
            Endereco endereco1 = new Endereco();
            client.BaseAddress = new Uri("https://brasilapi.com.br");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/api/cep/v1/02984010").Result;

            if (response.IsSuccessStatusCode)
            {
                var endereco = response.Content.ReadAsAsync<Endereco>();
                endereco1 = endereco;
            }

            endereco1 = endereco;
            return endereco;
        }
    }*/
}