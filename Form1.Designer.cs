namespace Huffman
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter String:";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(83, 24);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(204, 20);
            this.textInput.TabIndex = 2;
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(6, 97);
            this.richOutput.Name = "richOutput";
            this.richOutput.ReadOnly = true;
            this.richOutput.Size = new System.Drawing.Size(340, 209);
            this.richOutput.TabIndex = 5;
            this.richOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Huffman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

