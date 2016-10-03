using HS.Consulting.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace HS.Consulting.Data
{
    public class PartnerData
    {
        private static IReadOnlyList<Partner> _readOnlyPartners;

        static PartnerData()
        {
            var masterTheArt = new Partner
            {
                Company = "Master the Art",
                Url = "mastertheart.co.uk/",
                ImageUrl = "http://mastertheart.co.uk/wp-content/uploads/2015/10/logo_header.png",
                Caption = "Helping agencies win more business through improved communication and presentation skills. Master the Art provide presentation and communication skills training specifically for those working in an agency environment. We offer a range of affordable bite-size, half-day or full-day, group or individual sessions that are tailored to each agency’s needs."
            };

            var helenButler = new Partner
            {
                Company = "Helen Butler Coaching",
                Url = "www.helenbutlercoaching.com/",
                Caption = "Your most valuable asset is your people, so it’s a no-brainer that you need every single one to be operating at their best and achieving their full potential.<br /><br />I work with the whole spectrum of job roles within agencies because I believe passionately that coaching is not just for senior leadership roles, it can have a dramatic effect on bottom lines at all levels and in all functions, helping to foster a dynamic and collaborative working culture. "
            };

            _readOnlyPartners = new ReadOnlyCollection<Partner>(new[] { masterTheArt, helenButler });
        }

        public static IReadOnlyList<Partner> Partners
        {
            get { return _readOnlyPartners; }
        }
    }
}