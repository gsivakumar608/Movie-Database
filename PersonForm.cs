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
    public partial class PersonForm : Form
    {
        Form1 form1;
        public PersonForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            personBindingSource.DataSource = form1.database.Persons;
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            form1.database.SubmitChanges();

        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.movieDatabaseDataSet.Person);

        }
    }
}
