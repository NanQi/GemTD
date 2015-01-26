namespace NanQi.GemTD
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.sbpStatusMsg = new System.Windows.Forms.StatusBarPanel();
            this.sbpLocation = new System.Windows.Forms.StatusBarPanel();
            this.tspanel = new System.Windows.Forms.ToolStripPanel();
            this.toolStripGame = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripHelp = new System.Windows.Forms.ToolStrip();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.saveDLG = new System.Windows.Forms.SaveFileDialog();
            this.openDLG = new System.Windows.Forms.OpenFileDialog();
            this.worldMap = new NanQi.GemTD.WorldMap();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatusMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpLocation)).BeginInit();
            this.tspanel.SuspendLayout();
            this.toolStripGame.SuspendLayout();
            this.toolStripHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emnuGame,
            this.menuOperator,
            this.menuOptions,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emnuGame
            // 
            this.emnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiStop,
            this.toolStripSeparator1,
            this.tsmiOpen,
            this.tsmiSave,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.emnuGame.Name = "emnuGame";
            this.emnuGame.Size = new System.Drawing.Size(60, 20);
            this.emnuGame.Text = "游戏(&G)";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStart.Image")));
            this.tsmiStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiStart.Size = new System.Drawing.Size(219, 22);
            this.tsmiStart.Text = "开始游戏(&T)";
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.tsmiStop.Size = new System.Drawing.Size(219, 22);
            this.tsmiStop.Text = "结束游戏(&E)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpen.Image")));
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(219, 22);
            this.tsmiOpen.Text = "打开迷宫文件(&O)...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(219, 22);
            this.tsmiSave.Text = "保存迷宫(&S)...";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(219, 22);
            this.tsmiExit.Text = "退出游戏(&X)";
            // 
            // menuOperator
            // 
            this.menuOperator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReset,
            this.toolStripSeparator4});
            this.menuOperator.Name = "menuOperator";
            this.menuOperator.Size = new System.Drawing.Size(61, 20);
            this.menuOperator.Text = "操作(&O)";
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsmiReset.Size = new System.Drawing.Size(152, 22);
            this.tsmiReset.Text = "还原(&R)";
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGrid,
            this.toolStripSeparator6,
            this.tsmiTool,
            this.tsmiStatus,
            this.toolStripSeparator7,
            this.tsmiOptions});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(58, 20);
            this.menuOptions.Text = "选项(&P)";
            // 
            // tsmiGrid
            // 
            this.tsmiGrid.Name = "tsmiGrid";
            this.tsmiGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmiGrid.Size = new System.Drawing.Size(184, 22);
            this.tsmiGrid.Text = "显示网格(&G)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmiTool
            // 
            this.tsmiTool.Checked = true;
            this.tsmiTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(184, 22);
            this.tsmiTool.Text = "工具栏(&T)";
            // 
            // tsmiStatus
            // 
            this.tsmiStatus.Checked = true;
            this.tsmiStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatus.Name = "tsmiStatus";
            this.tsmiStatus.Size = new System.Drawing.Size(184, 22);
            this.tsmiStatus.Text = "状态栏(&S)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(184, 22);
            this.tsmiOptions.Text = "选项(&O)...";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.toolStripSeparator8,
            this.tsmiAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(60, 20);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHelp.Image")));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiHelp.Size = new System.Drawing.Size(158, 22);
            this.tsmiHelp.Text = "查看帮助(&V)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(158, 22);
            this.tsmiAbout.Tag = "http://www.codeproject.com/Articles/42236/Game-of-Life-Simulator-as-Learning-Tool" +
    "";
            this.tsmiAbout.Text = "关于(&A)";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 599);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbpStatusMsg,
            this.sbpLocation});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(550, 24);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 10;
            // 
            // sbpStatusMsg
            // 
            this.sbpStatusMsg.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sbpStatusMsg.Name = "sbpStatusMsg";
            this.sbpStatusMsg.Width = 470;
            // 
            // sbpLocation
            // 
            this.sbpLocation.Name = "sbpLocation";
            this.sbpLocation.Text = "0,0";
            this.sbpLocation.ToolTipText = "鼠标位于地图的坐标";
            this.sbpLocation.Width = 80;
            // 
            // tspanel
            // 
            this.tspanel.Controls.Add(this.toolStripGame);
            this.tspanel.Controls.Add(this.toolStripHelp);
            this.tspanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tspanel.Location = new System.Drawing.Point(0, 24);
            this.tspanel.Name = "tspanel";
            this.tspanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tspanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tspanel.Size = new System.Drawing.Size(550, 25);
            // 
            // toolStripGame
            // 
            this.toolStripGame.AllowItemReorder = true;
            this.toolStripGame.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave});
            this.toolStripGame.Location = new System.Drawing.Point(3, 0);
            this.toolStripGame.Name = "toolStripGame";
            this.toolStripGame.Size = new System.Drawing.Size(58, 25);
            this.toolStripGame.TabIndex = 0;
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "打开迷宫文件(C-O)";
            this.tsbOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存迷宫(C-S)";
            this.tsbSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.AllowItemReorder = true;
            this.toolStripHelp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHelp});
            this.toolStripHelp.Location = new System.Drawing.Point(61, 0);
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(35, 25);
            this.toolStripHelp.TabIndex = 2;
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbHelp.Text = "帮助(F1)";
            // 
            // worldMap
            // 
            this.worldMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldMap.IsShowGrid = true;
            this.worldMap.Location = new System.Drawing.Point(0, 49);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(550, 550);
            this.worldMap.TabIndex = 14;
            this.worldMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.worldMap_MouseDown);
            this.worldMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.worldMap_MouseMove);
            this.worldMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.worldMap_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 623);
            this.Controls.Add(this.worldMap);
            this.Controls.Add(this.tspanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(566, 662);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatusMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpLocation)).EndInit();
            this.tspanel.ResumeLayout(false);
            this.tspanel.PerformLayout();
            this.toolStripGame.ResumeLayout(false);
            this.toolStripGame.PerformLayout();
            this.toolStripHelp.ResumeLayout(false);
            this.toolStripHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emnuGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem menuOperator;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel sbpStatusMsg;
        private System.Windows.Forms.StatusBarPanel sbpLocation;
        private System.Windows.Forms.ToolStripPanel tspanel;
        private System.Windows.Forms.ToolStrip toolStripGame;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStrip toolStripHelp;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private WorldMap worldMap;
        private System.Windows.Forms.SaveFileDialog saveDLG;
        private System.Windows.Forms.OpenFileDialog openDLG;

    }
}