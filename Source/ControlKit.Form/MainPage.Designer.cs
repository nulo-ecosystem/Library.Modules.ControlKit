namespace Nulo {
    partial class MainPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox1 = new CheckBox();
            smartSecondaryButton1 = new Modules.ControlKit.Buttons.SmartSecondaryButton();
            smartPrimaryButton1 = new Modules.ControlKit.Buttons.SmartPrimaryButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(smartSecondaryButton1);
            tabPage1.Controls.Add(smartPrimaryButton1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(20);
            tabPage1.Size = new Size(792, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buttons";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(747, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // smartSecondaryButton1
            // 
            smartSecondaryButton1.BackColor = Color.Gray;
            smartSecondaryButton1.BorderColor = Color.White;
            smartSecondaryButton1.BorderRadius = 20;
            smartSecondaryButton1.BorderSize = 3;
            smartSecondaryButton1.DisabledBackColor = Color.DimGray;
            smartSecondaryButton1.DisabledBorderColor = Color.Gray;
            smartSecondaryButton1.DisabledForeColor = Color.Gray;
            smartSecondaryButton1.FlatAppearance.BorderSize = 0;
            smartSecondaryButton1.FlatStyle = FlatStyle.Flat;
            smartSecondaryButton1.ForeColor = Color.White;
            smartSecondaryButton1.Location = new Point(23, 83);
            smartSecondaryButton1.Name = "smartSecondaryButton1";
            smartSecondaryButton1.Size = new Size(250, 40);
            smartSecondaryButton1.TabIndex = 1;
            smartSecondaryButton1.Text = "Secondary";
            smartSecondaryButton1.UseVisualStyleBackColor = false;
            // 
            // smartPrimaryButton1
            // 
            smartPrimaryButton1.BackColor = SystemColors.Highlight;
            smartPrimaryButton1.BorderRadius = 20;
            smartPrimaryButton1.DisabledBackColor = SystemColors.HotTrack;
            smartPrimaryButton1.DisabledForeColor = Color.WhiteSmoke;
            smartPrimaryButton1.FlatAppearance.BorderSize = 0;
            smartPrimaryButton1.FlatStyle = FlatStyle.Flat;
            smartPrimaryButton1.ForeColor = Color.White;
            smartPrimaryButton1.Location = new Point(23, 23);
            smartPrimaryButton1.Name = "smartPrimaryButton1";
            smartPrimaryButton1.Size = new Size(250, 40);
            smartPrimaryButton1.TabIndex = 0;
            smartPrimaryButton1.Text = "Primary";
            smartPrimaryButton1.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainPage";
            Text = "MainPage";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Modules.ControlKit.Buttons.SmartSecondaryButton smartSecondaryButton1;
        private Modules.ControlKit.Buttons.SmartPrimaryButton smartPrimaryButton1;
        private CheckBox checkBox1;
    }
}