namespace LibraryAutomationWinForm
{
    partial class ActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lendbtn = new System.Windows.Forms.Button();
            this.RemoveBookbtn = new System.Windows.Forms.Button();
            this.EditBookbtn = new System.Windows.Forms.Button();
            this.AddBookbtn = new System.Windows.Forms.Button();
            this.Booksbtn = new System.Windows.Forms.Button();
            this.RemoveUserbtn = new System.Windows.Forms.Button();
            this.EditUserbtn = new System.Windows.Forms.Button();
            this.AddUserbtn = new System.Windows.Forms.Button();
            this.Usersbtn = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.Lendbtn);
            this.panel1.Controls.Add(this.RemoveBookbtn);
            this.panel1.Controls.Add(this.EditBookbtn);
            this.panel1.Controls.Add(this.AddBookbtn);
            this.panel1.Controls.Add(this.Booksbtn);
            this.panel1.Controls.Add(this.RemoveUserbtn);
            this.panel1.Controls.Add(this.EditUserbtn);
            this.panel1.Controls.Add(this.AddUserbtn);
            this.panel1.Controls.Add(this.Usersbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 756);
            this.panel1.TabIndex = 0;
            // 
            // Lendbtn
            // 
            this.Lendbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Lendbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lendbtn.Image = ((System.Drawing.Image)(resources.GetObject("Lendbtn.Image")));
            this.Lendbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lendbtn.Location = new System.Drawing.Point(0, 845);
            this.Lendbtn.Name = "Lendbtn";
            this.Lendbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lendbtn.Size = new System.Drawing.Size(199, 105);
            this.Lendbtn.TabIndex = 8;
            this.Lendbtn.Text = "            Lend";
            this.Lendbtn.UseVisualStyleBackColor = false;
            this.Lendbtn.Click += new System.EventHandler(this.Lendbtn_Click);
            // 
            // RemoveBookbtn
            // 
            this.RemoveBookbtn.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveBookbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveBookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveBookbtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBookbtn.Image")));
            this.RemoveBookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBookbtn.Location = new System.Drawing.Point(0, 740);
            this.RemoveBookbtn.Name = "RemoveBookbtn";
            this.RemoveBookbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.RemoveBookbtn.Size = new System.Drawing.Size(199, 105);
            this.RemoveBookbtn.TabIndex = 7;
            this.RemoveBookbtn.Text = "             Remove";
            this.RemoveBookbtn.UseVisualStyleBackColor = false;
            this.RemoveBookbtn.Click += new System.EventHandler(this.RemoveBookbtn_Click);
            // 
            // EditBookbtn
            // 
            this.EditBookbtn.BackColor = System.Drawing.Color.IndianRed;
            this.EditBookbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditBookbtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBookbtn.Image")));
            this.EditBookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBookbtn.Location = new System.Drawing.Point(0, 635);
            this.EditBookbtn.Name = "EditBookbtn";
            this.EditBookbtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.EditBookbtn.Size = new System.Drawing.Size(199, 105);
            this.EditBookbtn.TabIndex = 6;
            this.EditBookbtn.Text = "         Edit";
            this.EditBookbtn.UseVisualStyleBackColor = false;
            this.EditBookbtn.Click += new System.EventHandler(this.EditBookbtn_Click);
            // 
            // AddBookbtn
            // 
            this.AddBookbtn.BackColor = System.Drawing.Color.IndianRed;
            this.AddBookbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBookbtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBookbtn.Image")));
            this.AddBookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBookbtn.Location = new System.Drawing.Point(0, 530);
            this.AddBookbtn.Name = "AddBookbtn";
            this.AddBookbtn.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.AddBookbtn.Size = new System.Drawing.Size(199, 105);
            this.AddBookbtn.TabIndex = 5;
            this.AddBookbtn.Text = "        Add ";
            this.AddBookbtn.UseVisualStyleBackColor = false;
            this.AddBookbtn.Click += new System.EventHandler(this.AddBookbtn_Click);
            // 
            // Booksbtn
            // 
            this.Booksbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Booksbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Booksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Booksbtn.Image = ((System.Drawing.Image)(resources.GetObject("Booksbtn.Image")));
            this.Booksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booksbtn.Location = new System.Drawing.Point(0, 425);
            this.Booksbtn.Name = "Booksbtn";
            this.Booksbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Booksbtn.Size = new System.Drawing.Size(199, 105);
            this.Booksbtn.TabIndex = 4;
            this.Booksbtn.Text = "           Books\r\n";
            this.Booksbtn.UseVisualStyleBackColor = false;
            this.Booksbtn.Click += new System.EventHandler(this.Booksbtn_Click);
            // 
            // RemoveUserbtn
            // 
            this.RemoveUserbtn.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveUserbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveUserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveUserbtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUserbtn.Image")));
            this.RemoveUserbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveUserbtn.Location = new System.Drawing.Point(0, 315);
            this.RemoveUserbtn.Name = "RemoveUserbtn";
            this.RemoveUserbtn.Size = new System.Drawing.Size(199, 110);
            this.RemoveUserbtn.TabIndex = 3;
            this.RemoveUserbtn.Text = "                  Remove";
            this.RemoveUserbtn.UseVisualStyleBackColor = false;
            this.RemoveUserbtn.Click += new System.EventHandler(this.RemoveUserbtn_Click);
            // 
            // EditUserbtn
            // 
            this.EditUserbtn.BackColor = System.Drawing.Color.IndianRed;
            this.EditUserbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditUserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditUserbtn.Image = ((System.Drawing.Image)(resources.GetObject("EditUserbtn.Image")));
            this.EditUserbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditUserbtn.Location = new System.Drawing.Point(0, 210);
            this.EditUserbtn.Name = "EditUserbtn";
            this.EditUserbtn.Size = new System.Drawing.Size(199, 105);
            this.EditUserbtn.TabIndex = 2;
            this.EditUserbtn.Text = "                Edit";
            this.EditUserbtn.UseVisualStyleBackColor = false;
            this.EditUserbtn.Click += new System.EventHandler(this.EditUserbtn_Click);
            // 
            // AddUserbtn
            // 
            this.AddUserbtn.BackColor = System.Drawing.Color.IndianRed;
            this.AddUserbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddUserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddUserbtn.Image = ((System.Drawing.Image)(resources.GetObject("AddUserbtn.Image")));
            this.AddUserbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserbtn.Location = new System.Drawing.Point(0, 105);
            this.AddUserbtn.Name = "AddUserbtn";
            this.AddUserbtn.Size = new System.Drawing.Size(199, 105);
            this.AddUserbtn.TabIndex = 1;
            this.AddUserbtn.Text = "                 Add ";
            this.AddUserbtn.UseVisualStyleBackColor = false;
            this.AddUserbtn.Click += new System.EventHandler(this.AddUserbtn_Click);
            // 
            // Usersbtn
            // 
            this.Usersbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Usersbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Usersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Usersbtn.Image = ((System.Drawing.Image)(resources.GetObject("Usersbtn.Image")));
            this.Usersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usersbtn.Location = new System.Drawing.Point(0, 0);
            this.Usersbtn.Name = "Usersbtn";
            this.Usersbtn.Size = new System.Drawing.Size(199, 105);
            this.Usersbtn.TabIndex = 0;
            this.Usersbtn.Text = "               Users";
            this.Usersbtn.UseVisualStyleBackColor = false;
            this.Usersbtn.Click += new System.EventHandler(this.Usersbtn_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoPanel.Location = new System.Drawing.Point(220, 0);
            this.userInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(1325, 74);
            this.userInfoPanel.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Firebrick;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(0, 950);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.backBtn.Size = new System.Drawing.Size(199, 105);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "             Take it Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 756);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "ActionForm";
            this.Text = "Action Screen";
            this.Load += new System.EventHandler(this.ActionForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Button Usersbtn;
        private System.Windows.Forms.Button RemoveUserbtn;
        private System.Windows.Forms.Button EditUserbtn;
        private System.Windows.Forms.Button AddUserbtn;
        private System.Windows.Forms.Button Booksbtn;
        private System.Windows.Forms.Button AddBookbtn;
        private System.Windows.Forms.Button RemoveBookbtn;
        private System.Windows.Forms.Button EditBookbtn;
        private System.Windows.Forms.Button Lendbtn;
        private System.Windows.Forms.Button backBtn;
    }
}