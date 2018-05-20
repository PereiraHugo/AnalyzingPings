using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Latency
{
    public partial class MainWindow : Form
    {
        InternetOperation IntSt = new InternetOperation();

        Server allServer = new Server();

        /// <summary>
        /// Method to initialize the graphic main window of the program.
        /// It set to disable the start button and the list country to force the user to check the Internet
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            ListCountry.DataSource = new BindingSource(allServer.Country.Keys, null);
            ListCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            ListCountry.FlatStyle = FlatStyle.Flat;
            startButton.Enabled = false;
            ListCountry.Enabled = false;
        }

        /// <summary>
        /// Method for the button start's action.
        /// The first action is to disable the start button.
        /// Then get from the list the country selected. If random chosen, it compute the random.
        /// With the abbreviation of the country it complete the url_to_open.
        /// Open the file from url_to_open.
        /// Collect all DNS, for each DNS send a connection and collect the ping resulted.
        /// Pings are stored.
        /// Finally, the graphic is build.
        /// </summary>
        private void start_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            progBarPing.Value = 0;
            string abvCountry;
            if (allServer.Country[ListCountry.SelectedItem.ToString()] == "rd")
            {
                List<string> keysList = new List<string>(allServer.Country.Keys);
                string random_Country = allServer.GetRandomCountry(keysList);
                abvCountry = allServer.Country[random_Country];
                ProportionsChart.Titles["Graphic_Title"].Text = random_Country;
            }
            else
            {
                abvCountry = allServer.Country[ListCountry.SelectedItem.ToString()];
                ProportionsChart.Titles["Graphic_Title"].Text = ListCountry.SelectedItem.ToString();
            }

            WebClient wc = new WebClient();
            string url_to_open = $"https://public-dns.info/nameserver/{abvCountry}.txt";
            List<long> allmypings = new List<long>();
            try
            {
                string theTextFile = wc.DownloadString(url_to_open);
                string[] all_IP = theTextFile.Split('\n');
                int index_ping = 0;
                foreach (string each_ping in all_IP)
                {
                    index_ping += 1;
                    progBarPing.Value = index_ping * 100 / all_IP.Length;
                    long ping_recevied = IntSt.GetPing(each_ping);
                    if(ping_recevied != 0 && ping_recevied != -1)
                    {
                        allmypings.Add(ping_recevied);
                    }
                }
                allmypings.Sort();
                
                startButton.Enabled = true;

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error into web connection");
            }
            if (allmypings.Count > 0)
            {
                PingStatistics ping_stat = new PingStatistics(allmypings);

                var count_group_pings = from one_ping in ping_stat.GetPingsValue()
                                        group one_ping by one_ping into one_group
                                        let count = one_group.Count()
                                        orderby count descending
                                        select new { Value = one_group.Key, Count = count };
                foreach (var ping_proportion in count_group_pings)
                {
                    ProportionsChart.Series["Pings"].Points.AddXY(ping_proportion.Value, ping_proportion.Count);
                }

                if (ping_stat.GetPingsValue().Count > 5)
                {
                    CreateVerticalLineByValue(ping_stat.GetMean(), Color.Red);
                    CreateVerticalLineByValue(ping_stat.GetMedian(), Color.Orange);
                    CreateVerticalLineByValue((double)ping_stat.GetFirstQuartile(), Color.Green);
                    CreateVerticalLineByValue((double)ping_stat.GetThirdQuartile(), Color.Green);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No ping collected for the Country " + ListCountry.SelectedItem.ToString() + ".\nYou should change the Country!");
            }
            startButton.Enabled = true;
        }

        /// <summary>
        /// Method to create a vertical line on graphics.
        /// The vertical line is situated with a position index of the vector
        /// </summary>
        void CreateVerticalLineByPosition(int index, Color line_color)
        {
            VerticalLineAnnotation LA = new VerticalLineAnnotation();
            LA.LineColor = line_color;
            LA.LineWidth = 3;
            LA.IsInfinitive = true;
            LA.AnchorDataPoint = ProportionsChart.Series["Pings"].Points[0];
            LA.X = ProportionsChart.Series["Pings"].Points[index].XValue;
            LA.ClipToChartArea = ProportionsChart.ChartAreas[0].Name;
            ProportionsChart.Annotations.Add(LA);
        }

        /// <summary>
        /// Method to create a vertical line on graphics.
        /// The verticale line is situated with a double value
        /// </summary>
        void CreateVerticalLineByValue(double value, Color line_color)
        {
            VerticalLineAnnotation LA = new VerticalLineAnnotation();
            LA.LineColor = line_color;
            LA.LineWidth = 3;
            LA.IsInfinitive = true;
            LA.AnchorDataPoint = ProportionsChart.Series["Pings"].Points[0];
            LA.X = value;
            LA.ClipToChartArea = ProportionsChart.ChartAreas[0].Name;
            ProportionsChart.Annotations.Add(LA);
        }

        /// <summary>
        /// Method for the button check Internet's action.
        /// Get the Internet status as boolean.
        /// Enable the rest of the program if the computer is connected to the Internet.
        /// </summary>
        private void ckinternet_Click(object sender, EventArgs e)
        {
            bool Internet_St = IntSt.internet_Status;
            if (Internet_St)
            {
                RpInternet.BackColor = Color.Green;
                startButton.Enabled = true;
                ListCountry.Enabled = true;
            }
            else
            {
                RpInternet.BackColor = Color.Red;
                startButton.Enabled = false;
                ListCountry.Enabled = false;
            }
        }

        /// <summary>
        /// Method for the button help's action.
        /// This show a message box with all the help needed. //In construction
        /// </summary>
        private void genHelpButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("General Help");
        }
    }
}
