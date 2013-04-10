namespace FreshTemplateGenerator
{
    partial class FreshTemplateGenerator
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
            this.txtHtmlOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblValidate = new System.Windows.Forms.Label();
            this.span = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHtmlOutput
            // 
            this.txtHtmlOutput.Location = new System.Drawing.Point(12, 235);
            this.txtHtmlOutput.Multiline = true;
            this.txtHtmlOutput.Name = "txtHtmlOutput";
            this.txtHtmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtmlOutput.Size = new System.Drawing.Size(875, 226);
            this.txtHtmlOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Html output";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(812, 206);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToOrderColumns = true;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.span,
            this.node,
            this.value});
            this.dgvInput.Location = new System.Drawing.Point(12, 50);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.Size = new System.Drawing.Size(875, 150);
            this.dgvInput.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 34);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input";
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(65, 34);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(55, 13);
            this.lblValidate.TabIndex = 4;
            this.lblValidate.Text = "lblValidate";
            // 
            // span
            // 
            this.span.HeaderText = "Span";
            this.span.Name = "span";
            // 
            // node
            // 
            this.node.HeaderText = "Node";
            this.node.Name = "node";
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            // 
            // FreshTemplateGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 513);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHtmlOutput);
            this.Name = "FreshTemplateGenerator";
            this.Text = "Fresh Template Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHtmlOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn span;
        private System.Windows.Forms.DataGridViewTextBoxColumn node;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}

