namespace WorkWithFilesWinFormsApp
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
            print = new Button();
            write = new Button();
            writeBox = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // print
            // 
            print.Location = new Point(33, 14);
            print.Name = "print";
            print.Size = new Size(128, 63);
            print.TabIndex = 0;
            print.Text = "Чтение файла";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // write
            // 
            write.Location = new Point(186, 12);
            write.Name = "write";
            write.Size = new Size(128, 65);
            write.TabIndex = 2;
            write.Text = "Запись файла";
            write.UseVisualStyleBackColor = true;
            write.Click += write_Click;
            // 
            // writeBox
            // 
            writeBox.Location = new Point(330, 46);
            writeBox.Name = "writeBox";
            writeBox.Size = new Size(353, 27);
            writeBox.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(330, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(353, 234);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 14);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Запись в файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 90);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 6;
            label2.Text = "Содержание файла";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 366);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(writeBox);
            Controls.Add(write);
            Controls.Add(print);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button print;
        private Button write;
        private TextBox writeBox;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
    }
}