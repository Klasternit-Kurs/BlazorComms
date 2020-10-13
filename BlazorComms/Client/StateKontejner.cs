using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComms.Client
{
	public class StateKontejner
	{
		private int _brojac;
		public int Brojac 
		{ 
			get => _brojac;
			set
			{
				_brojac = value;
				Promena?.Invoke();
			}
		}

		private string _zadnjaIzmena;
		public string ZadnjaIzmena 
		{ 
			get => _zadnjaIzmena;
			set
			{
				_zadnjaIzmena = value;
				Promena?.Invoke();
			}
		}

		public event Action Promena;
	}
}
