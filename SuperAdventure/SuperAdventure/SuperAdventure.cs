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

            // Creates a new Player object, and assigns it to the object _player
            _player = new Player();

            // Assign values to the properties of the _player object
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            // Get the values of the properties of the _player object and assign them to the labels on screen
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }



        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
