namespace OrderingApp
{
    partial class Ordering
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
            this.bntOne = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntOne
            // 
            this.bntOne.Location = new System.Drawing.Point(63, 55);
            this.bntOne.Name = "bntOne";
            this.bntOne.Size = new System.Drawing.Size(157, 45);
            this.bntOne.TabIndex = 0;
            this.bntOne.Text = "button1";
            this.bntOne.UseVisualStyleBackColor = true;
            this.bntOne.Click += new System.EventHandler(this.bntOne_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(74, 9);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(130, 22);
            this.lblOne.TabIndex = 1;
            this.lblOne.Text = "Hello World";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(155, 174);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "label1";
            
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 423);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.bntOne);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.Load += new System.EventHandler(this.Ordering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOne;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblOutput;
    }
}

