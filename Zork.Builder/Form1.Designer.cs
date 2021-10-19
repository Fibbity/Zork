
namespace Zork.Builder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worldTab = new System.Windows.Forms.TabPage();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomList = new System.Windows.Forms.ListBox();
            this.startingRoomLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.roomListLabel = new System.Windows.Forms.Label();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentRoomlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.northButton = new System.Windows.Forms.Button();
            this.westButton1 = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.westNeighbor = new System.Windows.Forms.Label();
            this.southNeighbor = new System.Windows.Forms.Label();
            this.northNeighbor = new System.Windows.Forms.Label();
            this.eastNeighbor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
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
            this.tabControl1.Size = new System.Drawing.Size(951, 587);
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
            this.worldTab.Size = new System.Drawing.Size(943, 558);
            this.worldTab.TabIndex = 0;
            this.worldTab.Text = "World";
            this.worldTab.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Location = new System.Drawing.Point(4, 25);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTab.Size = new System.Drawing.Size(943, 558);
            this.itemsTab.TabIndex = 1;
            this.itemsTab.Text = "Items";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // gameTab
            // 
            this.gameTab.Location = new System.Drawing.Point(4, 25);
            this.gameTab.Name = "gameTab";
            this.gameTab.Size = new System.Drawing.Size(943, 558);
            this.gameTab.TabIndex = 2;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.Location = new System.Drawing.Point(4, 25);
            this.filesTab.Name = "filesTab";
            this.filesTab.Size = new System.Drawing.Size(943, 558);
            this.filesTab.TabIndex = 3;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
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
            // startingRoomLabel
            // 
            this.startingRoomLabel.AutoSize = true;
            this.startingRoomLabel.Location = new System.Drawing.Point(15, 14);
            this.startingRoomLabel.Name = "startingRoomLabel";
            this.startingRoomLabel.Size = new System.Drawing.Size(115, 17);
            this.startingRoomLabel.TabIndex = 2;
            this.startingRoomLabel.Text = "Starting Location";
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
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(113, 485);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(18, 34);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(170, 24);
            this.startingLocationComboBox.TabIndex = 6;
            this.startingLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(194, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 367);
            this.panel1.TabIndex = 7;
            // 
            // currentRoomlabel
            // 
            this.currentRoomlabel.AutoSize = true;
            this.currentRoomlabel.Location = new System.Drawing.Point(3, 0);
            this.currentRoomlabel.Name = "currentRoomlabel";
            this.currentRoomlabel.Size = new System.Drawing.Size(90, 17);
            this.currentRoomlabel.TabIndex = 0;
            this.currentRoomlabel.Text = "Room Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(202, 50);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 67);
            this.northButton.TabIndex = 2;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            // 
            // westButton1
            // 
            this.westButton1.Location = new System.Drawing.Point(51, 164);
            this.westButton1.Name = "westButton1";
            this.westButton1.Size = new System.Drawing.Size(75, 67);
            this.westButton1.TabIndex = 3;
            this.westButton1.Text = "West";
            this.westButton1.UseVisualStyleBackColor = true;
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(202, 237);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 67);
            this.southButton.TabIndex = 4;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(361, 164);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 67);
            this.eastButton.TabIndex = 6;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // westNeighbor
            // 
            this.westNeighbor.AutoSize = true;
            this.westNeighbor.Location = new System.Drawing.Point(65, 237);
            this.westNeighbor.Name = "westNeighbor";
            this.westNeighbor.Size = new System.Drawing.Size(58, 17);
            this.westNeighbor.TabIndex = 7;
            this.westNeighbor.Text = "<None>";
            // 
            // southNeighbor
            // 
            this.southNeighbor.AutoSize = true;
            this.southNeighbor.Location = new System.Drawing.Point(209, 307);
            this.southNeighbor.Name = "southNeighbor";
            this.southNeighbor.Size = new System.Drawing.Size(58, 17);
            this.southNeighbor.TabIndex = 8;
            this.southNeighbor.Text = "<None>";
            // 
            // northNeighbor
            // 
            this.northNeighbor.AutoSize = true;
            this.northNeighbor.Location = new System.Drawing.Point(209, 120);
            this.northNeighbor.Name = "northNeighbor";
            this.northNeighbor.Size = new System.Drawing.Size(58, 17);
            this.northNeighbor.TabIndex = 9;
            this.northNeighbor.Text = "<None>";
            // 
            // eastNeighbor
            // 
            this.eastNeighbor.AutoSize = true;
            this.eastNeighbor.Location = new System.Drawing.Point(368, 237);
            this.eastNeighbor.Name = "eastNeighbor";
            this.eastNeighbor.Size = new System.Drawing.Size(58, 17);
            this.eastNeighbor.TabIndex = 10;
            this.eastNeighbor.Text = "<None>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 631);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.worldTab.ResumeLayout(false);
            this.worldTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
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
    }
}

