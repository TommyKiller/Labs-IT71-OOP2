namespace TransportLab
{
    partial class SaveForm
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
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.FileNameIn = new System.Windows.Forms.TextBox();
            this.SerializerTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(86, 38);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(54, 20);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(146, 38);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(54, 20);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FileNameIn
            // 
            this.FileNameIn.Location = new System.Drawing.Point(12, 12);
            this.FileNameIn.Name = "FileNameIn";
            this.FileNameIn.Size = new System.Drawing.Size(114, 20);
            this.FileNameIn.TabIndex = 3;
            this.FileNameIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputFilter_KeyPress);
            // 
            // SerializerTypes
            // 
            this.SerializerTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerializerTypes.FormattingEnabled = true;
            this.SerializerTypes.Location = new System.Drawing.Point(132, 11);
            this.SerializerTypes.Name = "SerializerTypes";
            this.SerializerTypes.Size = new System.Drawing.Size(68, 21);
            this.SerializerTypes.TabIndex = 4;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 68);
            this.Controls.Add(this.SerializerTypes);
            this.Controls.Add(this.FileNameIn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Name = "SaveForm";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox FileNameIn;
        private System.Windows.Forms.ComboBox SerializerTypes;
    }
}