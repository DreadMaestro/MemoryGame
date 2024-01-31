
namespace MemoryGame
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnR1C1 = new System.Windows.Forms.Button();
            this.btnR1C2 = new System.Windows.Forms.Button();
            this.btnR1C3 = new System.Windows.Forms.Button();
            this.btnR1C4 = new System.Windows.Forms.Button();
            this.btnR2C4 = new System.Windows.Forms.Button();
            this.btnR2C3 = new System.Windows.Forms.Button();
            this.btnR2C2 = new System.Windows.Forms.Button();
            this.btnR2C1 = new System.Windows.Forms.Button();
            this.btnR3C4 = new System.Windows.Forms.Button();
            this.btnR3C3 = new System.Windows.Forms.Button();
            this.btnR3C2 = new System.Windows.Forms.Button();
            this.btnR3C1 = new System.Windows.Forms.Button();
            this.btnR4C4 = new System.Windows.Forms.Button();
            this.btnR4C3 = new System.Windows.Forms.Button();
            this.btnR4C2 = new System.Windows.Forms.Button();
            this.btnR4C1 = new System.Windows.Forms.Button();
            this.lblClickCounter = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(51, 49);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(291, 63);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "The Memory Game";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(137, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnR1C1
            // 
            this.btnR1C1.Location = new System.Drawing.Point(51, 60);
            this.btnR1C1.Name = "btnR1C1";
            this.btnR1C1.Size = new System.Drawing.Size(59, 52);
            this.btnR1C1.TabIndex = 2;
            this.btnR1C1.UseVisualStyleBackColor = true;
            this.btnR1C1.Visible = false;
            this.btnR1C1.Click += new System.EventHandler(this.btnR1C1_Click);
            // 
            // btnR1C2
            // 
            this.btnR1C2.Location = new System.Drawing.Point(116, 60);
            this.btnR1C2.Name = "btnR1C2";
            this.btnR1C2.Size = new System.Drawing.Size(59, 52);
            this.btnR1C2.TabIndex = 3;
            this.btnR1C2.UseVisualStyleBackColor = true;
            this.btnR1C2.Visible = false;
            this.btnR1C2.Click += new System.EventHandler(this.btnR1C2_Click);
            // 
            // btnR1C3
            // 
            this.btnR1C3.Location = new System.Drawing.Point(181, 60);
            this.btnR1C3.Name = "btnR1C3";
            this.btnR1C3.Size = new System.Drawing.Size(59, 52);
            this.btnR1C3.TabIndex = 4;
            this.btnR1C3.UseVisualStyleBackColor = true;
            this.btnR1C3.Visible = false;
            this.btnR1C3.Click += new System.EventHandler(this.btnR1C3_Click);
            // 
            // btnR1C4
            // 
            this.btnR1C4.Location = new System.Drawing.Point(246, 60);
            this.btnR1C4.Name = "btnR1C4";
            this.btnR1C4.Size = new System.Drawing.Size(59, 52);
            this.btnR1C4.TabIndex = 5;
            this.btnR1C4.UseVisualStyleBackColor = true;
            this.btnR1C4.Visible = false;
            this.btnR1C4.Click += new System.EventHandler(this.btnR1C4_Click);
            // 
            // btnR2C4
            // 
            this.btnR2C4.Location = new System.Drawing.Point(246, 118);
            this.btnR2C4.Name = "btnR2C4";
            this.btnR2C4.Size = new System.Drawing.Size(59, 52);
            this.btnR2C4.TabIndex = 10;
            this.btnR2C4.UseVisualStyleBackColor = true;
            this.btnR2C4.Visible = false;
            this.btnR2C4.Click += new System.EventHandler(this.btnR2C4_Click);
            // 
            // btnR2C3
            // 
            this.btnR2C3.Location = new System.Drawing.Point(181, 118);
            this.btnR2C3.Name = "btnR2C3";
            this.btnR2C3.Size = new System.Drawing.Size(59, 52);
            this.btnR2C3.TabIndex = 9;
            this.btnR2C3.UseVisualStyleBackColor = true;
            this.btnR2C3.Visible = false;
            this.btnR2C3.Click += new System.EventHandler(this.btnR2C3_Click);
            // 
            // btnR2C2
            // 
            this.btnR2C2.Location = new System.Drawing.Point(116, 118);
            this.btnR2C2.Name = "btnR2C2";
            this.btnR2C2.Size = new System.Drawing.Size(59, 52);
            this.btnR2C2.TabIndex = 8;
            this.btnR2C2.UseVisualStyleBackColor = true;
            this.btnR2C2.Visible = false;
            this.btnR2C2.Click += new System.EventHandler(this.btnR2C2_Click);
            // 
            // btnR2C1
            // 
            this.btnR2C1.Location = new System.Drawing.Point(51, 118);
            this.btnR2C1.Name = "btnR2C1";
            this.btnR2C1.Size = new System.Drawing.Size(59, 52);
            this.btnR2C1.TabIndex = 7;
            this.btnR2C1.UseVisualStyleBackColor = true;
            this.btnR2C1.Visible = false;
            this.btnR2C1.Click += new System.EventHandler(this.btnR2C1_Click);
            // 
            // btnR3C4
            // 
            this.btnR3C4.Location = new System.Drawing.Point(246, 176);
            this.btnR3C4.Name = "btnR3C4";
            this.btnR3C4.Size = new System.Drawing.Size(59, 52);
            this.btnR3C4.TabIndex = 15;
            this.btnR3C4.UseVisualStyleBackColor = true;
            this.btnR3C4.Visible = false;
            this.btnR3C4.Click += new System.EventHandler(this.btnR3C4_Click);
            // 
            // btnR3C3
            // 
            this.btnR3C3.Location = new System.Drawing.Point(181, 176);
            this.btnR3C3.Name = "btnR3C3";
            this.btnR3C3.Size = new System.Drawing.Size(59, 52);
            this.btnR3C3.TabIndex = 14;
            this.btnR3C3.UseVisualStyleBackColor = true;
            this.btnR3C3.Visible = false;
            this.btnR3C3.Click += new System.EventHandler(this.btnR3C3_Click);
            // 
            // btnR3C2
            // 
            this.btnR3C2.Location = new System.Drawing.Point(116, 176);
            this.btnR3C2.Name = "btnR3C2";
            this.btnR3C2.Size = new System.Drawing.Size(59, 52);
            this.btnR3C2.TabIndex = 13;
            this.btnR3C2.UseVisualStyleBackColor = true;
            this.btnR3C2.Visible = false;
            this.btnR3C2.Click += new System.EventHandler(this.btnR3C2_Click);
            // 
            // btnR3C1
            // 
            this.btnR3C1.Location = new System.Drawing.Point(51, 176);
            this.btnR3C1.Name = "btnR3C1";
            this.btnR3C1.Size = new System.Drawing.Size(59, 52);
            this.btnR3C1.TabIndex = 12;
            this.btnR3C1.UseVisualStyleBackColor = true;
            this.btnR3C1.Visible = false;
            this.btnR3C1.Click += new System.EventHandler(this.btnR3C1_Click);
            // 
            // btnR4C4
            // 
            this.btnR4C4.Location = new System.Drawing.Point(246, 231);
            this.btnR4C4.Name = "btnR4C4";
            this.btnR4C4.Size = new System.Drawing.Size(59, 52);
            this.btnR4C4.TabIndex = 20;
            this.btnR4C4.UseVisualStyleBackColor = true;
            this.btnR4C4.Visible = false;
            this.btnR4C4.Click += new System.EventHandler(this.btnR4C4_Click);
            // 
            // btnR4C3
            // 
            this.btnR4C3.Location = new System.Drawing.Point(181, 231);
            this.btnR4C3.Name = "btnR4C3";
            this.btnR4C3.Size = new System.Drawing.Size(59, 52);
            this.btnR4C3.TabIndex = 19;
            this.btnR4C3.UseVisualStyleBackColor = true;
            this.btnR4C3.Visible = false;
            this.btnR4C3.Click += new System.EventHandler(this.btnR4C3_Click);
            // 
            // btnR4C2
            // 
            this.btnR4C2.Location = new System.Drawing.Point(116, 231);
            this.btnR4C2.Name = "btnR4C2";
            this.btnR4C2.Size = new System.Drawing.Size(59, 52);
            this.btnR4C2.TabIndex = 18;
            this.btnR4C2.UseVisualStyleBackColor = true;
            this.btnR4C2.Visible = false;
            this.btnR4C2.Click += new System.EventHandler(this.btnR4C2_Click);
            // 
            // btnR4C1
            // 
            this.btnR4C1.Location = new System.Drawing.Point(51, 231);
            this.btnR4C1.Name = "btnR4C1";
            this.btnR4C1.Size = new System.Drawing.Size(59, 52);
            this.btnR4C1.TabIndex = 17;
            this.btnR4C1.UseVisualStyleBackColor = true;
            this.btnR4C1.Visible = false;
            this.btnR4C1.Click += new System.EventHandler(this.btnR4C1_Click);
            // 
            // lblClickCounter
            // 
            this.lblClickCounter.AutoSize = true;
            this.lblClickCounter.Location = new System.Drawing.Point(134, 36);
            this.lblClickCounter.Name = "lblClickCounter";
            this.lblClickCounter.Size = new System.Drawing.Size(76, 13);
            this.lblClickCounter.TabIndex = 21;
            this.lblClickCounter.Text = "Click Counter: ";
            this.lblClickCounter.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(147, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 331);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblClickCounter);
            this.Controls.Add(this.btnR4C4);
            this.Controls.Add(this.btnR4C3);
            this.Controls.Add(this.btnR4C2);
            this.Controls.Add(this.btnR4C1);
            this.Controls.Add(this.btnR3C4);
            this.Controls.Add(this.btnR3C3);
            this.Controls.Add(this.btnR3C2);
            this.Controls.Add(this.btnR3C1);
            this.Controls.Add(this.btnR2C4);
            this.Controls.Add(this.btnR2C3);
            this.Controls.Add(this.btnR2C2);
            this.Controls.Add(this.btnR2C1);
            this.Controls.Add(this.btnR1C4);
            this.Controls.Add(this.btnR1C3);
            this.Controls.Add(this.btnR1C2);
            this.Controls.Add(this.btnR1C1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnR1C1;
        private System.Windows.Forms.Button btnR1C2;
        private System.Windows.Forms.Button btnR1C3;
        private System.Windows.Forms.Button btnR1C4;
        private System.Windows.Forms.Button btnR2C4;
        private System.Windows.Forms.Button btnR2C3;
        private System.Windows.Forms.Button btnR2C2;
        private System.Windows.Forms.Button btnR2C1;
        private System.Windows.Forms.Button btnR3C4;
        private System.Windows.Forms.Button btnR3C3;
        private System.Windows.Forms.Button btnR3C2;
        private System.Windows.Forms.Button btnR3C1;
        private System.Windows.Forms.Button btnR4C4;
        private System.Windows.Forms.Button btnR4C3;
        private System.Windows.Forms.Button btnR4C2;
        private System.Windows.Forms.Button btnR4C1;
        private System.Windows.Forms.Label lblClickCounter;
        private System.Windows.Forms.Button btnReset;
    }
}

