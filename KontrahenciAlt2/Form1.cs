using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KontrahenciAlt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            this.kontrahenciTableAdapter.FillBy(this.database1DataSet.Kontrahenci);


        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Form3 f = new Form3();
                
                f.Show();
            }
        }

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patryk\source\repos\KontrahenciAlt2\KontrahenciAlt2\Database1.mdf;Integrated Security=True");
         

                SqlCommand sm = new SqlCommand("Delete Kontrahenci where Id = @Id", sc);          
                sc.Open();
                sm.ExecuteNonQuery();
                sc.Close();


                MessageBox.Show("Zapisano");

                this.Close();
            
        }

        private void buttonRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            this.kontrahenciTableAdapter.FillBy(this.database1DataSet.Kontrahenci);
        }
    }
}

