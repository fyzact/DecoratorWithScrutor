using DecoratorWithScrutor.Interfaces;
using DecoratorWithScrutor.Model;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorWithScrutor.Services
{
    public class CacheNewsService : INewsService
    {
        INewsService _newsService;
        readonly IMemoryCache _memoryCache;
        public CacheNewsService(INewsService newsService, IMemoryCache memoryCache)
        {
            _newsService = newsService;
            _memoryCache = memoryCache;
        }
        public async Task<IEnumerable<NewsDto>> GetNewsAsync()
        {
            string cacheKey = "news";
            _memoryCache.TryGetValue(cacheKey, out IEnumerable<NewsDto> news);
            if (news != null) return news;

            news = await _newsService.GetNewsAsync();
            var cacheExpOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(10)
            };
            _memoryCache.Set(cacheKey, news, cacheExpOptions);

            return news;
        }
    }
}
