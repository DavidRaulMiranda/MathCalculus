
namespace MathCalculus
{
    partial class btnMCD
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
            this.btnNumbers = new System.Windows.Forms.Button();
            this.btnMCM = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnCMD = new System.Windows.Forms.Button();
            this.lblRndL = new System.Windows.Forms.Label();
            this.lblRNDr = new System.Windows.Forms.Label();
            this.lblResCMD = new System.Windows.Forms.Label();
            this.lblResMCM = new System.Windows.Forms.Label();
            this.lvResult = new System.Windows.Forms.ListView();
            this.lbl_secCalc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNumbers
            // 
            this.btnNumbers.Location = new System.Drawing.Point(61, 61);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(91, 23);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnMCM
            // 
            this.btnMCM.Location = new System.Drawing.Point(61, 163);
            this.btnMCM.Name = "btnMCM";
            this.btnMCM.Size = new System.Drawing.Size(91, 23);
            this.btnMCM.TabIndex = 2;
            this.btnMCM.Text = "M.C.M";
            this.btnMCM.UseVisualStyleBackColor = true;
            this.btnMCM.Click += new System.EventHandler(this.btnMCM_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(61, 202);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(91, 23);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "Set de Calculs";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(61, 124);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(91, 23);
            this.btnCMD.TabIndex = 4;
            this.btnCMD.Text = "C.M.D";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // lblRndL
            // 
            this.lblRndL.AutoSize = true;
            this.lblRndL.Location = new System.Drawing.Point(194, 66);
            this.lblRndL.Name = "lblRndL";
            this.lblRndL.Size = new System.Drawing.Size(0, 13);
            this.lblRndL.TabIndex = 5;
            // 
            // lblRNDr
            // 
            this.lblRNDr.AutoSize = true;
            this.lblRNDr.Location = new System.Drawing.Point(259, 66);
            this.lblRNDr.Name = "lblRNDr";
            this.lblRNDr.Size = new System.Drawing.Size(0, 13);
            this.lblRNDr.TabIndex = 6;
            // 
            // lblResCMD
            // 
            this.lblResCMD.AutoSize = true;
            this.lblResCMD.Location = new System.Drawing.Point(259, 124);
            this.lblResCMD.Name = "lblResCMD";
            this.lblResCMD.Size = new System.Drawing.Size(0, 13);
            this.lblResCMD.TabIndex = 7;
            // 
            // lblResMCM
            // 
            this.lblResMCM.AutoSize = true;
            this.lblResMCM.Location = new System.Drawing.Point(259, 173);
            this.lblResMCM.Name = "lblResMCM";
            this.lblResMCM.Size = new System.Drawing.Size(0, 13);
            this.lblResMCM.TabIndex = 8;
            // 
            // lvResult
            // 
            this.lvResult.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(171, 228);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(332, 181);
            this.lvResult.TabIndex = 9;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.List;
            // 
            // lbl_secCalc
            // 
            this.lbl_secCalc.AutoSize = true;
            this.lbl_secCalc.Location = new System.Drawing.Point(168, 212);
            this.lbl_secCalc.Name = "lbl_secCalc";
            this.lbl_secCalc.Size = new System.Drawing.Size(45, 13);
            this.lbl_secCalc.TabIndex = 10;
            this.lbl_secCalc.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Results MCM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Results CMD:";
            // 
            // btnMCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_secCalc);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.lblResMCM);
            this.Controls.Add(this.lblResCMD);
            this.Controls.Add(this.lblRNDr);
            this.Controls.Add(this.lblRndL);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.btnMCM);
            this.Controls.Add(this.btnNumbers);
            this.Name = "btnMCD";
            this.Text = "M.C.D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Button btnMCM;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Label lblRndL;
        private System.Windows.Forms.Label lblRNDr;
        private System.Windows.Forms.Label lblResCMD;
        private System.Windows.Forms.Label lblResMCM;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.Label lbl_secCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

