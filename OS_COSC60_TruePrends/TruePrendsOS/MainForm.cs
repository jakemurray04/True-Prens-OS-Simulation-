using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TruePrendsOS
{
    public partial class MainForm : Form
    {
        string fileloc;
        public MainForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to shut down your computer?", "Shut Down", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else if (result == DialogResult.Cancel)
            {

            }
            
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restart your computer?", "Restart", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("shutdown", "/r /t 0");
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            gamePanel.Visible = false;
            powerPoint.SizeMode = PictureBoxSizeMode.StretchImage;
            word.SizeMode = PictureBoxSizeMode.StretchImage;
            excel.SizeMode = PictureBoxSizeMode.StretchImage;
            chrome.SizeMode = PictureBoxSizeMode.StretchImage;
            paint.SizeMode = PictureBoxSizeMode.StretchImage;
            calculator.SizeMode = PictureBoxSizeMode.StretchImage;
            sublime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            chessPic.SizeMode = PictureBoxSizeMode.StretchImage;
            mahjongPic.SizeMode = PictureBoxSizeMode.StretchImage;
            textFolder.Visible = false;
            labelFolder.Visible = false;
            createFolder.Visible = false;
            newFolderLabel.Visible = false;
            pictureFolder.Visible = false;
            cancelButton.Visible = false;
            fileloc = @"Desktop/test";
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login fr = new Login();
            fr.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == true)
            {
                menuPanel.Visible = false;
            }
            else
            {
                menuPanel.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (gamePanel.Visible == true)
            {
                gamePanel.Visible = false;
            }
            else
            {
                gamePanel.Visible = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            SystemInfo nf = new SystemInfo();
            nf.Show();
        }

        private void chessPic_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Games\Chess\Chess.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }     
        }

        private void mahjongPic_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Games\Mahjong\Mahjong.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }
        }

        private void powerPoint_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office PowerPoint 2007");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }       
        }

        private void word_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office Word 2007");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office Excel 2007");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }          
        }

        private void chrome_Click(object sender, EventArgs e)
        {
            Process.Start(@"chrome");
        }

        private void paint_Click(object sender, EventArgs e)
        {
            Process.Start(@"mspaint.exe");
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            Process.Start(@"calc.exe");
        }

        private void sublime_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"sublime.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Program not found.");
            }   
        }

        private void addFolderLabel_Click(object sender, EventArgs e)
        {
            textFolder.Visible = true;
            labelFolder.Visible = true;
            createFolder.Visible = true;
            cancelButton.Visible = true;
        }

        private void createFolder_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(fileloc + "\\" + textFolder.Text))
            {
                newFolderLabel.Text = textFolder.Text;
                Directory.CreateDirectory(fileloc + "\\" + textFolder.Text);
                MessageBox.Show("Folder Created");
                newFolderLabel.Visible = true;
                pictureFolder.Visible = true;
            }                                    
            else
            {
                MessageBox.Show("Folder Exist Already", "Error creating File");
            }
            textFolder.Visible = false;
            labelFolder.Visible = false;
            createFolder.Visible = false;
            cancelButton.Visible = false;
        }

        private void pictureFolder_Click(object sender, EventArgs e)
        {
            if (fileloc != "")
            {
                Process.Start(fileloc + "\\" + textFolder.Text);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            textFolder.Visible = false;
            labelFolder.Visible = false;
            createFolder.Visible = false;
            cancelButton.Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
