using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPokemonFight
{
    public partial class Form1 : Form
    {
        Pokemon newPokemon = null;
        Pokemon[] PokemonArray = new Pokemon[100];
        int PokemonIndex = 0;
        int count = 0;
        string nameJthi = "";
        string NewPokemonType = "";
        string img = "";
        bool flag = false;
        string imgFolderJthi = @"C:\Users\Just\source\repos\ClassPokemonFight\Pokemon\";

        public Form1()
        {
            InitializeComponent();
            cbShowJthi.Enabled = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbc1Jthi.SelectedTab = tbAddJthi;
        }

        private void MsiShowJthi_Click(object sender, EventArgs e)
        {
            tbc1Jthi.SelectedTab = tbShowJthi;
        }

        private void MsiFightJthi_Click(object sender, EventArgs e)
        {
            tbc1Jthi.SelectedTab = tbFightJthi;
        }

        private void btnAddJthi_Click(object sender, EventArgs e)
        {
            newPokemon = new Pokemon(tbAddpkmJthi.Text, cmbTypeJthi.Text, imgFolderJthi + cmbTypeJthi.Text + ".png");
            PokemonArray[PokemonIndex] = newPokemon;
            lblLastAddedJthi.Text = PokemonArray[PokemonIndex].GetAll();
            PokemonIndex++;
            count++;
            lblCountJthi.Text = count.ToString();
            pcbAdd1Jthi.Image = System.Drawing.Image.FromFile(newPokemon.GetImg());
        }


        private void tmrJthi_Tick(object sender, EventArgs e)
        {
            if (PokemonArray[PokemonIndex] != null)
            {

                if (flag == false)
                {
                    nameJthi = PokemonArray[PokemonIndex].GetName();
                    rtbShowJthi.Text += nameJthi + "\n";
                    PokemonIndex++;
                }
                else
                {
                    nameJthi = PokemonArray[PokemonIndex].GetName();
                    NewPokemonType = PokemonArray[PokemonIndex].GetType();
                    rtbShowJthi.Text += nameJthi + " Type: " + NewPokemonType + "\n";
                    PokemonIndex++;
                }

            }
        }

        private void btnShowJthi_Click(object sender, EventArgs e)
        {
            cbShowJthi.Enabled = true;
            PokemonIndex = 0;
            tmrJthi.Start();
        }

        private void cbShowJthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowJthi.Checked)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

        }
    }
}
