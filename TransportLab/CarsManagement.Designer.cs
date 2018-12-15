namespace TransportLab
{
    partial class CarsManagement
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
            this.cars = new System.Windows.Forms.GroupBox();
            this.typesList = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.editCar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.carsList = new System.Windows.Forms.ComboBox();
            this.deleteCar = new System.Windows.Forms.Button();
            this.newCar = new System.Windows.Forms.Button();
            this.cars.SuspendLayout();
            this.SuspendLayout();
            // 
            // cars
            // 
            this.cars.Controls.Add(this.typesList);
            this.cars.Controls.Add(this.typeLbl);
            this.cars.Controls.Add(this.cancel);
            this.cars.Controls.Add(this.editCar);
            this.cars.Controls.Add(this.exit);
            this.cars.Controls.Add(this.save);
            this.cars.Controls.Add(this.carsList);
            this.cars.Controls.Add(this.deleteCar);
            this.cars.Controls.Add(this.newCar);
            this.cars.Location = new System.Drawing.Point(12, 12);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(168, 162);
            this.cars.TabIndex = 2;
            this.cars.TabStop = false;
            this.cars.Text = "Cars";
            // 
            // typesList
            // 
            this.typesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesList.FormattingEnabled = true;
            this.typesList.Location = new System.Drawing.Point(47, 74);
            this.typesList.Name = "typesList";
            this.typesList.Size = new System.Drawing.Size(115, 21);
            this.typesList.TabIndex = 3;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(6, 78);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(34, 13);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Type:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(60, 129);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(48, 22);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // editCar
            // 
            this.editCar.Location = new System.Drawing.Point(6, 46);
            this.editCar.Name = "editCar";
            this.editCar.Size = new System.Drawing.Size(75, 22);
            this.editCar.TabIndex = 8;
            this.editCar.Text = "Edit";
            this.editCar.UseVisualStyleBackColor = true;
            this.editCar.Click += new System.EventHandler(this.editCar_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(114, 129);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 22);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 22);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // carsList
            // 
            this.carsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsList.FormattingEnabled = true;
            this.carsList.Location = new System.Drawing.Point(6, 19);
            this.carsList.Name = "carsList";
            this.carsList.Size = new System.Drawing.Size(156, 21);
            this.carsList.TabIndex = 2;
            this.carsList.SelectedIndexChanged += new System.EventHandler(this.carsList_SelectedIndexChanged);
            // 
            // deleteCar
            // 
            this.deleteCar.Location = new System.Drawing.Point(87, 46);
            this.deleteCar.Name = "deleteCar";
            this.deleteCar.Size = new System.Drawing.Size(75, 22);
            this.deleteCar.TabIndex = 2;
            this.deleteCar.Text = "Delete";
            this.deleteCar.UseVisualStyleBackColor = true;
            this.deleteCar.Click += new System.EventHandler(this.deleteCar_Click);
            // 
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(6, 101);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(156, 22);
            this.newCar.TabIndex = 1;
            this.newCar.Text = "Register car";
            this.newCar.UseVisualStyleBackColor = true;
            this.newCar.Click += new System.EventHandler(this.newCar_Click);
            // 
            // CarsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 182);
            this.Controls.Add(this.cars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsManagement";
            this.cars.ResumeLayout(false);
            this.cars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cars;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button editCar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button deleteCar;
        private System.Windows.Forms.Button newCar;
        public System.Windows.Forms.ComboBox carsList;
        private System.Windows.Forms.ComboBox typesList;
        private System.Windows.Forms.Label typeLbl;
    }
}