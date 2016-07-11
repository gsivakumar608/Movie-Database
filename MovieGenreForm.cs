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
    public partial class MovieGenreForm : Form
    {
        Form1 form1;
        public MovieGenreForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            movieGenreBindingSource.DataSource = form1.database.MovieGenres;
        }

        private void movieGenreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieGenreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            form1.database.SubmitChanges();

        }

        private void MovieGenreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.MovieGenre' table. You can move, or remove it, as needed.
            this.movieGenreTableAdapter.Fill(this.movieDatabaseDataSet.MovieGenre);

        }
    }
}
