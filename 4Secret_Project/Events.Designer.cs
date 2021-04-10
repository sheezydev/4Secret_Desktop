
namespace _4Secret_Project
{
    partial class Events
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
            this.buttonBR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDaily = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelWeekly = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelDaily.SuspendLayout();
            this.panelWeekly.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBR
            // 
            this.buttonBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            this.buttonBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBR.Font = new System.Drawing.Font("Mephisto™", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.buttonBR.Location = new System.Drawing.Point(92, 103);
            this.buttonBR.Name = "buttonBR";
            this.buttonBR.Size = new System.Drawing.Size(346, 245);
            this.buttonBR.TabIndex = 4;
            this.buttonBR.Text = "Daily Events";
            this.buttonBR.UseVisualStyleBackColor = false;
            this.buttonBR.Click += new System.EventHandler(this.buttonBR_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(199)))), ((int)(((byte)(96)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mephisto™", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.button1.Location = new System.Drawing.Point(578, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 245);
            this.button1.TabIndex = 5;
            this.button1.Text = "Weekly Events";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDaily
            // 
            this.panelDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDaily.Controls.Add(this.button2);
            this.panelDaily.Location = new System.Drawing.Point(13, 13);
            this.panelDaily.Name = "panelDaily";
            this.panelDaily.Size = new System.Drawing.Size(999, 566);
            this.panelDaily.TabIndex = 6;
            this.panelDaily.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mephisto™", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(842, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 60);
            this.button2.TabIndex = 34;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelWeekly
            // 
            this.panelWeekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWeekly.Controls.Add(this.button3);
            this.panelWeekly.Location = new System.Drawing.Point(13, 13);
            this.panelWeekly.Name = "panelWeekly";
            this.panelWeekly.Size = new System.Drawing.Size(999, 566);
            this.panelWeekly.TabIndex = 35;
            this.panelWeekly.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Mephisto™", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(842, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 60);
            this.button3.TabIndex = 34;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1024, 586);
            this.Controls.Add(this.panelWeekly);
            this.Controls.Add(this.panelDaily);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.panelDaily.ResumeLayout(false);
            this.panelWeekly.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDaily;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelWeekly;
        private System.Windows.Forms.Button button3;
    }
}