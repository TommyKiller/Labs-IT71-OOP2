namespace Lab2
{
    partial class EditRouteTaxi
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
            this.editCarPanel = new System.Windows.Forms.GroupBox();
            this.typesList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.editCarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editCarPanel
            // 
            this.editCarPanel.Controls.Add(this.typesList);
            this.editCarPanel.Controls.Add(this.label4);
            this.editCarPanel.Controls.Add(this.carIDIn);
            this.editCarPanel.Controls.Add(this.label3);
            this.editCarPanel.Controls.Add(this.fuelConsumptionIn);
            this.editCarPanel.Controls.Add(this.label2);
            this.editCarPanel.Controls.Add(this.fuelCapacityIn);
            this.editCarPanel.Controls.Add(this.label1);
            this.editCarPanel.Controls.Add(this.wpList);
            this.editCarPanel.Controls.Add(this.carCompanyIn);
            this.editCarPanel.Controls.Add(this.companyLbl);
            this.editCarPanel.Controls.Add(this.routesList);
            this.editCarPanel.Controls.Add(this.cancelChanges);
            this.editCarPanel.Controls.Add(this.saveChanges);
            this.editCarPanel.Location = new System.Drawing.Point(12, 12);
            this.editCarPanel.Name = "editCarPanel";
            this.editCarPanel.Size = new System.Drawing.Size(300, 189);
            this.editCarPanel.TabIndex = 3;
            this.editCarPanel.TabStop = false;
            this.editCarPanel.Text = "Edit";
            // 
            // typesList
            // 
            this.typesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesList.FormattingEnabled = true;
            this.typesList.Location = new System.Drawing.Point(74, 19);
            this.typesList.Name = "typesList";
            this.typesList.Size = new System.Drawing.Size(91, 21);
            this.typesList.TabIndex = 25;
            this.typesList.SelectedIndexChanged += new System.EventHandler(this.typesList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Route type:";
            // 
            // carIDIn
            // 
            this.carIDIn.Location = new System.Drawing.Point(66, 73);
            this.carIDIn.Name = "carIDIn";
            this.carIDIn.Size = new System.Drawing.Size(99, 20);
            this.carIDIn.TabIndex = 23;
            this.carIDIn.TextChanged += new System.EventHandler(this.carIDIn_TextChanged);
            this.carIDIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Car ID:";
            // 
            // fuelConsumptionIn
            // 
            this.fuelConsumptionIn.Location = new System.Drawing.Point(105, 159);
            this.fuelConsumptionIn.Name = "fuelConsumptionIn";
            this.fuelConsumptionIn.Size = new System.Drawing.Size(60, 20);
            this.fuelConsumptionIn.TabIndex = 21;
            this.fuelConsumptionIn.TextChanged += new System.EventHandler(this.fuelConsumptionIn_TextChanged);
            this.fuelConsumptionIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fuel consumption:";
            // 
            // fuelCapacityIn
            // 
            this.fuelCapacityIn.Location = new System.Drawing.Point(105, 131);
            this.fuelCapacityIn.Name = "fuelCapacityIn";
            this.fuelCapacityIn.Size = new System.Drawing.Size(60, 20);
            this.fuelCapacityIn.TabIndex = 19;
            this.fuelCapacityIn.TextChanged += new System.EventHandler(this.fuelCapacityIn_TextChanged);
            this.fuelCapacityIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitsIn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
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
            this.wpList.Size = new System.Drawing.Size(120, 134);
            this.wpList.TabIndex = 17;
            // 
            // carCompanyIn
            // 
            this.carCompanyIn.Location = new System.Drawing.Point(66, 103);
            this.carCompanyIn.Name = "carCompanyIn";
            this.carCompanyIn.Size = new System.Drawing.Size(99, 20);
            this.carCompanyIn.TabIndex = 16;
            this.carCompanyIn.TextChanged += new System.EventHandler(this.carCompanyIn_TextChanged);
            this.carCompanyIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carCompanyIn_KeyPress);
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Location = new System.Drawing.Point(6, 106);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(54, 13);
            this.companyLbl.TabIndex = 15;
            this.companyLbl.Text = "Company:";
            // 
            // routesList
            // 
            this.routesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routesList.FormattingEnabled = true;
            this.routesList.Location = new System.Drawing.Point(9, 46);
            this.routesList.Name = "routesList";
            this.routesList.Size = new System.Drawing.Size(156, 21);
            this.routesList.TabIndex = 9;
            this.routesList.SelectedIndexChanged += new System.EventHandler(this.routesList_SelectedIndexChanged);
            // 
            // cancelChanges
            // 
            this.cancelChanges.Location = new System.Drawing.Point(234, 159);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(57, 20);
            this.cancelChanges.TabIndex = 9;
            this.cancelChanges.Text = "Cancel";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.cancelChanges_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Enabled = false;
            this.saveChanges.Location = new System.Drawing.Point(171, 159);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(57, 20);
            this.saveChanges.TabIndex = 10;
            this.saveChanges.Text = "Save";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // EditRouteTaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 204);
            this.Controls.Add(this.editCarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditRouteTaxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.editCarPanel.ResumeLayout(false);
            this.editCarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editCarPanel;
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
        private System.Windows.Forms.ComboBox typesList;
        private System.Windows.Forms.Label label4;
    }
}