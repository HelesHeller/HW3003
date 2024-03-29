using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screenPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startServerButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.BackColor = System.Drawing.Color.MistyRose;
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPanel.Location = new System.Drawing.Point(0, 0);
            this.screenPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(533, 292);
            this.screenPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.startServerButton);
            this.panel2.Controls.Add(this.logTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 81);
            this.panel2.TabIndex = 1;
            // 
            // startServerButton
            // 
            this.startServerButton.BackColor = System.Drawing.Color.SeaShell;
            this.startServerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startServerButton.Location = new System.Drawing.Point(0, 62);
            this.startServerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(533, 19);
            this.startServerButton.TabIndex = 1;
            this.startServerButton.Text = "START SERVER";
            this.startServerButton.UseVisualStyleBackColor = false;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(533, 81);
            this.logTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.screenPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ServerForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel screenPanel;
        private Panel panel2;
        private TextBox logTextBox;
        private Button startServerButton;
    }
}
