namespace SSLReport
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            txt_Url = new TextBox();
            groupBox = new GroupBox();
            check_forceWay = new CheckBox();
            textBox1 = new TextBox();
            txt_Name = new TextBox();
            label1 = new Label();
            lblUrl = new Label();
            checkBox_isPublic = new CheckBox();
            btnAddToList = new Button();
            listUrl = new ListView();
            colum_sn = new ColumnHeader();
            colum_working = new ColumnHeader("(none)");
            colum_name = new ColumnHeader();
            colum_url = new ColumnHeader();
            colum_isPublic = new ColumnHeader();
            colum_expireDate = new ColumnHeader();
            colum_expireInDay = new ColumnHeader();
            colum_serial = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip_UpdateOnce = new ToolStripMenuItem();
            toolStrip_RemoveOnce = new ToolStripMenuItem();
            openInBrowserToolStripMenuItem = new ToolStripMenuItem();
            toolStrip_ViewOnce = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip_UpdateAll = new ToolStripMenuItem();
            toolStrip_RemoveAll = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            installToolStripMenuItem = new ToolStripMenuItem();
            dawnloadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyRowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            copyURLToolStripMenuItem = new ToolStripMenuItem();
            copyExpireDateToolStripMenuItem = new ToolStripMenuItem();
            copySerialNumberToolStripMenuItem = new ToolStripMenuItem();
            list_logs = new ListView();
            columnHeader8 = new ColumnHeader();
            groupBox.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Url
            // 
            txt_Url.Location = new Point(117, 16);
            txt_Url.Name = "txt_Url";
            txt_Url.Size = new Size(253, 25);
            txt_Url.TabIndex = 0;
            txt_Url.Text = "google.com";
            txt_Url.Leave += txt_Url_Leave;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(check_forceWay);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(txt_Name);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txt_Url);
            groupBox.Controls.Add(lblUrl);
            groupBox.Controls.Add(checkBox_isPublic);
            groupBox.Controls.Add(btnAddToList);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(776, 86);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // check_forceWay
            // 
            check_forceWay.Location = new Point(549, 15);
            check_forceWay.Name = "check_forceWay";
            check_forceWay.Size = new Size(104, 24);
            check_forceWay.TabIndex = 8;
            check_forceWay.Text = "Force way";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(47, 25);
            textBox1.TabIndex = 7;
            textBox1.Text = "https://";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(70, 43);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(300, 25);
            txt_Name.TabIndex = 2;
            txt_Name.Text = "google domain";
            // 
            // label1
            // 
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // lblUrl
            // 
            lblUrl.Location = new Point(16, 19);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(48, 23);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            // 
            // checkBox_isPublic
            // 
            checkBox_isPublic.Checked = true;
            checkBox_isPublic.CheckState = CheckState.Checked;
            checkBox_isPublic.Location = new Point(440, 15);
            checkBox_isPublic.Name = "checkBox_isPublic";
            checkBox_isPublic.Size = new Size(104, 24);
            checkBox_isPublic.TabIndex = 4;
            checkBox_isPublic.Text = "Is Public";
            // 
            // btnAddToList
            // 
            btnAddToList.Location = new Point(440, 39);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(213, 28);
            btnAddToList.TabIndex = 5;
            btnAddToList.Text = "Add && Start Scan";
            btnAddToList.Click += btnAddToList_Click;
            // 
            // listUrl
            // 
            listUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUrl.Columns.AddRange(new ColumnHeader[] { colum_sn, colum_working, colum_name, colum_url, colum_isPublic, colum_expireDate, colum_expireInDay, colum_serial });
            listUrl.ContextMenuStrip = contextMenuStrip1;
            listUrl.FullRowSelect = true;
            listUrl.Location = new Point(12, 104);
            listUrl.Name = "listUrl";
            listUrl.Size = new Size(776, 334);
            listUrl.TabIndex = 2;
            listUrl.UseCompatibleStateImageBehavior = false;
            listUrl.View = View.Details;
            // 
            // colum_sn
            // 
            colum_sn.Text = "Sn";
            colum_sn.Width = 30;
            // 
            // colum_working
            // 
            colum_working.Text = "Progress";
            colum_working.Width = 70;
            // 
            // colum_name
            // 
            colum_name.Text = "Name";
            colum_name.Width = 150;
            // 
            // colum_url
            // 
            colum_url.Text = "URL";
            colum_url.Width = 220;
            // 
            // colum_isPublic
            // 
            colum_isPublic.Text = "Is Public";
            // 
            // colum_expireDate
            // 
            colum_expireDate.Text = "Expire Date";
            colum_expireDate.Width = 150;
            // 
            // colum_expireInDay
            // 
            colum_expireInDay.Text = "Expire In Day?";
            colum_expireInDay.Width = 100;
            // 
            // colum_serial
            // 
            colum_serial.Text = "SerialNumber";
            colum_serial.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_UpdateOnce, toolStrip_RemoveOnce, openInBrowserToolStripMenuItem, toolStrip_ViewOnce, toolStripSeparator1, toolStrip_UpdateAll, toolStrip_RemoveAll, toolStripSeparator2, installToolStripMenuItem, dawnloadToolStripMenuItem, toolStripSeparator3, copyToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(192, 256);
            // 
            // toolStrip_UpdateOnce
            // 
            toolStrip_UpdateOnce.Image = (Image)resources.GetObject("toolStrip_UpdateOnce.Image");
            toolStrip_UpdateOnce.Name = "toolStrip_UpdateOnce";
            toolStrip_UpdateOnce.Size = new Size(191, 26);
            toolStrip_UpdateOnce.Text = "Update";
            toolStrip_UpdateOnce.Click += toolStrip_UpdateOnce_Click;
            // 
            // toolStrip_RemoveOnce
            // 
            toolStrip_RemoveOnce.Image = (Image)resources.GetObject("toolStrip_RemoveOnce.Image");
            toolStrip_RemoveOnce.Name = "toolStrip_RemoveOnce";
            toolStrip_RemoveOnce.Size = new Size(191, 26);
            toolStrip_RemoveOnce.Text = "Remove";
            toolStrip_RemoveOnce.Click += toolStrip_RemoveOnce_Click;
            // 
            // openInBrowserToolStripMenuItem
            // 
            openInBrowserToolStripMenuItem.Image = (Image)resources.GetObject("openInBrowserToolStripMenuItem.Image");
            openInBrowserToolStripMenuItem.Name = "openInBrowserToolStripMenuItem";
            openInBrowserToolStripMenuItem.Size = new Size(191, 26);
            openInBrowserToolStripMenuItem.Text = "Open In browser";
            openInBrowserToolStripMenuItem.Click += openInBrowserToolStripMenuItem_Click;
            // 
            // toolStrip_ViewOnce
            // 
            toolStrip_ViewOnce.Image = (Image)resources.GetObject("toolStrip_ViewOnce.Image");
            toolStrip_ViewOnce.Name = "toolStrip_ViewOnce";
            toolStrip_ViewOnce.Size = new Size(191, 26);
            toolStrip_ViewOnce.Text = "View Details";
            toolStrip_ViewOnce.Click += toolStrip_ViewOnce_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // toolStrip_UpdateAll
            // 
            toolStrip_UpdateAll.Image = (Image)resources.GetObject("toolStrip_UpdateAll.Image");
            toolStrip_UpdateAll.Name = "toolStrip_UpdateAll";
            toolStrip_UpdateAll.Size = new Size(191, 26);
            toolStrip_UpdateAll.Text = "Update All";
            toolStrip_UpdateAll.Click += toolStrip_UpdateAll_Click;
            // 
            // toolStrip_RemoveAll
            // 
            toolStrip_RemoveAll.Image = (Image)resources.GetObject("toolStrip_RemoveAll.Image");
            toolStrip_RemoveAll.Name = "toolStrip_RemoveAll";
            toolStrip_RemoveAll.Size = new Size(191, 26);
            toolStrip_RemoveAll.Text = "Remove All";
            toolStrip_RemoveAll.Click += toolStrip_RemoveAll_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // installToolStripMenuItem
            // 
            installToolStripMenuItem.Enabled = false;
            installToolStripMenuItem.Name = "installToolStripMenuItem";
            installToolStripMenuItem.Size = new Size(191, 26);
            installToolStripMenuItem.Text = "Install";
            // 
            // dawnloadToolStripMenuItem
            // 
            dawnloadToolStripMenuItem.Enabled = false;
            dawnloadToolStripMenuItem.Name = "dawnloadToolStripMenuItem";
            dawnloadToolStripMenuItem.Size = new Size(191, 26);
            dawnloadToolStripMenuItem.Text = "Dawnload ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(188, 6);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyRowToolStripMenuItem, toolStripSeparator4, copyURLToolStripMenuItem, copyExpireDateToolStripMenuItem, copySerialNumberToolStripMenuItem });
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(191, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // copyRowToolStripMenuItem
            // 
            copyRowToolStripMenuItem.Image = (Image)resources.GetObject("copyRowToolStripMenuItem.Image");
            copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            copyRowToolStripMenuItem.Size = new Size(225, 26);
            copyRowToolStripMenuItem.Text = "Copy row";
            copyRowToolStripMenuItem.Click += copyRowToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(222, 6);
            // 
            // copyURLToolStripMenuItem
            // 
            copyURLToolStripMenuItem.Image = (Image)resources.GetObject("copyURLToolStripMenuItem.Image");
            copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
            copyURLToolStripMenuItem.Size = new Size(225, 26);
            copyURLToolStripMenuItem.Text = "Copy URL";
            copyURLToolStripMenuItem.Click += copyURLToolStripMenuItem_Click;
            // 
            // copyExpireDateToolStripMenuItem
            // 
            copyExpireDateToolStripMenuItem.Image = (Image)resources.GetObject("copyExpireDateToolStripMenuItem.Image");
            copyExpireDateToolStripMenuItem.Name = "copyExpireDateToolStripMenuItem";
            copyExpireDateToolStripMenuItem.Size = new Size(225, 26);
            copyExpireDateToolStripMenuItem.Text = "Copy Expire Date";
            copyExpireDateToolStripMenuItem.Click += copyExpireDateToolStripMenuItem_Click;
            // 
            // copySerialNumberToolStripMenuItem
            // 
            copySerialNumberToolStripMenuItem.Image = (Image)resources.GetObject("copySerialNumberToolStripMenuItem.Image");
            copySerialNumberToolStripMenuItem.Name = "copySerialNumberToolStripMenuItem";
            copySerialNumberToolStripMenuItem.Size = new Size(225, 26);
            copySerialNumberToolStripMenuItem.Text = "Copy Serial Number";
            copySerialNumberToolStripMenuItem.Click += copySerialNumberToolStripMenuItem_Click;
            // 
            // list_logs
            // 
            list_logs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            list_logs.Columns.AddRange(new ColumnHeader[] { columnHeader8 });
            list_logs.FullRowSelect = true;
            list_logs.Location = new Point(12, 444);
            list_logs.Name = "list_logs";
            list_logs.Size = new Size(776, 122);
            list_logs.TabIndex = 3;
            list_logs.UseCompatibleStateImageBehavior = false;
            list_logs.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Logs.";
            columnHeader8.Width = 1000;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 568);
            Controls.Add(list_logs);
            Controls.Add(groupBox);
            Controls.Add(listUrl);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSL Reporting";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TextBox txt_Url;


        #endregion

        private GroupBox groupBox;
        private Label lblUrl;
        private TextBox txt_Name;
        private Label label1;
        private CheckBox checkBox_isPublic;
        private Button btnAddToList;
        private ListView listUrl;
        private ColumnHeader colum_working;
        private ColumnHeader colum_name;
        private ColumnHeader colum_url;
        private ColumnHeader colum_isPublic;
        private ColumnHeader colum_expireDate;
        private ColumnHeader colum_expireInDay;
        private TextBox textBox1;
        private ColumnHeader colum_sn;
        private CheckBox check_forceWay;
        private ListView list_logs;
        private ColumnHeader columnHeader8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStrip_UpdateOnce;
        private ToolStripMenuItem toolStrip_RemoveOnce;
        private ToolStripMenuItem toolStrip_ViewOnce;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStrip_UpdateAll;
        private ToolStripMenuItem toolStrip_RemoveAll;
        private ToolStripMenuItem openInBrowserToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem installToolStripMenuItem;
        private ToolStripMenuItem dawnloadToolStripMenuItem;
        private ColumnHeader colum_serial;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyURLToolStripMenuItem;
        private ToolStripMenuItem copyExpireDateToolStripMenuItem;
        private ToolStripMenuItem copySerialNumberToolStripMenuItem;
        private ToolStripMenuItem copyRowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
    }
}
