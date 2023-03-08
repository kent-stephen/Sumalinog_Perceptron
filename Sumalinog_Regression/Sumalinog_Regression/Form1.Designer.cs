namespace Sumalinog_Regression
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEpoch = new System.Windows.Forms.TextBox();
            this.brnPerceptron = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(-1, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(404, 29);
            this.title.TabIndex = 0;
            this.title.Text = "Calculate NAND Gates using Perceptron";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(267, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(41, 100);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 23);
            this.txtInput1.TabIndex = 3;
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(247, 100);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(104, 23);
            this.txtInput2.TabIndex = 4;
            this.txtInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Epoch";
            // 
            // txtEpoch
            // 
            this.txtEpoch.Location = new System.Drawing.Point(148, 181);
            this.txtEpoch.Name = "txtEpoch";
            this.txtEpoch.Size = new System.Drawing.Size(100, 23);
            this.txtEpoch.TabIndex = 6;
            this.txtEpoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brnPerceptron
            // 
            this.brnPerceptron.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brnPerceptron.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brnPerceptron.Location = new System.Drawing.Point(86, 328);
            this.brnPerceptron.Name = "brnPerceptron";
            this.brnPerceptron.Size = new System.Drawing.Size(216, 32);
            this.brnPerceptron.TabIndex = 7;
            this.brnPerceptron.Text = "Calculate Perceptron";
            this.brnPerceptron.UseVisualStyleBackColor = false;
            this.brnPerceptron.Click += new System.EventHandler(this.brnPerceptron_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(170, 273);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(53, 34);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(401, 409);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnPerceptron);
            this.Controls.Add(this.txtEpoch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sumalinog_Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Label label2;
        private Label label3;
        private TextBox txtInput1;
        private TextBox txtInput2;
        private Label label4;
        private TextBox txtEpoch;
        private Button brnPerceptron;
        private Label label1;
        private Label lblOutput;
    }
}