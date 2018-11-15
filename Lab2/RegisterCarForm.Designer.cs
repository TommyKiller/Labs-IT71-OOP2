namespace Lab2
{
    partial class RegisterCarForm
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
            this.editRoutePanel = new System.Windows.Forms.GroupBox();
            this.carIDIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fuelConsumptionIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelCapacityIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wpList = new System.Windows.Forms.ListBox();
            this.carCompanyIn = new System.Windows.Forms.TextBox();
            this.companyLbl = new System.Windows.Forms.Label();
            this.routesList = new System.Windows.Forms.ComboBox();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.editRoutePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editRoutePanel
            // 
            this.editRoutePanel.Controls.Add(this.carIDIn);
            this.editRoutePanel.Controls.Add(this.label3);
            this.editRoutePanel.Controls.Add(this.fuelConsumptionIn);
            this.editRoutePanel.Controls.Add(this.label2);
            this.editRoutePanel.Controls.Add(this.fuelCapacityIn);
            this.editRoutePanel.Controls.Add(this.label1);
            this.editRoutePanel.Controls.Add(this.wpList);
            this.editRoutePanel.Controls.Add(this.carCompanyIn);
            this.editRoutePanel.Controls.Add(this.companyLbl);
            this.editRoutePanel.Controls.Add(this.routesList);
            this.editRoutePanel.Controls.Add(this.cancelChanges);
            this.editRoutePanel.Controls.Add(this.saveChanges);
            this.editRoutePanel.Location = new System.Drawing.Point(12, 12);
            this.editRoutePanel.Name = "editRoutePanel";
            this.editRoutePanel.Size = new System.Drawing.Size(299, 161);
            this.editRoutePanel.TabIndex = 3;
            this.editRoutePanel.TabStop = false;
            this.editRoutePanel.Text = "Register car";
            // 
            // carIDIn
            // 
            this.carIDIn.Location = new System.Drawing.Point(66, 46);
            this.carIDIn.Name = "carIDIn";
            this.carIDIn.Size = new System.Drawing.Size(99, 20);
            this.carIDIn.TabIndex = 23;
            this.carIDIn.TextChanged += new System.EventHandler(this.carIDIn_TextChanged);
            this.carIDIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Car ID:";
            // 
            // fuelConsumptionIn
            // 
            this.fuelConsumptionIn.Location = new System.Drawing.Point(105, 132);
            this.fuelConsumptionIn.Name = "fuelConsumptionIn";
            this.fuelConsumptionIn.Size = new System.Drawing.Size(60, 20);
            this.fuelConsumptionIn.TabIndex = 21;
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
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(171, 133);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(57, 22);
            this.saveChanges.TabIndex = 10;
            this.saveChanges.Text = "Save";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // RegisterCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 177);
            this.Controls.Add(this.editRoutePanel);
            this.Name = "RegisterCar";
            this.Text = "RegisterCar";
            this.editRoutePanel.ResumeLayout(false);
            this.editRoutePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editRoutePanel;
        private System.Windows.Forms.TextBox fuelConsumptionIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fuelCapacityIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wpList;
        private System.Windows.Forms.TextBox carCompanyIn;
        private System.Windows.Forms.Label companyLbl;
        private System.Windows.Forms.ComboBox routesList;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox carIDIn;
        private System.Windows.Forms.Label label3;
    }
}