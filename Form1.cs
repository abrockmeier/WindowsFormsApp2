using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool KA_l = true;

		private void BT_KA_r_Click(object sender, EventArgs e)
		{
			// Spiegeln
			while (KA_l)
			{
			Point actualPointHg = new Point(P_Hg.Location.X + 2*P_Ab.Width,
			P_Kg.Location.Y + P_Ab.Height);

			P_Hg.Location = actualPointHg;

			Point actualPointAb = new Point(P_Ab.Location.X + P_Ab.Width + P_Kg.Width,
			P_Ab.Location.Y);

			P_Ab.Location = actualPointAb;

			KA_l = false;
			}
		}

		private void BT_KA_l_Click(object sender, EventArgs e)
		{
			while (!KA_l)
			{
			Point actualPointHg = new Point(P_Hg.Location.X  - 2*P_Ab.Width,
			P_Kg.Location.Y + P_Ab.Height );

			P_Hg.Location = actualPointHg;

			Point actualPointAb = new Point(P_Ab.Location.X - P_Ab.Width - P_Kg.Width,
			P_Ab.Location.Y);

			P_Ab.Location = actualPointAb;

			KA_l = true;
			}
		}

		private void BT_H_ausf_Click(object sender, EventArgs e)
		{
			if (P_Hg.Height < P_Kg.Height )
			P_Hg.Height += 10;
		}

		private void H_einf_Click(object sender, EventArgs e)
		{
			if (P_Hg.Height > 40)
			P_Hg.Height -= 10;
		}

		private void BT_A_ausf_Click(object sender, EventArgs e)
		{
			int width = ActiveForm.Width;
			if (KA_l)
			{
				if (P_Ab.Width < P_Ab.Location.X + P_Ab.Width - 20)
				{
					P_Ab.Width += 10;
					Point actualPointAb = new Point(P_Ab.Location.X - 10,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;
					Point actualPointHg = new Point(P_Hg.Location.X - 10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
			else
			{ 
				if (P_Ab.Width < width)
				{
					P_Ab.Width += 10;
					Point actualPointHg = new Point(P_Hg.Location.X  +10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
		}

		private void BT_A_einf_Click(object sender, EventArgs e)
		{
			if (KA_l)
			{
				if (P_Ab.Width >= 40)
				{
					P_Ab.Width -= 10;
					
					Point actualPointAb = new Point(P_Ab.Location.X +10,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;

					Point actualPointHg = new Point(P_Hg.Location.X  +10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
			else
			{
				if (!KA_l)
				{
					if (P_Ab.Width > 40)
					{
						P_Ab.Width -= 10;
						Point actualPointAb = new Point(P_Ab.Location.X,
						P_Ab.Location.Y);
						P_Ab.Location = actualPointAb;
						Point actualPointHg = new Point(P_Hg.Location.X - 10,
						P_Hg.Location.Y);
						P_Hg.Location = actualPointHg;
					}
				}
			}
		}

		private void BT_K_ausf_Click(object sender, EventArgs e)
		{
			//P_Kg
		}

		private void BT_K_einf_Click(object sender, EventArgs e)
		{
			//P_Kg
		}

		private void P_Hg_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void P_Ab_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void P_Kg_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void P_Fr_Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}
