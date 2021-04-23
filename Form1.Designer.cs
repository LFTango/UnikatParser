namespace UnikatParser
{
	partial class Form1
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ErgLabel = new System.Windows.Forms.Label();
			this.PrimäreTB = new System.Windows.Forms.TextBox();
			this.SekundäreTB = new System.Windows.Forms.TextBox();
			this.ButtonStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ErgLabel
			// 
			this.ErgLabel.AutoSize = true;
			this.ErgLabel.Location = new System.Drawing.Point(14, 166);
			this.ErgLabel.Name = "ErgLabel";
			this.ErgLabel.Size = new System.Drawing.Size(50, 13);
			this.ErgLabel.TabIndex = 1;
			this.ErgLabel.Text = "Unikate: ";
			// 
			// PrimäreTB
			// 
			this.PrimäreTB.Location = new System.Drawing.Point(17, 78);
			this.PrimäreTB.Name = "PrimäreTB";
			this.PrimäreTB.Size = new System.Drawing.Size(391, 20);
			this.PrimäreTB.TabIndex = 2;
			this.PrimäreTB.Text = "der pfannkuchen schmeckt süß und nach apfel und apfel";
			// 
			// SekundäreTB
			// 
			this.SekundäreTB.Location = new System.Drawing.Point(17, 121);
			this.SekundäreTB.Name = "SekundäreTB";
			this.SekundäreTB.Size = new System.Drawing.Size(391, 20);
			this.SekundäreTB.TabIndex = 3;
			this.SekundäreTB.Text = "der pfannkuchen schmeckt salzig aber auch nach apfel und zitrone";
			// 
			// ButtonStart
			// 
			this.ButtonStart.Location = new System.Drawing.Point(97, 195);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(229, 51);
			this.ButtonStart.TabIndex = 4;
			this.ButtonStart.Text = "Start!";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 258);
			this.Controls.Add(this.ButtonStart);
			this.Controls.Add(this.SekundäreTB);
			this.Controls.Add(this.PrimäreTB);
			this.Controls.Add(this.ErgLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label ErgLabel;
		private System.Windows.Forms.TextBox PrimäreTB;
		private System.Windows.Forms.TextBox SekundäreTB;
		private System.Windows.Forms.Button ButtonStart;
	}
}

