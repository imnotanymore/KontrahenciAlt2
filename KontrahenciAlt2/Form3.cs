using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrahenciAlt2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Kontrahenci' . Możesz go przenieść lub usunąć.
            this.kontrahenciTableAdapter.FillBy(this.database1DataSet.Kontrahenci);

        }

    }
}
