using HS.Consulting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HS.Consulting.Data
{
    public class TestimonialData
    {
        private static readonly Testimonial[] _testimonials;
        private static readonly int _testimonialCount;

        static TestimonialData()
        {
            _testimonials = new [] {
                new Testimonial
                {
                    Client = "Dan Saxby",
                    Company = "CEO iris London",
                    Caption = "“Niki understands the role of HR and talent in taking the business forward, and more importantly creating great places to work.”"
                },
                new Testimonial
                {
                    Client = "Craig Wheeler",
                    Company = "MD WDMP",
                    Caption = "“We have a long-standing partnership with Niki, she worked as our head of people for a number of years and we have subsequently worked with Hurst-Smith Consulting over the last year. During our time as Head of People she supported the leadership team through a period of significant business change. She is adept at flexing her style to reflect the business or individual need.  She worked across the full HR and Talent remit, and during her time ensured we had a programme of activity to attract and retain the best talent. Having worked in agencies all her career, she understands the role of HR and talent in taking the business forward, and more importantly creating great places to work.  More recently we have worked with Niki on building our team and managing a tupe transfer.  Niki is very personable, dedicated and goes the extra mile to help you find the right solution for your needs. It helps that she is sensitive to the wider implications of HR discussions on your wider business.”"
                },
                new Testimonial
                {
                    Client = "John Slater",
                    Company = "Managing Director Naked Ideas",
                    Caption = "“Naked Ideas is a small, but fast growing creative agency with a smart and highly focussed workforce. Niki joined us in 2015 to fulfil a full spectrum of HR and people-related functions. Her experience has proved invaluable. She has implemented a wide variety of schemes for us to better streamline and improve our hiring processes, looking at staff attraction and retention initiatives as well as encouraging learning and fostering the skills and interests of our existing staff base. She’s very driven and an absolute pleasure to work with.”"
                },
                new Testimonial
                {
                    Client = "Dan Saxby",
                    Company = "CEO iris London",
                    Caption = "“Niki's a real people person that understands client pressures, agency culture, future planning and tangible progress. She's got a big brain of knowledge that other agencies big and small can benefit from.”"
                },
                new Testimonial
                {
                    Client = "Georgia Oatway",
                    Company = "HR Manager Stott & May",
                    Caption = "“Niki has been working in a consulting capacity with Stott and May for a few months now as we needed an external facilitator to help us put together a strategy and plan specifically within our People and Performance team. Niki’s approach so far has been incredibly insightful and even after the first session of brainstorming and planning, we came away feeling like we’d started to get clarity. Whilst approaching things in a professional manner, Niki is also very personable and whether it be group or one to one work, she creates a relaxed environment that enables people to think and innovate.”"
                }
            };

            _testimonialCount = _testimonials.Count();
        }

        public static IEnumerable<Testimonial> Testimonials
        {
            get { return _testimonials; }
        }

        public static Testimonial Random
        {
            get
            {
                var random = new Random();

                return _testimonials[random.Next(_testimonialCount)];
            }
        }
    }
}