using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;


namespace Latency
{
    class PingStatistics
    {
        /// <summary>
        /// PingStatistics is a class who get an list of long, in this case "Pings".
        /// The pings are instantly sorted.
        /// Some basic statistics are computed like the mean, median, variance, standard deviation
        /// and the first/third quartile.
        /// </summary>
        /// <remarks>
        /// All the variable are private, a method is required to obtain them.
        /// </remarks>
        private List<long> pings;
        private List<long> unique_ping;
        private long first_quartile;
        private long third_quartile;
        private double median;
        private double mean;
        private double variance;
        private double std_deviation;

        /// <summary>
        /// Instance PingStatistics class without parameters, all variable are None.
        /// </summary>
        public PingStatistics()
        {
        }

        /// <summary>
        ///  Instance PingStatistics class with Pings as parameters.
        ///  The basics statistics variables are set if the list > 5 pings.
        /// </summary>
        /// <param name="pg">a list of long corresponding as Ping</param>
        public PingStatistics(List<long> pg)
        {
            pings = pg;
            pings.Sort();
            if (pings.Count > 5)
            {
                IdentifyQuartile();
                ComputeMedian();
                ComputeMean();
                ComputeVariance();
                ComputeStdDeviation();
            }
            IdentifyUnique();
        }

        /// <summary>
        /// Method to obtain the list of long : Pings
        /// </summary>
        public List<long> GetPingsValue()
        {
            return pings;
        }

        /// <summary>
        /// Method to obtain the list of unique long : Pings
        /// </summary>
        public List<long> GetUniquePings()
        {
            return unique_ping;
        }

        /// <summary>
        /// Method to obtain the first quartile value of the list Pings
        /// </summary>
        public long GetFirstQuartile()
        {
            return first_quartile;
        }

        /// <summary>
        /// Method to obtain the third quartile  value of the of the list Pings
        /// </summary>
        public long GetThirdQuartile()
        {
            return third_quartile;
        }

        /// <summary>
        /// Method to obtain the mean value of Pings
        /// </summary>
        public double GetMean()
        {
            return mean;
        }

        /// <summary>
        /// Method to obtain the median value of Pings
        /// </summary>
        public double GetMedian()
        {
            return median;
        }

        /// <summary>
        /// Method to obtain the variance value of Pings
        /// </summary>
        public double GetVariance()
        {
            return variance;
        }

        /// <summary>
        /// Method to obtain the standard deviation value of Pings
        /// </summary>
        public double GetStdDeviation()
        {
            return std_deviation;
        }

        /// <summary>
        /// Method to set the list of long : Pings
        /// </summary>
        public void SetPingsValue(List<long> pg)
        {
            pings = pg;
        }

        /// <summary>
        /// Method to identify the value of first and third quartile for the Ping list
        /// </summary>
        private void IdentifyQuartile()
        {
            int index = (int)Math.Ceiling((double)pings.Count / 4) - 1;
            first_quartile = pings[index];
            index = (int)Math.Ceiling((double)3 * pings.Count / 4) - 1;
            third_quartile = pings[index];
        }


        /// <summary>
        /// Method to compute the median of Ping list
        /// </summary>
        private void ComputeMedian()
        {
            if (pings.Count % 2 == 0)
            {
                median = (double)(pings[(pings.Count / 2) - 1] + pings[pings.Count / 2]) / 2;
            }
            else
            {
                median = (double)pings[pings.Count / 2];
            }
        }


        /// <summary>
        /// Method to compute the mean of Ping list
        /// </summary>
        private void ComputeMean()
        {
            double sum = 0;
            foreach (double x in pings)
            {
                sum += x;
            }
            mean = sum / pings.Count;
        }


        /// <summary>
        /// Method to compute the variance of Ping list
        /// </summary>
        private void ComputeVariance()
        {
            double sum = 0;
            foreach (long one_ping in pings)
            {
                sum += (one_ping - mean) * (one_ping - mean);
            }
            variance = sum / pings.Count;
        }


        /// <summary>
        /// Method to compute the standard deviation of Ping list
        /// </summary>
        private void ComputeStdDeviation()
        {

            std_deviation = Math.Sqrt(variance);
        }


        /// <summary>
        /// Method to identify all the uniques values of Pings
        /// </summary>
        private void IdentifyUnique()
        {
            unique_ping = pings.Distinct().ToList();
        }
    }

    class Server
    {
        /// <summary>
        /// Server is a class who contain the name and abbreviation of all the country available 
        /// on the site 'https://public-dns.info/nameserver/'.
        /// This site contain a large address of public DNS all over the world.
        /// </summary>

        public Dictionary<string, string> Country = new Dictionary<string, string>()
        {
            {"Random","rd"},
            { "Albania", "al"},
            { "Algeria", "dz"},
            { "American Samoa", "as"},
            { "Andorra", "ad"},
            { "Angola", "ao"},
            { "Anguilla", "ai"},
            { "Antarctica", "aq"},
            { "Antigua and Barbuda", "ag"},
            { "Argentina", "ar"},
            { "Armenia", "am"},
            { "Australia", "au"},
            { "Austria", "at"},
            { "Azerbaijan", "az"},
            { "Bahamas", "bs"},
            { "Bahrain", "bh"},
            { "Bangladesh", "bd"},
            { "Barbados", "bb"},
            { "Belarus", "by"},
            { "Belgium", "be"},
            { "Belize", "bz"},
            { "Benin", "bj"},
            { "Bermuda", "bm"},
            { "Bhutan", "bt"},
            { "Bolivia", "bo"},
            { "Bosnia and Herzegovina", "ba"},
            { "Botswana", "bw"},
            { "Brazil", "br"},
            { "British Indian Ocean Territory", "io"},
            { "Brunei Darussalam", "bn"},
            { "Bulgaria", "bg"},
            { "Burundi", "bi"},
            { "Cambodia", "kh"},
            { "Cameroon", "cm"},
            { "Canada", "ca"},
            { "Cape Verde", "cv"},
            { "Cayman Islands", "ky"},
            { "Chile", "cl"},
            { "China", "cn"},
            { "Colombia", "co"},
            { "Cook Islands", "ck"},
            { "Costa Rica", "cr"},
            { "Croatia", "hr"},
            { "Cuba", "cu"},
            { "Cyprus", "cy"},
            { "Czech Republic", "cz"},
            { "Côte d'Ivoire", "ci"},
            { "Denmark", "dk"},
            { "Djibouti", "dj"},
            { "Dominica", "dm"},
            {"Dominican Republic", "do"},
            {"Ecuador", "ec"},
            {"Egypt", "eg"},
            {"El Salvador", "sv"},
            {"Equatorial Guinea", "gq"},
            {"Estonia", "ee"},
            {"Ethiopia", "et"},
            {"Fiji", "fj"},
            {"Finland", "fi"},
            {"France", "fr"},
            {"French Polynesia", "pf"},
            {"Gabon", "ga"},
            {"Gambia", "gm"},
            {"Georgia", "ge"},
            {"Germany", "de"},
            {"Ghana", "gh"},
            {"Greece", "gr"},
            {"Greenland", "gl"},
            {"Grenada", "gd"},
            {"Guadeloupe", "gp"},
            {"Guam", "gu"},
            {"Guatemala", "gt"},
            {"Guinea", "gn"},
            {"Guyana", "gy"},
            {"Haiti", "ht"},
            {"Honduras", "hn"},
            {"Hong Kong", "hk"},
            {"Hungary", "hu"},
            {"Iceland", "is"},
            {"India", "in"},
            {"Indonesia", "id"},
            {"Ireland", "ie"},
            {"Israel", "il"},
            {"Italy", "it"},
            {"Jamaica", "jm"},
            {"Japan", "jp"},
            {"Jordan", "jo"},
            {"Kazakhstan", "kz"},
            {"Kenya", "ke"},
            {"Kuwait", "kw"},
            {"Kyrgyzstan", "kg"},
            {"Lao People's Democratic Republic", "la"},
            {"Latvia", "lv"},
            {"Lebanon", "lb"},
            {"Liberia", "lr"},
            {"Liechtenstein", "li"},
            {"Lithuania", "lt"},
            {"Luxembourg", "lu"},
            {"Macao", "mo"},
            {"Macedonia", "mk"},
            {"Malawi", "mw"},
            {"Malaysia", "my"},
            {"Maldives", "mv"},
            {"Malta", "mt"},
            {"Marshall Islands", "mh"},
            {"Martinique", "mq"},
            {"Mauritania", "mr"},
            {"Mauritius", "mu"},
            {"Mexico", "mx"},
            {"Micronesia", "fm"},
            {"Moldova", "md"},
            {"Monaco", "mc"},
            {"Mongolia", "mn"},
            {"Morocco", "ma"},
            {"Mozambique", "mz"},
            {"Myanmar", "mm"},
            {"Namibia", "na"},
            {"Nauru", "nr"},
            {"Nepal", "np"},
            {"Netherlands", "nl"},
            {"New Caledonia", "nc"},
            {"New Zealand", "nz"},
            {"Nicaragua", "ni"},
            {"Nigeria", "ng"},
            {"Niue", "nu"},
            {"Norway", "no"},
            {"Panama", "pa"},
            {"Papua New Guinea", "pg"},
            {"Paraguay", "py"},
            {"Peru", "pe"},
            {"Philippines", "ph"},
            {"Poland", "pl"},
            {"Portugal", ""},
            {"Puerto Rico", "pr"},
            {"Qatar", "qa"},
            {"Romania", "ro"},
            {"Russian Federation", "ru"},
            {"Réunion", "re"},
            {"Saint Kitts and Nevis", "kn"},
            {"Saint Lucia", "lc"},
            {"Saint Pierre and Miquelon", "pm"},
            {"Saint Vincent and the Grenadines", "vc"},
            {"Samoa", "ws"},
            {"Sao Tome and Principe", "st"},
            {"Saudi Arabia", "sa"},
            {"Senegal", "sn"},
            {"Seychelles", "sc"},
            {"Singapore", "sg"},
            {"Slovakia", "sk"},
            {"Slovenia", "si"},
            {"South Africa", "za"},
            {"Spain", "es"},
            {"Sri Lanka", "lk"},
            {"Sudan", "sd"},
            {"Suriname", "sr"},
            {"Swaziland", "sz"},
            {"Sweden", "se"},
            {"Switzerland", "ch"},
            {"Taiwan, Province of China", "tw"},
            {"Tajikistan", "tj"},
            {"Tanzania", "tz"},
            {"Thailand", "th"},
            {"Togo", "tg"},
            {"Tonga", "to"},
            {"Trinidad and Tobago", "tt"},
            {"Tunisia", "tn"},
            {"Ukraine", "ua"},
            {"United Arab Emirates", "ae"},
            {"United Kingdom", "gb"},
            {"United States", "us"},
            {"Uruguay", "uy"},
            {"Uzbekistan", "uz"},
            {"Vanuatu", "vu"},
            {"Venezuela", "ve"},
            {"Viet Nam", "vn"},
            {"Virgin Islands, British", "vg"},
            {"Virgin Islands, U.S.", "vi"},
            {"Wallis and Futuna", "wf"},
            {"Yemen", "ye"},
            {"Zambia", "zm"},
            {"Zimbabwe","zw"}
    };


        public string base_url = "https://public-dns.info/nameserver/";

        public string selectedCounrty = null;

        /// <summary>
        /// Method to select a random Country from the dictionary.
        /// </summary>
        public string GetRandomCountry(List<string> Country)
        {
            Random r = new Random();
            int index = r.Next(Country.Count);
            string randomCountry = Country[index];
            return randomCountry;
        }
    }

    class InternetOperation
    {
        /// <summary>
        /// InternetOperation is a class to perform all the operation of connexion in the program.
        /// This class detect if the computer is related to Google ( Internet ) and
        /// has a method to collect the pings between a computer and an IP address
        /// </summary>

        public bool internet_Status;


        /// <summary>
        /// Method to instance the class.
        /// Performing the detection of connexion to Google and setting internet_Status.
        /// </summary>
        public InternetOperation()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    internet_Status = true;
                }
            }
            catch
            {
                internet_Status = false;
            }
        }

        /// <summary>
        /// Method to collect the Ping between the computer and an IP address.
        /// </summary>
        public long GetPing(string IP_to_test)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(IP_to_test, 1000);
                if (reply != null && reply.RoundtripTime != 0)
                {
                    return reply.RoundtripTime;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
        }
    }

    static class Program
    {
        static MainWindow MainWin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWin = new MainWindow();
            Application.Run(MainWin);
        }
    }
}


