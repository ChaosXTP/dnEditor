namespace dnEditor.Forms
{
    partial class EditInstructionForm
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
            this.cbOpCode = new System.Windows.Forms.ComboBox();
            this.lblFlowControl = new System.Windows.Forms.Label();
            this.lblOpCodeType = new System.Windows.Forms.Label();
            this.lblOperandType = new System.Windows.Forms.Label();
            this.cbOperand = new System.Windows.Forms.ComboBox();
            this.lblOperand = new System.Windows.Forms.Label();
            this.lblOpCode = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOpCodeDescription = new System.Windows.Forms.Label();
            this.cbOperandType = new System.Windows.Forms.ComboBox();
            this.lblOperandType2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectOperand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOpCode
            // 
            this.cbOpCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOpCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOpCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpCode.FormattingEnabled = true;
            this.cbOpCode.Location = new System.Drawing.Point(77, 12);
            this.cbOpCode.Name = "cbOpCode";
            this.cbOpCode.Size = new System.Drawing.Size(183, 21);
            this.cbOpCode.TabIndex = 0;
            this.cbOpCode.SelectedIndexChanged += new System.EventHandler(this.cbOpCode_SelectedIndexChanged);
            // 
            // lblFlowControl
            // 
            this.lblFlowControl.AutoSize = true;
            this.lblFlowControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowControl.ForeColor = System.Drawing.Color.White;
            this.lblFlowControl.Location = new System.Drawing.Point(103, 61);
            this.lblFlowControl.Name = "lblFlowControl";
            this.lblFlowControl.Size = new System.Drawing.Size(0, 16);
            this.lblFlowControl.TabIndex = 1;
            // 
            // lblOpCodeType
            // 
            this.lblOpCodeType.AutoSize = true;
            this.lblOpCodeType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpCodeType.ForeColor = System.Drawing.Color.White;
            this.lblOpCodeType.Location = new System.Drawing.Point(103, 77);
            this.lblOpCodeType.Name = "lblOpCodeType";
            this.lblOpCodeType.Size = new System.Drawing.Size(0, 16);
            this.lblOpCodeType.TabIndex = 1;
            // 
            // lblOperandType
            // 
            this.lblOperandType.AutoSize = true;
            this.lblOperandType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperandType.ForeColor = System.Drawing.Color.White;
            this.lblOperandType.Location = new System.Drawing.Point(103, 93);
            this.lblOperandType.Name = "lblOperandType";
            this.lblOperandType.Size = new System.Drawing.Size(0, 16);
            this.lblOperandType.TabIndex = 1;
            // 
            // cbOperand
            // 
            this.cbOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperand.DropDownWidth = 500;
            this.cbOperand.FormattingEnabled = true;
            this.cbOperand.Location = new System.Drawing.Point(79, 179);
            this.cbOperand.Name = "cbOperand";
            this.cbOperand.Size = new System.Drawing.Size(315, 21);
            this.cbOperand.TabIndex = 0;
            // 
            // lblOperand
            // 
            this.lblOperand.AutoSize = true;
            this.lblOperand.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand.ForeColor = System.Drawing.Color.White;
            this.lblOperand.Location = new System.Drawing.Point(14, 182);
            this.lblOperand.Name = "lblOperand";
            this.lblOperand.Size = new System.Drawing.Size(59, 16);
            this.lblOperand.TabIndex = 1;
            this.lblOperand.Text = "Operand";
            // 
            // lblOpCode
            // 
            this.lblOpCode.AutoSize = true;
            this.lblOpCode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpCode.ForeColor = System.Drawing.Color.White;
            this.lblOpCode.Location = new System.Drawing.Point(14, 15);
            this.lblOpCode.Name = "lblOpCode";
            this.lblOpCode.Size = new System.Drawing.Size(57, 16);
            this.lblOpCode.TabIndex = 1;
            this.lblOpCode.Text = "OpCode";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(138, 215);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(219, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOpCodeDescription
            // 
            this.lblOpCodeDescription.AutoSize = true;
            this.lblOpCodeDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpCodeDescription.ForeColor = System.Drawing.Color.White;
            this.lblOpCodeDescription.Location = new System.Drawing.Point(94, 109);
            this.lblOpCodeDescription.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblOpCodeDescription.Name = "lblOpCodeDescription";
            this.lblOpCodeDescription.Size = new System.Drawing.Size(0, 16);
            this.lblOpCodeDescription.TabIndex = 3;
            // 
            // cbOperandType
            // 
            this.cbOperandType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOperandType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperandType.FormattingEnabled = true;
            this.cbOperandType.Items.AddRange(new object[] {
            "[None]",
            "Byte",
            "SByte",
            "Int32",
            "Int64",
            "Single",
            "Double",
            "String",
            "-> Instruction reference",
            "-> Multiple instructions reference",
            "-> Variable reference",
            "-> Parameter reference",
            "-> Field reference",
            "-> Method reference",
            "-> Type reference"});
            this.cbOperandType.Location = new System.Drawing.Point(107, 152);
            this.cbOperandType.Name = "cbOperandType";
            this.cbOperandType.Size = new System.Drawing.Size(326, 21);
            this.cbOperandType.TabIndex = 0;
            this.cbOperandType.SelectedIndexChanged += new System.EventHandler(this.cbOperandType_SelectedIndexChanged);
            // 
            // lblOperandType2
            // 
            this.lblOperandType2.AutoSize = true;
            this.lblOperandType2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperandType2.ForeColor = System.Drawing.Color.White;
            this.lblOperandType2.Location = new System.Drawing.Point(14, 155);
            this.lblOperandType2.Name = "lblOperandType2";
            this.lblOperandType2.Size = new System.Drawing.Size(87, 16);
            this.lblOperandType2.TabIndex = 1;
            this.lblOperandType2.Text = "Operand type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FlowControl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "OpCodeType:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "OperandType:";
            // 
            // btnSelectOperand
            // 
            this.btnSelectOperand.Location = new System.Drawing.Point(400, 179);
            this.btnSelectOperand.Name = "btnSelectOperand";
            this.btnSelectOperand.Size = new System.Drawing.Size(33, 21);
            this.btnSelectOperand.TabIndex = 4;
            this.btnSelectOperand.Text = "...";
            this.btnSelectOperand.UseVisualStyleBackColor = true;
            this.btnSelectOperand.Click += new System.EventHandler(this.btnSelectOperand_Click);
            // 
            // EditInstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(451, 250);
            this.Controls.Add(this.btnSelectOperand);
            this.Controls.Add(this.lblOpCodeDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOperandType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOpCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFlowControl);
            this.Controls.Add(this.cbOpCode);
            this.Controls.Add(this.lblOperandType2);
            this.Controls.Add(this.lblOperand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOpCode);
            this.Controls.Add(this.cbOperandType);
            this.Controls.Add(this.cbOperand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditInstructionForm";
            this.Text = "Edit Instruction";
            this.Load += new System.EventHandler(this.EditInstructionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOpCode;
        private System.Windows.Forms.Label lblFlowControl;
        private System.Windows.Forms.Label lblOpCodeType;
        private System.Windows.Forms.Label lblOperandType;
        private System.Windows.Forms.ComboBox cbOperand;
        private System.Windows.Forms.Label lblOperand;
        private System.Windows.Forms.Label lblOpCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOpCodeDescription;
        private System.Windows.Forms.ComboBox cbOperandType;
        private System.Windows.Forms.Label lblOperandType2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectOperand;
    }
}