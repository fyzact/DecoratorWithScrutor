using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorWithScrutor.Model
{
    public class NewsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }

    }
}
