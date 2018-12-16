namespace TransportLab
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
            this.EditCars = new System.Windows.Forms.Button();
            this.EditRoutes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditCars
            // 
            this.EditCars.Location = new System.Drawing.Point(51, 12);
            this.EditCars.Name = "EditCars";
            this.EditCars.Size = new System.Drawing.Size(126, 23);
            this.EditCars.TabIndex = 2;
            this.EditCars.Text = "Cars Management";
            this.EditCars.UseVisualStyleBackColor = true;
            this.EditCars.Click += new System.EventHandler(this.EditCars_Click);
            // 
            // EditRoutes
            // 
            this.EditRoutes.Location = new System.Drawing.Point(51, 41);
            this.EditRoutes.Name = "EditRoutes";
            this.EditRoutes.Size = new System.Drawing.Size(126, 23);
            this.EditRoutes.TabIndex = 3;
            this.EditRoutes.Text = "Routes Management";
            this.EditRoutes.UseVisualStyleBackColor = true;
            this.EditRoutes.Click += new System.EventHandler(this.EditRoutes_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(51, 99);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(126, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(51, 70);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(60, 23);
            this.SaveData.TabIndex = 5;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(117, 70);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(60, 23);
            this.LoadData.TabIndex = 6;
            this.LoadData.Text = "Load";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 134);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EditRoutes);
            this.Controls.Add(this.EditCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditCars;
        private System.Windows.Forms.Button EditRoutes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadData;
    }
}

