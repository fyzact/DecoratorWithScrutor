using DecoratorWithScrutor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorWithScrutor.Interfaces
{
    public interface INewsService
    {
        public Task<IEnumerable<NewsDto>> GetNewsAsync();
    }
}
