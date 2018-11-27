using System.Drawing;

namespace AnalyzingPings
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ListCountry = new System.Windows.Forms.ComboBox();
            this.progBarPing = new System.Windows.Forms.ProgressBar();
            this.infoButtPanel = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Label();
            this.RpInternet = new System.Windows.Forms.Panel();
            this.ckintbutton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.helpVersPanel = new System.Windows.Forms.Panel();
            this.genHelpButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.drawingArea = new System.Windows.Forms.Panel();
            this.ProportionsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoButtPanel.SuspendLayout();
            this.helpVersPanel.SuspendLayout();
            this.drawingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProportionsChart)).BeginInit();
            this.SuspendLayout();

            // Create the HelpProvider.
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();

            // Tell the HelpProvider what controls to provide help for, and
            // what the help string is.
            this.helpProvider1.SetShowHelp(this.ListCountry, true);
            this.helpProvider1.SetHelpString(this.ListCountry, "Select the country to analyze or pick random.");


            // 
            // ListCountry
            // 
            this.ListCountry.BackColor = System.Drawing.Color.White;
            this.ListCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCountry.FormattingEnabled = true;
            this.ListCountry.Location = new System.Drawing.Point(8, 144);
            this.ListCountry.Name = "ListCountry";
            this.ListCountry.Size = new System.Drawing.Size(184, 24);
            this.ListCountry.TabIndex = 2;
            // 
            // progBarPing
            // 
            this.progBarPing.AccessibleDescription = "progression bar for collectiong pings";
            this.progBarPing.Location = new System.Drawing.Point(8, 315);
            this.progBarPing.Name = "progBarPing";
            this.progBarPing.Size = new System.Drawing.Size(184, 23);
            this.progBarPing.TabIndex = 5;
            // 
            // infoButtPanel
            // 
            this.infoButtPanel.BackColor = System.Drawing.Color.Wheat;
            this.infoButtPanel.Controls.Add(this.separator);
            this.infoButtPanel.Controls.Add(this.RpInternet);
            this.infoButtPanel.Controls.Add(this.ckintbutton);
            this.infoButtPanel.Controls.Add(this.ListCountry);
            this.infoButtPanel.Controls.Add(this.countryLabel);
            this.infoButtPanel.Controls.Add(this.progBarPing);
            this.infoButtPanel.Controls.Add(this.loadLabel);
            this.infoButtPanel.Controls.Add(this.startButton);
            this.infoButtPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoButtPanel.ForeColor = System.Drawing.Color.Black;
            this.infoButtPanel.Location = new System.Drawing.Point(0, 0);
            this.infoButtPanel.Name = "infoButtPanel";
            this.infoButtPanel.Size = new System.Drawing.Size(211, 496);
            this.infoButtPanel.TabIndex = 7;
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(0, 88);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(211, 2);
            this.separator.TabIndex = 0;
            // 
            // RpInternet
            // 
            this.RpInternet.AccessibleDescription = "Response Check Internet";
            this.RpInternet.BackColor = System.Drawing.Color.White;
            this.RpInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RpInternet.Location = new System.Drawing.Point(145, 22);
            this.RpInternet.Name = "RpInternet";
            this.RpInternet.Size = new System.Drawing.Size(25, 28);
            this.RpInternet.TabIndex = 9;
            // 
            // ckintbutton
            // 
            this.ckintbutton.AccessibleDescription = "chekinternetbutton";
            this.ckintbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckintbutton.ImageKey = "(none)";
            this.ckintbutton.Location = new System.Drawing.Point(8, 22);
            this.ckintbutton.Name = "ckintbutton";
            this.ckintbutton.Size = new System.Drawing.Size(127, 28);
            this.ckintbutton.TabIndex = 7;
            this.ckintbutton.Text = "Check Internet";
            this.ckintbutton.UseVisualStyleBackColor = true;
            this.ckintbutton.Click += new System.EventHandler(this.ckinternet_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(8, 112);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(134, 20);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country Selection";
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(8, 283);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(133, 20);
            this.loadLabel.TabIndex = 6;
            this.loadLabel.Text = "Loading Progress";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ImageKey = "(none)";
            this.startButton.Location = new System.Drawing.Point(127, 184);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // helpVersPanel
            // 
            this.helpVersPanel.BackColor = System.Drawing.Color.DimGray;
            this.helpVersPanel.Controls.Add(this.genHelpButton);
            this.helpVersPanel.Controls.Add(this.authorLabel);
            this.helpVersPanel.Controls.Add(this.versionLabel);
            this.helpVersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpVersPanel.ForeColor = System.Drawing.Color.White;
            this.helpVersPanel.Location = new System.Drawing.Point(0, 496);
            this.helpVersPanel.Name = "helpVersPanel";
            this.helpVersPanel.Size = new System.Drawing.Size(800, 29);
            this.helpVersPanel.TabIndex = 7;
            // 
            // genHelpButton
            // 
            this.genHelpButton.BackColor = System.Drawing.Color.Black;
            this.genHelpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.genHelpButton.FlatAppearance.BorderSize = 3;
            this.genHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genHelpButton.ForeColor = System.Drawing.Color.White;
            this.genHelpButton.Location = new System.Drawing.Point(7, 3);
            this.genHelpButton.Name = "genHelpButton";
            this.genHelpButton.Size = new System.Drawing.Size(19, 23);
            this.genHelpButton.TabIndex = 2;
            this.genHelpButton.Text = "?";
            this.genHelpButton.UseVisualStyleBackColor = true;
            this.genHelpButton.Click += new System.EventHandler(this.genHelpButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(630, 10);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(69, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Pereira Hugo";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(723, 10);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(65, 13);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "version : 0.1";
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.Transparent;
            this.drawingArea.Controls.Add(this.ProportionsChart);
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawingArea.Location = new System.Drawing.Point(211, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Padding = new System.Windows.Forms.Padding(3);
            this.drawingArea.Size = new System.Drawing.Size(589, 496);
            this.drawingArea.TabIndex = 8;
            // 
            // ProportionsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ProportionsChart.ChartAreas.Add(chartArea1);
            this.ProportionsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ProportionsChart.Legends.Add(legend1);
            this.ProportionsChart.Location = new System.Drawing.Point(3, 3);
            this.ProportionsChart.Name = "ProportionsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Pings";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Quartile";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Mean";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Orange;
            series4.Legend = "Legend1";
            series4.Name = "Median";
            this.ProportionsChart.Series.Add(series1);
            this.ProportionsChart.Series.Add(series2);
            this.ProportionsChart.Series.Add(series3);
            this.ProportionsChart.Series.Add(series4);
            this.ProportionsChart.Size = new System.Drawing.Size(583, 490);
            this.ProportionsChart.TabIndex = 0;
            this.ProportionsChart.Text = "chart1";
            title1.Name = "Graphic_Title";
            this.ProportionsChart.Titles.Add(title1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.infoButtPanel);
            this.Controls.Add(this.helpVersPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Analyzing Pings";
            this.infoButtPanel.ResumeLayout(false);
            this.infoButtPanel.PerformLayout();
            this.helpVersPanel.ResumeLayout(false);
            this.helpVersPanel.PerformLayout();
            this.drawingArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProportionsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ListCountry;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ProgressBar progBarPing;

        private System.Windows.Forms.Panel RpInternet;
        private System.Windows.Forms.Panel infoButtPanel;
        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.Panel helpVersPanel;

        private System.Windows.Forms.DataVisualization.Charting.Chart ProportionsChart;

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label loadLabel;

        private System.Windows.Forms.Button genHelpButton;
        private System.Windows.Forms.Button ckintbutton;
        private System.Windows.Forms.Button startButton;
    }
}

