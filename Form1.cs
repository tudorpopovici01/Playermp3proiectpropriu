using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playermp3proiectpropriu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creem variabile globale
        string[] paths, files;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cod selectare muzica
           OpenFileDialog ofd = new OpenFileDialog();
            //Cod de selectarea mai multe melodii
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listBox1Songs.Items.Add(files[i]);
                }
            }
        }

        private void listBox1Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sriem un codpentru a reda muzică
            axWindowsMediaPlayer1.URL =paths[listBox1Songs.SelectedIndex]; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Cod de minimizare
           this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code de inchidere aplicatie
            this.Close();
        }
    }   
}
