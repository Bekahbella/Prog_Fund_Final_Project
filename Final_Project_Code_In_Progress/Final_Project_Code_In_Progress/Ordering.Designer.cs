namespace Final_Project_Code_In_Progress
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
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSpecialty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPreviousNext = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlPreviousNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.SystemColors.Window;
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Location = new System.Drawing.Point(155, 12);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(753, 427);
            this.pnlStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(321, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(191, 29);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(382, 42);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Press Button to Start";
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlLocation.Controls.Add(this.btnOut);
            this.pnlLocation.Controls.Add(this.btnIn);
            this.pnlLocation.Controls.Add(this.label1);
            this.pnlLocation.Location = new System.Drawing.Point(155, 12);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(753, 427);
            this.pnlLocation.TabIndex = 1;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(534, 227);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(208, 228);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "in";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eating Location";
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlOrderType.Controls.Add(this.lblOrderType);
            this.pnlOrderType.Controls.Add(this.btnSpecialty);
            this.pnlOrderType.Controls.Add(this.btnBuild);
            this.pnlOrderType.Location = new System.Drawing.Point(155, 12);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(753, 354);
            this.pnlOrderType.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(168, 175);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // btnSpecialty
            // 
            this.btnSpecialty.Location = new System.Drawing.Point(498, 175);
            this.btnSpecialty.Name = "btnSpecialty";
            this.btnSpecialty.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialty.TabIndex = 1;
            this.btnSpecialty.Text = "Specialty";
            this.btnSpecialty.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pnlPreviousNext
            // 
            this.pnlPreviousNext.Controls.Add(this.btnNext);
            this.pnlPreviousNext.Controls.Add(this.btnPrev);
            this.pnlPreviousNext.Location = new System.Drawing.Point(155, 365);
            this.pnlPreviousNext.Name = "pnlPreviousNext";
            this.pnlPreviousNext.Size = new System.Drawing.Size(753, 74);
            this.pnlPreviousNext.TabIndex = 3;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(50, 27);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(604, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(244, 71);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(268, 33);
            this.lblOrderType.TabIndex = 2;
            this.lblOrderType.Text = "Choose An Option";
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 451);
            this.Controls.Add(this.pnlPreviousNext);
            this.Controls.Add(this.pnlOrderType);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.label2);
            this.Name = "Ordering";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlPreviousNext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Button btnSpecialty;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPreviousNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblOrderType;
    }
}

