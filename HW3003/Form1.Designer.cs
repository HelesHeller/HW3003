using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW3003
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
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.startStreamingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(255, 79);
            this.logTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.MistyRose;
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.connectButton.Location = new System.Drawing.Point(0, 79);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(133, 20);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect to server";
            this.connectButton.UseVisualStyleBackColor = false;
            // 
            // startStreamingButton
            // 
            this.startStreamingButton.BackColor = System.Drawing.Color.MistyRose;
            this.startStreamingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStreamingButton.Location = new System.Drawing.Point(133, 79);
            this.startStreamingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startStreamingButton.Name = "startStreamingButton";
            this.startStreamingButton.Size = new System.Drawing.Size(122, 20);
            this.startStreamingButton.TabIndex = 2;
            this.startStreamingButton.Text = "Start streaming";
            this.startStreamingButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(255, 99);
            this.Controls.Add(this.startStreamingButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.logTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox logTextBox;
        private Button connectButton;
        private Button startStreamingButton;
    }
}
