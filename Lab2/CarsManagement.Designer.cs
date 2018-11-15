﻿namespace Lab2
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
            this.newCar = new System.Windows.Forms.Button();
            this.editRoutePanel = new System.Windows.Forms.GroupBox();
            this.fuelConsumptionIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelCapacityIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wpList = new System.Windows.Forms.ListBox();
            this.carCompanyIn = new System.Windows.Forms.TextBox();
            this.companyLbl = new System.Windows.Forms.Label();
            this.routesList = new System.Windows.Forms.ComboBox();
            this.carID = new System.Windows.Forms.Label();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.applyChanges = new System.Windows.Forms.Button();
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
            this.cars.Controls.Add(this.newCar);
            this.cars.Location = new System.Drawing.Point(12, 12);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(170, 130);
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
            this.exit.Location = new System.Drawing.Point(114, 102);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 22);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 102);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 22);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(6, 74);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(156, 22);
            this.newCar.TabIndex = 1;
            this.newCar.Text = "Register car";
            this.newCar.UseVisualStyleBackColor = true;
            this.newCar.Click += new System.EventHandler(this.newCar_Click);
            // 
            // editRoutePanel
            // 
            this.editRoutePanel.Controls.Add(this.fuelConsumptionIn);
            this.editRoutePanel.Controls.Add(this.label2);
            this.editRoutePanel.Controls.Add(this.fuelCapacityIn);
            this.editRoutePanel.Controls.Add(this.label1);
            this.editRoutePanel.Controls.Add(this.wpList);
            this.editRoutePanel.Controls.Add(this.carCompanyIn);
            this.editRoutePanel.Controls.Add(this.companyLbl);
            this.editRoutePanel.Controls.Add(this.routesList);
            this.editRoutePanel.Controls.Add(this.carID);
            this.editRoutePanel.Controls.Add(this.cancelChanges);
            this.editRoutePanel.Controls.Add(this.applyChanges);
            this.editRoutePanel.Location = new System.Drawing.Point(188, 12);
            this.editRoutePanel.Name = "editRoutePanel";
            this.editRoutePanel.Size = new System.Drawing.Size(299, 161);
            this.editRoutePanel.TabIndex = 2;
            this.editRoutePanel.TabStop = false;
            this.editRoutePanel.Text = "Edite car";
            // 
            // fuelConsumptionIn
            // 
            this.fuelConsumptionIn.Location = new System.Drawing.Point(105, 132);
            this.fuelConsumptionIn.Name = "fuelConsumptionIn";
            this.fuelConsumptionIn.Size = new System.Drawing.Size(60, 20);
            this.fuelConsumptionIn.TabIndex = 21;
            this.fuelConsumptionIn.TextChanged += new System.EventHandler(this.fuelConsumptionIn_TextChanged);
            this.fuelConsumptionIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fuel consumption:";
            // 
            // fuelCapacityIn
            // 
            this.fuelCapacityIn.Location = new System.Drawing.Point(105, 104);
            this.fuelCapacityIn.Name = "fuelCapacityIn";
            this.fuelCapacityIn.Size = new System.Drawing.Size(60, 20);
            this.fuelCapacityIn.TabIndex = 19;
            this.fuelCapacityIn.TextChanged += new System.EventHandler(this.fuelCapacityIn_TextChanged);
            this.fuelCapacityIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fuel capacity:";
            // 
            // wpList
            // 
            this.wpList.FormattingEnabled = true;
            this.wpList.Location = new System.Drawing.Point(171, 19);
            this.wpList.Name = "wpList";
            this.wpList.Size = new System.Drawing.Size(120, 108);
            this.wpList.TabIndex = 17;
            // 
            // carCompanyIn
            // 
            this.carCompanyIn.Location = new System.Drawing.Point(66, 76);
            this.carCompanyIn.Name = "carCompanyIn";
            this.carCompanyIn.Size = new System.Drawing.Size(99, 20);
            this.carCompanyIn.TabIndex = 16;
            this.carCompanyIn.TextChanged += new System.EventHandler(this.carCompanyIn_TextChanged);
            this.carCompanyIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carCompanyIn_KeyPress);
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Location = new System.Drawing.Point(6, 79);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(54, 13);
            this.companyLbl.TabIndex = 15;
            this.companyLbl.Text = "Company:";
            // 
            // routesList
            // 
            this.routesList.FormattingEnabled = true;
            this.routesList.Location = new System.Drawing.Point(6, 19);
            this.routesList.Name = "routesList";
            this.routesList.Size = new System.Drawing.Size(159, 21);
            this.routesList.TabIndex = 9;
            this.routesList.SelectedIndexChanged += new System.EventHandler(this.routesList_SelectedIndexChanged);
            // 
            // carID
            // 
            this.carID.AutoSize = true;
            this.carID.Location = new System.Drawing.Point(6, 50);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(43, 13);
            this.carID.TabIndex = 14;
            this.carID.Text = "Car ID: ";
            // 
            // cancelChanges
            // 
            this.cancelChanges.Location = new System.Drawing.Point(234, 133);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(57, 22);
            this.cancelChanges.TabIndex = 9;
            this.cancelChanges.Text = "Cancel";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.cancelChanges_Click);
            // 
            // applyChanges
            // 
            this.applyChanges.Location = new System.Drawing.Point(171, 133);
            this.applyChanges.Name = "applyChanges";
            this.applyChanges.Size = new System.Drawing.Size(57, 22);
            this.applyChanges.TabIndex = 10;
            this.applyChanges.Text = "Apply";
            this.applyChanges.UseVisualStyleBackColor = true;
            this.applyChanges.Click += new System.EventHandler(this.applyChanges_Click);
            // 
            // CarsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 179);
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
        private System.Windows.Forms.Button newCar;
        private System.Windows.Forms.GroupBox editRoutePanel;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button applyChanges;
        private System.Windows.Forms.Label carID;
        private System.Windows.Forms.ComboBox routesList;
        private System.Windows.Forms.Label companyLbl;
        private System.Windows.Forms.TextBox carCompanyIn;
        private System.Windows.Forms.ListBox wpList;
        private System.Windows.Forms.TextBox fuelConsumptionIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fuelCapacityIn;
        private System.Windows.Forms.Label label1;
    }
}