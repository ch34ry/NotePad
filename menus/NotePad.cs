using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace menus
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();

            View_fileboxMI.Checked = true;
            View_basiceditboxMI.Checked = true;

            //
            //ToolStripMenu
            //
            //File
            NewTSB.Click += File_newMI_Click;
            OpenTSB.Click += File_openMI_Click;
            SaveTSB.Click += File_saveMI_Click;
            SaveasTSB.Click += File_saveasMI_Click;

            //Edit
            UndoTSB.Click += Edit_undoMI_Click;
            RedoTSB.Click += Edit_redoMI_Click;
            FontTSB.Click += Edit_fontMI_Click;
            ColorTSB.Click += Edit_colorMI_Click;
            BackcolorTSB.Click += Edit_backcolorMI_Click;


            //Tools
            ToolsCB.Items.AddRange(new String[]
            {
                "English",
                "ქართული"
            });
            //default language
            ToolsCB.SelectedItem = "English";
        }
        #region File_Menustrip
        //
        //Open new file
        //
        private void File_newMI_Click(object sender, EventArgs e)
        {
            NotePad form1 = new NotePad();
            form1.ShowDialog();
        }
        //
        //Open file
        //
        private void File_openMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.ShowDialog();
            richTextBox1.LoadFile(Openfile.FileName);
        }
        //
        //Save 
        //
        private void File_saveMI_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = "txt",
                FileName = "Untitled.rtf",
            };
            richTextBox1.SaveFile(saveFileDialog.FileName);
        }
        //
        //Save as
        //
        private void File_saveasMI_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = "txt",
                FileName = "Untitled",
                Filter = "RTF Files(*.rtf)|*.rtf"
            };
            saveFileDialog.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog.FileName);
        }
        #endregion

        #region Edit_MenuStrip
        //
        //Undo 
        //
        private void Edit_undoMI_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }
        //
        //Redo
        //
        private void Edit_redoMI_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanRedo)
                richTextBox1.Redo();
        }
        //
        //Font changer
        //
        private void Edit_fontMI_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                if(richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionFont = fontDialog.Font; 
                }
                else
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
        }
        //
        //Color changer
        //
        private void Edit_colorMI_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            if(colordialog.ShowDialog() == DialogResult.OK)
            {
                if(richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionColor = colordialog.Color;
                }
                else
                {
                    richTextBox1.ForeColor = colordialog.Color;
                }
            }
        }
        //
        //richtextbox background color changer
        //
        private void Edit_backcolorMI_Click(object sender, EventArgs e)
        {
            ColorDialog backcolorDialog = new ColorDialog();
            backcolorDialog.ShowDialog();
            richTextBox1.BackColor = backcolorDialog.Color;
        }
        #endregion

        #region View_MenuStrip
        //
        //menu Visible/Invisible(default Visible)
        //
        private void View_fileboxMI_Click(object sender, EventArgs e)
        {
            FileboxTS.Visible = View_fileboxMI.Checked;
        }

        private void View_basiceditboxMI_Click(object sender, EventArgs e)
        {
            EditboxTS.Visible = View_basiceditboxMI.Checked;
        }
        #endregion

        private void File_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Word and Line counter
        //
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int lines = richTextBox1.Lines.Count();
            int words = richTextBox1.Text.Count() + 1; 

            Wordlbl.Text = $"Words: {words.ToString()}";
            Linelbl.Text = $"Lines: {lines.ToString()}";
        }

        #region Language(English-ქართული)
        private void ToolsCB_TextChanged(object sender, EventArgs e)
        {
            if(ToolsCB.SelectedItem.ToString() == "ქართული")
            {
                //
                //File
                //
                FileMS.Text = "ფაილი";
                File_newMI.Text = "ახალი";
                File_openMI.Text = "გახსნა";
                File_saveMI.Text = "დამახსოვრება";
                File_saveasMI.Text = "დაამახსოვრე როგორც";
                File_printMI.Text = "დაბეჭვდვა";
                File_pagesetupMI.Text = "გვერდის წყობა";
                File_exit.Text = "გასვლა";
                //
                //Home
                //
                HomeMS.Text = "სახლი";
                //
                //Edit
                //
                EditMS.Text = "რედაქტირება";
                Edit_undoMI.Text = "უკან";
                Edit_redoMI.Text = "წინ";
                Edit_fontMI.Text = "ფონტი";
                Edit_colorMI.Text = "ფერი";
                Edit_backcolorMI.Text = "ფონი";
                //
                //View
                //
                ViewMS.Text = "გამოსახულება";
                View_fileboxMI.Text = "ფაილის ყუთი";
                View_basiceditboxMI.Text = "რედაქტირების ყუთი";
                //
                //Tools
                //
                LangMS.Text = "ენა";
                //
                //Help
                //
                HelpMS.Text = "დახმარება";
            }
            else if(ToolsCB.SelectedItem.ToString() == "English")
            {
                //
                //File
                //
                FileMS.Text = "File";
                File_newMI.Text = "New";
                File_openMI.Text = "Open";
                File_saveMI.Text = "Save";
                File_saveasMI.Text = "Save as";
                File_printMI.Text = "Print";
                File_pagesetupMI.Text = "Page Setup";
                File_exit.Text = "Exit";
                //
                //Home
                //
                HomeMS.Text = "Home";
                //
                //Edit
                //
                EditMS.Text = "Edit";
                Edit_undoMI.Text = "Undo";
                Edit_redoMI.Text = "Redo";
                Edit_fontMI.Text = "Font";
                Edit_colorMI.Text = "Color";
                Edit_backcolorMI.Text = "Background Color";
                //
                //View
                //
                ViewMS.Text = "View";
                View_fileboxMI.Text = "File Box";
                View_basiceditboxMI.Text = "Basic edit box";
                //
                //Tools
                //
                LangMS.Text = "Language";
                //
                //Help
                //
                HelpMS.Text = "Help";
            }
        }
        #endregion

        private void HelpMS_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
