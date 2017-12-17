using MyBookshelfData.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyBookshelfData
{
    class GoogleService
    {
        private string _engineId = "015864746960202813867:z2lkut1gd34";
        private string _appKey = "AIzaSyCjiQzY_wrI28eNdjn3G1QtNv0GpLpJrJA";

        public async Task<List<SearchResult>> GetResults(string query)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync($"https://www.googleapis.com/customsearch/v1?q={query}&cx={_engineId}&key={_appKey}");
                var data = JsonConvert.DeserializeObject<Result>(result);

                // Convertion from DTO to Domain Model
                return data.Items.Select(item => new SearchResult
                {
                    Url = item.Link
                }).ToList();
            }
        }
    }
}
