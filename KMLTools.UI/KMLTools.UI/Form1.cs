using SharpKml.Base;
using System;
using System.IO;
using System.Windows.Forms;

namespace KMLTools.UI
{
    public partial class Form1 : Form
    {
        private const string KmlFile = "LocationHistoryAustralia2017-18.kml";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var inputKml = File.ReadAllText(KmlFile);

            Parser parser = new Parser();

            parser.ParseString(inputKml, false);

            var placemark = parser.Root;

            //Console.WriteLine("The placemark name is '{0}'.", placemark.Name);
        }
    }
}