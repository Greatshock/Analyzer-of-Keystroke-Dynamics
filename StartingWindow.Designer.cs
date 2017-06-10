namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    partial class StartingWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.Input_richTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newUser_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Input_richTextBox
            // 
            this.Input_richTextBox.Location = new System.Drawing.Point(58, 62);
            this.Input_richTextBox.Name = "Input_richTextBox";
            this.Input_richTextBox.Size = new System.Drawing.Size(47, 25);
            this.Input_richTextBox.TabIndex = 3;
            this.Input_richTextBox.Text = "";
            this.Input_richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.Input_richTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 62);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(35, 19);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(762, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(762, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // newUser_button
            // 
            this.newUser_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser_button.Location = new System.Drawing.Point(445, 323);
            this.newUser_button.Name = "newUser_button";
            this.newUser_button.Size = new System.Drawing.Size(158, 63);
            this.newUser_button.TabIndex = 9;
            this.newUser_button.Text = "Новый пользователь";
            this.newUser_button.UseVisualStyleBackColor = true;
            this.newUser_button.Click += new System.EventHandler(this.newUser_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Пройти аутентификацию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // StartingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(762, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newUser_button);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Input_richTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "StartingWindow";
            this.Text = "Keystroke Dynamics Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.RichTextBox Input_richTextBox;
        private System.Windows.Forms.Button newUser_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

