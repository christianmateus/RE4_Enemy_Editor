using System.Globalization;

namespace ESL_Tool
{
    public partial class mainWindow : Form
    {
        Structure.ESL_struct ESL = new Structure.ESL_struct();
        EnemyData enemyData = new EnemyData();
        OpenFileDialog dialog = new OpenFileDialog();
        string filepath = string.Empty;

        public mainWindow()
        {
            InitializeComponent();
            filterByRoom.SelectedIndex = 0;
            filterByEnemyType.SelectedIndex = 0;
            filterByHealthMax.Value = Int16.MaxValue;
        }
        public void CreateTable()
        {
            table.Columns.Clear();

            // Table config
            DataGridViewCheckBoxColumn check = new();
            check.Name = "Active";
            check.HeaderText = "Active";
            check.Width = 46;
            table.Columns.Insert(0, check);

            DataGridViewComboBoxColumn enemyType = new DataGridViewComboBoxColumn();
            enemyType.Name = "enemyType";
            enemyType.HeaderText = "Enemy Type";
            enemyType.DataSource = enemyData.emleon.Keys.ToList<string>();
            table.Columns.Insert(1, enemyType);

            DataGridViewComboBoxColumn enemySubtype = new DataGridViewComboBoxColumn();
            enemySubtype.Name = "enemySubtype";
            enemySubtype.HeaderText = "Subtype";
            table.Columns.Insert(2, enemySubtype);

            table.Columns.Add("animation", "Animation"); // 3
            table.Columns.Add("sight", "Sight"); // 4
            table.Columns.Add("equip1", "Equip 1"); // 5
            table.Columns.Add("equip2", "Equip 2"); // 6
            table.Columns.Add("weapon", "Weapon"); // 7
            table.Columns.Add("health", "Health"); // 8
            table.Columns.Add("unk1", "unk1"); // 9
            table.Columns.Add("returnToSpawn", "Return"); // 10
            table.Columns.Add("posX", "Pos X"); // 11
            table.Columns.Add("posY", "Pos Y"); // 12
            table.Columns.Add("posZ", "Pos Z"); // 13
            table.Columns.Add("rotX", "Rot X"); // 14
            table.Columns.Add("rotY", "Rot Y"); // 15
            table.Columns.Add("rotZ", "Rot Z"); // 16
            table.Columns.Add("roomID", "Room ID"); // 17
            table.Columns.Add("stageID", "Stage ID"); // 18
            table.Columns.Add("unk2", "unk2"); // 19
            table.Columns.Add("unk3", "unk3"); // 20
            table.Columns.Add("unk4", "unk4"); // 21 
            table.Columns.Add("unk5", "unk5"); // 22
            table.Columns.Add("unk6", "unk6"); // 23
            table.Columns.Add("unk7", "unk7"); // 24
        }
        private void LoadEnemies()
        {
            // Opening ESL file in memory
            BinaryReader br = new BinaryReader(File.Open(filepath, FileMode.Open));

            // Reading entries
            int totalEntries = (int)(br.BaseStream.Length / 0x20);

            // Table config
            CreateTable();

            // Hiding unused parameters
            table.Columns[9].Visible = false;
            table.Columns[19].Visible = false;
            table.Columns[20].Visible = false;
            table.Columns[21].Visible = false;
            table.Columns[22].Visible = false;
            table.Columns[23].Visible = false;
            table.Columns[24].Visible = false;

            // Reading enemy bytes for all entries
            for (int entry = 0; entry < totalEntries; entry++)
            {
                ESL.Active = br.ReadByte();
                ESL.EnemyType = br.ReadByte();
                ESL.Subtype = br.ReadByte();
                ESL.Animation = br.ReadByte();
                ESL.SightRange = br.ReadByte();
                ESL.Equip1 = br.ReadByte();
                ESL.Equip2 = br.ReadByte();
                ESL.Weapon = br.ReadByte();
                ESL.Health = br.ReadInt16();
                ESL.unk1 = br.ReadByte();
                ESL.ReturnSpawn = br.ReadByte();
                ESL.PosX = br.ReadInt16();
                ESL.PosY = br.ReadInt16();
                ESL.PosZ = br.ReadInt16();
                ESL.RotX = br.ReadInt16();
                ESL.RotY = br.ReadInt16();
                ESL.RotZ = br.ReadInt16();
                ESL.RoomID = br.ReadByte();
                ESL.StageID = br.ReadByte();
                ESL.unk2 = br.ReadByte();
                ESL.unk3 = br.ReadByte();
                ESL.unk4 = br.ReadByte();
                ESL.unk5 = br.ReadByte();
                ESL.unk6 = br.ReadByte();
                ESL.unk7 = br.ReadByte();

                // Checks if enemy is active
                bool GetActive()
                {
                    if (ESL.Active == 1) return true;
                    else return false;
                }

                // Get enemy type
                string GetEnemyType()
                {
                    return enemyData.emleon.Keys.ToList<string>()[ESL.EnemyType];
                }

                // Create combobox of enemy subtype
                DataGridViewComboBoxCell cmbbox = new DataGridViewComboBoxCell();
                cmbbox.Items.AddRange(enemyData.emleon.Values.ToArray()[ESL.EnemyType]);

                // Get enemy subtype
                string GetEnemySubtype()
                {
                    int subtypeIndex = 0;
                    for (int i = 0; i < enemyData.emleon.Values.ToArray()[ESL.EnemyType].Length; i++)
                    {
                        byte subtype = Byte.Parse(enemyData.emleon.Values.ToArray()[ESL.EnemyType][i].Substring(2, 2), NumberStyles.HexNumber);
                        if (subtype == ESL.Subtype)
                        {
                            subtypeIndex = i;
                        }
                    }
                    return enemyData.emleon.Values.ToArray()[ESL.EnemyType][subtypeIndex];
                }

                // Adding rows
                var index = table.Rows.Add();
                table.Rows[index].Cells[0].Value = GetActive();
                table.Rows[index].Cells[1].Value = GetEnemyType();
                table.Rows[index].Cells[2] = cmbbox;
                table.Rows[index].Cells[2].Value = GetEnemySubtype();
                table.Rows[index].Cells[3].Value = ESL.Animation.ToString("X");
                table.Rows[index].Cells[4].Value = ESL.SightRange.ToString("X");
                table.Rows[index].Cells[5].Value = ESL.Equip1.ToString("X");
                table.Rows[index].Cells[6].Value = ESL.Equip2.ToString("X");
                table.Rows[index].Cells[7].Value = ESL.Weapon.ToString("X");
                table.Rows[index].Cells[8].Value = ESL.Health;
                table.Rows[index].Cells[9].Value = ESL.unk1.ToString("X");
                table.Rows[index].Cells[10].Value = ESL.ReturnSpawn.ToString("X");
                table.Rows[index].Cells[11].Value = ESL.PosX * 10;
                table.Rows[index].Cells[12].Value = ESL.PosY * 10;
                table.Rows[index].Cells[13].Value = ESL.PosZ * 10;
                table.Rows[index].Cells[14].Value = ESL.RotX * 10;
                table.Rows[index].Cells[15].Value = ESL.RotY * 10;
                table.Rows[index].Cells[16].Value = ESL.RotZ * 10;
                table.Rows[index].Cells[17].Value = ESL.RoomID.ToString("X");
                table.Rows[index].Cells[18].Value = ESL.StageID.ToString("X");
                table.Rows[index].Cells[19].Value = ESL.unk2.ToString("X");
                table.Rows[index].Cells[20].Value = ESL.unk3.ToString("X");
                table.Rows[index].Cells[21].Value = ESL.unk4.ToString("X");
                table.Rows[index].Cells[22].Value = ESL.unk5.ToString("X");
                table.Rows[index].Cells[23].Value = ESL.unk6.ToString("X");
                table.Rows[index].Cells[24].Value = ESL.unk7.ToString("X");
            }
            br.Close();
            FormatTable();
        }
        private void SaveEnemies(string filename)
        {
            if (filename != "")
            {
                BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create));
                try
                {
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        // Active
                        if (Convert.ToBoolean(table.Rows[row].Cells[0].Value.ToString()) == true)
                        { bw.Write((byte)0x01); }
                        else { bw.Write((byte)0x00); }

                        // Rest of the data
                        bw.Write(byte.Parse(table.Rows[row].Cells[1].Value.ToString().Substring(2, 2), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[2].Value.ToString().Substring(2, 2), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[3].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[4].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[5].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[6].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[7].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(short.Parse(table.Rows[row].Cells[8].Value.ToString()));
                        bw.Write(byte.Parse(table.Rows[row].Cells[9].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[10].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[11].Value.ToString()) / 10));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[12].Value.ToString()) / 10));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[13].Value.ToString()) / 10));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[14].Value.ToString()) / 10));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[15].Value.ToString()) / 10));
                        bw.Write((short)(int.Parse(table.Rows[row].Cells[16].Value.ToString()) / 10));
                        bw.Write(byte.Parse(table.Rows[row].Cells[17].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[18].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[19].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[20].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[21].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[22].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[23].Value.ToString(), NumberStyles.HexNumber));
                        bw.Write(byte.Parse(table.Rows[row].Cells[24].Value.ToString(), NumberStyles.HexNumber));
                    }
                    bw.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bw.Close();
                }
            }
        }
        private void FormatTable()
        {
            for (int i = 3; i < table.ColumnCount; i++)
            {
                table.Columns[i].Width = 60;
            }
            table.Columns[3].Width = 65; // Animation
            table.Columns[1].Width = 120; // Enemy type
            table.Columns[2].Width = 130; // Subtype
        }
        private void FilterSearch()
        {
            try
            {
                // Returns if no filter selected
                if (filterByRoom.Text == "All Rooms" && filterByEnemyType.Text == "All Enemies"
                    && filterByHealthMax.Value == Int16.MaxValue && filterByHealthMin.Value == 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        table.Rows[i].Visible = true;
                    }
                    return;
                }

                // Get filter fields
                byte filterRoomID = 0x00;
                byte filterStageID = 0x00;
                string filterEnemyType = filterByEnemyType.Text;

                // Sets value if true
                if (filterByRoom.Text != "All Rooms")
                {
                    filterRoomID = byte.Parse(filterByRoom.Text.Substring(2, 2), NumberStyles.HexNumber);
                    filterStageID = byte.Parse(filterByRoom.Text.Substring(1, 1), NumberStyles.HexNumber);
                }

                // Verification 1
                if (filterByRoom.Text != "All Rooms" && filterByEnemyType.Text != "All Enemies")
                {
                    // Iterates through each row
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        byte roomID = byte.Parse(table.Rows[i].Cells[17].Value.ToString(), NumberStyles.HexNumber);
                        byte stageID = byte.Parse(table.Rows[i].Cells[18].Value.ToString(), NumberStyles.HexNumber);
                        string enemyType = table.Rows[i].Cells[1].Value.ToString();
                        int hp = int.Parse(table.Rows[i].Cells[8].Value.ToString());

                        if ((roomID == filterRoomID && filterStageID == stageID) && (filterEnemyType == enemyType)
                            && (hp >= filterByHealthMin.Value && hp <= filterByHealthMax.Value))
                        {
                            table.Rows[i].Visible = true;
                        }
                        else
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                }

                // Verification 2
                if (filterByRoom.Text != "All Rooms" && filterByEnemyType.Text == "All Enemies")
                {
                    // Iterates through each row
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        byte roomID = byte.Parse(table.Rows[i].Cells[17].Value.ToString(), NumberStyles.HexNumber);
                        byte stageID = byte.Parse(table.Rows[i].Cells[18].Value.ToString(), NumberStyles.HexNumber);
                        int hp = int.Parse(table.Rows[i].Cells[8].Value.ToString());

                        if ((roomID == filterRoomID && filterStageID == stageID)
                            && (hp >= filterByHealthMin.Value && hp <= filterByHealthMax.Value))
                        {
                            table.Rows[i].Visible = true;
                        }
                        else
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                }

                // Verification 3
                if (filterByEnemyType.Text != "All Enemies" && filterByRoom.Text == "All Rooms")
                {
                    // Iterates through each row
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string enemyType = table.Rows[i].Cells[1].Value.ToString();
                        int hp = int.Parse(table.Rows[i].Cells[8].Value.ToString());

                        if ((filterEnemyType == enemyType) && (hp >= filterByHealthMin.Value && hp <= filterByHealthMax.Value))
                        {
                            table.Rows[i].Visible = true;
                        }
                        else
                        {
                            table.Rows[i].Visible = false;
                        }
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error filtering results", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openESLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Filter = "RE4 ESL Files (*.ESL)|*.ESL";
            dialog.ShowDialog();
            filepath = dialog.FileName;
            if (filepath != "")
            {
                this.Text = "RE4 Enemy Editor | " + Path.GetFileName(filepath);
                LoadEnemies();

            }
        }
        private void saveESLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveEnemies(filepath);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "Enemy Spawn List (*.ESL)|*.ESL|All files (*.*)|*.*";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != null && saveFileDialog.FileName != "")
            {
                SaveEnemies(saveFileDialog.FileName);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void check_showHidden_Click(object sender, EventArgs e)
        {
            // Show hidden parameters toggle
            if (check_showHidden.Checked)
            {
                for (int column = 0; column < table.ColumnCount; column++)
                {
                    table.Columns[column].Visible = true;
                }
            }
            else
            {
                table.Columns[9].Visible = false;
                table.Columns[19].Visible = false;
                table.Columns[20].Visible = false;
                table.Columns[21].Visible = false;
                table.Columns[22].Visible = false;
                table.Columns[23].Visible = false;
                table.Columns[24].Visible = false;
            }
        }
        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int newEnemyType = byte.Parse(table.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(2, 2), NumberStyles.HexNumber);

                // Create combobox of enemy subtype
                DataGridViewComboBoxCell cmbbox = new DataGridViewComboBoxCell();
                cmbbox.Items.AddRange(enemyData.emleon.Values.ToArray()[newEnemyType]);

                table.Rows[e.RowIndex].Cells[2] = cmbbox;
                table.Rows[e.RowIndex].Cells[2].Value = enemyData.emleon.Values.ToArray()[newEnemyType][0];
            }
        }
        private void setAllToMaxHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i].Cells[8].Value = Int16.MaxValue;
            }
        }
        private void setAllToMinHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i].Cells[8].Value = 10;
            }
        }
        private void setAllToCustomHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int hpValue = 0;
                hpValue = short.Parse(customHpTextbox.Text);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    table.Rows[i].Cells[8].Value = hpValue;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void customHpTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    int hpValue = 0;
                    hpValue = short.Parse(customHpTextbox.Text);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        table.Rows[i].Cells[8].Value = hpValue;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterSearch();
        }
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusSelectedRow.Text = $"Selected enemy: {e.RowIndex}";
        }
    }
}