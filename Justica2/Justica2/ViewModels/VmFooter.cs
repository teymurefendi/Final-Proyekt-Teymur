using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmFooter
    {
        public Settings Settings { get; set; }
        public List<SettingSocial> SettingSocials { get; set; }
        public List<PracticeArea> PracticeAreas { get; set; }
        //public List<Subscribe> Subscribe { get; set; }
        public Subscribe Subscribe1 { get; set; }
    }
}
