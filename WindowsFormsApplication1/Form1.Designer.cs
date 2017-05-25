namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySurnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateARequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelARequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllRequestsByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.waterRequestsToolStripMenuItem,
            this.billsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(149, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.removeAClientToolStripMenuItem,
            this.updateAClientToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // removeAClientToolStripMenuItem
            // 
            this.removeAClientToolStripMenuItem.Name = "removeAClientToolStripMenuItem";
            this.removeAClientToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.removeAClientToolStripMenuItem.Text = "Remove a Client";
            this.removeAClientToolStripMenuItem.Click += new System.EventHandler(this.removeAClientToolStripMenuItem_Click);
            // 
            // updateAClientToolStripMenuItem
            // 
            this.updateAClientToolStripMenuItem.Name = "updateAClientToolStripMenuItem";
            this.updateAClientToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.updateAClientToolStripMenuItem.Text = "Update a Client";
            this.updateAClientToolStripMenuItem.Click += new System.EventHandler(this.updateAClientToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.bySurnameToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.byNameToolStripMenuItem.Text = "by Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // bySurnameToolStripMenuItem
            // 
            this.bySurnameToolStripMenuItem.Name = "bySurnameToolStripMenuItem";
            this.bySurnameToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.bySurnameToolStripMenuItem.Text = "by Surname";
            this.bySurnameToolStripMenuItem.Click += new System.EventHandler(this.bySurnameToolStripMenuItem_Click);
            // 
            // waterRequestsToolStripMenuItem
            // 
            this.waterRequestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewRequestToolStripMenuItem,
            this.updateARequestToolStripMenuItem,
            this.cancelARequestToolStripMenuItem,
            this.listAllRequestsByDateToolStripMenuItem,
            this.showAllRequestsToolStripMenuItem});
            this.waterRequestsToolStripMenuItem.Name = "waterRequestsToolStripMenuItem";
            this.waterRequestsToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.waterRequestsToolStripMenuItem.Text = "Water Requests";
            // 
            // addANewRequestToolStripMenuItem
            // 
            this.addANewRequestToolStripMenuItem.Name = "addANewRequestToolStripMenuItem";
            this.addANewRequestToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.addANewRequestToolStripMenuItem.Text = "Add a new request";
            this.addANewRequestToolStripMenuItem.Click += new System.EventHandler(this.addANewRequestToolStripMenuItem_Click);
            // 
            // updateARequestToolStripMenuItem
            // 
            this.updateARequestToolStripMenuItem.Name = "updateARequestToolStripMenuItem";
            this.updateARequestToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.updateARequestToolStripMenuItem.Text = "Update a request";
            this.updateARequestToolStripMenuItem.Click += new System.EventHandler(this.updateARequestToolStripMenuItem_Click);
            // 
            // cancelARequestToolStripMenuItem
            // 
            this.cancelARequestToolStripMenuItem.Name = "cancelARequestToolStripMenuItem";
            this.cancelARequestToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cancelARequestToolStripMenuItem.Text = "Cancel a request";
            this.cancelARequestToolStripMenuItem.Click += new System.EventHandler(this.cancelARequestToolStripMenuItem_Click);
            // 
            // listAllRequestsByDateToolStripMenuItem
            // 
            this.listAllRequestsByDateToolStripMenuItem.Name = "listAllRequestsByDateToolStripMenuItem";
            this.listAllRequestsByDateToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.listAllRequestsByDateToolStripMenuItem.Text = "List all requests by date";
            this.listAllRequestsByDateToolStripMenuItem.Click += new System.EventHandler(this.listAllRequestsByDateToolStripMenuItem_Click);
            // 
            // showAllRequestsToolStripMenuItem
            // 
            this.showAllRequestsToolStripMenuItem.Name = "showAllRequestsToolStripMenuItem";
            this.showAllRequestsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.showAllRequestsToolStripMenuItem.Text = "Show all Requests";
            this.showAllRequestsToolStripMenuItem.Click += new System.EventHandler(this.showAllRequestsToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.billsToolStripMenuItem.Text = "Bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(138, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(138, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 47);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Location = new System.Drawing.Point(617, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 47);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(138, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 363);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mobile Number";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 143;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-164, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 1402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 531);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Water Distribution Management";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySurnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateARequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelARequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllRequestsByDateToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem showAllRequestsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

