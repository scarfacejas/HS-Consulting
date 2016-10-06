using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HS.Consulting.Models
{
    public class Service
    {
        private string _key;

        public string Key
        {
            get { return _key ?? Name; }
            set { _key = value; }
        }

        public string Name { get; set; }
        public bool Selected { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}