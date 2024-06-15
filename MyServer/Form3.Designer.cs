namespace MyServer
{
    partial class Form3
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(246, 101);
            button1.Name = "button1";
            button1.Size = new Size(58, 23);
            button1.TabIndex = 2;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 23);
            textBox3.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(30, 174);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "В фоне";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(223, 174);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Запускать";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(30, 199);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(229, 199);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Закрыть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 9;
            label1.Text = "Наименование";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 83);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 11;
            label3.Text = "Исполняемый файл";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 127);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Аргументы";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 261);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            Shown += Form3_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}