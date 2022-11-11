namespace menus
{
    partial class NotePad
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.File_newMI = new System.Windows.Forms.ToolStripMenuItem();
            this.File_openMI = new System.Windows.Forms.ToolStripMenuItem();
            this.File_saveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.File_saveasMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.File_printMI = new System.Windows.Forms.ToolStripMenuItem();
            this.File_pagesetupMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.File_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeMS = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMS = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_undoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_redoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_fontMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_colorMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_backcolorMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMS = new System.Windows.Forms.ToolStripMenuItem();
            this.View_fileboxMI = new System.Windows.Forms.ToolStripMenuItem();
            this.View_basiceditboxMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LangMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsCB = new System.Windows.Forms.ToolStripComboBox();
            this.HelpMS = new System.Windows.Forms.ToolStripMenuItem();
            this.FileboxTS = new System.Windows.Forms.ToolStrip();
            this.NewTSB = new System.Windows.Forms.ToolStripButton();
            this.OpenTSB = new System.Windows.Forms.ToolStripButton();
            this.SaveTSB = new System.Windows.Forms.ToolStripButton();
            this.SaveasTSB = new System.Windows.Forms.ToolStripButton();
            this.EditboxTS = new System.Windows.Forms.ToolStrip();
            this.FontTSB = new System.Windows.Forms.ToolStripButton();
            this.ColorTSB = new System.Windows.Forms.ToolStripButton();
            this.BackcolorTSB = new System.Windows.Forms.ToolStripButton();
            this.UndoTSB = new System.Windows.Forms.ToolStripButton();
            this.RedoTSB = new System.Windows.Forms.ToolStripButton();
            this.Wordlbl = new System.Windows.Forms.Label();
            this.Linelbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.FileboxTS.SuspendLayout();
            this.EditboxTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 517);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // FileMS
            // 
            this.FileMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_newMI,
            this.File_openMI,
            this.File_saveMI,
            this.File_saveasMI,
            this.toolStripSeparator1,
            this.File_printMI,
            this.File_pagesetupMI,
            this.toolStripSeparator2,
            this.File_exit});
            this.FileMS.Name = "FileMS";
            this.FileMS.Size = new System.Drawing.Size(37, 20);
            this.FileMS.Text = "File";
            // 
            // File_newMI
            // 
            this.File_newMI.Name = "File_newMI";
            this.File_newMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.File_newMI.Size = new System.Drawing.Size(206, 22);
            this.File_newMI.Text = "New";
            this.File_newMI.Click += new System.EventHandler(this.File_newMI_Click);
            // 
            // File_openMI
            // 
            this.File_openMI.Name = "File_openMI";
            this.File_openMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.File_openMI.Size = new System.Drawing.Size(206, 22);
            this.File_openMI.Text = "Open";
            this.File_openMI.Click += new System.EventHandler(this.File_openMI_Click);
            // 
            // File_saveMI
            // 
            this.File_saveMI.Name = "File_saveMI";
            this.File_saveMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.File_saveMI.Size = new System.Drawing.Size(206, 22);
            this.File_saveMI.Text = "Save";
            this.File_saveMI.Click += new System.EventHandler(this.File_saveMI_Click);
            // 
            // File_saveasMI
            // 
            this.File_saveasMI.Name = "File_saveasMI";
            this.File_saveasMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.File_saveasMI.Size = new System.Drawing.Size(206, 22);
            this.File_saveasMI.Text = "Save As";
            this.File_saveasMI.Click += new System.EventHandler(this.File_saveasMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // File_printMI
            // 
            this.File_printMI.Name = "File_printMI";
            this.File_printMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.File_printMI.Size = new System.Drawing.Size(206, 22);
            this.File_printMI.Text = "Print";
            // 
            // File_pagesetupMI
            // 
            this.File_pagesetupMI.Name = "File_pagesetupMI";
            this.File_pagesetupMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.File_pagesetupMI.Size = new System.Drawing.Size(206, 22);
            this.File_pagesetupMI.Text = "Page Setup";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // File_exit
            // 
            this.File_exit.Name = "File_exit";
            this.File_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.File_exit.Size = new System.Drawing.Size(206, 22);
            this.File_exit.Text = "Exit";
            this.File_exit.Click += new System.EventHandler(this.File_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMS,
            this.HomeMS,
            this.EditMS,
            this.ViewMS,
            this.LangMS,
            this.HelpMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeMS
            // 
            this.HomeMS.Name = "HomeMS";
            this.HomeMS.Size = new System.Drawing.Size(52, 20);
            this.HomeMS.Text = "Home";
            // 
            // EditMS
            // 
            this.EditMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_undoMI,
            this.Edit_redoMI,
            this.Edit_fontMI,
            this.Edit_colorMI,
            this.Edit_backcolorMI});
            this.EditMS.Name = "EditMS";
            this.EditMS.Size = new System.Drawing.Size(39, 20);
            this.EditMS.Text = "Edit";
            // 
            // Edit_undoMI
            // 
            this.Edit_undoMI.Name = "Edit_undoMI";
            this.Edit_undoMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Edit_undoMI.Size = new System.Drawing.Size(170, 22);
            this.Edit_undoMI.Text = "Undo";
            this.Edit_undoMI.Click += new System.EventHandler(this.Edit_undoMI_Click);
            // 
            // Edit_redoMI
            // 
            this.Edit_redoMI.Name = "Edit_redoMI";
            this.Edit_redoMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Edit_redoMI.Size = new System.Drawing.Size(170, 22);
            this.Edit_redoMI.Text = "Redo";
            this.Edit_redoMI.Click += new System.EventHandler(this.Edit_redoMI_Click);
            // 
            // Edit_fontMI
            // 
            this.Edit_fontMI.Name = "Edit_fontMI";
            this.Edit_fontMI.Size = new System.Drawing.Size(170, 22);
            this.Edit_fontMI.Text = "Font";
            this.Edit_fontMI.Click += new System.EventHandler(this.Edit_fontMI_Click);
            // 
            // Edit_colorMI
            // 
            this.Edit_colorMI.Name = "Edit_colorMI";
            this.Edit_colorMI.Size = new System.Drawing.Size(170, 22);
            this.Edit_colorMI.Text = "Color";
            this.Edit_colorMI.Click += new System.EventHandler(this.Edit_colorMI_Click);
            // 
            // Edit_backcolorMI
            // 
            this.Edit_backcolorMI.Name = "Edit_backcolorMI";
            this.Edit_backcolorMI.Size = new System.Drawing.Size(170, 22);
            this.Edit_backcolorMI.Text = "Background Color";
            this.Edit_backcolorMI.Click += new System.EventHandler(this.Edit_backcolorMI_Click);
            // 
            // ViewMS
            // 
            this.ViewMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_fileboxMI,
            this.View_basiceditboxMI});
            this.ViewMS.Name = "ViewMS";
            this.ViewMS.Size = new System.Drawing.Size(44, 20);
            this.ViewMS.Text = "View";
            // 
            // View_fileboxMI
            // 
            this.View_fileboxMI.CheckOnClick = true;
            this.View_fileboxMI.Name = "View_fileboxMI";
            this.View_fileboxMI.Size = new System.Drawing.Size(147, 22);
            this.View_fileboxMI.Text = "File Box";
            this.View_fileboxMI.Click += new System.EventHandler(this.View_fileboxMI_Click);
            // 
            // View_basiceditboxMI
            // 
            this.View_basiceditboxMI.CheckOnClick = true;
            this.View_basiceditboxMI.Name = "View_basiceditboxMI";
            this.View_basiceditboxMI.Size = new System.Drawing.Size(147, 22);
            this.View_basiceditboxMI.Text = "Basic Edit Box";
            this.View_basiceditboxMI.Click += new System.EventHandler(this.View_basiceditboxMI_Click);
            // 
            // LangMS
            // 
            this.LangMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsCB});
            this.LangMS.Name = "LangMS";
            this.LangMS.Size = new System.Drawing.Size(71, 20);
            this.LangMS.Text = "Language";
            // 
            // ToolsCB
            // 
            this.ToolsCB.Name = "ToolsCB";
            this.ToolsCB.Size = new System.Drawing.Size(121, 23);
            this.ToolsCB.TextChanged += new System.EventHandler(this.ToolsCB_TextChanged);
            // 
            // HelpMS
            // 
            this.HelpMS.Name = "HelpMS";
            this.HelpMS.Size = new System.Drawing.Size(44, 20);
            this.HelpMS.Text = "Help";
            this.HelpMS.Click += new System.EventHandler(this.HelpMS_Click);
            // 
            // FileboxTS
            // 
            this.FileboxTS.Dock = System.Windows.Forms.DockStyle.None;
            this.FileboxTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTSB,
            this.OpenTSB,
            this.SaveTSB,
            this.SaveasTSB});
            this.FileboxTS.Location = new System.Drawing.Point(12, 24);
            this.FileboxTS.Name = "FileboxTS";
            this.FileboxTS.Size = new System.Drawing.Size(104, 25);
            this.FileboxTS.TabIndex = 5;
            this.FileboxTS.Text = "toolStrip1";
            // 
            // NewTSB
            // 
            this.NewTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewTSB.Image = global::menus.Properties.Resources.New;
            this.NewTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewTSB.Name = "NewTSB";
            this.NewTSB.Size = new System.Drawing.Size(23, 22);
            this.NewTSB.Text = "New";
            // 
            // OpenTSB
            // 
            this.OpenTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenTSB.Image = global::menus.Properties.Resources.Open;
            this.OpenTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenTSB.Name = "OpenTSB";
            this.OpenTSB.Size = new System.Drawing.Size(23, 22);
            this.OpenTSB.Text = "Open";
            // 
            // SaveTSB
            // 
            this.SaveTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTSB.Image = global::menus.Properties.Resources.Save;
            this.SaveTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTSB.Name = "SaveTSB";
            this.SaveTSB.Size = new System.Drawing.Size(23, 22);
            this.SaveTSB.Text = "Save";
            // 
            // SaveasTSB
            // 
            this.SaveasTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveasTSB.Image = global::menus.Properties.Resources.SaveAs;
            this.SaveasTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveasTSB.Name = "SaveasTSB";
            this.SaveasTSB.Size = new System.Drawing.Size(23, 22);
            this.SaveasTSB.Text = "SaveAs";
            // 
            // EditboxTS
            // 
            this.EditboxTS.BackColor = System.Drawing.Color.White;
            this.EditboxTS.Dock = System.Windows.Forms.DockStyle.None;
            this.EditboxTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontTSB,
            this.ColorTSB,
            this.BackcolorTSB,
            this.UndoTSB,
            this.RedoTSB});
            this.EditboxTS.Location = new System.Drawing.Point(116, 24);
            this.EditboxTS.Name = "EditboxTS";
            this.EditboxTS.Size = new System.Drawing.Size(127, 25);
            this.EditboxTS.TabIndex = 6;
            this.EditboxTS.Text = "toolStrip2";
            // 
            // FontTSB
            // 
            this.FontTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontTSB.Image = global::menus.Properties.Resources.Font;
            this.FontTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontTSB.Name = "FontTSB";
            this.FontTSB.Size = new System.Drawing.Size(23, 22);
            this.FontTSB.Text = "Font";
            // 
            // ColorTSB
            // 
            this.ColorTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorTSB.Image = global::menus.Properties.Resources.ForeColor;
            this.ColorTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorTSB.Name = "ColorTSB";
            this.ColorTSB.Size = new System.Drawing.Size(23, 22);
            this.ColorTSB.Text = "ForeColor";
            // 
            // BackcolorTSB
            // 
            this.BackcolorTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackcolorTSB.Image = global::menus.Properties.Resources.ColorBackground;
            this.BackcolorTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackcolorTSB.Name = "BackcolorTSB";
            this.BackcolorTSB.Size = new System.Drawing.Size(23, 22);
            this.BackcolorTSB.Text = "Background Color";
            // 
            // UndoTSB
            // 
            this.UndoTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoTSB.Image = global::menus.Properties.Resources.Undo;
            this.UndoTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoTSB.Name = "UndoTSB";
            this.UndoTSB.Size = new System.Drawing.Size(23, 22);
            this.UndoTSB.Text = "Undo";
            // 
            // RedoTSB
            // 
            this.RedoTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoTSB.Image = global::menus.Properties.Resources.Redo;
            this.RedoTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoTSB.Name = "RedoTSB";
            this.RedoTSB.Size = new System.Drawing.Size(23, 22);
            this.RedoTSB.Text = "Redo";
            // 
            // Wordlbl
            // 
            this.Wordlbl.AutoSize = true;
            this.Wordlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Wordlbl.Location = new System.Drawing.Point(13, 582);
            this.Wordlbl.Name = "Wordlbl";
            this.Wordlbl.Size = new System.Drawing.Size(50, 13);
            this.Wordlbl.TabIndex = 7;
            this.Wordlbl.Text = "Words: 0";
            // 
            // Linelbl
            // 
            this.Linelbl.AutoSize = true;
            this.Linelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Linelbl.Location = new System.Drawing.Point(88, 582);
            this.Linelbl.Name = "Linelbl";
            this.Linelbl.Size = new System.Drawing.Size(44, 13);
            this.Linelbl.TabIndex = 8;
            this.Linelbl.Text = "Lines: 0";
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.Linelbl);
            this.Controls.Add(this.Wordlbl);
            this.Controls.Add(this.EditboxTS);
            this.Controls.Add(this.FileboxTS);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NotePad";
            this.Text = "NotePad (ch34ry)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FileboxTS.ResumeLayout(false);
            this.FileboxTS.PerformLayout();
            this.EditboxTS.ResumeLayout(false);
            this.EditboxTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem FileMS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeMS;
        private System.Windows.Forms.ToolStripMenuItem EditMS;
        private System.Windows.Forms.ToolStripMenuItem ViewMS;
        private System.Windows.Forms.ToolStripMenuItem LangMS;
        private System.Windows.Forms.ToolStripMenuItem HelpMS;
        private System.Windows.Forms.ToolStrip FileboxTS;
        private System.Windows.Forms.ToolStripButton NewTSB;
        private System.Windows.Forms.ToolStripButton OpenTSB;
        private System.Windows.Forms.ToolStripButton SaveTSB;
        private System.Windows.Forms.ToolStripButton SaveasTSB;
        private System.Windows.Forms.ToolStrip EditboxTS;
        private System.Windows.Forms.ToolStripButton FontTSB;
        private System.Windows.Forms.ToolStripButton ColorTSB;
        private System.Windows.Forms.ToolStripButton BackcolorTSB;
        private System.Windows.Forms.ToolStripButton UndoTSB;
        private System.Windows.Forms.ToolStripMenuItem File_newMI;
        private System.Windows.Forms.ToolStripMenuItem File_openMI;
        private System.Windows.Forms.ToolStripMenuItem File_saveMI;
        private System.Windows.Forms.ToolStripMenuItem File_saveasMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem File_printMI;
        private System.Windows.Forms.ToolStripMenuItem File_pagesetupMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem File_exit;
        private System.Windows.Forms.ToolStripMenuItem Edit_undoMI;
        private System.Windows.Forms.ToolStripMenuItem Edit_redoMI;
        private System.Windows.Forms.ToolStripMenuItem Edit_fontMI;
        private System.Windows.Forms.ToolStripMenuItem Edit_colorMI;
        private System.Windows.Forms.ToolStripMenuItem Edit_backcolorMI;
        private System.Windows.Forms.ToolStripMenuItem View_fileboxMI;
        private System.Windows.Forms.ToolStripMenuItem View_basiceditboxMI;
        private System.Windows.Forms.ToolStripComboBox ToolsCB;
        private System.Windows.Forms.ToolStripButton RedoTSB;
        private System.Windows.Forms.Label Wordlbl;
        private System.Windows.Forms.Label Linelbl;
    }
}

