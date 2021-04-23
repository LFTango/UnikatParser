using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnikatParser
{
	public partial class Form1 : Form
	{
		bool notUnikati, notUnikatl; //Bools für die for schleifen, getrennt nach dem i zähler und dem l zähler
		bool firstEnter; //bool um out.of.range exceptions zu verhindern. Wurde während des programmierens genutzt. funktioniert mittlerweile auch ohne.

		List<string> ergString = new List<string>(); //Liste in der die unikate zusammengefasst werden

		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			ergString.Clear(); //zum cleanen des labels wenn der button gedrückt wird
			firstEnter = true;
			string[] primärString = PrimäreTB.Text.Split(new string[] { " " }, StringSplitOptions.None); //fügt den text in der textbox einem array hinzu, und wird pro word gesplittet wo ein leerzeichen ist
			string[] sekundärString = SekundäreTB.Text.Split(new string[] { " " }, StringSplitOptions.None);

			for (int i = 0; i < primärString.Length; i++) //die main for schleife der den primärstring mit sich selbst und dem sekundärstring vergleicht.
			{
				notUnikatl = true;
				for (int k = 0; k < sekundärString.Length - 1; k++)
				{
					if (primärString[i] == sekundärString[k] && firstEnter) //If beide x.ten wörter in den zwei string sind gleich, dann:
					{
						notUnikati = false;
					}
					else if (primärString[i] == sekundärString[k] && firstEnter == false)
					{
						notUnikati = false;
					}
					firstEnter = false;
				}

				if (notUnikati)
				{
					for (int l = 0; l <= primärString.Length - 1; l++) 
					{

						if (primärString[i] == primärString[l]) //if das x.te wort im selben string zweimal vorkommt, dann:
						{
							if (i != l) //Wenn beide NICHT die selbe x.te position haben (sonst würde das programm dasselbe wort als doppelt sehen)
							{
								notUnikatl = false;
							}
						}
						else if (primärString[i] == primärString[l])
						{
							if (i != l)
							{
								notUnikatl = false;
							}
						}
					}

					if (notUnikatl == true) //notUnikatl wird nur false gesetzt wenn der x.te primäre eintrag irgendwo doppelt vorkommt.
					{
						ergString.Add(primärString[i]); //fügt den x.ten beitrag aus dem primären string-array in die list hinzu
					}
				}
				notUnikati = true;

			}

			//^ v

			for (int i = 0; i < sekundärString.Length; i++) //die main for schleife der den sekundärstring mit sich selbst und dem primärstring vergleicht. relativ identisch zur oberen for schleife.
			{
				notUnikatl = true;
				for (int k = 0; k < primärString.Length - 1; k++)
				{
					if (sekundärString[i] == primärString[k] && firstEnter)
					{
						notUnikati = false;
					}
					else if (sekundärString[i] == primärString[k] && firstEnter == false)
					{
						notUnikati = false;
					}
					firstEnter = false;
				}

				if (notUnikati)
				{
					for (int l = 0; l <= sekundärString.Length - 1; l++)
					{
						if (sekundärString[i] == sekundärString[l])
						{
							if (i != l)
							{
								notUnikatl = false;
							}

						}
						else if (sekundärString[i] == sekundärString[l])
						{
							if (i != l)
							{
								notUnikatl = false;
							}
						}
					}

					if (notUnikatl == true)
					{
						ergString.Add(sekundärString[i]);
					}
				}
				notUnikati = true;

				if (ergString.Count() != 0) //If ergstring hat mindestens 1 element
				{
					ErgLabel.Text = "Unikate: " + string.Join(", ", ergString.ToArray()); ; //zeigt die unikate in ein label an.
					firstEnter = true;
				}
			}
		}
	}
}
