using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Hypoom.Spotify
{
    public class Connector
    {
        public Connector() {
            Debug.WriteLine("Spotify API");
            AccessToken token = GetToken().Result;
            Debug.WriteLine($"Access Token: {token.access_token}");
        }

        static async Task<AccessToken> GetToken()
        {
            Console.WriteLine("Getting Token");
            const string clientId = "YOUR CLIENT ID";
            const string clientSecret = "YOUR CLIENT SECRET";
            string credentials = $"{clientId}:{clientSecret}";

            using (var client = new HttpClient())
            {
                //Define Headers
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

                //Prepare Request Body
                List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                };

                FormUrlEncodedContent requestBody = new FormUrlEncodedContent(requestData);

                //Request Token
                var request = await client.PostAsync("https://accounts.spotify.com/api/token", requestBody);
                var response = await request.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AccessToken>(response);
            }
        }
    }
}