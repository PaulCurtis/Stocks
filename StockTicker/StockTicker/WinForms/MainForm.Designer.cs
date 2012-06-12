namespace StockTicker.WinForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoogleFinanceLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadAStockFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReloadAllStockData = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.tbCurrentStock = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fbdOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.bwLoadFile = new System.ComponentModel.BackgroundWorker();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnTestDBConnection = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit,
            this.tsmiGoogleFinanceLogin});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(206, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiGoogleFinanceLogin
            // 
            this.tsmiGoogleFinanceLogin.Name = "tsmiGoogleFinanceLogin";
            this.tsmiGoogleFinanceLogin.Size = new System.Drawing.Size(206, 22);
            this.tsmiGoogleFinanceLogin.Text = "Log in to &Google Finance";
            this.tsmiGoogleFinanceLogin.Click += new System.EventHandler(this.tsmiGoogleFinanceLogin_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadAStockFile,
            this.tsmiReloadAllStockData});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(48, 20);
            this.tsmiTools.Text = "&Tools";
            // 
            // tsmiLoadAStockFile
            // 
            this.tsmiLoadAStockFile.Name = "tsmiLoadAStockFile";
            this.tsmiLoadAStockFile.Size = new System.Drawing.Size(186, 22);
            this.tsmiLoadAStockFile.Text = "&Load a Stock File";
            this.tsmiLoadAStockFile.Click += new System.EventHandler(this.tsmiLoadAStockFile_Click);
            // 
            // tsmiReloadAllStockData
            // 
            this.tsmiReloadAllStockData.Name = "tsmiReloadAllStockData";
            this.tsmiReloadAllStockData.Size = new System.Drawing.Size(186, 22);
            this.tsmiReloadAllStockData.Text = "&Reload All Stock Data";
            this.tsmiReloadAllStockData.Click += new System.EventHandler(this.tsmiReloadAllStockData_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pbMain, 0, 3);
            this.tlpMain.Controls.Add(this.lblCurrentStock, 0, 2);
            this.tlpMain.Controls.Add(this.tbCurrentStock, 1, 2);
            this.tlpMain.Controls.Add(this.lblStatus, 0, 0);
            this.tlpMain.Controls.Add(this.button1, 2, 1);
            this.tlpMain.Controls.Add(this.btnTestDBConnection, 3, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.Size = new System.Drawing.Size(662, 342);
            this.tlpMain.TabIndex = 1;
            // 
            // pbMain
            // 
            this.tlpMain.SetColumnSpan(this.pbMain, 4);
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(3, 310);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(656, 29);
            this.pbMain.TabIndex = 1;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.Location = new System.Drawing.Point(9, 287);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentStock.TabIndex = 2;
            this.lblCurrentStock.Text = "Current Stock:";
            // 
            // tbCurrentStock
            // 
            this.tbCurrentStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentStock.Enabled = false;
            this.tbCurrentStock.Location = new System.Drawing.Point(104, 284);
            this.tbCurrentStock.Name = "tbCurrentStock";
            this.tbCurrentStock.Size = new System.Drawing.Size(100, 20);
            this.tbCurrentStock.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Loading Data...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bwLoadData
            // 
            this.bwLoadData.WorkerReportsProgress = true;
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadData_DoWork);
            this.bwLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadData_ProgressChanged);
            // 
            // bwLoadFile
            // 
            this.bwLoadFile.WorkerReportsProgress = true;
            this.bwLoadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadFile_DoWork);
            this.bwLoadFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadFile_RunWorkerCompleted);
            this.bwLoadFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadFile_ProgressChanged);
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "csv";
            this.ofdOpen.FileName = "*.csv";
            this.ofdOpen.Title = "Select Stock File to Open";
            // 
            // btnTestDBConnection
            // 
            this.btnTestDBConnection.Location = new System.Drawing.Point(437, 16);
            this.btnTestDBConnection.Name = "btnTestDBConnection";
            this.btnTestDBConnection.Size = new System.Drawing.Size(164, 129);
            this.btnTestDBConnection.TabIndex = 6;
            this.btnTestDBConnection.Text = "Test DB Connection";
            this.btnTestDBConnection.UseVisualStyleBackColor = true;
            this.btnTestDBConnection.Click += new System.EventHandler(this.btnTestDBConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FolderBrowserDialog fbdOpen;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.TextBox tbCurrentStock;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bwLoadData;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadAStockFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiReloadAllStockData;
        private System.ComponentModel.BackgroundWorker bwLoadFile;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoogleFinanceLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTestDBConnection;
    }
}

