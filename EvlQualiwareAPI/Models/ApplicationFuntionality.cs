using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvlQualiwareAPI.Models
{
    public class ApplicationFuntionality
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Capability { get; set; }
        public string Category { get; set; }
        public string AlternateID { get; set; }
        public string UsesInformationName { get; set; }
        public string SystemComponent { get; set; }
        public bool ProvidesStatusFlag { get; set; }
        public bool CapabilityFlag { get; set; }
        public bool ProvidesRead { get; set; }
        public bool ProvidesDelete { get; set; }
        public bool ProvidesUpdate { get; set; }
        public bool ProvidesCreate { get; set; }
    }
}