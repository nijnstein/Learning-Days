namespace Datums01
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
            VraagLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            goedLabel = new Label();
            foutLabel = new Label();
            bericht = new Label();
            SuspendLayout();
            // 
            // VraagLabel
            // 
            VraagLabel.AutoSize = true;
            VraagLabel.Font = new Font("Comic Sans MS", 14F);
            VraagLabel.Location = new Point(32, 50);
            VraagLabel.Name = "VraagLabel";
            VraagLabel.Size = new Size(92, 39);
            VraagLabel.TabIndex = 0;
            VraagLabel.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 11F);
            button1.Location = new Point(16, 200);
            button1.Name = "button1";
            button1.Size = new Size(491, 128);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 11F);
            button2.Location = new Point(514, 200);
            button2.Name = "button2";
            button2.Size = new Size(491, 128);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 11F);
            button3.Location = new Point(16, 334);
            button3.Name = "button3";
            button3.Size = new Size(491, 128);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 11F);
            button4.Location = new Point(514, 334);
            button4.Name = "button4";
            button4.Size = new Size(491, 128);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // goedLabel
            // 
            goedLabel.AutoSize = true;
            goedLabel.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            goedLabel.ForeColor = Color.Green;
            goedLabel.Location = new Point(32, 516);
            goedLabel.Name = "goedLabel";
            goedLabel.Size = new Size(58, 29);
            goedLabel.TabIndex = 5;
            goedLabel.Text = "goed";
            // 
            // foutLabel
            // 
            foutLabel.AutoSize = true;
            foutLabel.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            foutLabel.ForeColor = Color.Crimson;
            foutLabel.Location = new Point(32, 549);
            foutLabel.Name = "foutLabel";
            foutLabel.Size = new Size(53, 29);
            foutLabel.TabIndex = 6;
            foutLabel.Text = "fout";
            // 
            // bericht
            // 
            bericht.Font = new Font("Comic Sans MS", 54F, FontStyle.Bold);
            bericht.Location = new Point(100, 127);
            bericht.Name = "bericht";
            bericht.Size = new Size(793, 377);
            bericht.TabIndex = 7;
            bericht.Text = "label1";
            bericht.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 591);
            Controls.Add(bericht);
            Controls.Add(foutLabel);
            Controls.Add(goedLabel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(VraagLabel);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Datums01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VraagLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label goedLabel;
        private Label foutLabel;
        private Label bericht;
    }
}
