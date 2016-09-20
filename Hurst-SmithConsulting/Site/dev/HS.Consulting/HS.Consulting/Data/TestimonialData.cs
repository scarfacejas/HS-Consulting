using HS.Consulting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HS.Consulting.Data
{
    public class TestimonialData
    {
        private static int _serviceCount;

        static TestimonialData()
        {
            _serviceCount = ServiceData.Services.Count();
        }

        public static Testimonial Random
        {
            get
            {
                var random = new Random();

                return ServiceData.Services[random.Next(_serviceCount)].Testimonial;
            }
        }
    }
}