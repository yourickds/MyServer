namespace MyServer
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Исполняемый файл";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Аргументы";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 147);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(197, 74);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Обзор";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 183);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление программы";
            Shown += Form4_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private OpenFileDialog openFileDialog1;
    }
}