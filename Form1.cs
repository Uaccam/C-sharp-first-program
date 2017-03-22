using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        char[] spec_chars = new char[] { '*', '/', '%', '#', '@', '$' };
        Dictionary<string, double> metric;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metric = new Dictionary<string, double>();
            metric.Add("mm", 1);
            metric.Add("cm", 10);
            metric.Add("dm", 100);
            metric.Add("m", 1000);
            metric.Add("km", 1000000);
            metric.Add("mile", 1609344);
        }


        //Quit method
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //'About' message
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a little program called\nMy utilities. \nIt's my first C# program", "About");
        }


        //Counter. Increasing, decreasing and resetting methods.
        private void buttonplus_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            count--;
            labelCount.Text = count.ToString();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = count.ToString();
        }


        //Generator
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                if (tbRandom.Text.IndexOf(n.ToString()) == -1)
                    tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();

        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {

            try
            {
                Clipboard.SetText(tbRandom.Text);
            }
            catch
            {
                MessageBox.Show("There is no text to copy");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        //Notepad
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("Notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Saving error");
            }
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("Notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Loading error");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }


        //Passwords
        private void MainForm_Load(object sender, EventArgs e)
        {
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPassLength.Value; i++)
            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Digits":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Upper case":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Lower case":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPassword.Text = password;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Converter
        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metric[cbFrom.Text];
            double m2 = metric[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Distance":
                    metric.Clear();
                    metric.Add("mm", 1);
                    metric.Add("cm", 10);
                    metric.Add("dm", 100);
                    metric.Add("m", 1000);
                    metric.Add("km", 1000000);
                    metric.Add("mile", 1609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    cbFrom.Text = "mm";
                    cbTo.Text = "m";
                    break;
                case "Weight":
                    metric.Clear();
                    metric.Add("g", 1);
                    metric.Add("kg", 1000);
                    metric.Add("t", 1000000);
                    metric.Add("lb", 453.6);
                    metric.Add("oz", 283);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");
                    cbFrom.Text = "g";
                    cbTo.Text = "kg";
                    break;
            }
        }
    }
}