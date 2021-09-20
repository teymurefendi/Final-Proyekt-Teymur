using Justica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmHome
    {
        public List<PracticeArea> PracticeAreas { get; set; }
        public PracticeArea PracticeArea { get; set; }
        public List<PracticeAreaName> PracticeAreaNames { get; set; }
        public VmPractice VmPractice { get; set; }
        public List<Law> Laws { get; set; }
        public Our Our { get; set; }
        public List<OurPart> OurParts { get; set; }
        public List<AllPracticeAreas> AllPracticeAreas { get; set; }
        public WhatWeDid WhatWeDid { get; set; }
        public List<WeDidPart> WeDidParts { get; set; }
        public List<Team> Teams { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<News> News { get; set; }
    }
}
