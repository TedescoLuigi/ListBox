namespace ListBox
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
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtaggiungi = new TextBox();
            textmodifica = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(39, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(495, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 1;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(495, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 42);
            button2.TabIndex = 2;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(495, 325);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 3;
            button3.Text = "MODIFICA";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtaggiungi
            // 
            txtaggiungi.Location = new Point(608, 85);
            txtaggiungi.Name = "txtaggiungi";
            txtaggiungi.Size = new Size(100, 23);
            txtaggiungi.TabIndex = 4;
            txtaggiungi.TextChanged += txtaggiungi_TextChanged;
            // 
            // textmodifica
            // 
            textmodifica.Location = new Point(608, 336);
            textmodifica.Name = "textmodifica";
            textmodifica.Size = new Size(100, 23);
            textmodifica.TabIndex = 5;
            textmodifica.TextChanged += textmodifica_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 67);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 6;
            label1.Text = "aggiungi elemento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 318);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "modifica elemento";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(601, 201);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 8;
            label3.Text = "rimuovi elemento";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(601, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textmodifica);
            Controls.Add(txtaggiungi);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtaggiungi;
        private TextBox textmodifica;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
