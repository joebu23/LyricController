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
        public Form1()
        {
            InitializeComponent();
            TelnetConnection Lyric = new TelnetConnection("127.0.0.1", 23);

        }
    }
}
