using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MoviePersonForm : Form
    {
        Form1 form1;
        public MoviePersonForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            moviePersonBindingSource.DataSource = form1.database.MoviePersons;
        }

        private void moviePersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviePersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
                form1.database.SubmitChanges();

        }

        private void MoviePersonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.MoviePerson' table. You can move, or remove it, as needed.
            this.moviePersonTableAdapter.Fill(this.movieDatabaseDataSet.MoviePerson);

        }
    }
}
