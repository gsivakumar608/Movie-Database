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
    public partial class GenreForm : Form
    {
        Form1 form1;
        public GenreForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            genreBindingSource.DataSource = form1.database.Genres;
        }

        private void genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            form1.database.SubmitChanges();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.movieDatabaseDataSet.Genre);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
    }
}
