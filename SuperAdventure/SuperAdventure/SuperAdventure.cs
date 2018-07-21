using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Find Player class in Engine project. Do this for each class when it used classes from different projects
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        // Creating a class level variable by having it inside class, but outside functions or methods
        // Scope Datatype Name
        private Player _player;

        public SuperAdventure()
        {
            // This is the constructor for the class, gets called when we create a new ofject of the class - in this case, the form
            InitializeComponent();

            // Now using the default constructor of Location
			Location location = new Location(1, "Home", "This is your house.");
            
            // Creates a new Player object, and assigns it to the object _player
            // Assign values to the properties of the _player object using the Constructor created in the Player class
			_player = new Player(10, 10, 20, 0,1);

            // Get the values of the properties of the _player object and assign them to the labels on screen
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }



        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
