namespace dnEditor.Forms
{
    partial class EditVariableForm
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
            this.cbVariableType = new System.Windows.Forms.ComboBox();
            this.lblVariableName = new System.Windows.Forms.Label();
            this.lblVariableType = new System.Windows.Forms.Label();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeSpecification = new System.Windows.Forms.ComboBox();
            this.btnVariableType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVariableType
            // 
            this.cbVariableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbVariableType.Enabled = false;
            this.cbVariableType.Location = new System.Drawing.Point(99, 40);
            this.cbVariableType.Name = "cbVariableType";
            this.cbVariableType.Size = new System.Drawing.Size(291, 21);
            this.cbVariableType.TabIndex = 1;
            // 
            // lblVariableName
            // 
            this.lblVariableName.AutoSize = true;
            this.lblVariableName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableName.ForeColor = System.Drawing.Color.White;
            this.lblVariableName.Location = new System.Drawing.Point(11, 17);
            this.lblVariableName.Name = "lblVariableName";
            this.lblVariableName.Size = new System.Drawing.Size(41, 16);
            this.lblVariableName.TabIndex = 2;
            this.lblVariableName.Text = "Name";
            // 
            // lblVariableType
            // 
            this.lblVariableType.AutoSize = true;
            this.lblVariableType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableType.ForeColor = System.Drawing.Color.White;
            this.lblVariableType.Location = new System.Drawing.Point(11, 43);
            this.lblVariableType.Name = "lblVariableType";
            this.lblVariableType.Size = new System.Drawing.Size(82, 16);
            this.lblVariableType.TabIndex = 2;
            this.lblVariableType.Text = "Variable Type";
            // 
            // txtVariableName
            // 
            this.txtVariableName.Location = new System.Drawing.Point(58, 14);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(374, 20);
            this.txtVariableName.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(226, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(145, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type specification";
            // 
            // cbTypeSpecification
            // 
            this.cbTypeSpecification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeSpecification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeSpecification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSpecification.FormattingEnabled = true;
            this.cbTypeSpecification.Items.AddRange(new object[] {
            "None",
            "Array",
            "Multi-dimensional array",
            "Reference",
            "Pointer"});
            this.cbTypeSpecification.Location = new System.Drawing.Point(122, 67);
            this.cbTypeSpecification.Name = "cbTypeSpecification";
            this.cbTypeSpecification.Size = new System.Drawing.Size(199, 21);
            this.cbTypeSpecification.TabIndex = 1;
            // 
            // btnVariableType
            // 
            this.btnVariableType.Location = new System.Drawing.Point(399, 39);
            this.btnVariableType.Name = "btnVariableType";
            this.btnVariableType.Size = new System.Drawing.Size(33, 21);
            this.btnVariableType.TabIndex = 6;
            this.btnVariableType.Text = "...";
            this.btnVariableType.UseVisualStyleBackColor = true;
            this.btnVariableType.Click += new System.EventHandler(this.btnVariableType_Click);
            // 
            // EditVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(444, 143);
            this.Controls.Add(this.btnVariableType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtVariableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVariableType);
            this.Controls.Add(this.lblVariableName);
            this.Controls.Add(this.cbTypeSpecification);
            this.Controls.Add(this.cbVariableType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditVariableForm";
            this.Text = "Edit Variable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVariableType;
        private System.Windows.Forms.Label lblVariableName;
        private System.Windows.Forms.Label lblVariableType;
        private System.Windows.Forms.TextBox txtVariableName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeSpecification;
        private System.Windows.Forms.Button btnVariableType;
    }
}