using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlaknaProgress
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnAkce_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int>(x => PbPostup.Value = x);
            LblInfo.Text = "Pracuji";
            Pracant pracant = new Pracant();
            string vysledek = await Task.Factory.StartNew( () => pracant.DlouhaAkceProgress(15, progress));
            LblInfo.Text = vysledek;
        }
    }
}
