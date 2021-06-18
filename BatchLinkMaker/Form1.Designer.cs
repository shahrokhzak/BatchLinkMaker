
namespace BatchLinkMaker
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
            this.button1 = new System.Windows.Forms.Button();
            this.to_txt = new System.Windows.Forms.NumericUpDown();
            this.from_txt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.baseURL_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.to_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save To File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(506, 71);
            this.to_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(90, 23);
            this.to_txt.TabIndex = 1;
            this.to_txt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.to_txt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // from_txt
            // 
            this.from_txt.Location = new System.Drawing.Point(95, 71);
            this.from_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.from_txt.Name = "from_txt";
            this.from_txt.Size = new System.Drawing.Size(90, 23);
            this.from_txt.TabIndex = 2;
            this.from_txt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "From :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "To :";
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(51, 99);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result_txt.Size = new System.Drawing.Size(545, 186);
            this.result_txt.TabIndex = 5;
            this.result_txt.WordWrap = false;
            // 
            // baseURL_txt
            // 
            this.baseURL_txt.Location = new System.Drawing.Point(51, 37);
            this.baseURL_txt.Name = "baseURL_txt";
            this.baseURL_txt.PlaceholderText = "Base URL Use # wildcard";
            this.baseURL_txt.Size = new System.Drawing.Size(545, 23);
            this.baseURL_txt.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.baseURL_txt);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_txt);
            this.Controls.Add(this.to_txt);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.to_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown to_txt;
        private System.Windows.Forms.NumericUpDown from_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.TextBox baseURL_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

