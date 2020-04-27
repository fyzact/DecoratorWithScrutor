using DecoratorWithScrutor.Interfaces;
using DecoratorWithScrutor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorWithScrutor.Services
{
    public class NewsService : INewsService
    {
        public async Task<IEnumerable<NewsDto>> GetNewsAsync()
        {
            string text = await System.IO.File.ReadAllTextAsync(@"AppData\news.json");
            IEnumerable<NewsDto> news=  JsonConvert.DeserializeObject<IEnumerable<NewsDto>>(text);
            return news;
        }
    }
}
