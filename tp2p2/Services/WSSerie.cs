using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using tp2p2.Models;

namespace tp2p2.Services
{
    public class WSSerie : ISerie
    {

        public static HttpClient client = new HttpClient();

        public WSSerie(String URL)
        {
            // Update Port # in the following line.
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("aplication/json"));
        }
        public async Task<List<Serie>> GetSeriesAsync()
        {
            try
            {
                return await client.GetFromJsonAsync<List<Serie>>("api/serie");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> PutSeriesAsync(Serie seriemodif)
        {
            try
            {
                return await client.PutAsJsonAsync<Serie>("/api/serie", seriemodif);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> PostSeriesAsync(Serie seriemodif)
        {
            try
            {
                return await client.PostAsJsonAsync<Serie>("/api/serie", seriemodif);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> DeleteSeriesAsync(String nomControleur)
        {
            try
            {
                return await client.DeleteAsync(nomControleur);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<List<Serie>> GetDevisesAsync(string nomControleur)
        {
            throw new NotImplementedException();
        }

        
        
    }
}
