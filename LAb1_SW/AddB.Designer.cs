namespace LAb1_SW
{
    partial class AddB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddB));
            this.close = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(710, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 33);
            this.close.TabIndex = 8;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 199);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(405, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(295, 199);
            this.listBox2.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.ImageKey = "(none)";
            this.delete.Location = new System.Drawing.Point(617, 298);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(83, 33);
            this.delete.TabIndex = 24;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.ImageKey = "(none)";
            this.add.Location = new System.Drawing.Point(265, 298);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(83, 33);
            this.add.TabIndex = 23;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            // 
            // AddB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(754, 356);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddB";
            this.Text = "AddB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
    }
}