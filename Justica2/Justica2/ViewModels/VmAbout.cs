using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmAbout
    {
        public Legal Legal { get; set; }
        public Our Our { get; set; }
        public List<OurPart> OurParts { get; set; }
    }
}
