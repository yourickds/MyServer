namespace MyServer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            ComboBoxModule = new ComboBox();
            moduleBindingSource1 = new BindingSource(components);
            moduleBindingSource = new BindingSource(components);
            LabelModuleComboBox = new Label();
            LabelConfigComboBox = new Label();
            ComboBoxConfig = new ComboBox();
            ButtonAddModuleForm = new Button();
            ButtonAddConfigForm = new Button();
            listBoxStartupModules = new ListBox();
            ButtonAddConfigToListStartup = new Button();
            ButtonServer = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            groupBox2 = new GroupBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            label2 = new Label();
            groupBox4 = new GroupBox();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            comboBox3 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)moduleBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moduleBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ComboBoxModule
            // 
            ComboBoxModule.DataSource = moduleBindingSource1;
            ComboBoxModule.DisplayMember = "name";
            ComboBoxModule.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxModule.FormattingEnabled = true;
            ComboBoxModule.Location = new Point(38, 54);
            ComboBoxModule.Name = "ComboBoxModule";
            ComboBoxModule.Size = new Size(200, 23);
            ComboBoxModule.TabIndex = 14;
            ComboBoxModule.SelectedIndexChanged += ComboBoxModule_SelectedIndexChanged;
            // 
            // moduleBindingSource1
            // 
            moduleBindingSource1.DataSource = typeof(Model.Module);
            // 
            // moduleBindingSource
            // 
            moduleBindingSource.DataSource = typeof(Model.Module);
            // 
            // LabelModuleComboBox
            // 
            LabelModuleComboBox.AutoSize = true;
            LabelModuleComboBox.Location = new Point(38, 36);
            LabelModuleComboBox.Name = "LabelModuleComboBox";
            LabelModuleComboBox.Size = new Size(50, 15);
            LabelModuleComboBox.TabIndex = 15;
            LabelModuleComboBox.Text = "Модуль";
            // 
            // LabelConfigComboBox
            // 
            LabelConfigComboBox.AutoSize = true;
            LabelConfigComboBox.Location = new Point(38, 80);
            LabelConfigComboBox.Name = "LabelConfigComboBox";
            LabelConfigComboBox.Size = new Size(49, 15);
            LabelConfigComboBox.TabIndex = 16;
            LabelConfigComboBox.Text = "Конфиг";
            // 
            // ComboBoxConfig
            // 
            ComboBoxConfig.AutoCompleteCustomSource.AddRange(new string[] { "Default", "With_PHP_8.3" });
            ComboBoxConfig.FormattingEnabled = true;
            ComboBoxConfig.Location = new Point(38, 98);
            ComboBoxConfig.Name = "ComboBoxConfig";
            ComboBoxConfig.Size = new Size(200, 23);
            ComboBoxConfig.TabIndex = 17;
            // 
            // ButtonAddModuleForm
            // 
            ButtonAddModuleForm.Location = new Point(244, 54);
            ButtonAddModuleForm.Name = "ButtonAddModuleForm";
            ButtonAddModuleForm.Size = new Size(75, 23);
            ButtonAddModuleForm.TabIndex = 18;
            ButtonAddModuleForm.Text = "Добавить";
            ButtonAddModuleForm.UseVisualStyleBackColor = true;
            ButtonAddModuleForm.Click += ButtonAddModuleForm_Click;
            // 
            // ButtonAddConfigForm
            // 
            ButtonAddConfigForm.Location = new Point(244, 98);
            ButtonAddConfigForm.Name = "ButtonAddConfigForm";
            ButtonAddConfigForm.Size = new Size(75, 23);
            ButtonAddConfigForm.TabIndex = 19;
            ButtonAddConfigForm.Text = "Добавить";
            ButtonAddConfigForm.UseVisualStyleBackColor = true;
            ButtonAddConfigForm.Click += ButtonAddConfigForm_Click;
            // 
            // listBoxStartupModules
            // 
            listBoxStartupModules.FormattingEnabled = true;
            listBoxStartupModules.ItemHeight = 15;
            listBoxStartupModules.Location = new Point(38, 156);
            listBoxStartupModules.Name = "listBoxStartupModules";
            listBoxStartupModules.Size = new Size(475, 124);
            listBoxStartupModules.TabIndex = 20;
            // 
            // ButtonAddConfigToListStartup
            // 
            ButtonAddConfigToListStartup.Location = new Point(38, 127);
            ButtonAddConfigToListStartup.Name = "ButtonAddConfigToListStartup";
            ButtonAddConfigToListStartup.Size = new Size(200, 23);
            ButtonAddConfigToListStartup.TabIndex = 21;
            ButtonAddConfigToListStartup.Text = "Добавить в загрузку";
            ButtonAddConfigToListStartup.UseVisualStyleBackColor = true;
            ButtonAddConfigToListStartup.Click += ButtonAddConfigToListStartup_Click;
            // 
            // ButtonServer
            // 
            ButtonServer.Location = new Point(38, 286);
            ButtonServer.Name = "ButtonServer";
            ButtonServer.Size = new Size(130, 23);
            ButtonServer.TabIndex = 22;
            ButtonServer.Text = "Запустить сервер";
            ButtonServer.UseVisualStyleBackColor = true;
            ButtonServer.Click += ButtonServer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(325, 54);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 98);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 24;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(ComboBoxModule);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(LabelModuleComboBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(LabelConfigComboBox);
            groupBox1.Controls.Add(ButtonServer);
            groupBox1.Controls.Add(ComboBoxConfig);
            groupBox1.Controls.Add(ButtonAddConfigToListStartup);
            groupBox1.Controls.Add(ButtonAddModuleForm);
            groupBox1.Controls.Add(listBoxStartupModules);
            groupBox1.Controls.Add(ButtonAddConfigForm);
            groupBox1.Location = new Point(14, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 333);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сервер";
            // 
            // button7
            // 
            button7.Location = new Point(325, 127);
            button7.Name = "button7";
            button7.Size = new Size(188, 23);
            button7.TabIndex = 29;
            button7.Text = "Убрать из загрузки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(406, 97);
            button6.Name = "button6";
            button6.Size = new Size(107, 23);
            button6.TabIndex = 28;
            button6.Text = "Редактировать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(406, 54);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 27;
            button5.Text = "Редактировать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(244, 286);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 26;
            button4.Text = "Hosts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(383, 286);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 25;
            button3.Text = "Открыть терминал";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(570, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 107);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Программы";
            // 
            // button11
            // 
            button11.Location = new Point(300, 36);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 5;
            button11.Text = "Запустить";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(187, 65);
            button10.Name = "button10";
            button10.Size = new Size(107, 23);
            button10.TabIndex = 4;
            button10.Text = "Редактировать";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(106, 65);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 3;
            button9.Text = "Удалить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(25, 65);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 2;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Программа";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button14);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(570, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 107);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Закладки (сайты)";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(25, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(269, 23);
            comboBox2.TabIndex = 6;
            // 
            // button15
            // 
            button15.Location = new Point(300, 35);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 5;
            button15.Text = "Открыть";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(187, 65);
            button14.Name = "button14";
            button14.Size = new Size(107, 23);
            button14.TabIndex = 4;
            button14.Text = "Редактировать";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(106, 65);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 3;
            button13.Text = "Удалить";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(25, 65);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 2;
            button12.Text = "Добавить";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Button12_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 18);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Сайт";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button19);
            groupBox4.Controls.Add(button18);
            groupBox4.Controls.Add(button17);
            groupBox4.Controls.Add(button16);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(570, 239);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(400, 107);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Домены";
            // 
            // button19
            // 
            button19.Location = new Point(187, 66);
            button19.Name = "button19";
            button19.Size = new Size(107, 23);
            button19.TabIndex = 5;
            button19.Text = "Редактировать";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Button19_Click;
            // 
            // button18
            // 
            button18.Location = new Point(106, 66);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 4;
            button18.Text = "Удалить";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Button18_Click;
            // 
            // button17
            // 
            button17.Location = new Point(25, 66);
            button17.Name = "button17";
            button17.Size = new Size(75, 23);
            button17.TabIndex = 3;
            button17.Text = "Добавить";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(300, 37);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 2;
            button16.Text = "Открыть";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Button16_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(25, 37);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(269, 23);
            comboBox3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Домен";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 361);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyServer";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)moduleBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)moduleBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ComboBox ComboBoxModule;
        private Label LabelModuleComboBox;
        private Label LabelConfigComboBox;
        private ComboBox ComboBoxConfig;
        private Button ButtonAddModuleForm;
        private Button ButtonAddConfigForm;
        private ListBox listBoxStartupModules;
        private Button ButtonAddConfigToListStartup;
        private Button ButtonServer;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private NotifyIcon notifyIcon1;
        private Button button4;
        private BindingSource moduleBindingSource;
        private BindingSource moduleBindingSource1;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox groupBox2;
        private Button button10;
        private Button button9;
        private Button button8;
        private ComboBox comboBox1;
        private Label label1;
        private Button button11;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Label label2;
        private Button button16;
        private ComboBox comboBox3;
        private Label label3;
        private Button button19;
        private Button button18;
        private Button button17;
    }
}
