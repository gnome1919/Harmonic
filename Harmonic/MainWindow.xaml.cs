using Harmonic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Harmonic
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void NoOfInfTbx_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			var numberOfRows = Convert.ToInt32(e.Text);

			List<TicketInfo> ticketsList = new List<TicketInfo>();

			for (int i = 1; i < numberOfRows; i++)
			{
				ticketsList.Add(new TicketInfo());
			}
			
			dgData.ItemsSource = ticketsList;
		}
	}

	public class Para1_List : List<string>
    {
        public Para1_List()
        {
            for (int i = 1; i < 147; i++)
            {
                this.Add("P1");
                this.Add("P2");
                this.Add("P3");
                this.Add("P4");
                this.Add("P5");
            }
        }
    }
    public class Para2_List : List<string>
    {
        public Para2_List()
        {
            this.Add("P6");
            this.Add("P7");
            this.Add("P8");
            this.Add("P9");
            this.Add("P10");
        }
    }
}