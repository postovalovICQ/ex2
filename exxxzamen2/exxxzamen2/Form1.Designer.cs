namespace exxxzamen2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRASCHET = new System.Windows.Forms.Label();
            this.txtINPUT = new System.Windows.Forms.TextBox();
            this.btnCALCULATION = new System.Windows.Forms.Button();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRASCHET
            // 
            this.lblRASCHET.CausesValidation = false;
            this.lblRASCHET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRASCHET.Location = new System.Drawing.Point(12, 9);
            this.lblRASCHET.Name = "lblRASCHET";
            this.lblRASCHET.Size = new System.Drawing.Size(242, 58);
            this.lblRASCHET.TabIndex = 0;
            this.lblRASCHET.Text = "Введите трехзначное число и нажмите кпопку \"РАСЧЕТ\"";
            this.lblRASCHET.UseCompatibleTextRendering = true;
            this.lblRASCHET.UseMnemonic = false;
            this.lblRASCHET.UseWaitCursor = true;
            // 
            // txtINPUT
            // 
            this.txtINPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtINPUT.Location = new System.Drawing.Point(12, 59);
            this.txtINPUT.Name = "txtINPUT";
            this.txtINPUT.Size = new System.Drawing.Size(121, 22);
            this.txtINPUT.TabIndex = 1;
            this.txtINPUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINPUT_KeyPress);
            // 
            // btnCALCULATION
            // 
            this.btnCALCULATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCALCULATION.Location = new System.Drawing.Point(12, 99);
            this.btnCALCULATION.Name = "btnCALCULATION";
            this.btnCALCULATION.Size = new System.Drawing.Size(90, 32);
            this.btnCALCULATION.TabIndex = 2;
            this.btnCALCULATION.Text = "Расчет";
            this.btnCALCULATION.UseVisualStyleBackColor = true;
            this.btnCALCULATION.Click += new System.EventHandler(this.btnCALCULATION_Click);
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl100.Location = new System.Drawing.Point(9, 161);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(157, 16);
            this.lbl100.TabIndex = 3;
            this.lbl100.Text = "В этом числе сотен:";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl10.Location = new System.Drawing.Point(9, 201);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(182, 16);
            this.lbl10.TabIndex = 4;
            this.lbl10.Text = "В этом числе десятков:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(9, 242);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(168, 16);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "В этом числе единиц:";
            // 
            // txt100
            // 
            this.txt100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt100.Location = new System.Drawing.Point(172, 161);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(100, 22);
            this.txt100.TabIndex = 6;
            // 
            // txt10
            // 
            this.txt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt10.Location = new System.Drawing.Point(197, 201);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(100, 22);
            this.txt10.TabIndex = 7;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1.Location = new System.Drawing.Point(183, 242);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 288);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.btnCALCULATION);
            this.Controls.Add(this.txtINPUT);
            this.Controls.Add(this.lblRASCHET);
            this.Name = "Form1";
            this.Text = "Цифры трехзначного числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRASCHET;
        private System.Windows.Forms.TextBox txtINPUT;
        private System.Windows.Forms.Button btnCALCULATION;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt1;
    }
}

