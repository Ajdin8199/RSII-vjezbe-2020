using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WinUI.Properties;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public class APIService
    {
        public string endpoint = $"{Resources.ApiUrl}";
        public string resource;

        public APIService(string resource)
        {
            this.resource = resource;
        }

        public async Task<T> GetAll<T>(object search = null)
        {
            var query = await search?.ToQueryString();
            var list = await $"{endpoint}{resource}?{query}"
                .GetJsonAsync<T>();

            return list;
        }
    }
}
