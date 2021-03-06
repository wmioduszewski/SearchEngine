﻿namespace SearchEngine.ClientApp
{
    partial class SearchForm
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
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelProposes = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxSuggestions = new System.Windows.Forms.GroupBox();
            this.cbSuggestions = new System.Windows.Forms.CheckBox();
            this.resultsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxSuggestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuery
            // 
            this.tbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuery.Location = new System.Drawing.Point(106, 30);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(576, 20);
            this.tbQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter query here:";
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(691, 417);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(691, 28);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGroupBox.Controls.Add(this.resultsLayoutPanel);
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 103);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(751, 308);
            this.resultsGroupBox.TabIndex = 5;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results:";
            // 
            // resultsLayoutPanel
            // 
            this.resultsLayoutPanel.AutoScroll = true;
            this.resultsLayoutPanel.AutoSize = true;
            this.resultsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultsLayoutPanel.ColumnCount = 1;
            this.resultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.resultsLayoutPanel.Name = "resultsLayoutPanel";
            this.resultsLayoutPanel.RowCount = 1;
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.resultsLayoutPanel.Size = new System.Drawing.Size(745, 289);
            this.resultsLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDocumentsToolStripMenuItem,
            this.loadKeywordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDocumentsToolStripMenuItem
            // 
            this.loadDocumentsToolStripMenuItem.Name = "loadDocumentsToolStripMenuItem";
            this.loadDocumentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadDocumentsToolStripMenuItem.Text = "Load documents";
            this.loadDocumentsToolStripMenuItem.Click += new System.EventHandler(this.loadDocumentsToolStripMenuItem_Click);
            // 
            // loadKeywordsToolStripMenuItem
            // 
            this.loadKeywordsToolStripMenuItem.Name = "loadKeywordsToolStripMenuItem";
            this.loadKeywordsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadKeywordsToolStripMenuItem.Text = "Load keywords";
            this.loadKeywordsToolStripMenuItem.Click += new System.EventHandler(this.loadKeywordsToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 443);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(775, 22);
            this.statusStripMain.TabIndex = 7;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // flowLayoutPanelProposes
            // 
            this.flowLayoutPanelProposes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProposes.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelProposes.Name = "flowLayoutPanelProposes";
            this.flowLayoutPanelProposes.Size = new System.Drawing.Size(661, 22);
            this.flowLayoutPanelProposes.TabIndex = 8;
            // 
            // groupBoxSuggestions
            // 
            this.groupBoxSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSuggestions.Controls.Add(this.flowLayoutPanelProposes);
            this.groupBoxSuggestions.Location = new System.Drawing.Point(15, 56);
            this.groupBoxSuggestions.Name = "groupBoxSuggestions";
            this.groupBoxSuggestions.Size = new System.Drawing.Size(667, 41);
            this.groupBoxSuggestions.TabIndex = 8;
            this.groupBoxSuggestions.TabStop = false;
            this.groupBoxSuggestions.Text = "Suggestions";
            // 
            // cbSuggestions
            // 
            this.cbSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSuggestions.AutoSize = true;
            this.cbSuggestions.Location = new System.Drawing.Point(691, 72);
            this.cbSuggestions.Name = "cbSuggestions";
            this.cbSuggestions.Size = new System.Drawing.Size(55, 17);
            this.cbSuggestions.TabIndex = 9;
            this.cbSuggestions.Text = "on/off";
            this.cbSuggestions.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 465);
            this.Controls.Add(this.cbSuggestions);
            this.Controls.Add(this.groupBoxSuggestions);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchForm";
            this.Text = "Search Engine";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxSuggestions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TableLayoutPanel resultsLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeywordsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProposes;
        private System.Windows.Forms.GroupBox groupBoxSuggestions;
        private System.Windows.Forms.CheckBox cbSuggestions;        
    }
}

