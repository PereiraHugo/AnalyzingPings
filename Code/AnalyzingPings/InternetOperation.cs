using System.Net;
using System.Net.NetworkInformation;

namespace AnalyzingPings
{
    class InternetOperation
    {
        /// <summary>
        /// InternetOperation is a class to perform all the operation of connexion in the programm.
        /// This class detect if the computer is related to google ( internet ) and
        /// has a method to collect the pings beetween a computer and an IP adress
        /// </summary>

        public bool internet_Status;


        /// <summary>
        /// Method to instance the class.
        /// Performing the detection of connnexion to google and setting internet_Status.
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
        /// Method to collect the Ping beetween the computer and an IP adress.
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

}
