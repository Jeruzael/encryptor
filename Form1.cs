using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace encryptor
{
    public partial class Form1 : Form
    {

		Encrypt me = new Encrypt();

		public Form1()
        {
            InitializeComponent();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			textBox2.Text = me.encryptThis(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			
		}

        private void button2_Click(object sender, EventArgs e)
        {
			textBox2.Text = me.decryptThis(textBox1.Text);
		}

        private void button3_Click(object sender, EventArgs e)
        {

			int pos = Convert.ToInt32(textBox3.Text);
			if (textBox3.Text == null)
            {
				MessageBox.Show("Please input number first");
            }else
            {
				me.chooseSLot(pos);
				MessageBox.Show("Position Initialize!");
			}
			
		}
    }

    public class Encrypt
	{
		public string[] ConSlot = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " "};
		public string smallCapsAlphabet = "abcdefghijklmnopwrstuvwxyz";
		public string specialCharacter = "_@&*$#!";
		public string[] slot = new string[27];

		public Encrypt()
		{
			Console.WriteLine("Encryption System Started!");
		}

		public void chooseSLot(int num)
		{
			int i;
			for (i = 0; i < 27; i++)
			{
				slot[num++] = ConSlot[i];
				if (num == 27)
				{
					num = 0;
				}
			}
		}

		public void showSlot()
		{
			for (int i = 0; i < 27; i++)
			{
				Console.Write(slot[i]);
			}
		}

		public void showStandardAlpha()
		{
			for (int i = 0; i < 27; i++)
			{
				Console.Write(ConSlot[i]);
			}
		}

		public void showAll()
		{
			showSlot();
			Console.WriteLine();
			showStandardAlpha();
		}

		public string encryptThis(string text)
		{
			char[] converter = text.ToCharArray();
			char[] processed = new char[text.Length];
			int me2 = 0;
			for (int i = 0; i < text.Length; i++)
			{
				string cons = converter[i].ToString();

				for (int me = 0; me < 27; me++)
				{
					if (cons.Equals(ConSlot[me]))
					{
						Console.Write(slot[me]);
						processed[me2] = Convert.ToChar(slot[me]);
						me2++;
					}
				}
			}

			string meme = new string(processed);

			return meme;
		}

		public string decryptThis(string text)
		{
			char[] converter = text.ToCharArray();
			char[] processed = new char[text.Length];
			int me2 = 0;
			for (int i = 0; i < text.Length; i++)
			{
				string cons = converter[i].ToString();

				for (int me = 0; me < 27; me++)
				{
					if (cons.Equals(slot[me]))
					{
						Console.Write(ConSlot[me]);
						processed[me2] = Convert.ToChar(ConSlot[me]);
						me2++;
					}
				}
			}

			string meme = new string(processed);

			return meme;
		}

	}
}
