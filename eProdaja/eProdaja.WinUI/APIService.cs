using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public class APIService
    {
        public string endpoint = $"{WinUI.Properties.Resources.ApiUrl}";
        public string resource;

        public APIService(string resource)
        {
            this.resource = resource;
        }

        public async Task<T> GetAll<T>(object search = null)
        {
            var query = await search?.ToQueryString();

            var list = await $"{endpoint}{resource}?{query}".GetJsonAsync<T>();

            return list;
        }

        public async Task<T> Post<T>(object obj)
        {
            return await $"{endpoint}{resource}".PostJsonAsync(obj).ReceiveJson<T>();
        }
    }
}
