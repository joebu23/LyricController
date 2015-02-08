using MinimalisticTelnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricController
{
    public partial class Form1 : Form
    {
        TelnetConnection Lyric = new TelnetConnection("127.0.0.1", 23);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lyric.WriteLine("testing");
            //MessageBox.Show("hi");
            //Console.Write("hi");
            //while (tc.IsConnected && prompt.Trim() != "exit")
            //{
            //    // display server output
            Console.Write(Lyric.Read());

            //    // send client input to server
            //    prompt = Console.ReadLine();
            //    tc.WriteLine(prompt);

            //    // display server output
            //    Console.Write(tc.Read());
            //}
        }
    }
}
