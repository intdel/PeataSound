namespace PeataSound
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSoundDialog = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.currentSoundFileDescLabel = new System.Windows.Forms.Label();
            this.playEveryLabel = new System.Windows.Forms.Label();
            this.minuteSelector = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.currentSoundFileNameLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripNextTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundLauncher = new System.ComponentModel.BackgroundWorker();
            this.playButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.chooseButton = new System.Windows.Forms.Button();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.playForLabel = new System.Windows.Forms.Label();
            this.durationSelector = new System.Windows.Forms.NumericUpDown();
            this.playForSecondLabel = new System.Windows.Forms.Label();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            this.testSoundButtonWatcher = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteSelector)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click here to open it again!";
            this.notifyIcon1.BalloonTipTitle = "NoSleep is still running";
            this.notifyIcon1.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportConfigurationToolStripMenuItem,
            this.importConfigurationToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportConfigurationToolStripMenuItem
            // 
            this.exportConfigurationToolStripMenuItem.Enabled = false;
            this.exportConfigurationToolStripMenuItem.Name = "exportConfigurationToolStripMenuItem";
            this.exportConfigurationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportConfigurationToolStripMenuItem.Text = "Export configuration";
            // 
            // importConfigurationToolStripMenuItem
            // 
            this.importConfigurationToolStripMenuItem.Enabled = false;
            this.importConfigurationToolStripMenuItem.Name = "importConfigurationToolStripMenuItem";
            this.importConfigurationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.importConfigurationToolStripMenuItem.Text = "Import configuration";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectSoundDialog
            // 
            this.selectSoundDialog.Filter = "Sound (*.wav)|*.wav|All Files|*.*";
            this.selectSoundDialog.Title = "Select Sound to Play";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(62, 248);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // currentSoundFileDescLabel
            // 
            this.currentSoundFileDescLabel.AutoSize = true;
            this.currentSoundFileDescLabel.Location = new System.Drawing.Point(62, 48);
            this.currentSoundFileDescLabel.Name = "currentSoundFileDescLabel";
            this.currentSoundFileDescLabel.Size = new System.Drawing.Size(91, 13);
            this.currentSoundFileDescLabel.TabIndex = 3;
            this.currentSoundFileDescLabel.Text = "Current Soundfile:";
            // 
            // playEveryLabel
            // 
            this.playEveryLabel.AutoSize = true;
            this.playEveryLabel.Location = new System.Drawing.Point(63, 215);
            this.playEveryLabel.Name = "playEveryLabel";
            this.playEveryLabel.Size = new System.Drawing.Size(56, 13);
            this.playEveryLabel.TabIndex = 4;
            this.playEveryLabel.Text = "Play every";
            // 
            // minuteSelector
            // 
            this.minuteSelector.Location = new System.Drawing.Point(125, 213);
            this.minuteSelector.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minuteSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minuteSelector.Name = "minuteSelector";
            this.minuteSelector.Size = new System.Drawing.Size(77, 20);
            this.minuteSelector.TabIndex = 5;
            this.minuteSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuteSelector.ThousandsSeparator = true;
            this.minuteSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minuteSelector.ValueChanged += new System.EventHandler(this.minuteSelector_ValueChanged);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(176, 248);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(209, 215);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(46, 13);
            this.minutesLabel.TabIndex = 7;
            this.minutesLabel.Text = "minutes.";
            // 
            // currentSoundFileNameLabel
            // 
            this.currentSoundFileNameLabel.AutoSize = true;
            this.currentSoundFileNameLabel.Location = new System.Drawing.Point(171, 48);
            this.currentSoundFileNameLabel.Name = "currentSoundFileNameLabel";
            this.currentSoundFileNameLabel.Size = new System.Drawing.Size(65, 13);
            this.currentSoundFileNameLabel.TabIndex = 8;
            this.currentSoundFileNameLabel.Text = "$current_file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripNextTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(312, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "$status";
            // 
            // toolStripNextTimeLabel
            // 
            this.toolStripNextTimeLabel.Name = "toolStripNextTimeLabel";
            this.toolStripNextTimeLabel.Size = new System.Drawing.Size(148, 17);
            this.toolStripNextTimeLabel.Spring = true;
            this.toolStripNextTimeLabel.Text = "$next_time";
            // 
            // backgroundLauncher
            // 
            this.backgroundLauncher.WorkerReportsProgress = true;
            this.backgroundLauncher.WorkerSupportsCancellation = true;
            this.backgroundLauncher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLauncher_DoWork);
            this.backgroundLauncher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundLauncher_ProgressChanged);
            this.backgroundLauncher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLauncher_RunWorkerCompleted);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(62, 73);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Prelisten";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(12, 118);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(273, 45);
            this.volumeBar.TabIndex = 11;
            this.volumeBar.TickFrequency = 10;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(161, 73);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(90, 23);
            this.chooseButton.TabIndex = 12;
            this.chooseButton.Text = "Change Sound";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(111, 102);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 13;
            this.volumeLabel.Text = "Volume";
            // 
            // playForLabel
            // 
            this.playForLabel.AutoSize = true;
            this.playForLabel.Location = new System.Drawing.Point(77, 166);
            this.playForLabel.Name = "playForLabel";
            this.playForLabel.Size = new System.Drawing.Size(42, 13);
            this.playForLabel.TabIndex = 14;
            this.playForLabel.Text = "Play for";
            // 
            // durationSelector
            // 
            this.durationSelector.Location = new System.Drawing.Point(125, 164);
            this.durationSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationSelector.Name = "durationSelector";
            this.durationSelector.Size = new System.Drawing.Size(77, 20);
            this.durationSelector.TabIndex = 15;
            this.durationSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.durationSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationSelector.ValueChanged += new System.EventHandler(this.durationSelector_ValueChanged);
            // 
            // playForSecondLabel
            // 
            this.playForSecondLabel.AutoSize = true;
            this.playForSecondLabel.Location = new System.Drawing.Point(209, 166);
            this.playForSecondLabel.Name = "playForSecondLabel";
            this.playForSecondLabel.Size = new System.Drawing.Size(69, 13);
            this.playForSecondLabel.TabIndex = 16;
            this.playForSecondLabel.Text = "milli-seconds.";
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.Location = new System.Drawing.Point(161, 103);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(47, 13);
            this.volumeValueLabel.TabIndex = 17;
            this.volumeValueLabel.Text = "$vol_val";
            // 
            // testSoundButtonWatcher
            // 
            this.testSoundButtonWatcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.testSoundButtonWatcher_DoWork);
            this.testSoundButtonWatcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.testSoundButtonWatcher_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "All changes only affect next play!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeValueLabel);
            this.Controls.Add(this.playForSecondLabel);
            this.Controls.Add(this.durationSelector);
            this.Controls.Add(this.playForLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.currentSoundFileNameLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.minuteSelector);
            this.Controls.Add(this.playEveryLabel);
            this.Controls.Add(this.currentSoundFileDescLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeataSound - EARLY BUILD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteSelector)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog selectSoundDialog;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label currentSoundFileDescLabel;
        private System.Windows.Forms.Label playEveryLabel;
        private System.Windows.Forms.NumericUpDown minuteSelector;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label currentSoundFileNameLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripNextTimeLabel;
        private System.ComponentModel.BackgroundWorker backgroundLauncher;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label playForLabel;
        private System.Windows.Forms.NumericUpDown durationSelector;
        private System.Windows.Forms.Label playForSecondLabel;
        private System.Windows.Forms.Label volumeValueLabel;
        private System.ComponentModel.BackgroundWorker testSoundButtonWatcher;
        private System.Windows.Forms.Label label1;
    }
}

