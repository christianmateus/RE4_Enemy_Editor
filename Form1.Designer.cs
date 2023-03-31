namespace ESL_Tool
{
    partial class mainWindow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            menuBar = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openESLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveESLToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            exportEnemiesAsOBJToolStripMenuItem = new ToolStripMenuItem();
            importEnemiesFromOBJToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            setAllMaxHPToolStripMenuItem = new ToolStripMenuItem();
            setAllToMaxHPToolStripMenuItem = new ToolStripMenuItem();
            setAllToMinHPToolStripMenuItem = new ToolStripMenuItem();
            setAllToCustomHPToolStripMenuItem = new ToolStripMenuItem();
            customHpTextbox = new ToolStripTextBox();
            optionToolStripMenuItem = new ToolStripMenuItem();
            check_showHidden = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            enemyListToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnFilter = new Button();
            filterByHealthMax = new NumericUpDown();
            filterByHealthMin = new NumericUpDown();
            label3 = new Label();
            filterByEnemyType = new ComboBox();
            label2 = new Label();
            filterByRoom = new ComboBox();
            label1 = new Label();
            table = new DataGridView();
            statusStrip1 = new StatusStrip();
            statusSelectedRow = new ToolStripStatusLabel();
            menuBar.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterByHealthMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filterByHealthMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.BackColor = SystemColors.ButtonHighlight;
            menuBar.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, optionToolStripMenuItem, helpToolStripMenuItem });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(944, 24);
            menuBar.TabIndex = 1;
            menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openESLToolStripMenuItem, toolStripSeparator1, saveESLToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShowShortcutKeys = false;
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openESLToolStripMenuItem
            // 
            openESLToolStripMenuItem.Name = "openESLToolStripMenuItem";
            openESLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openESLToolStripMenuItem.Size = new Size(195, 22);
            openESLToolStripMenuItem.Text = "Open ESL";
            openESLToolStripMenuItem.Click += openESLToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // saveESLToolStripMenuItem
            // 
            saveESLToolStripMenuItem.Name = "saveESLToolStripMenuItem";
            saveESLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveESLToolStripMenuItem.Size = new Size(195, 22);
            saveESLToolStripMenuItem.Text = "Save ESL";
            saveESLToolStripMenuItem.Click += saveESLToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportEnemiesAsOBJToolStripMenuItem, importEnemiesFromOBJToolStripMenuItem, toolStripSeparator3, setAllMaxHPToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // exportEnemiesAsOBJToolStripMenuItem
            // 
            exportEnemiesAsOBJToolStripMenuItem.Name = "exportEnemiesAsOBJToolStripMenuItem";
            exportEnemiesAsOBJToolStripMenuItem.Size = new Size(209, 22);
            exportEnemiesAsOBJToolStripMenuItem.Text = "Export enemies as OBJ";
            // 
            // importEnemiesFromOBJToolStripMenuItem
            // 
            importEnemiesFromOBJToolStripMenuItem.Name = "importEnemiesFromOBJToolStripMenuItem";
            importEnemiesFromOBJToolStripMenuItem.Size = new Size(209, 22);
            importEnemiesFromOBJToolStripMenuItem.Text = "Import enemies from OBJ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(206, 6);
            // 
            // setAllMaxHPToolStripMenuItem
            // 
            setAllMaxHPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setAllToMaxHPToolStripMenuItem, setAllToMinHPToolStripMenuItem, setAllToCustomHPToolStripMenuItem, customHpTextbox });
            setAllMaxHPToolStripMenuItem.Name = "setAllMaxHPToolStripMenuItem";
            setAllMaxHPToolStripMenuItem.Size = new Size(209, 22);
            setAllMaxHPToolStripMenuItem.Text = "HP Presets";
            // 
            // setAllToMaxHPToolStripMenuItem
            // 
            setAllToMaxHPToolStripMenuItem.Name = "setAllToMaxHPToolStripMenuItem";
            setAllToMaxHPToolStripMenuItem.Size = new Size(184, 22);
            setAllToMaxHPToolStripMenuItem.Text = "Set all to max HP";
            setAllToMaxHPToolStripMenuItem.Click += setAllToMaxHPToolStripMenuItem_Click;
            // 
            // setAllToMinHPToolStripMenuItem
            // 
            setAllToMinHPToolStripMenuItem.Name = "setAllToMinHPToolStripMenuItem";
            setAllToMinHPToolStripMenuItem.Size = new Size(184, 22);
            setAllToMinHPToolStripMenuItem.Text = "Set all to min HP";
            setAllToMinHPToolStripMenuItem.Click += setAllToMinHPToolStripMenuItem_Click;
            // 
            // setAllToCustomHPToolStripMenuItem
            // 
            setAllToCustomHPToolStripMenuItem.Name = "setAllToCustomHPToolStripMenuItem";
            setAllToCustomHPToolStripMenuItem.Size = new Size(184, 22);
            setAllToCustomHPToolStripMenuItem.Text = "Set all to custom HP:";
            setAllToCustomHPToolStripMenuItem.Click += setAllToCustomHPToolStripMenuItem_Click;
            // 
            // customHpTextbox
            // 
            customHpTextbox.Name = "customHpTextbox";
            customHpTextbox.Size = new Size(100, 23);
            customHpTextbox.Text = "0";
            customHpTextbox.KeyUp += customHpTextbox_KeyUp;
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { check_showHidden });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // check_showHidden
            // 
            check_showHidden.CheckOnClick = true;
            check_showHidden.Name = "check_showHidden";
            check_showHidden.Size = new Size(205, 22);
            check_showHidden.Text = "Show hidden parameters";
            check_showHidden.Click += check_showHidden_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enemyListToolStripMenuItem });
            helpToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // enemyListToolStripMenuItem
            // 
            enemyListToolStripMenuItem.Name = "enemyListToolStripMenuItem";
            enemyListToolStripMenuItem.Size = new Size(180, 22);
            enemyListToolStripMenuItem.Text = "Enemy list";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "esl";
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(filterByHealthMax);
            groupBox1.Controls.Add(filterByHealthMin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(filterByEnemyType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(filterByRoom);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(108, 78);
            label4.Name = "label4";
            label4.Size = new Size(78, 13);
            label4.TabIndex = 8;
            label4.Text = "(Ctrl+Shift+F)";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(210, 220, 210);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Location = new Point(6, 73);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(99, 23);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // filterByHealthMax
            // 
            filterByHealthMax.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            filterByHealthMax.Location = new Point(402, 42);
            filterByHealthMax.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            filterByHealthMax.Name = "filterByHealthMax";
            filterByHealthMax.Size = new Size(71, 23);
            filterByHealthMax.TabIndex = 6;
            filterByHealthMax.TextAlign = HorizontalAlignment.Center;
            // 
            // filterByHealthMin
            // 
            filterByHealthMin.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            filterByHealthMin.Location = new Point(303, 42);
            filterByHealthMin.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            filterByHealthMin.Name = "filterByHealthMin";
            filterByHealthMin.Size = new Size(71, 23);
            filterByHealthMin.TabIndex = 5;
            filterByHealthMin.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 23);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Health between";
            // 
            // filterByEnemyType
            // 
            filterByEnemyType.DropDownStyle = ComboBoxStyle.DropDownList;
            filterByEnemyType.FormattingEnabled = true;
            filterByEnemyType.Items.AddRange(new object[] { "All Enemies", "em00: Invalid", "em01: Invalid", "em02: Leon", "em03: Ashley (HUD)", "em04: Luis", "em05: Ashley", "em06: Invalid", "em07: Invalid", "em08: Invalid", "em09: Invalid", "em0A: Invalid", "em0B: Invalid", "em0C: Invalid", "em0D: Invalid", "em0E: Jet-ski", "em0F: Boat", "em10: Ganado", "em11: Zealot", "em12: Ganado", "em13: Ganado", "em14: Zealot", "em15: Ganado", "em16: Ganado", "em17: Ganado", "em18: Merchant", "em19: Zealot", "em1A: Zealot", "em1B: Zealot", "em1C: Zealot", "em1D: Soldier", "em1E: Soldier", "em1F: Soldier", "em20: Soldier", "em21: Dog", "em22: Colmillo", "em23: Crow", "em24: Snake", "em25: Parasite", "em26: Cow", "em27: Black Bass", "em28: Chicken", "em29: Bat", "em2A: Trap", "em2B: El Gigante", "em2C: Verdugo", "em2D: Novistador", "em2E: Spider", "em2F: Del Lago", "em30: Saddler", "em31: Saddler v2", "em32: Unknown", "em33: Invalid", "em34: No. & No.", "em35: Bitores", "em36: Regenerator", "em37: Invalid", "em38: Salazar", "em39: Krauser", "em3A: Robot", "em3B: Truck/Wagon", "em3C: Knight", "em3D: Helicopter", "em3E: r22c Mark", "em3F: Saddler Human", "em40: Unknown", "em41: Unknown", "em42: SW Ganado", "em43: SW Soldier", "em44: SW Ganado", "em4E: SW Ship" });
            filterByEnemyType.Location = new Point(150, 41);
            filterByEnemyType.Name = "filterByEnemyType";
            filterByEnemyType.Size = new Size(121, 23);
            filterByEnemyType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 23);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Enemy type";
            // 
            // filterByRoom
            // 
            filterByRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            filterByRoom.FormattingEnabled = true;
            filterByRoom.Items.AddRange(new object[] { "All Rooms", "r100", "r101", "r102", "r103", "r104", "r105", "r106", "r107", "r108", "r109", "r10a", "r10b", "r10c", "r10d", "r10e", "r10f", "r111", "r112", "r113", "r117", "r118", "r119", "r11a", "r11b", "r11c", "r11d", "r11e", "r11f", "r200", "r201", "r202", "r203", "r204", "r205", "r206", "r207", "r208", "r209", "r20a", "r20b", "r20c", "r20d", "r20e", "r20f", "r210", "r211", "r212", "r213", "r214", "r215", "r216", "r217", "r218", "r219", "r21a", "r21b", "r21d", "r220", "r221", "r222", "r223", "r224", "r225", "r226", "r227", "r228", "r229", "r22a", "r22c", "r300", "r301", "r303", "r304", "r305", "r306", "r307", "r308", "r309", "r30a", "r30b", "r30c", "r30d", "r30e", "r30f", "r310", "r311", "r312", "r315", "r316", "r317", "r318", "r31a", "r31b", "r31c", "r31d", "r320", "r321", "r325", "r326", "r327", "r329", "r330", "r331", "r332", "r333", "r334", "r400", "r402", "r403", "r404", "r500", "r501", "r502", "r503", "r504", "r505", "r506", "r507", "r508", "r509", "r50a", "r50b", "r50c", "r50d", "r50e", "r50f", "r510", "r512", "r513", "r514", "r515", "r516", "r517", "r518", "r519", "r51a", "r51b", "r51c", "r51d", "r51e" });
            filterByRoom.Location = new Point(6, 41);
            filterByRoom.Name = "filterByRoom";
            filterByRoom.Size = new Size(121, 23);
            filterByRoom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Room";
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeRows = false;
            table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            table.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.EditMode = DataGridViewEditMode.EditOnEnter;
            table.Location = new Point(12, 148);
            table.Name = "table";
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            table.RowHeadersWidth = 25;
            table.RowTemplate.Height = 25;
            table.Size = new Size(920, 346);
            table.TabIndex = 3;
            table.CellClick += table_CellClick;
            table.CellValueChanged += table_CellValueChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusSelectedRow });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(944, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusSelectedRow
            // 
            statusSelectedRow.Name = "statusSelectedRow";
            statusSelectedRow.Size = new Size(0, 17);
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 519);
            Controls.Add(statusStrip1);
            Controls.Add(table);
            Controls.Add(groupBox1);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainWindow";
            Text = "RE4 Enemy Editor";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filterByHealthMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)filterByHealthMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openESLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveESLToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem enemyListToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private ComboBox filterByEnemyType;
        private Label label2;
        private ComboBox filterByRoom;
        private Label label1;
        private DataGridView table;
        private ToolStripMenuItem check_showHidden;
        private ToolStripMenuItem exportEnemiesAsOBJToolStripMenuItem;
        private NumericUpDown filterByHealthMax;
        private NumericUpDown filterByHealthMin;
        private Label label3;
        private ToolStripMenuItem importEnemiesFromOBJToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem setAllMaxHPToolStripMenuItem;
        private ToolStripMenuItem setAllToMaxHPToolStripMenuItem;
        private ToolStripMenuItem setAllToMinHPToolStripMenuItem;
        private ToolStripTextBox customHpTextbox;
        private ToolStripMenuItem setAllToCustomHPToolStripMenuItem;
        private Button btnFilter;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusSelectedRow;
    }
}