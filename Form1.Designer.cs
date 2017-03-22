namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Conver = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.lblPassLength = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Conver.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiInsert,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiInsert
            // 
            this.tsmiInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.tsmiInsert.Name = "tsmiInsert";
            this.tsmiInsert.Size = new System.Drawing.Size(65, 20);
            this.tsmiInsert.Text = "Notepad";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(206, 22);
            this.tsmiInsertDate.Text = "Insert Date";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(206, 22);
            this.tsmiInsertTime.Text = "Insert Time";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(206, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(206, 22);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // Conver
            // 
            this.Conver.Controls.Add(this.tabPage3);
            this.Conver.Controls.Add(this.tabPage5);
            this.Conver.Controls.Add(this.tabPage4);
            this.Conver.Controls.Add(this.tabPage2);
            this.Conver.Controls.Add(this.tabPage1);
            this.Conver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Conver.Location = new System.Drawing.Point(0, 24);
            this.Conver.Name = "Conver";
            this.Conver.SelectedIndex = 0;
            this.Conver.Size = new System.Drawing.Size(400, 230);
            this.Conver.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbMetric);
            this.tabPage3.Controls.Add(this.btnSwap);
            this.tabPage3.Controls.Add(this.tbTo);
            this.tabPage3.Controls.Add(this.tbFrom);
            this.tabPage3.Controls.Add(this.cbTo);
            this.tabPage3.Controls.Add(this.cbFrom);
            this.tabPage3.Controls.Add(this.btnConvert);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(392, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Converter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "Distance",
            "Weight"});
            this.cbMetric.Location = new System.Drawing.Point(123, 23);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(82, 21);
            this.cbMetric.TabIndex = 6;
            this.cbMetric.Text = "Distance";
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.cbMetric_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSwap.Location = new System.Drawing.Point(123, 72);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<--->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(213, 113);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(8, 112);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(213, 72);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(100, 21);
            this.cbTo.TabIndex = 2;
            this.cbTo.Text = "mm";
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(8, 72);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(100, 21);
            this.cbFrom.TabIndex = 1;
            this.cbFrom.Text = "m";
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(123, 109);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Change";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbPassword);
            this.tabPage5.Controls.Add(this.btnCreatePass);
            this.tabPage5.Controls.Add(this.lblPassLength);
            this.tabPage5.Controls.Add(this.nudPassLength);
            this.tabPage5.Controls.Add(this.clbPassword);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(392, 204);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Passwords";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(23, 141);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(183, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Location = new System.Drawing.Point(254, 138);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(104, 23);
            this.btnCreatePass.TabIndex = 3;
            this.btnCreatePass.Text = "Create password";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click);
            // 
            // lblPassLength
            // 
            this.lblPassLength.AutoSize = true;
            this.lblPassLength.Location = new System.Drawing.Point(163, 42);
            this.lblPassLength.Name = "lblPassLength";
            this.lblPassLength.Size = new System.Drawing.Size(85, 13);
            this.lblPassLength.TabIndex = 2;
            this.lblPassLength.Text = "Password length";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(254, 40);
            this.nudPassLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(44, 20);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Digits",
            "Upper case",
            "Lower case",
            "Special symbols"});
            this.clbPassword.Location = new System.Drawing.Point(23, 18);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(120, 64);
            this.clbPassword.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbNotepad);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(392, 204);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Notepad";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(386, 198);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            this.rtbNotepad.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRandom);
            this.tabPage2.Controls.Add(this.btnRandomCopy);
            this.tabPage2.Controls.Add(this.btnRandomClear);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.lblTo);
            this.tabPage2.Controls.Add(this.lblFrom);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lblRandom);
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(44, 87);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(63, 17);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "No reps";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Location = new System.Drawing.Point(39, 123);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(81, 23);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Copy to buffer";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Location = new System.Drawing.Point(172, 123);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(75, 23);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Clear";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(264, 38);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(111, 124);
            this.tbRandom.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(23, 50);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            this.lblTo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(23, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(67, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandom.Location = new System.Drawing.Point(198, 87);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(14, 13);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "0";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(172, 38);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Generate";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.btnreset);
            this.tabPage1.Controls.Add(this.btnminus);
            this.tabPage1.Controls.Add(this.btnplus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(153, 82);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(19, 20);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnreset.Location = new System.Drawing.Point(131, 143);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(70, 34);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnminus.Location = new System.Drawing.Point(219, 28);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(70, 34);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnplus.Location = new System.Drawing.Point(34, 28);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(70, 34);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.Conver);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My utilities";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Conver.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl Conver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnRandomClear;
        private System.Windows.Forms.Button btnRandomCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.Label lblPassLength;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetric;
    }
}

