using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAb1_SW
{
    
    public partial class Form1 : Form
    {
        //UserContext db = new UserContext();
        SBContext db = new SBContext();

        public Form1()
        {
            InitializeComponent();

            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            save_btn.FlatAppearance.BorderSize = 0;
            save_btn.FlatStyle = FlatStyle.Flat;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;

            table_select.Items.Add("Book");
            table_select.Items.Add("Sage");
            table_select.SelectedIndex = 0;
        }
        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            firstLoad();

            SBContext db = new SBContext();

            var books = db.Book.ToList();
            foreach (var b in books) {
                listBox2.Items.Add( b.Id + ", Name: "+b.Name+", Year:"+ b.Year+",");
                listBox2.Items.Add("Description: "+ b.Description+";");
                listBox2.Items.Add("______________________________________");
                
            }
            var sage = db.Sages.ToList();
            foreach (var s in sage) {
                listBox1.Items.Add(s.ID+ ", Name: "+s.Name + ", City: "+ s.City + ", Age: " + s.Age+ ";");
                listBox1.Items.Add("______________________________________");
            }
            #region not entiti
            //SqlConnection con = new SqlConnection("data source=DESKTOP-29VI2D2;initial catalog=SBook;integrated security=True;App=EntityFramework");
            //con.Open();

            //SqlDataAdapter da = new SqlDataAdapter("select * from Books", con);
            //SqlDataAdapter da1 = new SqlDataAdapter("select * from Sages", con);
            //SqlCommandBuilder scb = new SqlCommandBuilder(da);
            //SqlCommandBuilder scb1 = new SqlCommandBuilder(da1);

            //DataSet ds = new DataSet();
            //DataSet ds1 = new DataSet();
            //da.Fill(ds, "Books");
            //da1.Fill(ds1, "Sages");
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGrV.DataSource = ds1.Tables[0];
            #endregion
        }
        private void firstLoad()
        {
            //var sage = new Sage { ID = 1, Name = "Stiven", Age = 35, City = "London", Photo = null, Book = new List<Books>() };
            //var sage1 = new Sage { ID = 2, Name = "SS", Age = 23, City = "Lviv", Photo = null, Book = new List<Books>()};

            //sage.Book.Add(new Books { Id = 1, Description = "Some text ", Name = "Space", Year = 2012 });
            //sage1.Book.Add(new Books { Id=2,Description="some text",Name = "Sss", Year=2000});

            //var rep = new SageRep();

            //rep.AddSage(sage);
            //rep.AddSage(sage1);

            MessageBox.Show("First load - is done" , "Load data in db", MessageBoxButtons.OK);
            #region create_new_item
            //SBContext db = new SBContext();
            //Books book1 = new Books
            //{
            //    Name = "It",
            //    Description = "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and 18th novel written under his own name. The story follows the experiences of seven children as they are terrorized by a being that exploits the fears and phobias of its victims to disguise itself while hunting its prey. It primarily appears in the form of a clown to attract its preferred prey of young children.",
            //    Year = 1986
            //};
            //Books book2 = new Books
            //{
            //    Name = "Doctor Sleep",
            //    Description = "Doctor Sleep is a horror novel by American writer Stephen King. Doctor Sleep is the 61st book published by Stephen King and it is his 50th novel, and the 43rd under his own name. It is a sequel to his novel The Shining (1977), released in September 2013.[1] King stated that it is a return to balls - to - the - wall, keep - the - lights - on horror. The book reached the first position on The New York Times Best Seller list for print and ebook fiction (combined), hardcover fiction, and ebook fiction. Doctor Sleep won the 2013 Bram Stoker Award for Best Novel",
            //    Year = 2013
            //};
            //Sage sage1 = new Sage { Name = "Stephen King", City = "Portland", Photo = "PhotoString", Age = 70 };
            //Sage sage2 = new Sage { Name = "Erich Remarque", City = "NewYourk", Photo = "PhotoString", Age = 72 };
            //db.Sages.Add(sage1);
            //book1.Sages = new List<Sage> { sage1 };
            //book2.Sages = new List<Sage> { sage1 };
            //db.Book.Add(book1);
            //db.Book.Add(book2);

            //db.Sages.Add(sage2);
            //book1.Sages = new List<Sage> { sage2 };
            //book2.Sages = new List<Sage> { sage2 };
            //db.Book.Add(book1);
            //db.Book.Add(book2);
            //db.SaveChanges();
            #endregion
        }
        //delete data item
        private void delete_btn_Click(object sender, EventArgs e)
        {
            var select = table_select.SelectedItem.ToString();
            //var select = "Sage";
            if (select == "Sage")
            {
                int id = Int32.Parse(id_sage_txt.Text);

                Sage sage = db.Sages.Where(s => s.ID == id).FirstOrDefault();
                db.Sages.Remove(sage);
                db.SaveChanges();
                UpdateForDelB();
                UpdateForDelS();
            }
            else if (select == "Book")
            {
                int id = Int32.Parse(id_b_txt.Text);
                Books book = db.Book.Where(b => b.Id == id).FirstOrDefault();

                db.Book.Remove(book);
                db.SaveChanges();
                UpdateForDelB();
                UpdateForDelS();
            }
            else {
                MessageBox.Show("Selest table in box", "Select", MessageBoxButtons.OK);
            }
        }
        //btn close
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save btn
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(id_b_txt.Text) || !string.IsNullOrWhiteSpace(id_b_txt.Text))
                {
                    int id;
                    Int32.TryParse(id_b_txt.Text, out id);

                    Books book = db.Book.Find(id);
                    Console.WriteLine(book.Name + " " + book.Year);
                    int Year;
                    Int32.TryParse(year_txt.Text, out Year);
                    book.Name = name_b_txt.Text;
                    book.Description = descrp_txt.Text;
                    book.Year = Year;
                    db.Entry(book).State = EntityState.Modified;
                    db.SaveChanges();
                }
                if (!string.IsNullOrEmpty(id_sage_txt.Text) || !string.IsNullOrWhiteSpace(id_sage_txt.Text))
                {

                    int idSage;
                    Int32.TryParse(id_sage_txt.Text, out idSage);

                    Sage sage = db.Sages.Find(idSage);
                    Console.WriteLine(sage.Name + " " + sage.ID);
                    string name = name_txt.Text;
                    string city = city_txt.Text;
                    int age;
                    Int32.TryParse(age_txt.Text, out age);
                    sage.Name = name;
                    sage.City = city;
                    sage.Age = age;
                    db.Entry(sage).State = EntityState.Modified;
                    db.SaveChanges();
                }
            } catch (Exception ex) { }

        }
        #region clear
        private void upload_photo_Click(object sender, EventArgs e)
        {
          
        }

        private void Clear_sage()
        {
            name_txt.Clear();
            city_txt.Clear();
            age_txt.Clear();
            id_sage_txt.Clear();
       
        }
        private void Clear_book()
        {
            name_b_txt.Clear();
            descrp_txt.Clear();
            year_txt.Clear();
            id_b_txt.Clear();
        }
        private void clear_fields_Click(object sender, EventArgs e)
        {
            Clear_sage();
        }

        private void clear_fields1_Click(object sender, EventArgs e)
        {
            Clear_book();
        }
        #endregion
        //add new position book or sages 
        private void add_new_Click(object sender, EventArgs e)
        {
            var select = table_select.SelectedItem.ToString();
            if (select == "Sage")
            {
                int id;
                Int32.TryParse(id_sage_txt.Text, out id);
                String Name = name_txt.Text;
                String City = city_txt.Text;
                int age;
                Int32.TryParse(age_txt.Text, out age);

                var sage = new Sage { Name = Name, City = City, Age = age, Photo = null, ID = id, Book = new List<Books>() };
                var rep = new SageRep();
                rep.AddSage(sage);
                UpdateListSages(0);
            
            } else {
                int id;
                Int32.TryParse(id_b_txt.Text, out id);
                String Name = name_b_txt.Text;
                String Descr = descrp_txt.Text;
                int year;
                Int32.TryParse( year_txt.Text ,out year);

                var sage = new Sage { };
                sage.Book.Add(new Books {Name = Name, Description = Descr, Year = year });
                var rep = new SageRep();
                rep.AddSage(sage);
                UpdateListBooks(0);
            }
            
        }
        #region update_date
        private void UpdateListSages(int n)
        {
            //int id_temp = Int32.Parse(id_sage_txt.Text);
            if (id_sage_txt.Text != "" || n!=0)
            {
                int id; Int32.TryParse(id_sage_txt.Text, out id);
                Sage sage = db.Sages.Where(s => s.ID == id).FirstOrDefault();

                sage.Name = name_txt.Text;
                sage.City = city_txt.Text;
                sage.Age = Int32.Parse(age_txt.Text);

                listBox1.Items.Clear();
                var sages = db.Sages.ToList();
                foreach (var s in sages)
                {
                    listBox1.Items.Add(s.ID + ", Name: " + s.Name + ", City: " + s.City + ", Age: " + s.Age + ";");
                    listBox1.Items.Add("______________________________________");

                }
            }
            else {
                listBox1.Items.Clear();
                var sages = db.Sages.ToList();
                foreach (var s in sages)
                {
                    listBox1.Items.Add(s.ID + ", Name: " + s.Name + ", City: " + s.City + ", Age: " + s.Age + ";");
                    listBox1.Items.Add("______________________________________");
                }
                MessageBox.Show("Update completed successfully","Update",MessageBoxButtons.OK);
            }
            
        }
        private void UpdateForDelS()
        {
            listBox1.Items.Clear();
            var sages = db.Sages.ToList();
            foreach (var s in sages)
            {
                listBox1.Items.Add(s.ID + ", Name: " + s.Name + ", City: " + s.City + ", Age: " + s.Age + ";");
                listBox1.Items.Add("______________________________________");
            }
            MessageBox.Show("Update completed successfully", "Update", MessageBoxButtons.OK);
        }
        private void UpdateForDelB()
        {
            listBox2.Items.Clear();
            var books = db.Book.ToList();
            foreach (var b in books)
            {
                listBox2.Items.Add(b.Id + ", Name: " + b.Name + ", Year:" + b.Year + ",");
                listBox2.Items.Add("Description: " + b.Description + ";");
                listBox2.Items.Add("______________________________________");

            }
        }

        private void UpdateListBooks(int k)
        {
            if (id_b_txt.Text != "" || k!=0)
            {
                int id = Int32.Parse(id_b_txt.Text);
                Books book = db.Book.Where(b => b.Id == id).FirstOrDefault();

                book.Name = name_b_txt.Text;
                book.Description = descrp_txt.Text;
                book.Year = Int32.Parse(year_txt.Text);

                listBox2.Items.Clear();
                var books = db.Book.ToList();
                foreach (var b in books)
                {
                    listBox2.Items.Add(b.Id + ", Name: " + b.Name + ", Year:" + b.Year + ",");
                    listBox2.Items.Add("Description: " + b.Description + ";");
                    listBox2.Items.Add("______________________________________");

                }
            }
            else {
                listBox2.Items.Clear();
                var books = db.Book.ToList();
                foreach (var b in books)
                {
                    listBox2.Items.Add(b.Id + ", Name: " + b.Name + ", Year:" + b.Year + ",");
                    listBox2.Items.Add("Description: " + b.Description + ";");
                    listBox2.Items.Add("______________________________________");

                }
            }
            
        }
        private void Update_Save()
        {
            db.SaveChanges();
            UpdateListBooks(1);
            UpdateListSages(1);
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateListBooks(1);
            UpdateListSages(1);
            Clear_book();
            Clear_sage();
        }
        #endregion
        //add
        private void add_Click(object sender, EventArgs e)
        {
            String str;
            int Id;

            var select = table_select.SelectedItem.ToString();
            if (select == "Sage")
            {
                Int32.TryParse(id_sage_txt.Text, out Id);

                Sage sage = db.Sages.Find(Id);
                AddS adds = new AddS(Id, db);
                adds.Show();
            }
            else {
                
                Int32.TryParse(id_b_txt.Text, out Id);
                Console.WriteLine(Id);
                AddB addb = new AddB(Id, db);
                addb.Show();
            }

        }
        #region listbox_change
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String value = listBox2.SelectedItem.ToString();
                String[] some_text = value.Split(',');
                int d; Int32.TryParse(some_text[0], out d);
                String str = listBox2.SelectedItem.ToString();

                Books book = db.Book.Where(b => b.Id == d).FirstOrDefault();

                id_b_txt.Text = book.Id.ToString();
                name_b_txt.Text = book.Name;
                descrp_txt.Text = book.Description;
                year_txt.Text = book.Year.ToString();

                var bookSages = db.Book.ToList();

                listBox2.Items.Clear();

                foreach (var b in bookSages)
                {
                    listBox2.Items.Add(b.Id + ", Name: " + b.Name + ", Year:" + b.Year + ",");
                    listBox2.Items.Add("Descriptions:" + b.Description);
                    listBox2.Items.Add("______________________________________");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Виберіть правильну стрічку з номером.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String value = listBox1.SelectedItem.ToString();
                Char koma = ',';
                String[] some_text = value.Split(koma);
                string k = some_text[0];
                int d; Int32.TryParse(k,out d);

                Sage sage = db.Sages.Where(b => b.ID == d).FirstOrDefault();

                id_sage_txt.Text = sage.ID.ToString();
                name_txt.Text = sage.Name;
                city_txt.Text = sage.City;
                age_txt.Text = sage.Age.ToString();

                var sageBooks = db.Sages.ToList();

                listBox1.Items.Clear();

                foreach (var s in sageBooks)
                {
                    listBox1.Items.Add(s.ID + ", Name: " + s.Name + ", City: " + s.City + ", Age: " + s.Age + ";");
                    listBox1.Items.Add("______________________________________");
                }
            }
                catch (Exception ex) {
                MessageBox.Show("Виберіть правильну стрічку з номером.", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        
    }
}
