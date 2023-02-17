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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LastNametxtbox = new System.Windows.Forms.TextBox();
            this.FirstNametxtbox = new System.Windows.Forms.TextBox();
            this.Idtxtbox = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(140, 281);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 27);
            this.CancelBtn.TabIndex = 15;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(30, 281);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 27);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // LastNametxtbox
            // 
            this.LastNametxtbox.Location = new System.Drawing.Point(30, 213);
            this.LastNametxtbox.Name = "LastNametxtbox";
            this.LastNametxtbox.Size = new System.Drawing.Size(141, 23);
            this.LastNametxtbox.TabIndex = 13;
            // 
            // FirstNametxtbox
            // 
            this.FirstNametxtbox.Location = new System.Drawing.Point(30, 131);
            this.FirstNametxtbox.Name = "FirstNametxtbox";
            this.FirstNametxtbox.Size = new System.Drawing.Size(141, 23);
            this.FirstNametxtbox.TabIndex = 12;
            // 
            // Idtxtbox
            // 
            this.Idtxtbox.Location = new System.Drawing.Point(30, 59);
            this.Idtxtbox.Name = "Idtxtbox";
            this.Idtxtbox.Size = new System.Drawing.Size(141, 23);
            this.Idtxtbox.TabIndex = 11;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLbl.Location = new System.Drawing.Point(30, 193);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(68, 17);
            this.LastNameLbl.TabIndex = 10;
            this.LastNameLbl.Text = "LastName";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLbl.Location = new System.Drawing.Point(30, 111);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(70, 17);
            this.FirstNameLbl.TabIndex = 9;
            this.FirstNameLbl.Text = "FirstName";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLbl.Location = new System.Drawing.Point(30, 39);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(20, 17);
            this.IdLbl.TabIndex = 8;
            this.IdLbl.Text = "Id";
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 408);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LastNametxtbox);
            this.Controls.Add(this.FirstNametxtbox);
            this.Controls.Add(this.Idtxtbox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.IdLbl);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button AddBtn;
        private TextBox LastNametxtbox;
        private TextBox FirstNametxtbox;
        private TextBox Idtxtbox;
        private Label LastNameLbl;
        private Label FirstNameLbl;
        private Label IdLbl;
    }
}