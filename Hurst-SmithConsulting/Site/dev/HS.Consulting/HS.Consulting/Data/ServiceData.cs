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
        private readonly List<Service> _tempServices = new List<Service>();
        private static IReadOnlyList<Service> _readOnlyServices;
        private static bool _initialised = false;

        public ServiceData()
        {
            var consultancy = new Service
            {
                Name = "Consultancy",
                Description = "Collaborating with clients to ensure their people strategy is aligned with their business goals",
                SubTitle = "Areas",
                ImageUrl="servicesmainbanner_consultancy_1x.svg",
                Items = new string[] {
                    "Defining core skills and capabilities required to deliver against the business goals",
                    "Helping the leadership team define the company purpose, values and behaviours",
                    "Creating a strong employer brand",
                    "Using this framework to influence & shape all people / HR led initiatives",
                    "Providing counsel on a range of HR and Talent led issues"},
                Testimonial = new Testimonial
                {
                    Client = "Dan Saxby",
                    Company = "CEO iris London",
                    Caption = "“Niki understands the role of HR and talent in taking the business forward, and more importantly creating great places to work.”"
                }
            };

            var talent = new Service
            {
                Name = "Talent Attraction",
                Description = "Ensuring there is a strategically lead approach to attracting the best talent including",
                SubTitle = "Areas",
                ImageUrl = "servicesmainbanner_talentattraction_1x.svg",
                Items = new string[] {
                    "Talent audits / succession planning",
                    "Effective recruitment, interview and offer process",
                    "PSL Management",
                    "Maximising the effectiveness of direct sourcing"},
                Testimonial = new Testimonial
                {
                    Client = "Dan Saxby",
                    Company = "CEO iris London",
                    Caption = "“Niki's a real people person that understands client pressures, agency culture, future planning and tangible progress. She's got a big brain of knowledge that other agencies big and small can benefit from.”"
                }
            };

            var engagement = new Service
            {
                Name = "Engagement",
                Description = "A focus on retention is critical commercially, and also if it’s important to you to have a happy workforce. We’ll work with you to ensure your employer brand is working effectively to drive employee engagement.  We’ll help you unpick what’s working, what needs to change and recommend areas of focus longer-term. We can review progress year on year to ensure you are seeing positive change.",
                SubTitle = string.Empty,
                ImageUrl = "servicesmainbanner_engagement_1x.svg",
                Items = new string[0],
                Testimonial = new Testimonial
                {
                    Client = "Craig Wheeler",
                    Company = "MD WDMP",
                    Caption = "“We have a long-standing partnership with Niki, she worked as our head of people for a number of years and we have subsequently worked with Hurst-Smith Consulting over the last year. During our time as Head of People she supported the leadership team through a period of significant business change. She is adept at flexing her style to reflect the business or individual need.  She worked across the full HR and Talent remit, and during her time ensured we had a programme of activity to attract and retain the best talent. Having worked in agencies all her career, she understands the role of HR and talent in taking the business forward, and more importantly creating great places to work.  More recently we have worked with Niki on building our team and managing a tupe transfer.  Niki is very personable, dedicated and goes the extra mile to help you find the right solution for your needs. It helps that she is sensitive to the wider implications of HR discussions on your wider business.”"
                }
            };

            _services.Add(consultancy.Name, consultancy);
            _services.Add(talent.Name, talent);
            _services.Add(engagement.Name, engagement);

            if (!_initialised)
            {
                _tempServices.Add(consultancy);
                _tempServices.Add(talent);
                _tempServices.Add(engagement);
            }

            if (_serviceNames == null)
                _serviceNames = new ReadOnlyCollection<string>(_services.Keys.ToList());

            if (!_initialised)
            {
                _readOnlyServices = new ReadOnlyCollection<Service>(_tempServices);
                _initialised = true;
            }
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

        public static IEnumerable<Service> Services
        {
            get { return _readOnlyServices; }
        }
    }
}