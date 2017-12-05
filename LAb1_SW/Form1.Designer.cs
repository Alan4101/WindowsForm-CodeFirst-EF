namespace LAb1_SW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_sage = new System.Windows.Forms.Panel();
            this.panel_book = new System.Windows.Forms.Panel();
            this.Book = new System.Windows.Forms.Label();
            this.clear_fields1 = new System.Windows.Forms.Button();
            this.id_b_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.descrp_txt = new System.Windows.Forms.TextBox();
            this.name_b_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_db = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clear_fields = new System.Windows.Forms.Button();
            this.id_sage_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.table_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.close = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.add_new = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel_sage.SuspendLayout();
            this.panel_book.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sage
            // 
            this.panel_sage.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_sage.Controls.Add(this.label9);
            this.panel_sage.Controls.Add(this.clear_fields);
            this.panel_sage.Controls.Add(this.id_sage_txt);
            this.panel_sage.Controls.Add(this.label2);
            this.panel_sage.Controls.Add(this.age_txt);
            this.panel_sage.Controls.Add(this.city_txt);
            this.panel_sage.Controls.Add(this.name_txt);
            this.panel_sage.Controls.Add(this.label5);
            this.panel_sage.Controls.Add(this.label3);
            this.panel_sage.Controls.Add(this.l1);
            this.panel_sage.Location = new System.Drawing.Point(0, 57);
            this.panel_sage.Name = "panel_sage";
            this.panel_sage.Size = new System.Drawing.Size(348, 239);
            this.panel_sage.TabIndex = 0;
            // 
            // panel_book
            // 
            this.panel_book.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_book.Controls.Add(this.Book);
            this.panel_book.Controls.Add(this.clear_fields1);
            this.panel_book.Controls.Add(this.id_b_txt);
            this.panel_book.Controls.Add(this.label4);
            this.panel_book.Controls.Add(this.year_txt);
            this.panel_book.Controls.Add(this.descrp_txt);
            this.panel_book.Controls.Add(this.name_b_txt);
            this.panel_book.Controls.Add(this.label6);
            this.panel_book.Controls.Add(this.label7);
            this.panel_book.Controls.Add(this.label8);
            this.panel_book.Controls.Add(this.id_db);
            this.panel_book.Location = new System.Drawing.Point(364, 57);
            this.panel_book.Name = "panel_book";
            this.panel_book.Size = new System.Drawing.Size(369, 239);
            this.panel_book.TabIndex = 12;
            // 
            // Book
            // 
            this.Book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Book.AutoSize = true;
            this.Book.Location = new System.Drawing.Point(318, 15);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(35, 15);
            this.Book.TabIndex = 21;
            this.Book.Text = "Book";
            // 
            // clear_fields1
            // 
            this.clear_fields1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_fields1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.clear_fields1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_fields1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_fields1.ImageKey = "(none)";
            this.clear_fields1.Location = new System.Drawing.Point(271, 193);
            this.clear_fields1.Name = "clear_fields1";
            this.clear_fields1.Size = new System.Drawing.Size(83, 33);
            this.clear_fields1.TabIndex = 20;
            this.clear_fields1.Text = "Clear";
            this.clear_fields1.UseVisualStyleBackColor = false;
            this.clear_fields1.Click += new System.EventHandler(this.clear_fields1_Click);
            // 
            // id_b_txt
            // 
            this.id_b_txt.Location = new System.Drawing.Point(41, 203);
            this.id_b_txt.Name = "id_b_txt";
            this.id_b_txt.Size = new System.Drawing.Size(206, 23);
            this.id_b_txt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // year_txt
            // 
            this.year_txt.Location = new System.Drawing.Point(41, 146);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(206, 23);
            this.year_txt.TabIndex = 17;
            // 
            // descrp_txt
            // 
            this.descrp_txt.Location = new System.Drawing.Point(41, 89);
            this.descrp_txt.Name = "descrp_txt";
            this.descrp_txt.Size = new System.Drawing.Size(206, 23);
            this.descrp_txt.TabIndex = 16;
            // 
            // name_b_txt
            // 
            this.name_b_txt.Location = new System.Drawing.Point(41, 30);
            this.name_b_txt.Name = "name_b_txt";
            this.name_b_txt.Size = new System.Drawing.Size(206, 23);
            this.name_b_txt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name";
            // 
            // id_db
            // 
            this.id_db.AutoSize = true;
            this.id_db.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_db.Location = new System.Drawing.Point(169, 15);
            this.id_db.Name = "id_db";
            this.id_db.Size = new System.Drawing.Size(0, 15);
            this.id_db.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sage";
            // 
            // clear_fields
            // 
            this.clear_fields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_fields.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.clear_fields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_fields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_fields.ImageKey = "(none)";
            this.clear_fields.Location = new System.Drawing.Point(238, 196);
            this.clear_fields.Name = "clear_fields";
            this.clear_fields.Size = new System.Drawing.Size(83, 33);
            this.clear_fields.TabIndex = 12;
            this.clear_fields.Text = "Clear";
            this.clear_fields.UseVisualStyleBackColor = false;
            this.clear_fields.Click += new System.EventHandler(this.clear_fields_Click);
            // 
            // id_sage_txt
            // 
            this.id_sage_txt.Location = new System.Drawing.Point(45, 203);
            this.id_sage_txt.Name = "id_sage_txt";
            this.id_sage_txt.Size = new System.Drawing.Size(165, 23);
            this.id_sage_txt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(45, 146);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(165, 23);
            this.age_txt.TabIndex = 8;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(45, 89);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(165, 23);
            this.city_txt.TabIndex = 6;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(45, 30);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(165, 23);
            this.name_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "City";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(19, 12);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(35, 15);
            this.l1.TabIndex = 0;
            this.l1.Text = "Name";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.ImageKey = "(none)";
            this.save_btn.Location = new System.Drawing.Point(16, 321);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(83, 33);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_btn.Image")));
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(483, 321);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(114, 33);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(617, 321);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 33);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // table_select
            // 
            this.table_select.FormattingEnabled = true;
            this.table_select.Location = new System.Drawing.Point(122, 14);
            this.table_select.Name = "table_select";
            this.table_select.Size = new System.Drawing.Size(161, 23);
            this.table_select.TabIndex = 5;
            //this.table_select.SelectedIndexChanged += new System.EventHandler(this.table_select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select tabble";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(701, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 33);
            this.close.TabIndex = 7;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 382);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 169);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(364, 382);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(369, 169);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // add_new
            // 
            this.add_new.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_new.ImageKey = "(none)";
            this.add_new.Location = new System.Drawing.Point(140, 321);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(83, 33);
            this.add_new.TabIndex = 10;
            this.add_new.Text = "Add new";
            this.add_new.UseVisualStyleBackColor = false;
            this.add_new.Click += new System.EventHandler(this.add_new_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.ImageKey = "(none)";
            this.add.Location = new System.Drawing.Point(265, 321);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(83, 33);
            this.add.TabIndex = 11;
            this.add.Text = "Add ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(735, 572);
            this.Controls.Add(this.panel_book);
            this.Controls.Add(this.add);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_select);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.panel_sage);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sage-Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_sage.ResumeLayout(false);
            this.panel_sage.PerformLayout();
            this.panel_book.ResumeLayout(false);
            this.panel_book.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_sage;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label id_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox table_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox id_sage_txt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel_book;
        private System.Windows.Forms.Button add_new;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox id_b_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.TextBox descrp_txt;
        private System.Windows.Forms.TextBox name_b_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear_fields;
        private System.Windows.Forms.Button clear_fields1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Book;
    }
}

