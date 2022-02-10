
namespace TubeTowel
{
    partial class TubeTowel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TubeTowel));
            this.TubeTowelLbl = new System.Windows.Forms.Label();
            this.ChkInOutLbl = new System.Windows.Forms.Label();
            this.member = new System.Windows.Forms.TextBox();
            this.tubes = new System.Windows.Forms.TextBox();
            this.towels = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MemLbl = new System.Windows.Forms.Label();
            this.TubeLbl = new System.Windows.Forms.Label();
            this.TowelLbl = new System.Windows.Forms.Label();
            this.returnChk = new System.Windows.Forms.CheckBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.tubesTLbl = new System.Windows.Forms.Label();
            this.TotalTubelsCountLbl = new System.Windows.Forms.Label();
            this.TotalTowelsCountLbl = new System.Windows.Forms.Label();
            this.TowelsTLbl = new System.Windows.Forms.Label();
            this.CloseOutBtn = new System.Windows.Forms.Button();
            this.creditLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TubeTowelLbl
            // 
            resources.ApplyResources(this.TubeTowelLbl, "TubeTowelLbl");
            this.TubeTowelLbl.Name = "TubeTowelLbl";
            this.TubeTowelLbl.TabStop = true;
            this.TubeTowelLbl.UseMnemonic = false;
            // 
            // ChkInOutLbl
            // 
            resources.ApplyResources(this.ChkInOutLbl, "ChkInOutLbl");
            this.ChkInOutLbl.Name = "ChkInOutLbl";
            this.ChkInOutLbl.TabStop = true;
            this.ChkInOutLbl.UseMnemonic = false;
            // 
            // member
            // 
            resources.ApplyResources(this.member, "member");
            this.member.Name = "member";
            this.member.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.member.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // tubes
            // 
            resources.ApplyResources(this.tubes, "tubes");
            this.tubes.Name = "tubes";
            this.tubes.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.tubes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // towels
            // 
            resources.ApplyResources(this.towels, "towels");
            this.towels.Name = "towels";
            this.towels.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.towels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // MemLbl
            // 
            resources.ApplyResources(this.MemLbl, "MemLbl");
            this.MemLbl.Name = "MemLbl";
            this.MemLbl.TabStop = true;
            // 
            // TubeLbl
            // 
            resources.ApplyResources(this.TubeLbl, "TubeLbl");
            this.TubeLbl.Name = "TubeLbl";
            this.TubeLbl.TabStop = true;
            // 
            // TowelLbl
            // 
            resources.ApplyResources(this.TowelLbl, "TowelLbl");
            this.TowelLbl.Name = "TowelLbl";
            this.TowelLbl.TabStop = true;
            // 
            // returnChk
            // 
            resources.ApplyResources(this.returnChk, "returnChk");
            this.returnChk.Name = "returnChk";
            this.returnChk.UseVisualStyleBackColor = true;
            this.returnChk.CheckedChanged += new System.EventHandler(this.returnChk_CheckedChanged);
            this.returnChk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.returnChk_KeyPress);
            // 
            // submitBtn
            // 
            resources.ApplyResources(this.submitBtn, "submitBtn");
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Press);
            this.submitBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.submitBtn_KeyPress);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.Output, "Output");
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.TabStop = false;
            this.Output.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Output_KeyPress);
            // 
            // tubesTLbl
            // 
            resources.ApplyResources(this.tubesTLbl, "tubesTLbl");
            this.tubesTLbl.Name = "tubesTLbl";
            // 
            // TotalTubelsCountLbl
            // 
            resources.ApplyResources(this.TotalTubelsCountLbl, "TotalTubelsCountLbl");
            this.TotalTubelsCountLbl.Name = "TotalTubelsCountLbl";
            // 
            // TotalTowelsCountLbl
            // 
            resources.ApplyResources(this.TotalTowelsCountLbl, "TotalTowelsCountLbl");
            this.TotalTowelsCountLbl.Name = "TotalTowelsCountLbl";
            // 
            // TowelsTLbl
            // 
            resources.ApplyResources(this.TowelsTLbl, "TowelsTLbl");
            this.TowelsTLbl.Name = "TowelsTLbl";
            // 
            // CloseOutBtn
            // 
            resources.ApplyResources(this.CloseOutBtn, "CloseOutBtn");
            this.CloseOutBtn.Name = "CloseOutBtn";
            this.CloseOutBtn.TabStop = false;
            this.CloseOutBtn.UseVisualStyleBackColor = true;
            this.CloseOutBtn.Click += new System.EventHandler(this.CloseOutBtn_Click);
            // 
            // creditLbl
            // 
            resources.ApplyResources(this.creditLbl, "creditLbl");
            this.creditLbl.Name = "creditLbl";
            // 
            // TubeTowel
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.CloseOutBtn);
            this.Controls.Add(this.TotalTowelsCountLbl);
            this.Controls.Add(this.TowelsTLbl);
            this.Controls.Add(this.TotalTubelsCountLbl);
            this.Controls.Add(this.tubesTLbl);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.returnChk);
            this.Controls.Add(this.TowelLbl);
            this.Controls.Add(this.TubeLbl);
            this.Controls.Add(this.MemLbl);
            this.Controls.Add(this.towels);
            this.Controls.Add(this.tubes);
            this.Controls.Add(this.member);
            this.Controls.Add(this.ChkInOutLbl);
            this.Controls.Add(this.TubeTowelLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TubeTowel";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.TubeTowle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TubeTowelLbl;
        private System.Windows.Forms.Label ChkInOutLbl;
        private System.Windows.Forms.TextBox member;
        private System.Windows.Forms.TextBox tubes;
        private System.Windows.Forms.TextBox towels;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label MemLbl;
        private System.Windows.Forms.Label TubeLbl;
        private System.Windows.Forms.Label TowelLbl;
        private System.Windows.Forms.CheckBox returnChk;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label tubesTLbl;
        private System.Windows.Forms.Label TotalTubelsCountLbl;
        private System.Windows.Forms.Label TotalTowelsCountLbl;
        private System.Windows.Forms.Label TowelsTLbl;
        private System.Windows.Forms.Button CloseOutBtn;
        private System.Windows.Forms.Label creditLbl;
    }
}

