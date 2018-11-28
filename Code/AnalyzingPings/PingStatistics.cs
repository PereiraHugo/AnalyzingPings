using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzingPings
{
    public class PingStatistics
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
            unique_ping = IdentifyUnique(pings);
            if (pings.Count > 5)
            {
                first_quartile = IdentifyFirstQuartile(pings);
                third_quartile = IdentifyThirdQuartile(pings);
                median = ComputeMedian(pings);
                mean = ComputeMean(pings);
                variance = ComputeVariance(pings);
                std_deviation = ComputeStdDeviation(pings);
            }
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
        public long IdentifyFirstQuartile(List<long> listofpings)
        {
            int index = (int)Math.Ceiling((double)listofpings.Count / 4) - 1;
            long first_quartile = listofpings[index];
            return(first_quartile);
        }

        /// <summary>
        /// Method to identify the value of first and third quartile for the Ping list
        /// </summary>
        public long IdentifyThirdQuartile(List<long> listofpings)
        {
            int index = (int)Math.Ceiling((double)3 * listofpings.Count / 4) - 1;
            long third_quartile = listofpings[index];
            return(third_quartile);
        }


        /// <summary>
        /// Method to compute the median of Ping list
        /// </summary>
        public double ComputeMedian(List<long> listofpings)
        {
            double median;

            if (listofpings.Count % 2 == 0)
            {
                median = (double)(listofpings[(listofpings.Count / 2) - 1] + listofpings[listofpings.Count / 2]) / 2;
            }
            else
            {
                median = (double)listofpings[listofpings.Count / 2];
            }
            return (median);
        }


        /// <summary>
        /// Method to compute the mean of Ping list
        /// </summary>
        public double ComputeMean(List<long> listofpings)
        {
            double sum = 0;
            double mean;

            foreach (double x in listofpings)
            {
                sum += x;
            }
            mean = sum / listofpings.Count;
            return (mean);
        }


        /// <summary>
        /// Method to compute the variance of Ping list
        /// </summary>
        public double ComputeVariance(List<long> listofpings)
        {
            double sum = 0;
            double mean = ComputeMean(listofpings);
            double variance;

            foreach (long one_ping in listofpings)
            {
                sum += (one_ping - mean) * (one_ping - mean);
            }
            variance = sum / listofpings.Count;
            return (variance);
        }


        /// <summary>
        /// Method to compute the standard deviation of Ping list
        /// </summary>
        public double ComputeStdDeviation(List<long> listofpings)
        {
            double variance = ComputeVariance(listofpings);
            double std_deviation = Math.Sqrt(variance);
            return (std_deviation);
        }

        /// <summary>
        /// Method to identify all the uniques values of Pings
        /// </summary>
        public List<long> IdentifyUnique(List<long> listofpings)
        {
            List<long> unique_ping = listofpings.Distinct().ToList();
            return (unique_ping);
        }
    }

}
