namespace Lab2
{
    partial class RoutesManagement
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
            this.routes = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.editRoute = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.routeIdIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.routesList = new System.Windows.Forms.ComboBox();
            this.deleteRoute = new System.Windows.Forms.Button();
            this.addNewRoute = new System.Windows.Forms.Button();
            this.editRoutePanel = new System.Windows.Forms.GroupBox();
            this.cancelRoute = new System.Windows.Forms.Button();
            this.deleteWp = new System.Windows.Forms.Button();
            this.exitRoute = new System.Windows.Forms.Button();
            this.editWp = new System.Windows.Forms.Button();
            this.saveRoute = new System.Windows.Forms.Button();
            this.selectedWpAdressIn = new System.Windows.Forms.TextBox();
            this.selectedWpAdressLbl = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.wpList = new System.Windows.Forms.ListBox();
            this.addNewWp = new System.Windows.Forms.Button();
            this.newWpAdressIn = new System.Windows.Forms.TextBox();
            this.newWpAdressLbl = new System.Windows.Forms.Label();
            this.routes.SuspendLayout();
            this.editRoutePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // routes
            // 
            this.routes.Controls.Add(this.cancel);
            this.routes.Controls.Add(this.editRoute);
            this.routes.Controls.Add(this.exit);
            this.routes.Controls.Add(this.save);
            this.routes.Controls.Add(this.routeIdIn);
            this.routes.Controls.Add(this.label1);
            this.routes.Controls.Add(this.routesList);
            this.routes.Controls.Add(this.deleteRoute);
            this.routes.Controls.Add(this.addNewRoute);
            this.routes.Location = new System.Drawing.Point(12, 12);
            this.routes.Name = "routes";
            this.routes.Size = new System.Drawing.Size(170, 158);
            this.routes.TabIndex = 0;
            this.routes.TabStop = false;
            this.routes.Text = "Routes";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(60, 128);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(48, 22);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // editRoute
            // 
            this.editRoute.Location = new System.Drawing.Point(6, 46);
            this.editRoute.Name = "editRoute";
            this.editRoute.Size = new System.Drawing.Size(75, 22);
            this.editRoute.TabIndex = 8;
            this.editRoute.Text = "Edit";
            this.editRoute.UseVisualStyleBackColor = true;
            this.editRoute.Click += new System.EventHandler(this.editRoute_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(114, 128);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 22);
            this.exit.TabIndex = 6;
            this.exit.Text = "Back";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 128);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 22);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // routeIdIn
            // 
            this.routeIdIn.Location = new System.Drawing.Point(59, 74);
            this.routeIdIn.Name = "routeIdIn";
            this.routeIdIn.Size = new System.Drawing.Size(103, 20);
            this.routeIdIn.TabIndex = 7;
            this.routeIdIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.routeIdIn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Route id:";
            // 
            // routesList
            // 
            this.routesList.FormattingEnabled = true;
            this.routesList.Location = new System.Drawing.Point(6, 19);
            this.routesList.Name = "routesList";
            this.routesList.Size = new System.Drawing.Size(156, 21);
            this.routesList.TabIndex = 2;
            this.routesList.SelectedIndexChanged += new System.EventHandler(this.routesList_SelectedIndexChanged);
            // 
            // deleteRoute
            // 
            this.deleteRoute.Location = new System.Drawing.Point(87, 46);
            this.deleteRoute.Name = "deleteRoute";
            this.deleteRoute.Size = new System.Drawing.Size(75, 22);
            this.deleteRoute.TabIndex = 2;
            this.deleteRoute.Text = "Delete";
            this.deleteRoute.UseVisualStyleBackColor = true;
            this.deleteRoute.Click += new System.EventHandler(this.deleteRoute_Click);
            // 
            // addNewRoute
            // 
            this.addNewRoute.Location = new System.Drawing.Point(6, 100);
            this.addNewRoute.Name = "addNewRoute";
            this.addNewRoute.Size = new System.Drawing.Size(156, 22);
            this.addNewRoute.TabIndex = 1;
            this.addNewRoute.Text = "Create route";
            this.addNewRoute.UseVisualStyleBackColor = true;
            this.addNewRoute.Click += new System.EventHandler(this.createRoute_Click);
            // 
            // editRoutePanel
            // 
            this.editRoutePanel.Controls.Add(this.cancelRoute);
            this.editRoutePanel.Controls.Add(this.deleteWp);
            this.editRoutePanel.Controls.Add(this.exitRoute);
            this.editRoutePanel.Controls.Add(this.editWp);
            this.editRoutePanel.Controls.Add(this.saveRoute);
            this.editRoutePanel.Controls.Add(this.selectedWpAdressIn);
            this.editRoutePanel.Controls.Add(this.selectedWpAdressLbl);
            this.editRoutePanel.Controls.Add(this.down);
            this.editRoutePanel.Controls.Add(this.up);
            this.editRoutePanel.Controls.Add(this.wpList);
            this.editRoutePanel.Controls.Add(this.addNewWp);
            this.editRoutePanel.Controls.Add(this.newWpAdressIn);
            this.editRoutePanel.Controls.Add(this.newWpAdressLbl);
            this.editRoutePanel.Location = new System.Drawing.Point(188, 12);
            this.editRoutePanel.Name = "editRoutePanel";
            this.editRoutePanel.Size = new System.Drawing.Size(319, 158);
            this.editRoutePanel.TabIndex = 1;
            this.editRoutePanel.TabStop = false;
            this.editRoutePanel.Text = "Edite route";
            // 
            // cancelRoute
            // 
            this.cancelRoute.Location = new System.Drawing.Point(60, 128);
            this.cancelRoute.Name = "cancelRoute";
            this.cancelRoute.Size = new System.Drawing.Size(48, 22);
            this.cancelRoute.TabIndex = 9;
            this.cancelRoute.Text = "Cancel";
            this.cancelRoute.UseVisualStyleBackColor = true;
            this.cancelRoute.Click += new System.EventHandler(this.cancelRoute_Click);
            // 
            // deleteWp
            // 
            this.deleteWp.Location = new System.Drawing.Point(87, 100);
            this.deleteWp.Name = "deleteWp";
            this.deleteWp.Size = new System.Drawing.Size(75, 22);
            this.deleteWp.TabIndex = 12;
            this.deleteWp.Text = "Delete";
            this.deleteWp.UseVisualStyleBackColor = true;
            this.deleteWp.Click += new System.EventHandler(this.deleteSelectedWp_Click);
            // 
            // exitRoute
            // 
            this.exitRoute.Location = new System.Drawing.Point(114, 128);
            this.exitRoute.Name = "exitRoute";
            this.exitRoute.Size = new System.Drawing.Size(48, 22);
            this.exitRoute.TabIndex = 8;
            this.exitRoute.Text = "OK";
            this.exitRoute.UseVisualStyleBackColor = true;
            this.exitRoute.Click += new System.EventHandler(this.exitRoute_Click);
            // 
            // editWp
            // 
            this.editWp.Location = new System.Drawing.Point(6, 100);
            this.editWp.Name = "editWp";
            this.editWp.Size = new System.Drawing.Size(75, 22);
            this.editWp.TabIndex = 13;
            this.editWp.Text = "Edit";
            this.editWp.UseVisualStyleBackColor = true;
            this.editWp.Click += new System.EventHandler(this.editSelectedWpAdress_Click);
            // 
            // saveRoute
            // 
            this.saveRoute.Location = new System.Drawing.Point(6, 128);
            this.saveRoute.Name = "saveRoute";
            this.saveRoute.Size = new System.Drawing.Size(48, 22);
            this.saveRoute.TabIndex = 10;
            this.saveRoute.Text = "Apply";
            this.saveRoute.UseVisualStyleBackColor = true;
            this.saveRoute.Click += new System.EventHandler(this.saveRoute_Click);
            // 
            // selectedWpAdressIn
            // 
            this.selectedWpAdressIn.Location = new System.Drawing.Point(51, 74);
            this.selectedWpAdressIn.Name = "selectedWpAdressIn";
            this.selectedWpAdressIn.Size = new System.Drawing.Size(111, 20);
            this.selectedWpAdressIn.TabIndex = 11;
            this.selectedWpAdressIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wpAdressIn_KeyPress);
            // 
            // selectedWpAdressLbl
            // 
            this.selectedWpAdressLbl.AutoSize = true;
            this.selectedWpAdressLbl.Location = new System.Drawing.Point(3, 77);
            this.selectedWpAdressLbl.Name = "selectedWpAdressLbl";
            this.selectedWpAdressLbl.Size = new System.Drawing.Size(42, 13);
            this.selectedWpAdressLbl.TabIndex = 10;
            this.selectedWpAdressLbl.Text = "Adress:";
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(294, 86);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(21, 64);
            this.down.TabIndex = 5;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(294, 16);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(21, 64);
            this.up.TabIndex = 4;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // wpList
            // 
            this.wpList.FormattingEnabled = true;
            this.wpList.Location = new System.Drawing.Point(168, 16);
            this.wpList.Name = "wpList";
            this.wpList.Size = new System.Drawing.Size(120, 134);
            this.wpList.TabIndex = 3;
            this.wpList.SelectedIndexChanged += new System.EventHandler(this.wpList_SelectedIndexChanged);
            // 
            // addNewWp
            // 
            this.addNewWp.Location = new System.Drawing.Point(6, 46);
            this.addNewWp.Name = "addNewWp";
            this.addNewWp.Size = new System.Drawing.Size(156, 22);
            this.addNewWp.TabIndex = 2;
            this.addNewWp.Text = "Add waypoint";
            this.addNewWp.UseVisualStyleBackColor = true;
            this.addNewWp.Click += new System.EventHandler(this.addNewWp_Click);
            // 
            // newWpAdressIn
            // 
            this.newWpAdressIn.Location = new System.Drawing.Point(51, 19);
            this.newWpAdressIn.Name = "newWpAdressIn";
            this.newWpAdressIn.Size = new System.Drawing.Size(111, 20);
            this.newWpAdressIn.TabIndex = 1;
            this.newWpAdressIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wpAdressIn_KeyPress);
            // 
            // newWpAdressLbl
            // 
            this.newWpAdressLbl.AutoSize = true;
            this.newWpAdressLbl.Location = new System.Drawing.Point(3, 23);
            this.newWpAdressLbl.Name = "newWpAdressLbl";
            this.newWpAdressLbl.Size = new System.Drawing.Size(42, 13);
            this.newWpAdressLbl.TabIndex = 0;
            this.newWpAdressLbl.Text = "Adress:";
            // 
            // RoutesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 174);
            this.Controls.Add(this.editRoutePanel);
            this.Controls.Add(this.routes);
            this.Name = "RoutesManagement";
            this.Text = "Routes Management";
            this.routes.ResumeLayout(false);
            this.routes.PerformLayout();
            this.editRoutePanel.ResumeLayout(false);
            this.editRoutePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox routes;
        private System.Windows.Forms.ComboBox routesList;
        private System.Windows.Forms.Button deleteRoute;
        private System.Windows.Forms.Button addNewRoute;
        private System.Windows.Forms.GroupBox editRoutePanel;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.ListBox wpList;
        private System.Windows.Forms.Button addNewWp;
        private System.Windows.Forms.TextBox newWpAdressIn;
        private System.Windows.Forms.Label newWpAdressLbl;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox routeIdIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedWpAdressIn;
        private System.Windows.Forms.Label selectedWpAdressLbl;
        private System.Windows.Forms.Button deleteWp;
        private System.Windows.Forms.Button editWp;
        private System.Windows.Forms.Button editRoute;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button cancelRoute;
        private System.Windows.Forms.Button exitRoute;
        private System.Windows.Forms.Button saveRoute;
    }
}