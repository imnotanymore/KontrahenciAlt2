
namespace KontrahenciAlt2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new KontrahenciAlt2.Database1DataSet();
            this.kontrahenciTableAdapter = new KontrahenciAlt2.Database1DataSetTableAdapters.KontrahenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(663, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(663, 42);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRefresh_MouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(663, 72);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDelete_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kontrahenciBindingSource, "NIP", true));
            this.listBox1.DataSource = this.kontrahenciBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(613, 420);
            this.listBox1.TabIndex = 4;
            this.listBox1.ValueMember = "Id";
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "Kontrahenci";
            this.kontrahenciBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontrahenciTableAdapter
            // 
            this.kontrahenciTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Kontrahenci";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private Database1DataSetTableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
    }
}

