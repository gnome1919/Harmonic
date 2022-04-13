using System.ComponentModel;

namespace Harmonic.Models
{
	public class TicketInfo : INotifyPropertyChanged
	{
		private string period;
		private string period2;

		public string Period { get => period; set { period = value; OnPropertyChanged(nameof(Calc)); } }
		public string Period2 { get => period2; set { period2 = value; OnPropertyChanged(nameof(Calc2)); } }
		public string Calc
		{
			get
			{
				switch (period)
				{
					case "P1":
						return "Period_1_1";
					case "P2":
						return "Period_1_2";
					case "P3":		   
						return "Period_1_3";
					case "P4":		   
						return "Period_1_4";
					case "P5":		   
						return "Period_1_5";
					default:
						return "";
				}
			}
		}

		public string Calc2
		{
			get
			{
				switch (period2)
				{
					case "P6":
						return "Period_2_1";
					case "P7":		   
						return "Period_2_2";
					case "P8":		   
						return "Period_2_3";
					case "P9":		   
						return "Period_2_4";
					case "P10":		   
						return "Period_2_5";
					default:
						return "";
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
