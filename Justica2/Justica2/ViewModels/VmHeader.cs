using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmHeader
    {
        public Settings Settings { get; set; }
        public List<SettingSocial> SettingSocials { get; set; }
        public List<PracticeArea> PracticeAreas { get; set; }
    }
}
