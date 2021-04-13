namespace FileSplitter_Joiner
{
    partial class FormMain
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
            this.groupBox_FileSplit = new DarkUI.Controls.DarkGroupBox();
            this.btnScanFolderSplit = new DarkUI.Controls.DarkButton();
            this.tbScanFolderSplit = new DarkUI.Controls.DarkTextBox();
            this.radioScanFolderSplit = new DarkUI.Controls.DarkRadioButton();
            this.radioSplitFile = new DarkUI.Controls.DarkRadioButton();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.btnOutputSplit = new DarkUI.Controls.DarkButton();
            this.tbOutputSplit = new DarkUI.Controls.DarkTextBox();
            this.btnBrowseFileSplit = new DarkUI.Controls.DarkButton();
            this.tbSplitFile = new DarkUI.Controls.DarkTextBox();
            this.groupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.label4 = new DarkUI.Controls.DarkLabel();
            this.numericUpDown_stepSize = new DarkUI.Controls.DarkNumericUpDown();
            this.numericUpDown_SplitSize = new DarkUI.Controls.DarkNumericUpDown();
            this.comboBox_ByteSize = new DarkUI.Controls.DarkComboBox();
            this.label3 = new DarkUI.Controls.DarkLabel();
            this.button_Split = new DarkUI.Controls.DarkButton();
            this.splitWorker = new System.ComponentModel.BackgroundWorker();
            this.darkListBoxSplit = new DarkUI.Controls.DarkListBox(this.components);
            this.darkContextMenuSplit = new DarkUI.Controls.DarkContextMenu();
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanFolderWorker = new System.ComponentModel.BackgroundWorker();
            this.label7 = new DarkUI.Controls.DarkLabel();
            this.checkBoxDeleteFile = new DarkUI.Controls.DarkCheckBox();
            this.darkListBoxJoin = new DarkUI.Controls.DarkListBox(this.components);
            this.darkContextMenuJoin = new DarkUI.Controls.DarkContextMenu();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new DarkUI.Controls.DarkLabel();
            this.checkboxDeletefileJoin = new DarkUI.Controls.DarkCheckBox();
            this.groupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.label5 = new DarkUI.Controls.DarkLabel();
            this.numericUpDown1 = new DarkUI.Controls.DarkNumericUpDown();
            this.button_Join = new DarkUI.Controls.DarkButton();
            this.groupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.radioJoinFile = new DarkUI.Controls.DarkRadioButton();
            this.radioScanFolderJoin = new DarkUI.Controls.DarkRadioButton();
            this.btnScanFolderJoin = new DarkUI.Controls.DarkButton();
            this.tbScanFolderJoin = new DarkUI.Controls.DarkTextBox();
            this.btnOutputJoin = new DarkUI.Controls.DarkButton();
            this.tbOutputJoin = new DarkUI.Controls.DarkTextBox();
            this.btnBrowseFileJoin = new DarkUI.Controls.DarkButton();
            this.tbJoinFile = new DarkUI.Controls.DarkTextBox();
            this.scanFolderJoinworker = new System.ComponentModel.BackgroundWorker();
            this.joinWorker = new System.ComponentModel.BackgroundWorker();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_SplitNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flatTabControl1 = new FlatTabControl.FlatTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.darkCheckBoxSplitAll = new DarkUI.Controls.DarkCheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.darkCheckBoxJoinAll = new DarkUI.Controls.DarkCheckBox();
            this.groupBox_FileSplit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SplitSize)).BeginInit();
            this.darkContextMenuSplit.SuspendLayout();
            this.darkContextMenuJoin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.darkStatusStrip1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_FileSplit
            // 
            this.groupBox_FileSplit.Controls.Add(this.btnScanFolderSplit);
            this.groupBox_FileSplit.Controls.Add(this.tbScanFolderSplit);
            this.groupBox_FileSplit.Controls.Add(this.radioScanFolderSplit);
            this.groupBox_FileSplit.Controls.Add(this.radioSplitFile);
            this.groupBox_FileSplit.Controls.Add(this.label2);
            this.groupBox_FileSplit.Controls.Add(this.btnOutputSplit);
            this.groupBox_FileSplit.Controls.Add(this.tbOutputSplit);
            this.groupBox_FileSplit.Controls.Add(this.btnBrowseFileSplit);
            this.groupBox_FileSplit.Controls.Add(this.tbSplitFile);
            this.groupBox_FileSplit.Location = new System.Drawing.Point(15, 13);
            this.groupBox_FileSplit.Name = "groupBox_FileSplit";
            this.groupBox_FileSplit.Size = new System.Drawing.Size(465, 204);
            this.groupBox_FileSplit.TabIndex = 1;
            this.groupBox_FileSplit.TabStop = false;
            this.groupBox_FileSplit.Text = "Select file/folder/output";
            // 
            // btnScanFolderSplit
            // 
            this.btnScanFolderSplit.Location = new System.Drawing.Point(364, 44);
            this.btnScanFolderSplit.Name = "btnScanFolderSplit";
            this.btnScanFolderSplit.Size = new System.Drawing.Size(93, 27);
            this.btnScanFolderSplit.TabIndex = 9;
            this.btnScanFolderSplit.Text = "Browse folder";
            this.btnScanFolderSplit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbScanFolderSplit
            // 
            this.tbScanFolderSplit.Location = new System.Drawing.Point(12, 46);
            this.tbScanFolderSplit.Name = "tbScanFolderSplit";
            this.tbScanFolderSplit.Size = new System.Drawing.Size(345, 23);
            this.tbScanFolderSplit.TabIndex = 8;
            this.tbScanFolderSplit.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // radioScanFolderSplit
            // 
            this.radioScanFolderSplit.AutoSize = true;
            this.radioScanFolderSplit.Checked = true;
            this.radioScanFolderSplit.Location = new System.Drawing.Point(12, 21);
            this.radioScanFolderSplit.Name = "radioScanFolderSplit";
            this.radioScanFolderSplit.Size = new System.Drawing.Size(146, 19);
            this.radioScanFolderSplit.TabIndex = 7;
            this.radioScanFolderSplit.TabStop = true;
            this.radioScanFolderSplit.Text = "Scan folder for big files";
            this.radioScanFolderSplit.CheckedChanged += new System.EventHandler(this.radioScanFolder_CheckedChanged);
            // 
            // radioSplitFile
            // 
            this.radioSplitFile.AutoSize = true;
            this.radioSplitFile.Location = new System.Drawing.Point(12, 76);
            this.radioSplitFile.Name = "radioSplitFile";
            this.radioSplitFile.Size = new System.Drawing.Size(96, 19);
            this.radioSplitFile.TabIndex = 6;
            this.radioSplitFile.Text = "Split a big file";
            this.radioSplitFile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Path";
            // 
            // btnOutputSplit
            // 
            this.btnOutputSplit.Location = new System.Drawing.Point(365, 154);
            this.btnOutputSplit.Name = "btnOutputSplit";
            this.btnOutputSplit.Size = new System.Drawing.Size(93, 27);
            this.btnOutputSplit.TabIndex = 3;
            this.btnOutputSplit.Text = "Browse dir";
            this.btnOutputSplit.Click += new System.EventHandler(this.button_FolderBrowse_Click);
            // 
            // tbOutputSplit
            // 
            this.tbOutputSplit.Location = new System.Drawing.Point(13, 157);
            this.tbOutputSplit.Name = "tbOutputSplit";
            this.tbOutputSplit.Size = new System.Drawing.Size(345, 23);
            this.tbOutputSplit.TabIndex = 2;
            this.tbOutputSplit.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // btnBrowseFileSplit
            // 
            this.btnBrowseFileSplit.Enabled = false;
            this.btnBrowseFileSplit.Location = new System.Drawing.Point(364, 100);
            this.btnBrowseFileSplit.Name = "btnBrowseFileSplit";
            this.btnBrowseFileSplit.Size = new System.Drawing.Size(94, 27);
            this.btnBrowseFileSplit.TabIndex = 1;
            this.btnBrowseFileSplit.Text = "Browse file";
            this.btnBrowseFileSplit.Click += new System.EventHandler(this.button_FileBrowse_Click);
            // 
            // tbSplitFile
            // 
            this.tbSplitFile.Enabled = false;
            this.tbSplitFile.Location = new System.Drawing.Point(12, 103);
            this.tbSplitFile.Name = "tbSplitFile";
            this.tbSplitFile.Size = new System.Drawing.Size(345, 23);
            this.tbSplitFile.TabIndex = 0;
            this.tbSplitFile.TextChanged += new System.EventHandler(this.userInputChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown_stepSize);
            this.groupBox2.Controls.Add(this.numericUpDown_SplitSize);
            this.groupBox2.Controls.Add(this.comboBox_ByteSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Memory Step Size (MB)";
            // 
            // numericUpDown_stepSize
            // 
            this.numericUpDown_stepSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.numericUpDown_stepSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numericUpDown_stepSize.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown_stepSize.Location = new System.Drawing.Point(23, 88);
            this.numericUpDown_stepSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_stepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stepSize.MousewheelSingleIncrement = true;
            this.numericUpDown_stepSize.Name = "numericUpDown_stepSize";
            this.numericUpDown_stepSize.ReadOnly = true;
            this.numericUpDown_stepSize.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown_stepSize.TabIndex = 4;
            this.numericUpDown_stepSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown_SplitSize
            // 
            this.numericUpDown_SplitSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.numericUpDown_SplitSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numericUpDown_SplitSize.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown_SplitSize.Location = new System.Drawing.Point(23, 38);
            this.numericUpDown_SplitSize.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.MousewheelSingleIncrement = true;
            this.numericUpDown_SplitSize.Name = "numericUpDown_SplitSize";
            this.numericUpDown_SplitSize.ReadOnly = true;
            this.numericUpDown_SplitSize.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown_SplitSize.TabIndex = 3;
            this.numericUpDown_SplitSize.Value = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numericUpDown_SplitSize.ValueChanged += new System.EventHandler(this.userInputChanged);
            // 
            // comboBox_ByteSize
            // 
            this.comboBox_ByteSize.FormattingEnabled = true;
            this.comboBox_ByteSize.Items.AddRange(new object[] {
            "B",
            "kB",
            "MB"});
            this.comboBox_ByteSize.Location = new System.Drawing.Point(111, 38);
            this.comboBox_ByteSize.Name = "comboBox_ByteSize";
            this.comboBox_ByteSize.Size = new System.Drawing.Size(47, 24);
            this.comboBox_ByteSize.TabIndex = 2;
            this.comboBox_ByteSize.SelectedIndexChanged += new System.EventHandler(this.userInputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Split File Size";
            // 
            // button_Split
            // 
            this.button_Split.Enabled = false;
            this.button_Split.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Split.Location = new System.Drawing.Point(200, 223);
            this.button_Split.Name = "button_Split";
            this.button_Split.Size = new System.Drawing.Size(281, 98);
            this.button_Split.TabIndex = 4;
            this.button_Split.Text = "Split!";
            this.button_Split.Click += new System.EventHandler(this.button_Split_Click);
            // 
            // splitWorker
            // 
            this.splitWorker.WorkerReportsProgress = true;
            this.splitWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.splitWorker_DoWork);
            this.splitWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.splitWorker_ProgressChanged);
            // 
            // darkListBoxSplit
            // 
            this.darkListBoxSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkListBoxSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkListBoxSplit.ContextMenuStrip = this.darkContextMenuSplit;
            this.darkListBoxSplit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.darkListBoxSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkListBoxSplit.FormattingEnabled = true;
            this.darkListBoxSplit.ItemHeight = 15;
            this.darkListBoxSplit.Location = new System.Drawing.Point(487, 42);
            this.darkListBoxSplit.Name = "darkListBoxSplit";
            this.darkListBoxSplit.Size = new System.Drawing.Size(465, 302);
            this.darkListBoxSplit.TabIndex = 6;
            this.darkListBoxSplit.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // darkContextMenuSplit
            // 
            this.darkContextMenuSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenuSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenuSplit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInExplorerToolStripMenuItem});
            this.darkContextMenuSplit.Name = "darkContextMenu1";
            this.darkContextMenuSplit.Size = new System.Drawing.Size(169, 26);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openInExplorerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openInExplorerToolStripMenuItem.Text = "Open file location";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // ScanFolderWorker
            // 
            this.ScanFolderWorker.WorkerReportsProgress = true;
            this.ScanFolderWorker.WorkerSupportsCancellation = true;
            this.ScanFolderWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ScanFolderWorker_DoWork);
            this.ScanFolderWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ScanFolderWorker_RunWorkerCompleted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label7.Location = new System.Drawing.Point(484, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Scan result :";
            // 
            // checkBoxDeleteFile
            // 
            this.checkBoxDeleteFile.AutoSize = true;
            this.checkBoxDeleteFile.Location = new System.Drawing.Point(200, 327);
            this.checkBoxDeleteFile.Name = "checkBoxDeleteFile";
            this.checkBoxDeleteFile.Size = new System.Drawing.Size(173, 19);
            this.checkBoxDeleteFile.TabIndex = 7;
            this.checkBoxDeleteFile.Text = "Delete original file after split";
            // 
            // darkListBoxJoin
            // 
            this.darkListBoxJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkListBoxJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkListBoxJoin.ContextMenuStrip = this.darkContextMenuJoin;
            this.darkListBoxJoin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.darkListBoxJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkListBoxJoin.FormattingEnabled = true;
            this.darkListBoxJoin.ItemHeight = 15;
            this.darkListBoxJoin.Location = new System.Drawing.Point(487, 42);
            this.darkListBoxJoin.Name = "darkListBoxJoin";
            this.darkListBoxJoin.Size = new System.Drawing.Size(465, 302);
            this.darkListBoxJoin.TabIndex = 13;
            this.darkListBoxJoin.SelectedIndexChanged += new System.EventHandler(this.darkListBoxJoin_SelectedIndexChanged);
            // 
            // darkContextMenuJoin
            // 
            this.darkContextMenuJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenuJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenuJoin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.darkContextMenuJoin.Name = "darkContextMenu1";
            this.darkContextMenuJoin.Size = new System.Drawing.Size(169, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Open file location";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(484, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scan result :";
            // 
            // checkboxDeletefileJoin
            // 
            this.checkboxDeletefileJoin.AutoSize = true;
            this.checkboxDeletefileJoin.Location = new System.Drawing.Point(200, 327);
            this.checkboxDeletefileJoin.Name = "checkboxDeletefileJoin";
            this.checkboxDeletefileJoin.Size = new System.Drawing.Size(171, 19);
            this.checkboxDeletefileJoin.TabIndex = 12;
            this.checkboxDeletefileJoin.Text = "Delete original file after join";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(15, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 123);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memory Step Size (MB)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.numericUpDown1.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(27, 59);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.MousewheelSingleIncrement = true;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button_Join
            // 
            this.button_Join.Enabled = false;
            this.button_Join.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Join.Location = new System.Drawing.Point(200, 223);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(281, 98);
            this.button_Join.TabIndex = 10;
            this.button_Join.Text = "Join!";
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.darkLabel1);
            this.groupBox1.Controls.Add(this.radioJoinFile);
            this.groupBox1.Controls.Add(this.radioScanFolderJoin);
            this.groupBox1.Controls.Add(this.btnScanFolderJoin);
            this.groupBox1.Controls.Add(this.tbScanFolderJoin);
            this.groupBox1.Controls.Add(this.btnOutputJoin);
            this.groupBox1.Controls.Add(this.tbOutputJoin);
            this.groupBox1.Controls.Add(this.btnBrowseFileJoin);
            this.groupBox1.Controls.Add(this.tbJoinFile);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select file/folder/output";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(10, 139);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(72, 15);
            this.darkLabel1.TabIndex = 12;
            this.darkLabel1.Text = "Output Path";
            // 
            // radioJoinFile
            // 
            this.radioJoinFile.AutoSize = true;
            this.radioJoinFile.Location = new System.Drawing.Point(12, 76);
            this.radioJoinFile.Name = "radioJoinFile";
            this.radioJoinFile.Size = new System.Drawing.Size(116, 19);
            this.radioJoinFile.TabIndex = 11;
            this.radioJoinFile.Text = "Join a splitted file";
            this.radioJoinFile.CheckedChanged += new System.EventHandler(this.radioSplitFileJoin_CheckedChanged);
            // 
            // radioScanFolderJoin
            // 
            this.radioScanFolderJoin.AutoSize = true;
            this.radioScanFolderJoin.Checked = true;
            this.radioScanFolderJoin.Location = new System.Drawing.Point(12, 21);
            this.radioScanFolderJoin.Name = "radioScanFolderJoin";
            this.radioScanFolderJoin.Size = new System.Drawing.Size(168, 19);
            this.radioScanFolderJoin.TabIndex = 10;
            this.radioScanFolderJoin.TabStop = true;
            this.radioScanFolderJoin.Text = "Scan folder for splitted files";
            this.radioScanFolderJoin.CheckedChanged += new System.EventHandler(this.radioScanFolderJoin_CheckedChanged);
            // 
            // btnScanFolderJoin
            // 
            this.btnScanFolderJoin.Location = new System.Drawing.Point(364, 44);
            this.btnScanFolderJoin.Name = "btnScanFolderJoin";
            this.btnScanFolderJoin.Size = new System.Drawing.Size(93, 27);
            this.btnScanFolderJoin.TabIndex = 9;
            this.btnScanFolderJoin.Text = "Browse folder";
            this.btnScanFolderJoin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbScanFolderJoin
            // 
            this.tbScanFolderJoin.Location = new System.Drawing.Point(12, 46);
            this.tbScanFolderJoin.Name = "tbScanFolderJoin";
            this.tbScanFolderJoin.Size = new System.Drawing.Size(345, 23);
            this.tbScanFolderJoin.TabIndex = 8;
            this.tbScanFolderJoin.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // btnOutputJoin
            // 
            this.btnOutputJoin.Location = new System.Drawing.Point(365, 154);
            this.btnOutputJoin.Name = "btnOutputJoin";
            this.btnOutputJoin.Size = new System.Drawing.Size(93, 27);
            this.btnOutputJoin.TabIndex = 3;
            this.btnOutputJoin.Text = "Browse dir";
            this.btnOutputJoin.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOutputJoin
            // 
            this.tbOutputJoin.Location = new System.Drawing.Point(13, 157);
            this.tbOutputJoin.Name = "tbOutputJoin";
            this.tbOutputJoin.Size = new System.Drawing.Size(345, 23);
            this.tbOutputJoin.TabIndex = 2;
            this.tbOutputJoin.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // btnBrowseFileJoin
            // 
            this.btnBrowseFileJoin.Enabled = false;
            this.btnBrowseFileJoin.Location = new System.Drawing.Point(364, 100);
            this.btnBrowseFileJoin.Name = "btnBrowseFileJoin";
            this.btnBrowseFileJoin.Size = new System.Drawing.Size(94, 27);
            this.btnBrowseFileJoin.TabIndex = 1;
            this.btnBrowseFileJoin.Text = "Browse file";
            this.btnBrowseFileJoin.Click += new System.EventHandler(this.btnBrowseFileJoin_Click);
            // 
            // tbJoinFile
            // 
            this.tbJoinFile.Enabled = false;
            this.tbJoinFile.Location = new System.Drawing.Point(12, 103);
            this.tbJoinFile.Name = "tbJoinFile";
            this.tbJoinFile.Size = new System.Drawing.Size(345, 23);
            this.tbJoinFile.TabIndex = 0;
            this.tbJoinFile.TextChanged += new System.EventHandler(this.userInputChangedJoin);
            // 
            // scanFolderJoinworker
            // 
            this.scanFolderJoinworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanFolderJoinworker_DoWork);
            this.scanFolderJoinworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.scanFolderJoinworker_RunWorkerCompleted);
            // 
            // joinWorker
            // 
            this.joinWorker.WorkerReportsProgress = true;
            this.joinWorker.WorkerSupportsCancellation = true;
            this.joinWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.joinWorker_DoWork);
            this.joinWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.joinWorker_ProgressChanged);
            this.joinWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.joinWorker_RunWorkerCompleted);
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel,
            this.toolStripStatusLabel_SplitNum,
            this.toolStripStatusLabel5,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel6});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 409);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1002, 24);
            this.darkStatusStrip1.TabIndex = 10;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(16, 11);
            this.toolStripLabel.Text = "...";
            // 
            // toolStripStatusLabel_SplitNum
            // 
            this.toolStripStatusLabel_SplitNum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_SplitNum.Name = "toolStripStatusLabel_SplitNum";
            this.toolStripStatusLabel_SplitNum.Size = new System.Drawing.Size(62, 11);
            this.toolStripStatusLabel_SplitNum.Text = "0 split files";
            this.toolStripStatusLabel_SplitNum.Visible = false;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(912, 11);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(117, 10);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(74, 11);
            this.toolStripStatusLabel6.Text = "By pearlxcore";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Controls.Add(this.tabPage4);
            this.flatTabControl1.Location = new System.Drawing.Point(12, 12);
            this.flatTabControl1.myBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(975, 388);
            this.flatTabControl1.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage3.Controls.Add(this.darkCheckBoxSplitAll);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.groupBox_FileSplit);
            this.tabPage3.Controls.Add(this.checkBoxDeleteFile);
            this.tabPage3.Controls.Add(this.button_Split);
            this.tabPage3.Controls.Add(this.darkListBoxSplit);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 359);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Split";
            // 
            // darkCheckBoxSplitAll
            // 
            this.darkCheckBoxSplitAll.AutoSize = true;
            this.darkCheckBoxSplitAll.Location = new System.Drawing.Point(381, 327);
            this.darkCheckBoxSplitAll.Name = "darkCheckBoxSplitAll";
            this.darkCheckBoxSplitAll.Size = new System.Drawing.Size(88, 19);
            this.darkCheckBoxSplitAll.TabIndex = 15;
            this.darkCheckBoxSplitAll.Text = "Split all files";
            this.darkCheckBoxSplitAll.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage4.Controls.Add(this.darkCheckBoxJoinAll);
            this.tabPage4.Controls.Add(this.darkListBoxJoin);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.button_Join);
            this.tabPage4.Controls.Add(this.checkboxDeletefileJoin);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(967, 359);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Join";
            // 
            // darkCheckBoxJoinAll
            // 
            this.darkCheckBoxJoinAll.AutoSize = true;
            this.darkCheckBoxJoinAll.Location = new System.Drawing.Point(381, 327);
            this.darkCheckBoxJoinAll.Name = "darkCheckBoxJoinAll";
            this.darkCheckBoxJoinAll.Size = new System.Drawing.Size(86, 19);
            this.darkCheckBoxJoinAll.TabIndex = 14;
            this.darkCheckBoxJoinAll.Text = "Join all files";
            this.darkCheckBoxJoinAll.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 433);
            this.Controls.Add(this.flatTabControl1);
            this.Controls.Add(this.darkStatusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 327);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Splitter & Joiner";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_FileSplit.ResumeLayout(false);
            this.groupBox_FileSplit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SplitSize)).EndInit();
            this.darkContextMenuSplit.ResumeLayout(false);
            this.darkContextMenuJoin.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox groupBox_FileSplit;
        private DarkUI.Controls.DarkLabel label2;
        private DarkUI.Controls.DarkButton btnOutputSplit;
        private DarkUI.Controls.DarkTextBox tbOutputSplit;
        private DarkUI.Controls.DarkButton btnBrowseFileSplit;
        private DarkUI.Controls.DarkTextBox tbSplitFile;
        private DarkUI.Controls.DarkGroupBox groupBox2;
        private DarkUI.Controls.DarkButton button_Split;
        private DarkUI.Controls.DarkNumericUpDown numericUpDown_SplitSize;
        private DarkUI.Controls.DarkComboBox comboBox_ByteSize;
        private DarkUI.Controls.DarkLabel label3;
        private DarkUI.Controls.DarkLabel label4;
        private DarkUI.Controls.DarkNumericUpDown numericUpDown_stepSize;
        private System.ComponentModel.BackgroundWorker splitWorker;
        private DarkUI.Controls.DarkButton btnScanFolderSplit;
        private DarkUI.Controls.DarkTextBox tbScanFolderSplit;
        private DarkUI.Controls.DarkListBox darkListBoxSplit;
        private System.ComponentModel.BackgroundWorker ScanFolderWorker;
        private DarkUI.Controls.DarkCheckBox checkBoxDeleteFile;
        private DarkUI.Controls.DarkButton button_Join;
        private DarkUI.Controls.DarkGroupBox groupBox1;
        private DarkUI.Controls.DarkButton btnScanFolderJoin;
        private DarkUI.Controls.DarkTextBox tbScanFolderJoin;
        private DarkUI.Controls.DarkButton btnOutputJoin;
        private DarkUI.Controls.DarkTextBox tbOutputJoin;
        private DarkUI.Controls.DarkButton btnBrowseFileJoin;
        private DarkUI.Controls.DarkTextBox tbJoinFile;
        private System.ComponentModel.BackgroundWorker scanFolderJoinworker;
        private DarkUI.Controls.DarkGroupBox groupBox3;
        private DarkUI.Controls.DarkLabel label5;
        private DarkUI.Controls.DarkNumericUpDown numericUpDown1;
        private System.ComponentModel.BackgroundWorker joinWorker;
        private DarkUI.Controls.DarkCheckBox checkboxDeletefileJoin;
        private DarkUI.Controls.DarkLabel label7;
        private DarkUI.Controls.DarkLabel label6;
        private DarkUI.Controls.DarkContextMenu darkContextMenuSplit;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkRadioButton radioJoinFile;
        private DarkUI.Controls.DarkRadioButton radioScanFolderJoin;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SplitNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private DarkUI.Controls.DarkRadioButton radioScanFolderSplit;
        private DarkUI.Controls.DarkRadioButton radioSplitFile;
        private DarkUI.Controls.DarkListBox darkListBoxJoin;
        private FlatTabControl.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private DarkUI.Controls.DarkContextMenu darkContextMenuJoin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxSplitAll;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxJoinAll;
    }
}