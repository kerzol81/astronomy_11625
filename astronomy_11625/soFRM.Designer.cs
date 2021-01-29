
namespace astronomy_11625
{
    partial class soFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.numericUpDown_perimeter = new System.Windows.Forms.NumericUpDown();
            this.comboBox_material = new System.Windows.Forms.ComboBox();
            this.comboBox_crosses = new System.Windows.Forms.ComboBox();
            this.comboBox_insolar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_perimeter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perimeter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crosses Earth\'s Orbit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "In Solar System:";
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(25, 183);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(158, 183);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(137, 19);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(96, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // numericUpDown_perimeter
            // 
            this.numericUpDown_perimeter.DecimalPlaces = 1;
            this.numericUpDown_perimeter.Location = new System.Drawing.Point(137, 53);
            this.numericUpDown_perimeter.Name = "numericUpDown_perimeter";
            this.numericUpDown_perimeter.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown_perimeter.TabIndex = 2;
            this.numericUpDown_perimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_perimeter.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // comboBox_material
            // 
            this.comboBox_material.FormattingEnabled = true;
            this.comboBox_material.Location = new System.Drawing.Point(137, 81);
            this.comboBox_material.Name = "comboBox_material";
            this.comboBox_material.Size = new System.Drawing.Size(96, 21);
            this.comboBox_material.TabIndex = 3;
            // 
            // comboBox_crosses
            // 
            this.comboBox_crosses.FormattingEnabled = true;
            this.comboBox_crosses.Location = new System.Drawing.Point(137, 116);
            this.comboBox_crosses.Name = "comboBox_crosses";
            this.comboBox_crosses.Size = new System.Drawing.Size(96, 21);
            this.comboBox_crosses.TabIndex = 4;
            // 
            // comboBox_insolar
            // 
            this.comboBox_insolar.FormattingEnabled = true;
            this.comboBox_insolar.Location = new System.Drawing.Point(137, 147);
            this.comboBox_insolar.Name = "comboBox_insolar";
            this.comboBox_insolar.Size = new System.Drawing.Size(96, 21);
            this.comboBox_insolar.TabIndex = 5;
            // 
            // soFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 228);
            this.Controls.Add(this.comboBox_insolar);
            this.Controls.Add(this.comboBox_crosses);
            this.Controls.Add(this.comboBox_material);
            this.Controls.Add(this.numericUpDown_perimeter);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "soFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Object";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_perimeter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.NumericUpDown numericUpDown_perimeter;
        private System.Windows.Forms.ComboBox comboBox_material;
        private System.Windows.Forms.ComboBox comboBox_crosses;
        private System.Windows.Forms.ComboBox comboBox_insolar;
    }
}