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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patryk\source\repos\KontrahenciAlt2\KontrahenciAlt2\Database1.mdf;Integrated Security=True");
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand sm = new SqlCommand("insert into Kontrahenci (Name, NIP, City, Adress, Phone) values('" + textName.Text + "', '" + textNIP.Text + "', '" + textCity.Text + "','" + textAdress.Text + "','" + textPhone.Text + "')", sc);

            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();


            MessageBox.Show("Zapisano");
           
            this.Close();
        }
      
    }
}
