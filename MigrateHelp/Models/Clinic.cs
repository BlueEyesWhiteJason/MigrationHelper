using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrateHelp.Models
{
    public class Clinic
    {
        public string url { get; set; }
        public string fullAddress { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string add1 { get; set; }
        public string add2 { get; set; }
        public string city { get; set; }
        public string googUrl { get; set; }
        public string embedUrl { get; set; }
        public string days1 { get; set; }
        public string days2 { get; set; }
        public string hours1 { get; set; }
        public string hours2 { get; set; }
        public string hours3 { get; set; }
        public string hours4 { get; set; }
        public string ampm1 { get; set; }
        public string ampm2 { get; set; }
        public string ampm3 { get; set; }
        public string ampm4 { get; set; }
        public string busName { get; set; }
        public string geotag { get; set; }
        public bool multiDay { get; set; }

        public List<string> banners { get; set; }

        public Clinic()
        {

        }

        public Clinic(string url, string phone, string fax, string add1, string add2,
            string city, string googUrl, string embedUrl, string days1, string days2,
        string hours1,
        string hours2,
        string hours3,
        string hours4,
        string ampm1,
        string ampm2,
        string ampm3,
        string ampm4,
        string busName,
        string geotag,
        bool multiDay,
        List<string> banners
        )
        {
            this.add1 = add1;
            this.add2 = add2;
            this.ampm1 = ampm1;
            this.ampm2 = ampm2;
            this.ampm3 = ampm3;
            this.ampm4 = ampm4;
            this.city = city;
            this.days1 = days1;
            this.days2 = days2;
            this.embedUrl = embedUrl;
            this.fax = fax;
            this.phone = phone;
            this.url = url;
            this.hours1 = hours1;
            this.hours2 = hours2;
            this.hours3 = hours3;
            this.hours4 = hours4;
            this.googUrl = googUrl;
            this.busName = busName;
            this.geotag = geotag;
            this.multiDay = multiDay;
            this.banners = banners;

            //Make string for insert full address
            //char[] MyChar = { ',', '.', '/'};

            string fa = (add1 + '+' + city.Replace(",", "")).Trim();

            this.fullAddress = fa.Replace(' ', '+');

            //this.fullAddress = add1 +add2


        }
    }


}
