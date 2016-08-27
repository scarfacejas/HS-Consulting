using HS.Consulting.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace HS.Consulting.Data
{
    public class ServiceData
    {
        private readonly Dictionary<string, Service> _services = new Dictionary<string, Service>();
        private static IReadOnlyList<string> _serviceNames;

        public ServiceData()
        {
            var consultancy = new Service
            {
                Name = "Consultancy",
                Description = "Collaborating with clients to ensure their people strategy is aligned with their business goals",
                SubTitle = "Areas",
                Items = new string[] {
                    "Defining core skills and capabilities required to deliver against the business goals",
                    "Helping the leadership team define the company purpose, values and behaviours",
                    "Creating a strong employer brand",
                    "Using this framework to influence & shape all people / HR led initiatives",
                    "Providing counsel on a range of HR and Talent led issues"},
                Testimonial = new Testimonial
                {
                    Client = "Dan Saxby",
                    Company = "CEO iris London ",
                    Caption = "“Niki understands the role of HR and talent in taking the business forward, and more importantly creating great places to work.”"
                }
            };

            _services.Add(consultancy.Name, consultancy);

            if(_serviceNames == null)
                _serviceNames = new ReadOnlyCollection<string>(_services.Keys.ToList());
        }

        public Service GetService(string name)
        {
            var service = _services[name];

            service.Selected = true;

            return service;
        }

        public static IEnumerable<string> ServicesNames
        {
            get { return _serviceNames; }
        }
    }
}