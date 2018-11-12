namespace Lab2
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
            this.cancel = new System.Windows.Forms.Button();
            this.editCar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.carsList = new System.Windows.Forms.ComboBox();
            this.deleteCar = new System.Windows.Forms.Button();
            this.addNewCar = new System.Windows.Forms.Button();
            this.editRoutePanel = new System.Windows.Forms.GroupBox();
            this.wpList = new System.Windows.Forms.ListBox();
            this.carCompany = new System.Windows.Forms.TextBox();
            this.companyLbl = new System.Windows.Forms.Label();
            this.routesList = new System.Windows.Forms.ComboBox();
            this.carID = new System.Windows.Forms.Label();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.exitCar = new System.Windows.Forms.Button();
            this.applyCar = new System.Windows.Forms.Button();
            this.cars.SuspendLayout();
            this.editRoutePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cars
            // 
            this.cars.Controls.Add(this.cancel);
            this.cars.Controls.Add(this.editCar);
            this.cars.Controls.Add(this.exit);
            this.cars.Controls.Add(this.save);
            this.cars.Controls.Add(this.carsList);
            this.cars.Controls.Add(this.deleteCar);
            this.cars.Controls.Add(this.addNewCar);
            this.cars.Location = new System.Drawing.Point(12, 12);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(170, 134);
            this.cars.TabIndex = 1;
            this.cars.TabStop = false;
            this.cars.Text = "Cars";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(60, 102);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(48, 22);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
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
            this.exit.Location = new System.Drawing.Point(114, 102);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 22);
            this.exit.TabIndex = 6;
            this.exit.Text = "Back";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 102);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 22);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // carsList
            // 
            this.carsList.FormattingEnabled = true;
            this.carsList.Location = new System.Drawing.Point(6, 19);
            this.carsList.Name = "carsList";
            this.carsList.Size = new System.Drawing.Size(156, 21);
            this.carsList.TabIndex = 2;
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
            // addNewCar
            // 
            this.addNewCar.Location = new System.Drawing.Point(6, 74);
            this.addNewCar.Name = "addNewCar";
            this.addNewCar.Size = new System.Drawing.Size(156, 22);
            this.addNewCar.TabIndex = 1;
            this.addNewCar.Text = "Register car";
            this.addNewCar.UseVisualStyleBackColor = true;
            // 
            // editRoutePanel
            // 
            this.editRoutePanel.Controls.Add(this.wpList);
            this.editRoutePanel.Controls.Add(this.carCompany);
            this.editRoutePanel.Controls.Add(this.companyLbl);
            this.editRoutePanel.Controls.Add(this.routesList);
            this.editRoutePanel.Controls.Add(this.carID);
            this.editRoutePanel.Controls.Add(this.cancelChanges);
            this.editRoutePanel.Controls.Add(this.exitCar);
            this.editRoutePanel.Controls.Add(this.applyCar);
            this.editRoutePanel.Location = new System.Drawing.Point(188, 12);
            this.editRoutePanel.Name = "editRoutePanel";
            this.editRoutePanel.Size = new System.Drawing.Size(299, 134);
            this.editRoutePanel.TabIndex = 2;
            this.editRoutePanel.TabStop = false;
            this.editRoutePanel.Text = "Edite route";
            // 
            // wpList
            // 
            this.wpList.FormattingEnabled = true;
            this.wpList.Location = new System.Drawing.Point(171, 19);
            this.wpList.Name = "wpList";
            this.wpList.Size = new System.Drawing.Size(120, 108);
            this.wpList.TabIndex = 17;
            // 
            // carCompany
            // 
            this.carCompany.Location = new System.Drawing.Point(66, 48);
            this.carCompany.Name = "carCompany";
            this.carCompany.Size = new System.Drawing.Size(99, 20);
            this.carCompany.TabIndex = 16;
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Location = new System.Drawing.Point(6, 51);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(54, 13);
            this.companyLbl.TabIndex = 15;
            this.companyLbl.Text = "Company:";
            // 
            // routesList
            // 
            this.routesList.FormattingEnabled = true;
            this.routesList.Location = new System.Drawing.Point(9, 76);
            this.routesList.Name = "routesList";
            this.routesList.Size = new System.Drawing.Size(156, 21);
            this.routesList.TabIndex = 9;
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.Location = new System.Drawing.Point(6, 22);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(0, 13);
            this.carID.TabIndex = 14;
            // 
            // cancelChanges
            // 
            this.cancelChanges.Location = new System.Drawing.Point(63, 102);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(48, 22);
            this.cancelChanges.TabIndex = 9;
            this.cancelChanges.Text = "Cancel";
            this.cancelChanges.UseVisualStyleBackColor = true;
            // 
            // exitCar
            // 
            this.exitCar.Location = new System.Drawing.Point(117, 102);
            this.exitCar.Name = "exitCar";
            this.exitCar.Size = new System.Drawing.Size(48, 22);
            this.exitCar.TabIndex = 8;
            this.exitCar.Text = "OK";
            this.exitCar.UseVisualStyleBackColor = true;
            // 
            // applyCar
            // 
            this.applyCar.Location = new System.Drawing.Point(9, 102);
            this.applyCar.Name = "applyCar";
            this.applyCar.Size = new System.Drawing.Size(48, 22);
            this.applyCar.TabIndex = 10;
            this.applyCar.Text = "Apply";
            this.applyCar.UseVisualStyleBackColor = true;
            // 
            // CarsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 151);
            this.Controls.Add(this.editRoutePanel);
            this.Controls.Add(this.cars);
            this.Name = "CarsManagement";
            this.Text = "CarManagement";
            this.cars.ResumeLayout(false);
            this.editRoutePanel.ResumeLayout(false);
            this.editRoutePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cars;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button editCar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox carsList;
        private System.Windows.Forms.Button deleteCar;
        private System.Windows.Forms.Button addNewCar;
        private System.Windows.Forms.GroupBox editRoutePanel;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button exitCar;
        private System.Windows.Forms.Button applyCar;
        private System.Windows.Forms.Label carID;
        private System.Windows.Forms.ComboBox routesList;
        private System.Windows.Forms.Label companyLbl;
        private System.Windows.Forms.TextBox carCompany;
        private System.Windows.Forms.ListBox wpList;
    }
}