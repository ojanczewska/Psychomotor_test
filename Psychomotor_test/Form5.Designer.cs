namespace Psychomotor_test
{
    partial class Test3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_czas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(533, 131);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(114, 54);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "button1";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_czas
            // 
            this.label_czas.AutoSize = true;
            this.label_czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czas.Location = new System.Drawing.Point(538, 273);
            this.label_czas.Name = "label_czas";
            this.label_czas.Size = new System.Drawing.Size(90, 25);
            this.label_czas.TabIndex = 2;
            this.label_czas.Text = "00:00:00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "PTAKI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttons_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "KROWA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttons_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 77);
            this.button3.TabIndex = 5;
            this.button3.Text = "AMBULNAS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttons_click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Test3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_czas);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Name = "Test3";
            this.ShowIcon = false;
            this.Text = "Test 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test3_FormClosing);
            this.Load += new System.EventHandler(this.Test3_Load);
            this.Click += new System.EventHandler(this.buttons_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_czas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}