using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using APIGetNet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIGetNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("Autenticacao")]
        public async Task<Autenticacao> Autenticacao()
        {
            var data = new Dictionary<string, string>();
            data.Add("scope", "oob");
            data.Add("grant_type", "client_credentials");
            var autenticacao = new Autenticacao();
            using (var client = new HttpClient())
            {
                string APIUrlBase = "https://api-sandbox.getnet.com.br/auth/oauth/v2/token";

                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "basic NjhkMTM1YWMtNmUyZi00M2EwLTkzMmYtNmYzODZmN2NmNTFmOjZmMDE1ZGM3LTA3NDUtNDVhOS1iYTg0LTRmNDE3MzY0MTM4MQ==");

                using (var request = new FormUrlEncodedContent(data))
                {
                    request.Headers.Clear();
                    request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    var response = await client.PostAsync(APIUrlBase, request);
                    autenticacao.StatusCode = response.ToString().Substring(0, 15);

                    string conteudo = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    dynamic result = JsonConvert.DeserializeObject(conteudo);
                    autenticacao.Token_Acesso = result.access_token;
                }
            }

            return autenticacao;
        }

        [HttpPost]
        [Route("Tokenizacao/{Numero_Do_Cartao}")]
        public async Task<Tokenizacao> Tokenizacao(string Numero_Do_Cartao)
        {
            var tokenDeAutoricacao = Autenticacao().Result.Token_Acesso;
            //var data = new Dictionary<string, string>();
            //data.Add("card_number", "5155901222280001");
            //data.Add("customer_id", "customer_21081826");
            object data = new
            {
                // card_number = "5155901222280001",
                card_number = Numero_Do_Cartao,
                customer_id = "customer_21081826"
            };

            var tokenizacao = new Tokenizacao();
            tokenizacao.StatusCode = (tokenDeAutoricacao != null) ? tokenDeAutoricacao : tokenizacao.StatusCode;
            using (var client = new HttpClient())
            {
                string APIUrlBase = "https://api-sandbox.getnet.com.br/v1/tokens/card";

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenDeAutoricacao);
                var jsonObject = JsonConvert.SerializeObject(data);
                using (var request = new StringContent(jsonObject))
                {
                    request.Headers.Clear();
                    request.Headers.Add("Content-Type", "application/json; charset=utf-8");

                    var response = await client.PostAsync(APIUrlBase, request);
                    tokenizacao.StatusCode = response.ToString().Substring(0, 15);

                    string conteudo = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    dynamic result = JsonConvert.DeserializeObject(conteudo.ToString());
                    tokenizacao.Token_Cartao = result.number_token;
                }
            }
            // Numero do Cartão de Credito convertido em token
            return tokenizacao;
        }
    }
}

