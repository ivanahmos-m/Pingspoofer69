﻿namespace HaHaPingspoofer69
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
			this.components = new System.ComponentModel.Container();
			this.Start = new System.Windows.Forms.Button();
			this.Stop = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(143, 169);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(136, 95);
			this.Start.TabIndex = 0;
			this.Start.Text = "Start";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// Stop
			// 
			this.Stop.Location = new System.Drawing.Point(480, 169);
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(148, 95);
			this.Stop.TabIndex = 1;
			this.Stop.Text = "Stop";
			this.Stop.UseVisualStyleBackColor = true;
			this.Stop.Click += new System.EventHandler(this.Stop_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Stop);
			this.Controls.Add(this.Start);
			this.Name = "Form1";
			this.Text = "HaHaPingspoofer69";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.Timer timer1;
	}
}

