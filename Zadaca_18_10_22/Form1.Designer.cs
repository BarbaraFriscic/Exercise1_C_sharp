namespace Zadaca_18_10_22
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
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalcReturn = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblReturnOrder = new System.Windows.Forms.Label();
            this.txtDrawers = new System.Windows.Forms.TextBox();
            this.txtWoodTyp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Location = new System.Drawing.Point(71, 30);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(135, 13);
            this.lblInstruction1.TabIndex = 0;
            this.lblInstruction1.Text = "Pritisnite dugme za izračun:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 72);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "OK";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalcReturn
            // 
            this.lblCalcReturn.AutoSize = true;
            this.lblCalcReturn.Location = new System.Drawing.Point(58, 115);
            this.lblCalcReturn.Name = "lblCalcReturn";
            this.lblCalcReturn.Size = new System.Drawing.Size(0, 13);
            this.lblCalcReturn.TabIndex = 2;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Location = new System.Drawing.Point(464, 30);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(100, 13);
            this.lblInstruction2.TabIndex = 3;
            this.lblInstruction2.Text = "Koliko ladica želite?";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Location = new System.Drawing.Point(390, 81);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(174, 13);
            this.lblInstruction3.TabIndex = 4;
            this.lblInstruction3.Text = "Koji tip drva - H(rast), B(or) ili J(avor)";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(489, 124);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Naruči";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblReturnOrder
            // 
            this.lblReturnOrder.AutoSize = true;
            this.lblReturnOrder.Location = new System.Drawing.Point(390, 152);
            this.lblReturnOrder.Name = "lblReturnOrder";
            this.lblReturnOrder.Size = new System.Drawing.Size(0, 13);
            this.lblReturnOrder.TabIndex = 6;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Location = new System.Drawing.Point(586, 27);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(68, 20);
            this.txtDrawers.TabIndex = 7;
            // 
            // txtWoodTyp
            // 
            this.txtWoodTyp.Location = new System.Drawing.Point(586, 75);
            this.txtWoodTyp.Name = "txtWoodTyp";
            this.txtWoodTyp.Size = new System.Drawing.Size(68, 20);
            this.txtWoodTyp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWoodTyp);
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.lblReturnOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblInstruction3);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblCalcReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblInstruction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalcReturn;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblReturnOrder;
        private System.Windows.Forms.TextBox txtDrawers;
        private System.Windows.Forms.TextBox txtWoodTyp;
    }
}

