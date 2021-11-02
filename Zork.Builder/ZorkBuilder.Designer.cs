
namespace Zork.Builder
{
    partial class ZorkBuilder
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
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worldTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eastNeighbor = new System.Windows.Forms.Label();
            this.northNeighbor = new System.Windows.Forms.Label();
            this.southNeighbor = new System.Windows.Forms.Label();
            this.westNeighbor = new System.Windows.Forms.Label();
            this.eastButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.westButton1 = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currentRoomlabel = new System.Windows.Forms.Label();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.roomListLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.startingRoomLabel = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.ListBox();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTracker = new System.Windows.Forms.NumericUpDown();
            this.playerLabel = new System.Windows.Forms.Label();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.ranksLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ranksList = new System.Windows.Forms.ListBox();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            closeProjectToolStripMenuItem,
            toolStripSeparator2,
            saveToolStripMenuItem,
            saveAsToolStripMenuItem,
            toolStripSeparator1,
            recentProjectsToolStripMenuItem,
            toolStripSeparator3,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            newToolStripMenuItem.Text = "New Project...";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            openToolStripMenuItem.Text = "Open Project...";
            // 
            // closeProjectToolStripMenuItem
            // 
            closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            closeProjectToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            closeProjectToolStripMenuItem.Text = "Close Project...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            saveToolStripMenuItem.Text = "Save...";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            recentProjectsToolStripMenuItem.Text = "Recent Projects";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worldTab);
            this.tabControl1.Controls.Add(this.itemsTab);
            this.tabControl1.Controls.Add(this.gameTab);
            this.tabControl1.Controls.Add(this.filesTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 551);
            this.tabControl1.TabIndex = 1;
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.panel1);
            this.worldTab.Controls.Add(this.startingLocationComboBox);
            this.worldTab.Controls.Add(this.roomListLabel);
            this.worldTab.Controls.Add(this.deleteButton);
            this.worldTab.Controls.Add(this.addButton);
            this.worldTab.Controls.Add(this.startingRoomLabel);
            this.worldTab.Controls.Add(this.roomList);
            this.worldTab.Location = new System.Drawing.Point(4, 25);
            this.worldTab.Name = "worldTab";
            this.worldTab.Padding = new System.Windows.Forms.Padding(3);
            this.worldTab.Size = new System.Drawing.Size(715, 522);
            this.worldTab.TabIndex = 0;
            this.worldTab.Text = "World";
            this.worldTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.eastNeighbor);
            this.panel1.Controls.Add(this.northNeighbor);
            this.panel1.Controls.Add(this.southNeighbor);
            this.panel1.Controls.Add(this.westNeighbor);
            this.panel1.Controls.Add(this.eastButton);
            this.panel1.Controls.Add(this.southButton);
            this.panel1.Controls.Add(this.westButton1);
            this.panel1.Controls.Add(this.northButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.currentRoomlabel);
            this.panel1.Location = new System.Drawing.Point(194, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 474);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 47);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 102);
            this.textBox1.TabIndex = 11;
            // 
            // eastNeighbor
            // 
            this.eastNeighbor.AutoSize = true;
            this.eastNeighbor.Location = new System.Drawing.Point(368, 367);
            this.eastNeighbor.Name = "eastNeighbor";
            this.eastNeighbor.Size = new System.Drawing.Size(58, 17);
            this.eastNeighbor.TabIndex = 10;
            this.eastNeighbor.Text = "<None>";
            // 
            // northNeighbor
            // 
            this.northNeighbor.AutoSize = true;
            this.northNeighbor.Location = new System.Drawing.Point(209, 250);
            this.northNeighbor.Name = "northNeighbor";
            this.northNeighbor.Size = new System.Drawing.Size(58, 17);
            this.northNeighbor.TabIndex = 9;
            this.northNeighbor.Text = "<None>";
            // 
            // southNeighbor
            // 
            this.southNeighbor.AutoSize = true;
            this.southNeighbor.Location = new System.Drawing.Point(209, 437);
            this.southNeighbor.Name = "southNeighbor";
            this.southNeighbor.Size = new System.Drawing.Size(58, 17);
            this.southNeighbor.TabIndex = 8;
            this.southNeighbor.Text = "<None>";
            // 
            // westNeighbor
            // 
            this.westNeighbor.AutoSize = true;
            this.westNeighbor.Location = new System.Drawing.Point(65, 367);
            this.westNeighbor.Name = "westNeighbor";
            this.westNeighbor.Size = new System.Drawing.Size(58, 17);
            this.westNeighbor.TabIndex = 7;
            this.westNeighbor.Text = "<None>";
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(361, 294);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 67);
            this.eastButton.TabIndex = 6;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(202, 367);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 67);
            this.southButton.TabIndex = 4;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            // 
            // westButton1
            // 
            this.westButton1.Location = new System.Drawing.Point(51, 294);
            this.westButton1.Name = "westButton1";
            this.westButton1.Size = new System.Drawing.Size(75, 67);
            this.westButton1.TabIndex = 3;
            this.westButton1.Text = "West";
            this.westButton1.UseVisualStyleBackColor = true;
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(202, 180);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 67);
            this.northButton.TabIndex = 2;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // currentRoomlabel
            // 
            this.currentRoomlabel.AutoSize = true;
            this.currentRoomlabel.Location = new System.Drawing.Point(3, 0);
            this.currentRoomlabel.Name = "currentRoomlabel";
            this.currentRoomlabel.Size = new System.Drawing.Size(90, 17);
            this.currentRoomlabel.TabIndex = 0;
            this.currentRoomlabel.Text = "Room Name:";
            this.currentRoomlabel.Click += new System.EventHandler(this.currentRoomlabel_Click);
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(18, 34);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(170, 24);
            this.startingLocationComboBox.TabIndex = 6;
            this.startingLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // roomListLabel
            // 
            this.roomListLabel.AutoSize = true;
            this.roomListLabel.Location = new System.Drawing.Point(15, 71);
            this.roomListLabel.Name = "roomListLabel";
            this.roomListLabel.Size = new System.Drawing.Size(52, 17);
            this.roomListLabel.TabIndex = 5;
            this.roomListLabel.Text = "Rooms";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(113, 485);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 485);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // startingRoomLabel
            // 
            this.startingRoomLabel.AutoSize = true;
            this.startingRoomLabel.Location = new System.Drawing.Point(15, 14);
            this.startingRoomLabel.Name = "startingRoomLabel";
            this.startingRoomLabel.Size = new System.Drawing.Size(115, 17);
            this.startingRoomLabel.TabIndex = 2;
            this.startingRoomLabel.Text = "Starting Location";
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.ItemHeight = 16;
            this.roomList.Location = new System.Drawing.Point(18, 91);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(170, 388);
            this.roomList.TabIndex = 0;
            // 
            // itemsTab
            // 
            this.itemsTab.Location = new System.Drawing.Point(4, 25);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTab.Size = new System.Drawing.Size(715, 558);
            this.itemsTab.TabIndex = 1;
            this.itemsTab.Text = "Items";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // gameTab
            // 
            this.gameTab.Controls.Add(this.titleLabel);
            this.gameTab.Controls.Add(this.textBox2);
            this.gameTab.Controls.Add(this.scoreLabel);
            this.gameTab.Controls.Add(this.scoreTracker);
            this.gameTab.Controls.Add(this.playerLabel);
            this.gameTab.Controls.Add(this.welcomeMessageLabel);
            this.gameTab.Controls.Add(this.welcomeMessageTextBox);
            this.gameTab.Controls.Add(this.ranksLabel);
            this.gameTab.Controls.Add(this.button1);
            this.gameTab.Controls.Add(this.button2);
            this.gameTab.Controls.Add(this.ranksList);
            this.gameTab.Location = new System.Drawing.Point(4, 25);
            this.gameTab.Name = "gameTab";
            this.gameTab.Size = new System.Drawing.Size(715, 558);
            this.gameTab.TabIndex = 2;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(182, 126);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 22);
            this.textBox2.TabIndex = 16;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(179, 174);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(45, 17);
            this.scoreLabel.TabIndex = 15;
            this.scoreLabel.Text = "Score";
            // 
            // scoreTracker
            // 
            this.scoreTracker.Location = new System.Drawing.Point(182, 194);
            this.scoreTracker.Name = "scoreTracker";
            this.scoreTracker.Size = new System.Drawing.Size(96, 22);
            this.scoreTracker.TabIndex = 13;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(0, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(48, 17);
            this.playerLabel.TabIndex = 12;
            this.playerLabel.Text = "Player";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(3, 36);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            this.welcomeMessageLabel.TabIndex = 11;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(3, 56);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(700, 22);
            this.welcomeMessageTextBox.TabIndex = 10;
            this.welcomeMessageTextBox.Text = "Welcome to ZORK.";
            // 
            // ranksLabel
            // 
            this.ranksLabel.AutoSize = true;
            this.ranksLabel.Location = new System.Drawing.Point(0, 81);
            this.ranksLabel.Name = "ranksLabel";
            this.ranksLabel.Size = new System.Drawing.Size(48, 17);
            this.ranksLabel.TabIndex = 9;
            this.ranksLabel.Text = "Ranks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ranksList
            // 
            this.ranksList.FormattingEnabled = true;
            this.ranksList.ItemHeight = 16;
            this.ranksList.Location = new System.Drawing.Point(3, 101);
            this.ranksList.Name = "ranksList";
            this.ranksList.Size = new System.Drawing.Size(170, 388);
            this.ranksList.TabIndex = 6;
            // 
            // filesTab
            // 
            this.filesTab.Location = new System.Drawing.Point(4, 25);
            this.filesTab.Name = "filesTab";
            this.filesTab.Size = new System.Drawing.Size(715, 558);
            this.filesTab.TabIndex = 3;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "ZorkBuilder";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 591);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gameTab.ResumeLayout(false);
            this.gameTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage worldTab;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label startingRoomLabel;
        private System.Windows.Forms.ListBox roomList;
        private System.Windows.Forms.TabPage itemsTab;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.Label roomListLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button westButton1;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label currentRoomlabel;
        private System.Windows.Forms.Label eastNeighbor;
        private System.Windows.Forms.Label northNeighbor;
        private System.Windows.Forms.Label southNeighbor;
        private System.Windows.Forms.Label westNeighbor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label ranksLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ranksList;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.NumericUpDown scoreTracker;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

