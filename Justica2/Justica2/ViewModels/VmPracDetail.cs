using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmPracDetail
    {
        public List<PracticeArea> practiceAreas { get; set; }
        public PracticeArea Area { get; set; }
        public List<PracticeAreaName> PracticeAreaNames { get; set; }
        public List<Form> Forms { get; set; }
        public Settings Settings { get; set; }

    }
}
