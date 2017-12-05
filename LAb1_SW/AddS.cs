using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace LAb1_SW
{
    public partial class AddS : Form
        
    {
        private SBContext db;
        private int id;

         public AddS(int id, SBContext db)
        {

            InitializeComponent();
            this.id = id;
            this.db = db;
            UpdateListBoxes();
        }

        private void UpdateListBoxes()
        {
            try
            {
                var sage = db.Sages.Find(id);
                List<Books> books = sage.Book.ToList();
                var allBooks = db.Book.ToList();
                foreach (var b in books)
                {
                    allBooks.Remove(b);
                }
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (var b in allBooks)
                {
                    listBox1.Items.Add(b.Name);
                }
                foreach (var b in books)
                {
                    listBox2.Items.Add(b.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("","", MessageBoxButtons.OK);
            }
        }
        
        

        private void add_Click(object sender, EventArgs e)
        {
            String str = listBox1.SelectedItem.ToString();

            Books book = db.Book.Where(b => b.Name == str).FirstOrDefault();
            Sage sage = db.Sages.Find(id);

            sage.Book.Add(book);
            db.Entry(sage).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            UpdateListBoxes();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            String val = listBox2.SelectedItem.ToString();

            Sage sage = db.Sages.Find(id);

            Books book = db.Book.Where(b => b.Name == val).FirstOrDefault();
            sage.Book.Remove(book);
            db.Entry(sage).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            UpdateListBoxes();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
