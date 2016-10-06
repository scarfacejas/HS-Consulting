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
                ImageUrl = "servicesmainbanner_consultancy_1x.svg",
                Items = new string[] {
                    "Defining core skills and capabilities required to deliver against the business goals",
                    "Helping the leadership team define the company purpose, values and behaviours",
                    "Creating a strong employer brand",
                    "Using this framework to influence & shape all people / HR led initiatives",
                    "Providing counsel on a range of HR and Talent led issues"}
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
                    "Maximising the effectiveness of direct sourcing"}
            };

            var engagement = new Service
            {
                Name = "Engagement",
                Description = "A focus on retention is critical commercially, and also if it’s important to you to have a happy workforce. We’ll work with you to ensure your employer brand is working effectively to drive employee engagement.  We’ll help you unpick what’s working, what needs to change and recommend areas of focus longer-term. We can review progress year on year to ensure you are seeing positive change.",
                SubTitle = string.Empty,
                ImageUrl = "servicesmainbanner_engagement_1x.svg",
                Items = new string[0]
            };

            var outsourcedHr = new Service
            {
                Name = "Outsourced HR",
                Description = "Tailored by client needs, but we essentially take care of all HR initiatives, and more importantly, ensure they are all working bottom up to deliver against the business goals, support the company’s values and build the culture.",
                SubTitle = "Areas",
                ImageUrl = "servicesmainbanner_hr_1x.svg",
                Items = new string[] {
                    "All employee documentation",
                    "Advice and mediation for sensitive employee issues",
                    "Appraisal systems (including online portals)",
                    "Performance management",
                    "Cultural & social initiatives"}
            };

            var employeeBenefits = new Service
            {
                Name = "Employee Benefits",
                Description = "It’s important to have a bespoke and flexible benefits package that can be adapted as businesses grow, and which, more importantly stands out from the crowd. We’ll ensure you have the best benefits package in place for now and the future and help you implement it.",
                SubTitle = string.Empty,
                ImageUrl = "servicesmainbanner_benefits_1x.svg",
                Items = new string[0]
            };

            var training = new Service
            {
                Key = "Training",
                Name = "Training, Development and Coaching",
                Description = "Before we create a bespoke training and development programme we’ll work with you to be clear on the key skills and capabilities you need in the business, now and going forwards, and highlight any key gaps you may have.",
                SubTitle = "Key Expertise",
                ImageUrl = "servicesmainbanner_training_1x.svg",
                Items = new string[] {
                    "Bespoke training programmes by level and department (client servicing, PM, tech, creative)",
                    "Creating a calendar of ‘learning events’ both internal and external",
                    "On-going coaching and mentoring",
                    "Creative ways to coach, train and develop that reflect the needs of our industry"}
            };

            _services.Add(consultancy.Key, consultancy);
            _services.Add(talent.Key, talent);
            _services.Add(engagement.Key, engagement);
            _services.Add(outsourcedHr.Key, outsourcedHr);
            _services.Add(employeeBenefits.Key, employeeBenefits);
            _services.Add(training.Key, training);

            if (!_initialised)
            {
                _tempServices.Add(consultancy);
                _tempServices.Add(talent);
                _tempServices.Add(engagement);
                _tempServices.Add(outsourcedHr);
                _tempServices.Add(employeeBenefits);
                _tempServices.Add(training);
            }

            if (!_initialised)
            {
                _readOnlyServices = new ReadOnlyCollection<Service>(_tempServices);
                _initialised = true;
            }
        }

        public Service GetService(string key)
        {
            var service = _services[key];

            service.Selected = true;

            return service;
        }

        public static IReadOnlyList<Service> Services
        {
            get { return _readOnlyServices; }
        }
    }
}
