using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezVlaken
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAkce_Click(object sender, EventArgs e)
        {
            LblInfo.Text = "Pracuji";
            Pracant pracant = new Pracant();
            string vysledek = pracant.DlouhaAkceBezVlaken(15, PbPostup);
            LblInfo.Text = vysledek;
        }
    }
}
