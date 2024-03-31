namespace Aplicatie_Matei_Dragos_Catalin_LFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(561, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 286);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(561, 105);
            textBox3.TabIndex = 1;
            // 
            // Button
            // 
            Button.Location = new Point(295, 397);
            Button.Name = "Button";
            Button.Size = new Size(223, 29);
            Button.TabIndex = 2;
            Button.Text = "Check";
            Button.UseVisualStyleBackColor = true;
            Button.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 74);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 3;
            label1.Text = "Please here introduce the pattern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 253);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 4;
            label2.Text = "Please here introduce the text 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 165);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 6;
            label3.Text = "Please here introduce the text 1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(561, 36);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Pattern Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Button Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
    }
}
