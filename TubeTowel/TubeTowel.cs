using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace TubeTowel
{
    public partial class TubeTowel : Form
    {

        private int TotalTubes = 0;
        private int TotalTowels = 0;
        private Dictionary<String, Tuple<int, int>> checkList;
        private FileStream log;

        public TubeTowel()
        {
            InitializeComponent();
            Size = new Size(600, 500);
            if (!File.Exists("db.json") || (File.Exists("db.json") && new FileInfo("db.json").Length==0)) {
                File.Create("db.json").Close();
                checkList = new Dictionary<string, Tuple<int, int>>();
            } else {
                checkList = JsonConvert.DeserializeObject<Dictionary<String, Tuple<int, int>>>(File.ReadAllText("db.json"));
                foreach (var e in checkList) {
                    TotalTubes += e.Value.Item1;
                    TotalTowels += e.Value.Item2;
                }
                TotalTubelsCountLbl.Text = TotalTubes.ToString();
                TotalTowelsCountLbl.Text = TotalTowels.ToString();
            }
        }

        private void TubeTowle_Load(object sender, EventArgs e){
        }

        private void returnChk_CheckedChanged(object sender, EventArgs e) {
            if (tubes.Text.Length == 0 || tubes.Text.Length == 0) return;
            if (returnChk.Checked) {
                submitBtn.Text = "Check In";
            } else {
                submitBtn.Text = "Check Out";
            }
        }

        private void returnChk_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar==10 || e.KeyChar == 13) {
                returnChk.Checked = !returnChk.Checked;
            }
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 10 || e.KeyChar == 13) {
                ((TextBox)sender).Parent.SelectNextControl(ActiveControl, true, false, true, true);
                e.Handled = true;
            }
            if ((e.KeyChar > 31 && e.KeyChar < 48) || e.KeyChar > 57) {
                e.Handled = true; //ignore if not a number
            }
        }

        private void Output_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void submitBtn_Press(object sender, EventArgs e) {
            submitBtn_submit((Button)sender);
        }

        private void submitBtn_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar==10 || e.KeyChar==13) {
                submitBtn_submit((Button)sender);
            }
        }

        private void submitBtn_submit(Button sender) {
            if (member.Text.Length > 0 && tubes.Text.Length == 0 && towels.Text.Length == 0) {
                if (checkList.ContainsKey(member.Text)) {
                    checkList.TryGetValue(member.Text, out Tuple<int, int> tt);
                    MessageBox.Show(this, $"Member \"{member.Text}\" has {tt.Item1} tubes and {tt.Item2} towels", "Memeber Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                } else {
                    MessageBox.Show(this, "Member has nothing checked out", "Member Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                return;
            }
            Regex r = new Regex("^[0-9]{1,6}$");
            if (!r.IsMatch(member.Text)) {
                MessageBox.Show(this, "Member number is an invaild number", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                member.Text = "";
                sender.Parent.Controls.Find("member", false)[0].Select();
                return;
            } else if (!r.IsMatch(tubes.Text)) {
                MessageBox.Show(this, "Tubes is an invaild number", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tubes.Text = "";
                sender.Parent.Controls.Find("tubes", false)[0].Select();
                return;
            } else if (!r.IsMatch(towels.Text)) {
                MessageBox.Show(this, "Towels is an invaild number", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                towels.Text = "";
                sender.Parent.Controls.Find("towels", false)[0].Select();
                return;
            }
            int tb = Int32.Parse(tubes.Text);
            int tw = Int32.Parse(towels.Text);
            int ltb, ltw = 0;
            String mem = member.Text;
            if (!returnChk.Checked) {
                if (checkList.ContainsKey(mem)) {
                    checkList.TryGetValue(mem, out Tuple<int, int> tt);
                    ltb = tt.Item1 + tb;
                    ltw = tt.Item2 + tw;
                    checkList[mem] = new Tuple<int, int>(tt.Item1 + tb, tt.Item2 + tw);
                } else {
                    checkList.Add(mem, new Tuple<int, int>(tb, tw));
                    ltb = tb;
                    ltw = tw;
                }
                TotalTubes += tb;
                TotalTowels += tw;
            } else {
                if (checkList.ContainsKey(mem)) {
                    Tuple<int, int> tt;
                    checkList.TryGetValue(mem, out tt);
                    ltb = tt.Item1 - tb;
                    ltw = tt.Item2 - tw;
                    checkList[mem] = new Tuple<int, int>(tt.Item1 - tb, tt.Item2 - tw);
                    TotalTubes -= tb;
                    TotalTowels -= tw;
                } else {
                    MessageBox.Show(this, "Member has nothing checked out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            File.WriteAllText("db.json", JsonConvert.SerializeObject(checkList, Formatting.Indented));
            Output_update(mem, tb, tw, returnChk.Checked, ltb, ltw);
            TotalTubelsCountLbl.Text = TotalTubes.ToString();
            TotalTowelsCountLbl.Text = TotalTowels.ToString();
            member.Text = "";
            tubes.Text = "";
            towels.Text = "";
            returnChk.Checked = false;
        }
        private void Output_update(String mem, int tb, int tw, bool inout, int ltb, int ltw) {
            String strout = "[" + DateTime.Now.ToString("h:mm:ss tt") + "] ";
            if (inout) {
                strout += "Checked in ";
            } else {
                strout += "Checked out ";
            }
            strout += tb + " tubes and " + tw + " towels to member " + mem + " (" + ltb + " tubes, " + ltw + " towels total)\n";
            Output.AppendText(strout);
            Output.ScrollToCaret();
            Output.Refresh();
            File.AppendAllText("log.txt", strout);
        }

        private void textbox_TextChanged(object sender, EventArgs e) {
            if (member.Text.Length > 0 && tubes.Text.Length == 0 && towels.Text.Length == 0) {
                submitBtn.Text = "Member Info";
            } else {
                if (returnChk.Checked) {
                    submitBtn.Text = "Check In";
                } else {
                    submitBtn.Text = "Check Out";
                }
            }
        }

        private void CloseOutBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to close out for the day? This cannot be undone.", "Close out for the day", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) {
                submitBtn.Enabled = false;
                member.Enabled = false;
                tubes.Enabled = false;
                towels.Enabled = false;
                returnChk.Enabled = false;
                CloseOutBtn.Enabled = false;
                Output.Text = "Remaining tubes and towels are as follows:\n";
                foreach (var i in checkList) {
                    Output.AppendText($"Member \"{i.Key}\": {i.Value.Item1} Tubes, {i.Value.Item2} Towels (${(i.Value.Item1*20)+(i.Value.Item2*10)})\n");
                }
                File.AppendAllText("log.txt", "=====================End of Day=====================\n" + Output.Text);
                if (!Directory.Exists("dbs")) Directory.CreateDirectory("dbs");
                if (!Directory.Exists("logs")) Directory.CreateDirectory("logs");
                File.Move("db.json", $"dbs\\db-{DateTime.Now.ToString("MM-dd-yyyy_HH.mm.ss")}.json");
                File.Move("log.txt", $"logs\\log-{DateTime.Now.ToString("MM-dd-yyyy_HH.mm.ss")}.txt");
            }
        }
    }
}
