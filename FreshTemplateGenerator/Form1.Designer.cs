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
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHtmlOutput
            // 
            this.txtHtmlOutput.Location = new System.Drawing.Point(12, 258);
            this.txtHtmlOutput.Multiline = true;
            this.txtHtmlOutput.Name = "txtHtmlOutput";
            this.txtHtmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHtmlOutput.Size = new System.Drawing.Size(875, 226);
            this.txtHtmlOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Html output";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(812, 229);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(12, 12);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(512, 20);
            this.txtRows.TabIndex = 3;
            this.txtRows.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(533, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 4;
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(12, 67);
            this.txtValues.Multiline = true;
            this.txtValues.Name = "txtValues";
            this.txtValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValues.Size = new System.Drawing.Size(875, 156);
            this.txtValues.TabIndex = 5;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 51);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Value";
            // 
            // FreshTemplateGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 496);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHtmlOutput);
            this.Name = "FreshTemplateGenerator";
            this.Text = "Fresh Template Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHtmlOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Label lblValue;
    }
}

