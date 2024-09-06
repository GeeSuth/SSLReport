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
            list_logs = new ListView();
            columnHeader8 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            groupBox.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Url
            // 
            txt_Url.Location = new Point(117, 16);
            txt_Url.Name = "txt_Url";
            txt_Url.Size = new Size(253, 21);
            txt_Url.TabIndex = 0;
            txt_Url.Text = "google.com";
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
            groupBox.Size = new Size(776, 107);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // check_forceWay
            // 
            check_forceWay.Enabled = false;
            check_forceWay.Location = new Point(266, 70);
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
            textBox1.Size = new Size(47, 21);
            textBox1.TabIndex = 7;
            textBox1.Text = "https://";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(70, 43);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(300, 21);
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
            checkBox_isPublic.Location = new Point(70, 70);
            checkBox_isPublic.Name = "checkBox_isPublic";
            checkBox_isPublic.Size = new Size(104, 24);
            checkBox_isPublic.TabIndex = 4;
            checkBox_isPublic.Text = "Is Public";
            // 
            // btnAddToList
            // 
            btnAddToList.Location = new Point(385, 14);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(75, 50);
            btnAddToList.TabIndex = 5;
            btnAddToList.Text = "Add To List";
            btnAddToList.Click += btnAddToList_Click;
            // 
            // listUrl
            // 
            listUrl.Columns.AddRange(new ColumnHeader[] { colum_sn, colum_working, colum_name, colum_url, colum_isPublic, colum_expireDate, colum_expireInDay });
            listUrl.ContextMenuStrip = contextMenuStrip1;
            listUrl.FullRowSelect = true;
            listUrl.Location = new Point(12, 125);
            listUrl.Name = "listUrl";
            listUrl.Size = new Size(776, 313);
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
            // list_logs
            // 
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem5, toolStripSeparator1, toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(138, 120);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(137, 22);
            toolStripMenuItem1.Text = "Update";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(137, 22);
            toolStripMenuItem2.Text = "Remove";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(137, 22);
            toolStripMenuItem3.Text = "Update All";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(137, 22);
            toolStripMenuItem4.Text = "Remove All";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(137, 22);
            toolStripMenuItem5.Text = "View Details";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 568);
            Controls.Add(list_logs);
            Controls.Add(groupBox);
            Controls.Add(listUrl);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}
