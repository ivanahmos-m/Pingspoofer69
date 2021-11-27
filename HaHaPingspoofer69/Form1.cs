using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.NetworkInformation;

namespace HaHaPingspoofer69
{
	public partial class Form1 : Form
	{
		bool sendpacs = true;
		
		Ping p = new Ping();
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			 PingReply pr = p.Send("google.com"); 
		}

		private void Start_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void Stop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
				
		}
		
	}
}
