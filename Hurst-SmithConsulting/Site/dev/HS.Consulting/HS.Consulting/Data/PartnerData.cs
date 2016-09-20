using HS.Consulting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HS.Consulting.Data
{
    public class PartnerData
    {
        private static IReadOnlyList<Partner> _readOnlyPartners;

        static PartnerData()
        {
            var helenButler = new Partner
            {
                Company = "Helen Butler Coaching",
                Url = "www.helenbutlercoaching.com",
                Caption = "Your most valuable asset is your people, so it’s a no-brainer that you need every single one to be operating at their best and achieving their full potential.<br />I work with the whole spectrum of job roles within agencies because I believe passionately that coaching is not just for senior leadership roles, it can have a dramatic effect on bottom lines at all levels and in all functions, helping to foster a dynamic and collaborative working culture. "
            };
    }
}
}