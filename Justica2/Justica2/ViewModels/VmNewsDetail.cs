using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmNewsDetail
    {
        public List<News> News { get; set; }
        public News New { get; set; }
        public List<NewsName> NewsNames { get; set; }
    }
}
