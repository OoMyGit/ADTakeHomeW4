using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ADTakeHomeW4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Team> listteam = new List<Team>();
        List<string> listnegara = new List<string>();
        public void addingteam(string name, string country, string city)
        {
            Team tim = new Team();
            tim.TeamName = name;
            tim.TeamCountry = country;
            tim.TeamCity = city;
            listteam.Add(tim);
            listnegara.Add(country);
            int cektimdouble = 0;
            int ceknegaradouble = 0;
            foreach (Team timm in listteam)
            {
                if (timm.TeamName.Equals(name))
                {
                    cektimdouble++;
                }
            }
            if (cektimdouble > 1)
            {
                listteam.RemoveAt(listteam.Count - 1);
                MessageBox.Show("Team Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (string negara in listnegara)
            {
                if (country == negara)
                {
                    ceknegaradouble++;
                }
            }
            if (ceknegaradouble > 1)
            {
                listnegara.RemoveAt(listnegara.Count - 1);
            }
            else
            {
                combochoosecountry.Items.Add(country);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboplayerposition.Items.Add("GK");
            comboplayerposition.Items.Add("DF");
            comboplayerposition.Items.Add("MF");
            comboplayerposition.Items.Add("FW");

            addingteam("Manchester United", "England", "Manchester");
            addingteam("Manchester City", "England", "Manchester");
            addingteam("Paris Saint-Germain", "France", "Paris");

            foreach (Team tim in listteam)
            {
                if (tim.TeamName == "Manchester United")
                {
                    tim.addingplayer("David De Gea", "01", "GK");
                    tim.addingplayer("Aaron Wan-Bissaka", "29", "DF");
                    tim.addingplayer("Victor Lindelof", "02", "DF");
                    tim.addingplayer("Harry Maguire", "05", "DF");
                    tim.addingplayer("Luke Shaw", "23", "DF");
                    tim.addingplayer("Fred", "17", "MF");
                    tim.addingplayer("Scott McTominay", "39", "MF");
                    tim.addingplayer("Paul Pogba", "06", "MF");
                    tim.addingplayer("Bruno Fernandes", "18", "MF");
                    tim.addingplayer("Marcus Rashford", "10", "FW");
                    tim.addingplayer("Edinson Cavani", "07", "FW");
                    tim.addingplayer("Mason Greenwood", "11", "FW");
                }
            }

            foreach (Team tim in listteam)
            {
                if (tim.TeamName == "Manchester City")
                {
                    tim.addingplayer("Ederson", "31", "GK");
                    tim.addingplayer("Joao Cancelo", "27", "DF");
                    tim.addingplayer("John Stones", "05", "DF");
                    tim.addingplayer("Ruben Dias", "03", "DF");
                    tim.addingplayer("Kyle Walker", "02", "DF");
                    tim.addingplayer("Fernandinho", "25", "MF");
                    tim.addingplayer("Rodri", "16", "MF");
                    tim.addingplayer("Kevin De Bruyne", "17", "MF");
                    tim.addingplayer("Riyad Mahrez", "26", "FW");
                    tim.addingplayer("Phil Foden", "47", "FW");
                    tim.addingplayer("Erling Haaland", "09", "FW");
                }
            }

            foreach (Team tim in listteam)
            {
                if (tim.TeamName == "Paris Saint-Germain")
                {
                    tim.addingplayer("Keylor Navas", "01", "GK");
                    tim.addingplayer("Achraf Hakimi", "02", "DF");
                    tim.addingplayer("Presnel Kimpembe", "03", "DF");
                    tim.addingplayer("Marquinhos", "05", "DF");
                    tim.addingplayer("Layvin Kurzawa", "20", "DF");
                    tim.addingplayer("Ander Herrera", "21", "MF");
                    tim.addingplayer("Marco Verratti", "06", "MF");
                    tim.addingplayer("Georginio Wijnaldum", "18", "MF");
                    tim.addingplayer("Lionel Messi", "30", "FW");
                    tim.addingplayer("Kylian Mbappe", "07", "FW");
                    tim.addingplayer("Neymar Jr.", "10", "FW");
                }
            }
        }
        private void buttonaddteam_Click(object sender, EventArgs e)
        {
            if (textboxteamname.Text == "" || textboxteamcountry.Text == "" || textboxteamcity.Text == "")
            {
                MessageBox.Show("All Of The Fields Need To Be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addingteam(textboxteamname.Text, textboxteamcountry.Text, textboxteamcity.Text);
            }
            textboxteamname.Text = "";
            textboxteamcountry.Text = "";
            textboxteamcity.Text = "";
        }
        private void buttonaddplayer_Click(object sender, EventArgs e)
        {
            if (textboxplayername.Text == "" || textboxplayernumber.Text == "" || comboplayerposition.SelectedIndex < 0)
            {
                MessageBox.Show("All Of The Fields Need To Be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team tim in listteam)
                {
                    if (tim.TeamName == combochooseteam.SelectedItem.ToString())
                    {
                        tim.addingplayer(textboxplayername.Text, textboxplayernumber.Text, comboplayerposition.SelectedItem.ToString());
                        int cekplayernamedouble = 0;
                        int cekplayernumdouble = 0;
                        foreach (Player pemain in tim.Players)
                        {
                            if (pemain.PlayerName == textboxplayername.Text)
                            {
                                cekplayernamedouble++;
                            }
                            if (pemain.PlayerNum == textboxplayernumber.Text)
                            {
                                cekplayernumdouble++;
                            }
                        }
                        if (cekplayernamedouble > 1)
                        {
                            tim.Players.RemoveAt(tim.Players.Count - 1);
                            MessageBox.Show("Player With The Same Name Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (cekplayernumdouble > 1)
                        {
                            tim.Players.RemoveAt(tim.Players.Count - 1);
                            MessageBox.Show("Player With The Same Number Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            comboplayerposition.SelectedIndex = -1;
            textboxplayername.Text = "";
            textboxplayernumber.Text = "";
            listboxplayer.Items.Clear();
            foreach (Team tim in listteam)
            {
                if (tim.TeamName == combochooseteam.SelectedItem.ToString())
                {
                    foreach (Player pemain in tim.Players)
                    {
                        listboxplayer.Items.Add($"(" + pemain.PlayerNum + ")" + " " + pemain.PlayerName + ", " + pemain.PlayerPos);
                    }
                }
            }
            listboxplayer.Sorted = true;
        }
        private void combochoosecountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            combochooseteam.Items.Clear();
            foreach (Team tim in listteam)
            {
                if (tim.TeamCountry == combochoosecountry.SelectedItem.ToString())
                {
                    combochooseteam.Items.Add(tim.TeamName);
                }
            }
        }
        private void combochooseteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxplayer.Items.Clear();
            foreach (Team tim in listteam)
            {
                if (tim.TeamName == combochooseteam.SelectedItem.ToString())
                {
                    foreach (Player pemain in tim.Players)
                    {
                        listboxplayer.Items.Add($"(" + pemain.PlayerNum + ")" + " " + pemain.PlayerName + ", " + pemain.PlayerPos);
                    }
                }
            }
            listboxplayer.Sorted = true;
        }
        private void buttonremove_Click(object sender, EventArgs e)
        {
            if (listboxplayer.Items.Count <= 11)
            {
                MessageBox.Show("Unable To Remove Players If Players Less Than Equal 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team tim in listteam)
                {
                    if (tim.TeamName == combochooseteam.SelectedItem.ToString())
                    {
                        foreach (Player pemain in tim.Players)
                        {
                            if (listboxplayer.SelectedItem.ToString().Equals($"(" + pemain.PlayerNum + ")" + " " + pemain.PlayerName + ", " + pemain.PlayerPos))
                            {
                                tim.Players.Remove(pemain);
                                listboxplayer.Items.Remove($"(" + pemain.PlayerNum + ")" + " " + pemain.PlayerName + ", " + pemain.PlayerPos);
                                break;
                            }
                        }
                    }
                }
                listboxplayer.Sorted = true;
            }
        }
    }
}
