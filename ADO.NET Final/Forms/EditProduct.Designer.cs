namespace ADO.NET_Final
{
    partial class EditProduct
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.Ratinglbl = new System.Windows.Forms.Label();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.Ratingtxtbox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CatIdtxtbox = new System.Windows.Forms.TextBox();
            this.Quantitytxtbox = new System.Windows.Forms.TextBox();
            this.Pricetxtbox = new System.Windows.Forms.TextBox();
            this.CatIdlbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(25, 22);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 17);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // Ratinglbl
            // 
            this.Ratinglbl.AutoSize = true;
            this.Ratinglbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ratinglbl.Location = new System.Drawing.Point(119, 164);
            this.Ratinglbl.Name = "Ratinglbl";
            this.Ratinglbl.Size = new System.Drawing.Size(47, 17);
            this.Ratinglbl.TabIndex = 2;
            this.Ratinglbl.Text = "Rating";
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Location = new System.Drawing.Point(25, 42);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(141, 23);
            this.Nametxtbox.TabIndex = 4;
            // 
            // Ratingtxtbox
            // 
            this.Ratingtxtbox.Location = new System.Drawing.Point(119, 184);
            this.Ratingtxtbox.Name = "Ratingtxtbox";
            this.Ratingtxtbox.Size = new System.Drawing.Size(141, 23);
            this.Ratingtxtbox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(85, 233);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(79, 27);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(238, 233);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 27);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CatIdtxtbox
            // 
            this.CatIdtxtbox.Location = new System.Drawing.Point(25, 112);
            this.CatIdtxtbox.Name = "CatIdtxtbox";
            this.CatIdtxtbox.Size = new System.Drawing.Size(141, 23);
            this.CatIdtxtbox.TabIndex = 13;
            // 
            // Quantitytxtbox
            // 
            this.Quantitytxtbox.Location = new System.Drawing.Point(238, 114);
            this.Quantitytxtbox.Name = "Quantitytxtbox";
            this.Quantitytxtbox.Size = new System.Drawing.Size(141, 23);
            this.Quantitytxtbox.TabIndex = 12;
            // 
            // Pricetxtbox
            // 
            this.Pricetxtbox.Location = new System.Drawing.Point(238, 42);
            this.Pricetxtbox.Name = "Pricetxtbox";
            this.Pricetxtbox.Size = new System.Drawing.Size(141, 23);
            this.Pricetxtbox.TabIndex = 11;
            // 
            // CatIdlbl
            // 
            this.CatIdlbl.AutoSize = true;
            this.CatIdlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CatIdlbl.Location = new System.Drawing.Point(25, 92);
            this.CatIdlbl.Name = "CatIdlbl";
            this.CatIdlbl.Size = new System.Drawing.Size(80, 17);
            this.CatIdlbl.TabIndex = 10;
            this.CatIdlbl.Text = "Category Id";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quantitylbl.Location = new System.Drawing.Point(238, 94);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(61, 17);
            this.Quantitylbl.TabIndex = 9;
            this.Quantitylbl.Text = "Quantity";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pricelbl.Location = new System.Drawing.Point(238, 22);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(37, 17);
            this.Pricelbl.TabIndex = 8;
            this.Pricelbl.Text = "Price";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 322);
            this.Controls.Add(this.CatIdtxtbox);
            this.Controls.Add(this.Quantitytxtbox);
            this.Controls.Add(this.Pricetxtbox);
            this.Controls.Add(this.CatIdlbl);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Ratingtxtbox);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.Ratinglbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "EditProduct";
            this.Text = "EditAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label NameLbl;
        private Label Ratinglbl;
        private TextBox Nametxtbox;
        private TextBox Ratingtxtbox;
        private Button SaveBtn;
        private Button CancelBtn;
        private TextBox CatIdtxtbox;
        private TextBox Quantitytxtbox;
        private TextBox Pricetxtbox;
        private Label CatIdlbl;
        private Label Quantitylbl;
        private Label Pricelbl;
    }
}