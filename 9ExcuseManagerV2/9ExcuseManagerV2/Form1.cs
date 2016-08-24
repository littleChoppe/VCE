﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace ExcuseManagerV2
{
    public partial class Form1 : Form
    {

        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = "";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.Path))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.Path).ToString();
                }
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = this.selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                    "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
            saveFileDialog1.FileName = description.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.SaveFile(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
                openFileDialog1.FileName = description.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool clearForm = false;
                    try
                    {
                        currentExcuse = new Excuse(openFileDialog1.FileName);
                        try
                        {
                            UpdateForm(false);
                        }
                        catch (ArgumentOutOfRangeException)
                        {

                            MessageBox.Show("The excuse file '" +
                                openFileDialog1.FileName + "' had a invalid data",
                                "Unable to open the excuse");
                            clearForm = true;
                        }
                    }
                    catch (SerializationException ex)
                    {

                        MessageBox.Show("An error occurred while opening the excuse '" +
                            openFileDialog1.FileName + "'\n" + ex.Message,
                            "Unable to open the excuse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearForm = true;
                    }
                    finally
                    {
                        if (clearForm)
                        {
                            description.Text = "";
                            results.Text = "";
                            lastUsed.Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            string[] fileName = Directory.GetFiles(selectedFolder, "*.excuse");
            if (fileName.Length == 0)
            {
                MessageBox.Show("Please specify a folder with excuse files in it",
                    "No excuse files found");
            }
            else
            {
                try
                {
                    if (CheckChanged())
                    {
                        currentExcuse = new Excuse(random, selectedFolder);
                        //UpdateForm(false); 这个语句无论抛不抛出异常都需要执行
                    }
                }
                catch (SerializationException)
                {
                    currentExcuse = new Excuse();
                    currentExcuse.Description = "";
                    currentExcuse.Results = "";
                    currentExcuse.LastUsed = DateTime.Now;
                    MessageBox.Show("Your excuse file was invalid.",
                        "Unable to open a random excuse");
                }
                finally
                {
                    UpdateForm(false);
                }
            }
        }


    }
}
