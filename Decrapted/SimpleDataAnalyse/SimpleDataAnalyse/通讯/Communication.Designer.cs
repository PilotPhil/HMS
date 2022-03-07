
namespace SimpleDataAnalyse
{
    partial class Communication
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
            this.checkedListBox_chooseCom = new System.Windows.Forms.CheckedListBox();
            this.panel_chooseCom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkedListBox_chooseCom
            // 
            this.checkedListBox_chooseCom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_chooseCom.CheckOnClick = true;
            this.checkedListBox_chooseCom.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_chooseCom.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListBox_chooseCom.FormattingEnabled = true;
            this.checkedListBox_chooseCom.Items.AddRange(new object[] {
            "串口通信",
            "UDP",
            "TCP/IP"});
            this.checkedListBox_chooseCom.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox_chooseCom.MultiColumn = true;
            this.checkedListBox_chooseCom.Name = "checkedListBox_chooseCom";
            this.checkedListBox_chooseCom.Size = new System.Drawing.Size(937, 20);
            this.checkedListBox_chooseCom.TabIndex = 0;
            this.checkedListBox_chooseCom.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_chooseCom_SelectedIndexChanged);
            // 
            // panel_chooseCom
            // 
            this.panel_chooseCom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chooseCom.Location = new System.Drawing.Point(0, 26);
            this.panel_chooseCom.Name = "panel_chooseCom";
            this.panel_chooseCom.Size = new System.Drawing.Size(937, 520);
            this.panel_chooseCom.TabIndex = 1;
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 548);
            this.Controls.Add(this.panel_chooseCom);
            this.Controls.Add(this.checkedListBox_chooseCom);
            this.Name = "Communication";
            this.Text = "Communication";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_chooseCom;
        private System.Windows.Forms.Panel panel_chooseCom;
    }
}