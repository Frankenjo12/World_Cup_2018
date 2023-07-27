using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App
{
    public partial class Initial_settings : Form
    {
        private const string PATH = @"../../../../DAL/Repo/Config/Config.txt";

        public Initial_settings()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

            string[] lines = new string[3];

            if (rbMale.Checked)
                lines[0] = "GENDER=MALE";
            else
                lines[0] = "GENDER=FEMALE";

            if (rbEnglish.Checked)
                lines[1] = "LANGUAGE=ENGLISH";
            else
                lines[1] = "LANGUAGE=CROATIAN";

            if (rbAPI.Checked)
                lines[2] = "REPOSITORY=API";
            else
                lines[2] = "REPOSITORY=FILE";

            File.WriteAllLines(PATH, lines);

            var fnt = new Favorite_National_Team();
            fnt.Show();
            this.Hide();
        }
    }
}
