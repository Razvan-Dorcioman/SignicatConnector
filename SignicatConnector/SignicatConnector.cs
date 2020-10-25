using Newtonsoft.Json;
using SignicatConnector.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SignicatConnector
{
    class SignicatConnector
    {
        const string identificationSession = "https://api.idfy.io";
        public static string ClientId { get; private set; }
        public static string ClientSecret { get; private set; }

        public SignicatConnector(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        private static async Task<TokenModel> GetToken()
        {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(identificationSession);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("client_id", ClientId),
                        new KeyValuePair<string, string>("client_secret", ClientSecret),
                        new KeyValuePair<string, string>("grant_type", "client_credentials"),
                        new KeyValuePair<string, string>("scope", "identify")
                    });

                    var response = await client.PostAsync("/oauth/connect/token", formContent);
                    response.EnsureSuccessStatusCode();

                    string resJson = await response.Content.ReadAsStringAsync();
                    TokenModel token = JsonConvert.DeserializeObject<TokenModel>(resJson);

                    return token;
                }
        }

        private static async Task<SessionModel> CreateSession()
        {
            try
            {
                var token = await GetToken();

                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(identificationSession);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.Token_type, token.Access_token);

                    var jsonText = File.ReadAllText(Environment.CurrentDirectory + "/SessionBody.json");

                    var content = new StringContent(jsonText, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("/identification/v2/sessions", content);
                    response.EnsureSuccessStatusCode();

                    string resJson = await response.Content.ReadAsStringAsync();
                    SessionModel session = JsonConvert.DeserializeObject<SessionModel>(resJson);

                    return session;
                }
            }
            catch (Exception e)
            {
                //TODO: Log the error
                return null;
            }
        }

        public async Task<bool> OpenDashboard()
        {
            SessionModel session = await CreateSession();

            if(session != null)
            {
                Process.Start(new ProcessStartInfo(session.url) { UseShellExecute = true });
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
