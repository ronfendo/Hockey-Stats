using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Goals_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(Number.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                Number.Text = Number.Text.Substring(0, Number.Text.Length - 1);
                return;
            }
            if (Number == null)
            { return;
            }
//TODO FIX VALIDATION WHEN 
        }

        private void Assists_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool playerInfoLock = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (playerInfoLock == true)

            {
                Number.ReadOnly = false;
                PlayerName.ReadOnly = false;
                PlayerLock.Text = "Lock Players";
                playerInfoLock = false;
                return;
            }
            else
                Number.ReadOnly = true;
                PlayerName.ReadOnly = true;
                PlayerLock.Text = "Unlock Players";
                playerInfoLock = true;
            return;
            }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            char parsedValue;
            if (!char.TryParse(Number.Text, out parsedValue))
            {
                MessageBox.Show("This is a text only field");
                return;
            }
            if (PlayerName.Text.Trim() == string.Empty)
            {
                return;
            }
        }
    }
    }

