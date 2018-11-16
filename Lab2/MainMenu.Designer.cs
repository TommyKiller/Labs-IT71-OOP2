namespace Lab2
{
    partial class MainMenu
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
            this.editCarBtn = new System.Windows.Forms.Button();
            this.editRouteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editCarBtn
            // 
            this.editCarBtn.Location = new System.Drawing.Point(54, 12);
            this.editCarBtn.Name = "editCarBtn";
            this.editCarBtn.Size = new System.Drawing.Size(126, 23);
            this.editCarBtn.TabIndex = 2;
            this.editCarBtn.Text = "Cars Management";
            this.editCarBtn.UseVisualStyleBackColor = true;
            this.editCarBtn.Click += new System.EventHandler(this.editCarBtn_Click);
            // 
            // editRouteBtn
            // 
            this.editRouteBtn.Location = new System.Drawing.Point(54, 41);
            this.editRouteBtn.Name = "editRouteBtn";
            this.editRouteBtn.Size = new System.Drawing.Size(126, 23);
            this.editRouteBtn.TabIndex = 3;
            this.editRouteBtn.Text = "Routes Management";
            this.editRouteBtn.UseVisualStyleBackColor = true;
            this.editRouteBtn.Click += new System.EventHandler(this.editRouteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(54, 70);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(126, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 105);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.editRouteBtn);
            this.Controls.Add(this.editCarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editCarBtn;
        private System.Windows.Forms.Button editRouteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

