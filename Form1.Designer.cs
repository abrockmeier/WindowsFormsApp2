﻿namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.BT_H_ausf = new System.Windows.Forms.Button();
			this.H_einf = new System.Windows.Forms.Button();
			this.BT_A_ausf = new System.Windows.Forms.Button();
			this.BT_A_einf = new System.Windows.Forms.Button();
			this.BT_KA_r = new System.Windows.Forms.Button();
			this.BT_KA_l = new System.Windows.Forms.Button();
			this.BT_K_ausf = new System.Windows.Forms.Button();
			this.BT_K_einf = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.P_Fr = new System.Windows.Forms.Panel();
			this.P_Kg = new System.Windows.Forms.Panel();
			this.P_Ab = new System.Windows.Forms.Panel();
			this.P_Hg = new System.Windows.Forms.Panel();
			this.BT_Mright = new System.Windows.Forms.Button();
			this.BT_Mleft = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BT_H_ausf
			// 
			this.BT_H_ausf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.BT_H_ausf.Location = new System.Drawing.Point(39, 34);
			this.BT_H_ausf.Name = "BT_H_ausf";
			this.BT_H_ausf.Size = new System.Drawing.Size(126, 31);
			this.BT_H_ausf.TabIndex = 0;
			this.BT_H_ausf.Text = "H_ausf";
			this.BT_H_ausf.UseVisualStyleBackColor = false;
			this.BT_H_ausf.Click += new System.EventHandler(this.BT_H_ausf_Click);
			// 
			// H_einf
			// 
			this.H_einf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.H_einf.Location = new System.Drawing.Point(39, 71);
			this.H_einf.Name = "H_einf";
			this.H_einf.Size = new System.Drawing.Size(126, 31);
			this.H_einf.TabIndex = 1;
			this.H_einf.Text = "H_einf";
			this.H_einf.UseVisualStyleBackColor = false;
			this.H_einf.Click += new System.EventHandler(this.H_einf_Click);
			// 
			// BT_A_ausf
			// 
			this.BT_A_ausf.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_A_ausf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_A_ausf.Location = new System.Drawing.Point(39, 108);
			this.BT_A_ausf.Name = "BT_A_ausf";
			this.BT_A_ausf.Size = new System.Drawing.Size(126, 31);
			this.BT_A_ausf.TabIndex = 2;
			this.BT_A_ausf.Text = "A_ausf";
			this.BT_A_ausf.UseVisualStyleBackColor = false;
			this.BT_A_ausf.Click += new System.EventHandler(this.BT_A_ausf_Click);
			// 
			// BT_A_einf
			// 
			this.BT_A_einf.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_A_einf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_A_einf.Location = new System.Drawing.Point(39, 145);
			this.BT_A_einf.Name = "BT_A_einf";
			this.BT_A_einf.Size = new System.Drawing.Size(126, 31);
			this.BT_A_einf.TabIndex = 3;
			this.BT_A_einf.Text = "A_einf";
			this.BT_A_einf.UseVisualStyleBackColor = false;
			this.BT_A_einf.Click += new System.EventHandler(this.BT_A_einf_Click);
			// 
			// BT_KA_r
			// 
			this.BT_KA_r.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_KA_r.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_KA_r.Location = new System.Drawing.Point(39, 182);
			this.BT_KA_r.Name = "BT_KA_r";
			this.BT_KA_r.Size = new System.Drawing.Size(126, 31);
			this.BT_KA_r.TabIndex = 4;
			this.BT_KA_r.Text = "Schwenken ->";
			this.BT_KA_r.UseVisualStyleBackColor = false;
			this.BT_KA_r.Click += new System.EventHandler(this.BT_KA_r_Click);
			// 
			// BT_KA_l
			// 
			this.BT_KA_l.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_KA_l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_KA_l.Location = new System.Drawing.Point(39, 219);
			this.BT_KA_l.Name = "BT_KA_l";
			this.BT_KA_l.Size = new System.Drawing.Size(126, 31);
			this.BT_KA_l.TabIndex = 5;
			this.BT_KA_l.Text = "<-Schwenken";
			this.BT_KA_l.UseVisualStyleBackColor = false;
			this.BT_KA_l.Click += new System.EventHandler(this.BT_KA_l_Click);
			// 
			// BT_K_ausf
			// 
			this.BT_K_ausf.BackColor = System.Drawing.Color.Gold;
			this.BT_K_ausf.Location = new System.Drawing.Point(39, 256);
			this.BT_K_ausf.Name = "BT_K_ausf";
			this.BT_K_ausf.Size = new System.Drawing.Size(126, 31);
			this.BT_K_ausf.TabIndex = 6;
			this.BT_K_ausf.Text = "K_ausf";
			this.BT_K_ausf.UseVisualStyleBackColor = false;
			this.BT_K_ausf.Click += new System.EventHandler(this.BT_K_ausf_Click);
			// 
			// BT_K_einf
			// 
			this.BT_K_einf.BackColor = System.Drawing.Color.Gold;
			this.BT_K_einf.Location = new System.Drawing.Point(39, 293);
			this.BT_K_einf.Name = "BT_K_einf";
			this.BT_K_einf.Size = new System.Drawing.Size(126, 31);
			this.BT_K_einf.TabIndex = 7;
			this.BT_K_einf.Text = "K_einf";
			this.BT_K_einf.UseVisualStyleBackColor = false;
			this.BT_K_einf.Click += new System.EventHandler(this.BT_K_einf_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.BT_Mleft);
			this.panel1.Controls.Add(this.BT_Mright);
			this.panel1.Controls.Add(this.BT_K_einf);
			this.panel1.Controls.Add(this.BT_K_ausf);
			this.panel1.Controls.Add(this.BT_KA_l);
			this.panel1.Controls.Add(this.BT_KA_r);
			this.panel1.Controls.Add(this.BT_A_einf);
			this.panel1.Controls.Add(this.BT_A_ausf);
			this.panel1.Controls.Add(this.H_einf);
			this.panel1.Controls.Add(this.BT_H_ausf);
			this.panel1.Location = new System.Drawing.Point(602, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 402);
			this.panel1.TabIndex = 8;
			// 
			// P_Fr
			// 
			this.P_Fr.BackColor = System.Drawing.Color.OrangeRed;
			this.P_Fr.Location = new System.Drawing.Point(270, 410);
			this.P_Fr.Name = "P_Fr";
			this.P_Fr.Size = new System.Drawing.Size(120, 20);
			this.P_Fr.TabIndex = 9;
			this.P_Fr.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Fr_Paint);
			// 
			// P_Kg
			// 
			this.P_Kg.BackColor = System.Drawing.Color.Gold;
			this.P_Kg.Location = new System.Drawing.Point(311, 210);
			this.P_Kg.Name = "P_Kg";
			this.P_Kg.Size = new System.Drawing.Size(20, 200);
			this.P_Kg.TabIndex = 10;
			this.P_Kg.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Kg_Paint);
			// 
			// P_Ab
			// 
			this.P_Ab.BackColor = System.Drawing.Color.SteelBlue;
			this.P_Ab.Location = new System.Drawing.Point(210, 210);
			this.P_Ab.Name = "P_Ab";
			this.P_Ab.Size = new System.Drawing.Size(100, 20);
			this.P_Ab.TabIndex = 12;
			this.P_Ab.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Ab_Paint);
			// 
			// P_Hg
			// 
			this.P_Hg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.P_Hg.Location = new System.Drawing.Point(210, 230);
			this.P_Hg.Name = "P_Hg";
			this.P_Hg.Size = new System.Drawing.Size(20, 40);
			this.P_Hg.TabIndex = 11;
			this.P_Hg.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Hg_Paint);
			// 
			// BT_Mright
			// 
			this.BT_Mright.BackColor = System.Drawing.Color.Crimson;
			this.BT_Mright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Mright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_Mright.Location = new System.Drawing.Point(108, 335);
			this.BT_Mright.Name = "BT_Mright";
			this.BT_Mright.Size = new System.Drawing.Size(57, 31);
			this.BT_Mright.TabIndex = 8;
			this.BT_Mright.Text = "-->";
			this.BT_Mright.UseVisualStyleBackColor = false;
			// 
			// BT_Mleft
			// 
			this.BT_Mleft.BackColor = System.Drawing.Color.Crimson;
			this.BT_Mleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Mleft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_Mleft.Location = new System.Drawing.Point(39, 335);
			this.BT_Mleft.Name = "BT_Mleft";
			this.BT_Mleft.Size = new System.Drawing.Size(57, 31);
			this.BT_Mleft.TabIndex = 9;
			this.BT_Mleft.Text = "<--";
			this.BT_Mleft.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.P_Hg);
			this.Controls.Add(this.P_Ab);
			this.Controls.Add(this.P_Kg);
			this.Controls.Add(this.P_Fr);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BT_H_ausf;
		private System.Windows.Forms.Button H_einf;
		private System.Windows.Forms.Button BT_A_ausf;
		private System.Windows.Forms.Button BT_A_einf;
		private System.Windows.Forms.Button BT_KA_r;
		private System.Windows.Forms.Button BT_KA_l;
		private System.Windows.Forms.Button BT_K_ausf;
		private System.Windows.Forms.Button BT_K_einf;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel P_Fr;
		private System.Windows.Forms.Panel P_Kg;
		private System.Windows.Forms.Panel P_Ab;
		private System.Windows.Forms.Panel P_Hg;
		private System.Windows.Forms.Button BT_Mleft;
		private System.Windows.Forms.Button BT_Mright;
	}
}

