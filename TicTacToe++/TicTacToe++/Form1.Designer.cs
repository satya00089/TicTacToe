namespace TicTacToe__
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p2 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.A2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.B2 = new System.Windows.Forms.Button();
            this.o_win_count = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Button();
            this.x_win_count = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.draw_count = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlayerDefaultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlayerDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.DarkGreen;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.Color.Yellow;
            this.p2.Location = new System.Drawing.Point(208, 288);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(77, 20);
            this.p2.TabIndex = 76;
            this.p2.Text = "player2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.DarkOrange;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.Yellow;
            this.p1.Location = new System.Drawing.Point(43, 288);
            this.p1.MaxLength = 8;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(77, 20);
            this.p1.TabIndex = 75;
            this.p1.Text = "player1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.progressBar3.Location = new System.Drawing.Point(127, 336);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(77, 10);
            this.progressBar3.TabIndex = 74;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(77, 10);
            this.progressBar1.TabIndex = 72;
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.DarkOrange;
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(127, 35);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 60;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(207, 336);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(77, 10);
            this.progressBar2.TabIndex = 73;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(127, 116);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 63;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.BackColor = System.Drawing.Color.IndianRed;
            this.o_win_count.Location = new System.Drawing.Point(241, 317);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 13);
            this.o_win_count.TabIndex = 70;
            this.o_win_count.Text = "0";
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.DarkGreen;
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(46, 197);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 65;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.BackColor = System.Drawing.Color.IndianRed;
            this.x_win_count.Location = new System.Drawing.Point(78, 317);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 13);
            this.x_win_count.TabIndex = 69;
            this.x_win_count.Text = "0";
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.DarkOrange;
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(46, 35);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 59;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.DarkOrange;
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(208, 35);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 61;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(126, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Draw Count";
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(46, 116);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 62;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(208, 116);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 64;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.DarkGreen;
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(208, 197);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 67;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.DarkGreen;
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(127, 197);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 66;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.BackColor = System.Drawing.Color.IndianRed;
            this.draw_count.Location = new System.Drawing.Point(158, 317);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 13);
            this.draw_count.TabIndex = 71;
            this.draw_count.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.setPlayerDefaultsToolStripMenuItem1,
            this.resetToolStripMenuItem,
            this.toolStripSeparator5,
            this.levelToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 126);
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GrayText;
            this.newGameToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newGameToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem1.Image")));
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // setPlayerDefaultsToolStripMenuItem1
            // 
            this.setPlayerDefaultsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setPlayerDefaultsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("setPlayerDefaultsToolStripMenuItem1.Image")));
            this.setPlayerDefaultsToolStripMenuItem1.Name = "setPlayerDefaultsToolStripMenuItem1";
            this.setPlayerDefaultsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.setPlayerDefaultsToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.setPlayerDefaultsToolStripMenuItem1.Text = "Set Player Defaults";
            this.setPlayerDefaultsToolStripMenuItem1.Click += new System.EventHandler(this.setPlayerDefaultsToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripMenuItem.Image")));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.resetToolStripMenuItem.Text = "Reset Win Count";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("levelToolStripMenuItem1.Image")));
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.levelToolStripMenuItem1.Text = "Level";
            this.levelToolStripMenuItem1.Click += new System.EventHandler(this.levelToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayerDefaultToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.toolStripSeparator1,
            this.levelToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.Image")));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // setPlayerDefaultToolStripMenuItem
            // 
            this.setPlayerDefaultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setPlayerDefaultToolStripMenuItem.Image")));
            this.setPlayerDefaultToolStripMenuItem.Name = "setPlayerDefaultToolStripMenuItem";
            this.setPlayerDefaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.setPlayerDefaultToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.setPlayerDefaultToolStripMenuItem.Text = "Set Player Default";
            this.setPlayerDefaultToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaultToolStripMenuItem_Click_1);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetWinCountToolStripMenuItem.Image")));
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(253)))));
            this.levelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("levelToolStripMenuItem.Image")));
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.levelToolStripMenuItem.Text = "Level";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutUSToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instructionsToolStripMenuItem.Image")));
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUSToolStripMenuItem.Image")));
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutUSToolStripMenuItem.Text = "About TicTacToe++";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About Author";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpProvider1.SetHelpString(this.button1, "level");
            this.button1.Location = new System.Drawing.Point(292, -1);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 357);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.draw_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem1;
    }
}

