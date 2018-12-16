namespace TransportLab
{
    partial class LoadForm
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
            this.SerializerTypes = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerializerTypes
            // 
            this.SerializerTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerializerTypes.FormattingEnabled = true;
            this.SerializerTypes.Location = new System.Drawing.Point(160, 12);
            this.SerializerTypes.Name = "SerializerTypes";
            this.SerializerTypes.Size = new System.Drawing.Size(68, 21);
            this.SerializerTypes.TabIndex = 5;
            this.SerializerTypes.SelectedIndexChanged += new System.EventHandler(this.SerializerTypes_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(160, 91);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(68, 20);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(160, 39);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(68, 20);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(12, 12);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(142, 108);
            this.FilesList.TabIndex = 8;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(160, 65);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(68, 20);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 163);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SerializerTypes);
            this.Name = "LoadForm";
            this.Text = "Load";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SerializerTypes;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.Button Delete;
    }
}