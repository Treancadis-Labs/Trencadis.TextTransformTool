namespace Trencadis.Tools.TextTransformations.Demo
{
    partial class Form1
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
            this.grpTransformationsSetup = new System.Windows.Forms.GroupBox();
            this.lblTransformationsFile = new System.Windows.Forms.Label();
            this.txtTransformationsFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectTransformationsFile = new System.Windows.Forms.Button();
            this.txtTransformationsDefinitionsContent = new System.Windows.Forms.RichTextBox();
            this.lblActiveTransformations = new System.Windows.Forms.Label();
            this.dlgOpenTransformationsFile = new System.Windows.Forms.OpenFileDialog();
            this.grpTransformationInput = new System.Windows.Forms.GroupBox();
            this.btnSelectInputFile = new System.Windows.Forms.Button();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblInputContent = new System.Windows.Forms.Label();
            this.txtInputContent = new System.Windows.Forms.RichTextBox();
            this.btnApplyTransformations = new System.Windows.Forms.Button();
            this.dlgOpenInputFile = new System.Windows.Forms.OpenFileDialog();
            this.grpTransformationResult = new System.Windows.Forms.GroupBox();
            this.btnSaveResultsBackToFile = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpTransformationsSetup.SuspendLayout();
            this.grpTransformationInput.SuspendLayout();
            this.grpTransformationResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTransformationsSetup
            // 
            this.grpTransformationsSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTransformationsSetup.Controls.Add(this.btnApplyTransformations);
            this.grpTransformationsSetup.Controls.Add(this.lblActiveTransformations);
            this.grpTransformationsSetup.Controls.Add(this.txtTransformationsDefinitionsContent);
            this.grpTransformationsSetup.Controls.Add(this.btnSelectTransformationsFile);
            this.grpTransformationsSetup.Controls.Add(this.txtTransformationsFilePath);
            this.grpTransformationsSetup.Controls.Add(this.lblTransformationsFile);
            this.grpTransformationsSetup.Location = new System.Drawing.Point(12, 12);
            this.grpTransformationsSetup.Name = "grpTransformationsSetup";
            this.grpTransformationsSetup.Size = new System.Drawing.Size(300, 512);
            this.grpTransformationsSetup.TabIndex = 0;
            this.grpTransformationsSetup.TabStop = false;
            this.grpTransformationsSetup.Text = " :: Transformations :: ";
            // 
            // lblTransformationsFile
            // 
            this.lblTransformationsFile.AutoSize = true;
            this.lblTransformationsFile.Location = new System.Drawing.Point(7, 20);
            this.lblTransformationsFile.Name = "lblTransformationsFile";
            this.lblTransformationsFile.Size = new System.Drawing.Size(153, 13);
            this.lblTransformationsFile.TabIndex = 0;
            this.lblTransformationsFile.Text = "Select transformations from file:";
            // 
            // txtTransformationsFilePath
            // 
            this.txtTransformationsFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransformationsFilePath.Enabled = false;
            this.txtTransformationsFilePath.Location = new System.Drawing.Point(7, 38);
            this.txtTransformationsFilePath.Name = "txtTransformationsFilePath";
            this.txtTransformationsFilePath.Size = new System.Drawing.Size(241, 20);
            this.txtTransformationsFilePath.TabIndex = 1;
            // 
            // btnSelectTransformationsFile
            // 
            this.btnSelectTransformationsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTransformationsFile.Location = new System.Drawing.Point(258, 37);
            this.btnSelectTransformationsFile.Name = "btnSelectTransformationsFile";
            this.btnSelectTransformationsFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectTransformationsFile.TabIndex = 2;
            this.btnSelectTransformationsFile.Text = " ... ";
            this.btnSelectTransformationsFile.UseVisualStyleBackColor = true;
            this.btnSelectTransformationsFile.Click += new System.EventHandler(this.btnSelectTransformationsFile_Click);
            // 
            // txtTransformationsDefinitionsContent
            // 
            this.txtTransformationsDefinitionsContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransformationsDefinitionsContent.Location = new System.Drawing.Point(7, 88);
            this.txtTransformationsDefinitionsContent.Name = "txtTransformationsDefinitionsContent";
            this.txtTransformationsDefinitionsContent.Size = new System.Drawing.Size(276, 383);
            this.txtTransformationsDefinitionsContent.TabIndex = 3;
            this.txtTransformationsDefinitionsContent.Text = "";
            // 
            // lblActiveTransformations
            // 
            this.lblActiveTransformations.AutoSize = true;
            this.lblActiveTransformations.Location = new System.Drawing.Point(7, 64);
            this.lblActiveTransformations.Name = "lblActiveTransformations";
            this.lblActiveTransformations.Size = new System.Drawing.Size(159, 13);
            this.lblActiveTransformations.TabIndex = 4;
            this.lblActiveTransformations.Text = "Transformations definitions (xml):";
            // 
            // dlgOpenTransformationsFile
            // 
            this.dlgOpenTransformationsFile.Filter = "Xml files|*.xml|All files|*.*";
            // 
            // grpTransformationInput
            // 
            this.grpTransformationInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTransformationInput.Controls.Add(this.lblInputContent);
            this.grpTransformationInput.Controls.Add(this.txtInputContent);
            this.grpTransformationInput.Controls.Add(this.btnSelectInputFile);
            this.grpTransformationInput.Controls.Add(this.txtInputFilePath);
            this.grpTransformationInput.Controls.Add(this.lblInputFile);
            this.grpTransformationInput.Location = new System.Drawing.Point(318, 12);
            this.grpTransformationInput.Name = "grpTransformationInput";
            this.grpTransformationInput.Size = new System.Drawing.Size(300, 512);
            this.grpTransformationInput.TabIndex = 1;
            this.grpTransformationInput.TabStop = false;
            this.grpTransformationInput.Text = " :: Apply transformations to :: ";
            // 
            // btnSelectInputFile
            // 
            this.btnSelectInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectInputFile.Location = new System.Drawing.Point(260, 37);
            this.btnSelectInputFile.Name = "btnSelectInputFile";
            this.btnSelectInputFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectInputFile.TabIndex = 5;
            this.btnSelectInputFile.Text = " ... ";
            this.btnSelectInputFile.UseVisualStyleBackColor = true;
            this.btnSelectInputFile.Click += new System.EventHandler(this.btnSelectInputFile_Click);
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFilePath.Enabled = false;
            this.txtInputFilePath.Location = new System.Drawing.Point(6, 38);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(248, 20);
            this.txtInputFilePath.TabIndex = 4;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(6, 20);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(153, 13);
            this.lblInputFile.TabIndex = 3;
            this.lblInputFile.Text = "Select transformations from file:";
            // 
            // lblInputContent
            // 
            this.lblInputContent.AutoSize = true;
            this.lblInputContent.Location = new System.Drawing.Point(6, 64);
            this.lblInputContent.Name = "lblInputContent";
            this.lblInputContent.Size = new System.Drawing.Size(34, 13);
            this.lblInputContent.TabIndex = 7;
            this.lblInputContent.Text = "Input:";
            // 
            // txtInputContent
            // 
            this.txtInputContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputContent.Location = new System.Drawing.Point(6, 88);
            this.txtInputContent.Name = "txtInputContent";
            this.txtInputContent.Size = new System.Drawing.Size(282, 383);
            this.txtInputContent.TabIndex = 6;
            this.txtInputContent.Text = "";
            // 
            // btnApplyTransformations
            // 
            this.btnApplyTransformations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyTransformations.Location = new System.Drawing.Point(121, 477);
            this.btnApplyTransformations.Name = "btnApplyTransformations";
            this.btnApplyTransformations.Size = new System.Drawing.Size(162, 23);
            this.btnApplyTransformations.TabIndex = 5;
            this.btnApplyTransformations.Text = "Apply Transformations";
            this.btnApplyTransformations.UseVisualStyleBackColor = true;
            this.btnApplyTransformations.Click += new System.EventHandler(this.btnApplyTransformations_Click);
            // 
            // dlgOpenInputFile
            // 
            this.dlgOpenInputFile.Filter = "Config Files|*.config|Text files|*.txt|All files|*.*";
            // 
            // grpTransformationResult
            // 
            this.grpTransformationResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTransformationResult.Controls.Add(this.btnSaveResultsBackToFile);
            this.grpTransformationResult.Controls.Add(this.lblResults);
            this.grpTransformationResult.Controls.Add(this.txtResults);
            this.grpTransformationResult.Location = new System.Drawing.Point(625, 12);
            this.grpTransformationResult.Name = "grpTransformationResult";
            this.grpTransformationResult.Size = new System.Drawing.Size(300, 512);
            this.grpTransformationResult.TabIndex = 2;
            this.grpTransformationResult.TabStop = false;
            this.grpTransformationResult.Text = " :: Transformation results :: ";
            // 
            // btnSaveResultsBackToFile
            // 
            this.btnSaveResultsBackToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveResultsBackToFile.Location = new System.Drawing.Point(126, 477);
            this.btnSaveResultsBackToFile.Name = "btnSaveResultsBackToFile";
            this.btnSaveResultsBackToFile.Size = new System.Drawing.Size(162, 23);
            this.btnSaveResultsBackToFile.TabIndex = 8;
            this.btnSaveResultsBackToFile.Text = "Save back to file";
            this.btnSaveResultsBackToFile.UseVisualStyleBackColor = true;
            this.btnSaveResultsBackToFile.Click += new System.EventHandler(this.btnSaveResultsBackToFile_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(6, 38);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(282, 433);
            this.txtResults.TabIndex = 6;
            this.txtResults.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(6, 20);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 536);
            this.Controls.Add(this.grpTransformationResult);
            this.Controls.Add(this.grpTransformationInput);
            this.Controls.Add(this.grpTransformationsSetup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTransformationsSetup.ResumeLayout(false);
            this.grpTransformationsSetup.PerformLayout();
            this.grpTransformationInput.ResumeLayout(false);
            this.grpTransformationInput.PerformLayout();
            this.grpTransformationResult.ResumeLayout(false);
            this.grpTransformationResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTransformationsSetup;
        private System.Windows.Forms.Label lblActiveTransformations;
        private System.Windows.Forms.RichTextBox txtTransformationsDefinitionsContent;
        private System.Windows.Forms.Button btnSelectTransformationsFile;
        private System.Windows.Forms.TextBox txtTransformationsFilePath;
        private System.Windows.Forms.Label lblTransformationsFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenTransformationsFile;
        private System.Windows.Forms.GroupBox grpTransformationInput;
        private System.Windows.Forms.Button btnSelectInputFile;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.Label lblInputContent;
        private System.Windows.Forms.RichTextBox txtInputContent;
        private System.Windows.Forms.Button btnApplyTransformations;
        private System.Windows.Forms.OpenFileDialog dlgOpenInputFile;
        private System.Windows.Forms.GroupBox grpTransformationResult;
        private System.Windows.Forms.Button btnSaveResultsBackToFile;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RichTextBox txtResults;
    }
}

