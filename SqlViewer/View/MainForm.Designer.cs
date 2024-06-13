namespace SqlViewer.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.twServer = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbXML = new System.Windows.Forms.ToolStripButton();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.tpMessages = new System.Windows.Forms.TabPage();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.dgQueryResults = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.tpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryResults)).BeginInit();
            this.SuspendLayout();
            // 
            // twServer
            // 
            this.twServer.Location = new System.Drawing.Point(28, 91);
            this.twServer.Margin = new System.Windows.Forms.Padding(1);
            this.twServer.Name = "twServer";
            this.twServer.Size = new System.Drawing.Size(494, 1028);
            this.twServer.TabIndex = 0;
            this.twServer.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TwServer_AfterCollapse);
            this.twServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TwServer_BeforeExpand);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.tsbXML});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1604, 49);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(44, 44);
            this.tsbSelect.Text = "Select";
            this.tsbSelect.Click += new System.EventHandler(this.TsbSelect_Click);
            // 
            // tsbXML
            // 
            this.tsbXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbXML.Image = ((System.Drawing.Image)(resources.GetObject("tsbXML.Image")));
            this.tsbXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXML.Name = "tsbXML";
            this.tsbXML.Size = new System.Drawing.Size(44, 44);
            this.tsbXML.Text = "XML";
            this.tsbXML.Click += new System.EventHandler(this.TsbXML_Click);
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(552, 91);
            this.tbContent.Margin = new System.Windows.Forms.Padding(1);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(1031, 425);
            this.tbContent.TabIndex = 2;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(552, 53);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(143, 34);
            this.btnExecuteQuery.TabIndex = 3;
            this.btnExecuteQuery.Text = "Execute query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.BtnExecuteQuery_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpResults);
            this.tabControl.Controls.Add(this.tpMessages);
            this.tabControl.Location = new System.Drawing.Point(553, 549);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1030, 489);
            this.tabControl.TabIndex = 4;
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.dgQueryResults);
            this.tpResults.Location = new System.Drawing.Point(4, 34);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(1022, 451);
            this.tpResults.TabIndex = 0;
            this.tpResults.Text = "Result/s";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // tpMessages
            // 
            this.tpMessages.Controls.Add(this.tbMessages);
            this.tpMessages.Location = new System.Drawing.Point(4, 34);
            this.tpMessages.Name = "tpMessages";
            this.tpMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessages.Size = new System.Drawing.Size(1022, 451);
            this.tpMessages.TabIndex = 1;
            this.tpMessages.Text = "Messages";
            this.tpMessages.UseVisualStyleBackColor = true;
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(3, 3);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.Size = new System.Drawing.Size(1019, 445);
            this.tbMessages.TabIndex = 0;
            // 
            // dgQueryResults
            // 
            this.dgQueryResults.AllowUserToAddRows = false;
            this.dgQueryResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgQueryResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQueryResults.Location = new System.Drawing.Point(3, 3);
            this.dgQueryResults.Name = "dgQueryResults";
            this.dgQueryResults.ReadOnly = true;
            this.dgQueryResults.RowHeadersWidth = 62;
            this.dgQueryResults.RowTemplate.Height = 33;
            this.dgQueryResults.Size = new System.Drawing.Size(1016, 445);
            this.dgQueryResults.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 1050);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.twServer);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpResults.ResumeLayout(false);
            this.tpMessages.ResumeLayout(false);
            this.tpMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView twServer;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelect;
        private ToolStripButton tsbXML;
        private TextBox tbContent;
        private Button btnExecuteQuery;
        private TabControl tabControl;
        private TabPage tpResults;
        private TabPage tpMessages;
        private TextBox tbMessages;
        private DataGridView dgQueryResults;
    }
}