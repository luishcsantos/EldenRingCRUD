using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using EldenRingCRUD.Models;
using System.Net.Http;

namespace EldenRingCRUD.Services
{
    public class BossAPIService
    {
        //cria um objeto para acessar páginas 
        private static readonly HttpClient client = new HttpClient();

        //método assíncrono - evita travamentos
        //aguarda a finalização do método
        public async Task<Boss> BuscarBoss(string name)
        {
            string url = $"https://eldenring.fanapis.com/api/bosses?name={name.ToLower()}";

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();

            var obj = JObject.Parse(json);

            var data = obj["data"]?.FirstOrDefault();

            if (data == null)
                return null;

            var boss = new Boss
            {
                Id = data["id"]?.ToString(),
                Name = data["name"]?.ToString(),
                Image = data["image"]?.ToString(),
                Description = data["description"]?.ToString(),
                Location = data["location"]?.ToString(),
                Drops = data["drops"]?.ToString(),
                HealthPoints = data["healthPoints"]?.ToString()
            };

            return boss;
        }
    }
}
