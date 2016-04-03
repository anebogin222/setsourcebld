using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL.BLL;

namespace SetSource
{
    public partial class MainForm : Form
    {
        private string JiraTaskNumber { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void setView()
        {
            btnNext.Enabled = false;
            lblError.Text = string.Empty;
            lblJiraTask.Text = string.Empty;
            txtJintegNumber.Text = string.Empty;
            txtJiratwNumber.Text = string.Empty;
            txtJiratwNumber.Enabled = true;
            txtJintegNumber.Enabled = true;
            btnJinteg.Enabled = false;
            btnJiratw.Enabled = false;
        }

        private void btnJiratw_Click(object sender, EventArgs e)
        {
            try
            {
                JiraTask jiraTask = new Jira().getJiraTaskByNumber("JIRATW-" + txtJiratwNumber.Text);
                if (jiraTask == null)
                {
                    lblError.Text = string.Format("Задача JIRATW-{0} в Jira не найдена", txtJiratwNumber.Text);
                    btnNext.Enabled = false;
                }
                else
                {
                    lblJiraTask.Text = jiraTask.Summary;
                    JiraTaskNumber = jiraTask.Number;
                    txtJiratwNumber.Enabled = true;
                    btnJiratw.Enabled = true;
                    btnNext.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                btnNext.Enabled = false;
            }
        }

        private void btnJinteg_Click(object sender, EventArgs e)
        {
            try
            {
                JiraTask jiraTask = new Jira().getJiraTaskByNumber("JINTEG-" + txtJintegNumber.Text);
                if (jiraTask == null)
                {
                    lblError.Text = string.Format("Задача JINTEG-{0} в Jira не найдена", txtJintegNumber.Text);
                    btnNext.Enabled = false;
                }
                else
                {
                    lblJiraTask.Text = jiraTask.Summary;
                    JiraTaskNumber = jiraTask.Number;
                    txtJintegNumber.Enabled = true;
                    btnJinteg.Enabled = true;
                    btnNext.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                btnNext.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setView();
        }

        private void txtJiratwNumber_TextChanged(object sender, EventArgs e)
        {
            txtJintegNumber.Enabled = txtJiratwNumber.Text.Length == 0;
            btnJiratw.Enabled = txtJiratwNumber.Text.Length != 0;
            lblError.Text = string.Empty;
        }

        private void txtJintegNumber_TextChanged(object sender, EventArgs e)
        {
            txtJiratwNumber.Enabled = txtJintegNumber.Text.Length == 0;
            btnJinteg.Enabled = txtJintegNumber.Text.Length != 0;
            lblError.Text = string.Empty;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SecondForm(this, JiraTaskNumber).Show();
        }
 
    }
}
