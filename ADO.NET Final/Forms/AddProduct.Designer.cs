namespace ADO.NET_Final
{
    partial class AddProduct
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
            this.CatIdtxtbox = new System.Windows.Forms.TextBox();
            this.Quantitytxtbox = new System.Windows.Forms.TextBox();
            this.Pricetxtbox = new System.Windows.Forms.TextBox();
            this.CatIdlbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Ratingtxtbox = new System.Windows.Forms.TextBox();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.Ratinglbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatIdtxtbox
            // 
            this.CatIdtxtbox.Location = new System.Drawing.Point(37, 124);
            this.CatIdtxtbox.Name = "CatIdtxtbox";
            this.CatIdtxtbox.Size = new System.Drawing.Size(141, 23);
            this.CatIdtxtbox.TabIndex = 29;
            // 
            // Quantitytxtbox
            // 
            this.Quantitytxtbox.Location = new System.Drawing.Point(264, 126);
            this.Quantitytxtbox.Name = "Quantitytxtbox";
            this.Quantitytxtbox.Size = new System.Drawing.Size(141, 23);
            this.Quantitytxtbox.TabIndex = 28;
            // 
            // Pricetxtbox
            // 
            this.Pricetxtbox.Location = new System.Drawing.Point(264, 54);
            this.Pricetxtbox.Name = "Pricetxtbox";
            this.Pricetxtbox.Size = new System.Drawing.Size(141, 23);
            this.Pricetxtbox.TabIndex = 27;
            // 
            // CatIdlbl
            // 
            this.CatIdlbl.AutoSize = true;
            this.CatIdlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CatIdlbl.Location = new System.Drawing.Point(37, 104);
            this.CatIdlbl.Name = "CatIdlbl";
            this.CatIdlbl.Size = new System.Drawing.Size(80, 17);
            this.CatIdlbl.TabIndex = 26;
            this.CatIdlbl.Text = "Category Id";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quantitylbl.Location = new System.Drawing.Point(264, 106);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(61, 17);
            this.Quantitylbl.TabIndex = 25;
            this.Quantitylbl.Text = "Quantity";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pricelbl.Location = new System.Drawing.Point(264, 34);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(37, 17);
            this.Pricelbl.TabIndex = 24;
            this.Pricelbl.Text = "Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(264, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(111, 245);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(79, 27);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Ratingtxtbox
            // 
            this.Ratingtxtbox.Location = new System.Drawing.Point(143, 190);
            this.Ratingtxtbox.Name = "Ratingtxtbox";
            this.Ratingtxtbox.Size = new System.Drawing.Size(141, 23);
            this.Ratingtxtbox.TabIndex = 21;
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Location = new System.Drawing.Point(37, 54);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(141, 23);
            this.Nametxtbox.TabIndex = 20;
            // 
            // Ratinglbl
            // 
            this.Ratinglbl.AutoSize = true;
            this.Ratinglbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ratinglbl.Location = new System.Drawing.Point(143, 170);
            this.Ratinglbl.Name = "Ratinglbl";
            this.Ratinglbl.Size = new System.Drawing.Size(47, 17);
            this.Ratinglbl.TabIndex = 18;
            this.Ratinglbl.Text = "Rating";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(37, 34);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 17);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Name";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 340);
            this.Controls.Add(this.CatIdtxtbox);
            this.Controls.Add(this.Quantitytxtbox);
            this.Controls.Add(this.Pricetxtbox);
            this.Controls.Add(this.CatIdlbl);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Ratingtxtbox);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.Ratinglbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "AddProduct";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CatIdtxtbox;
        private TextBox Quantitytxtbox;
        private TextBox Pricetxtbox;
        private Label CatIdlbl;
        private Label Quantitylbl;
        private Label Pricelbl;
        private Button button1;
        private Button SaveBtn;
        private TextBox Ratingtxtbox;
        private TextBox Nametxtbox;
        private Label Ratinglbl;
        private Label NameLbl;
    }
}