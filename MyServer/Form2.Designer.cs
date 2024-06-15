namespace MyServer
{
    partial class FormNewModule
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 447);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование модуля";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(23, 67);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddModule;
            // 
            // button2
            // 
            button2.Location = new Point(133, 67);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CloseDialogNewModule;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNewModule
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 111);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewModule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Новый модуль";
            Shown += FormNewModule_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}