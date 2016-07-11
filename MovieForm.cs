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
    public partial class MovieForm : Form
    {
        Form1 form1;
        public MovieForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
          movieBindingSource.DataSource = form1.database.Movies;
        }


   

        private void MovieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Movie' table. You can move, or remove it, as needed.
            
            
        
        }

      

        private void movieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void movieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            movieBindingSource.EndEdit();
            form1.database.SubmitChanges();
        }

      
        
    }
}
