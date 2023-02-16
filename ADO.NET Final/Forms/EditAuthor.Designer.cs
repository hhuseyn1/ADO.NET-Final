namespace ADO.NET_Final
{
    partial class EditAuthor
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
            this.IdLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.Idtxtbox = new System.Windows.Forms.TextBox();
            this.FirstNametxtbox = new System.Windows.Forms.TextBox();
            this.LastNametxtbox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLbl.Location = new System.Drawing.Point(23, 22);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(20, 17);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "Id";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLbl.Location = new System.Drawing.Point(23, 94);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(70, 17);
            this.FirstNameLbl.TabIndex = 1;
            this.FirstNameLbl.Text = "FirstName";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLbl.Location = new System.Drawing.Point(23, 176);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(68, 17);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "LastName";
            // 
            // Idtxtbox
            // 
            this.Idtxtbox.Location = new System.Drawing.Point(23, 42);
            this.Idtxtbox.Name = "Idtxtbox";
            this.Idtxtbox.Size = new System.Drawing.Size(141, 23);
            this.Idtxtbox.TabIndex = 3;
            // 
            // FirstNametxtbox
            // 
            this.FirstNametxtbox.Location = new System.Drawing.Point(23, 114);
            this.FirstNametxtbox.Name = "FirstNametxtbox";
            this.FirstNametxtbox.Size = new System.Drawing.Size(141, 23);
            this.FirstNametxtbox.TabIndex = 4;
            // 
            // LastNametxtbox
            // 
            this.LastNametxtbox.Location = new System.Drawing.Point(23, 196);
            this.LastNametxtbox.Name = "LastNametxtbox";
            this.LastNametxtbox.Size = new System.Drawing.Size(141, 23);
            this.LastNametxtbox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(23, 264);
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
            this.CancelBtn.Location = new System.Drawing.Point(133, 264);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 27);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 375);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LastNametxtbox);
            this.Controls.Add(this.FirstNametxtbox);
            this.Controls.Add(this.Idtxtbox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.IdLbl);
            this.Name = "EditAuthor";
            this.Text = "EditAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IdLbl;
        private Label FirstNameLbl;
        private Label LastNameLbl;
        private TextBox Idtxtbox;
        private TextBox FirstNametxtbox;
        private TextBox LastNametxtbox;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}