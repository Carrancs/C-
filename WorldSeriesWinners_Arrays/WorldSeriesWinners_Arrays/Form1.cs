using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorldSeriesWinners_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // *************** METHODS ***************

        // My own search method
        private int RepeatedTimes(string[] wArray, string listSel)
        {
            // Variables
            int matchTimes = 0; // Variable to hold win times total

            int roundit = 0;  // Variable to use on the while loop of the through the Array

            string userSel;    // Variable to hold the total times the team has won

            if (teamsListBox.SelectedIndex != -1)
            {
                // Determine how many times the item is in the array
                while (roundit < wArray.Length)
                {
                    userSel = wArray[roundit];
                    if (listSel == userSel)
                    {
                        matchTimes++;
                    }
                    roundit++;
                }
            }
            return matchTimes;
        }

        // *************** LOAD LIST BOX ***************
        // Load the ListBox with the Teams
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Display the items read from the file "teams.txt" into the ListBox
                // Declare the variables
                string team;      // To display the teams as String on the List Box
                int totOfNum;     // To hold the total of items (numbers) on the List Box

                // Open a File
                StreamReader inputFile;

                // Open the selected File
                inputFile = File.OpenText("teams.txt");

                // Clear the List Box
                teamsListBox.Items.Clear();

                // Read the file's content
                while (!inputFile.EndOfStream)
                {
                    // Get each team from the file
                    team = inputFile.ReadLine();

                    // Add each team to the List Box
                    //  teamsListBox.Items.Add(inputFile.ReadLine());
                    teamsListBox.Items.Add(team);

                }

                // Close the file
                inputFile.Close();

                // Get the total of items (numbers) stored on the List Box
                totOfNum = teamsListBox.Items.Count;
                //MessageBox.Show(totOfNum.ToString());
            }

            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void findOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // *************** ARRAY ***************
                // Create an array to hold items read from the file
                const int SIZE = 108;                     // Constant to hold the size of the Array
                string[] winnerTeams = new string[SIZE];  

                int listIndex = 0; // Counter variable to use in the loop

                // Declare a StreamReader variable
                StreamReader inputFile;

                // Open the file and get StreamReader Object
                inputFile = File.OpenText("WorldSeriesWinners.txt");

                // Read the file's content into the array
                while (!inputFile.EndOfStream)
                {
                    winnerTeams[listIndex] = inputFile.ReadLine().ToString();
                    listIndex++;
                }

                // Close the file
                inputFile.Close();

                // ************* WIN TIMES *************

                // Get the selected item
                string selection = teamsListBox.SelectedItem.ToString();
                //MessageBox.Show(selection);

                int winTimes;

                winTimes = RepeatedTimes(winnerTeams, selection);

                // Display the message box with the winning times result
                MessageBox.Show("The " + selection + " have won " + winTimes.ToString() + " times the World Series");

            }

            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Cose the form
            this.Close();
        }
    }
}
