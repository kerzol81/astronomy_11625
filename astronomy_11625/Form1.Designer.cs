
namespace astronomy_11625
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
            this.listBox_space_objects = new System.Windows.Forms.ListBox();
            this.listBox_m = new System.Windows.Forms.ListBox();
            this.button_new_so = new System.Windows.Forms.Button();
            this.button_edit_so = new System.Windows.Forms.Button();
            this.button_del_so = new System.Windows.Forms.Button();
            this.button_new_m = new System.Windows.Forms.Button();
            this.button_edit_m = new System.Windows.Forms.Button();
            this.button_del_m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_space_objects
            // 
            this.listBox_space_objects.FormattingEnabled = true;
            this.listBox_space_objects.Location = new System.Drawing.Point(13, 13);
            this.listBox_space_objects.Name = "listBox_space_objects";
            this.listBox_space_objects.Size = new System.Drawing.Size(187, 316);
            this.listBox_space_objects.TabIndex = 0;
            // 
            // listBox_m
            // 
            this.listBox_m.FormattingEnabled = true;
            this.listBox_m.Location = new System.Drawing.Point(225, 13);
            this.listBox_m.Name = "listBox_m";
            this.listBox_m.Size = new System.Drawing.Size(187, 316);
            this.listBox_m.TabIndex = 1;
            // 
            // button_new_so
            // 
            this.button_new_so.Location = new System.Drawing.Point(13, 336);
            this.button_new_so.Name = "button_new_so";
            this.button_new_so.Size = new System.Drawing.Size(75, 23);
            this.button_new_so.TabIndex = 2;
            this.button_new_so.Text = "New";
            this.button_new_so.UseVisualStyleBackColor = true;
            this.button_new_so.Click += new System.EventHandler(this.button_new_so_Click);
            // 
            // button_edit_so
            // 
            this.button_edit_so.Location = new System.Drawing.Point(13, 365);
            this.button_edit_so.Name = "button_edit_so";
            this.button_edit_so.Size = new System.Drawing.Size(75, 23);
            this.button_edit_so.TabIndex = 3;
            this.button_edit_so.Text = "Edit";
            this.button_edit_so.UseVisualStyleBackColor = true;
            this.button_edit_so.Click += new System.EventHandler(this.button_edit_so_Click);
            // 
            // button_del_so
            // 
            this.button_del_so.Location = new System.Drawing.Point(13, 394);
            this.button_del_so.Name = "button_del_so";
            this.button_del_so.Size = new System.Drawing.Size(75, 23);
            this.button_del_so.TabIndex = 4;
            this.button_del_so.Text = "Del";
            this.button_del_so.UseVisualStyleBackColor = true;
            this.button_del_so.Click += new System.EventHandler(this.button_del_so_Click);
            // 
            // button_new_m
            // 
            this.button_new_m.Location = new System.Drawing.Point(225, 335);
            this.button_new_m.Name = "button_new_m";
            this.button_new_m.Size = new System.Drawing.Size(75, 23);
            this.button_new_m.TabIndex = 5;
            this.button_new_m.Text = "New";
            this.button_new_m.UseVisualStyleBackColor = true;
            // 
            // button_edit_m
            // 
            this.button_edit_m.Location = new System.Drawing.Point(225, 364);
            this.button_edit_m.Name = "button_edit_m";
            this.button_edit_m.Size = new System.Drawing.Size(75, 23);
            this.button_edit_m.TabIndex = 6;
            this.button_edit_m.Text = "Edit";
            this.button_edit_m.UseVisualStyleBackColor = true;
            // 
            // button_del_m
            // 
            this.button_del_m.Location = new System.Drawing.Point(225, 393);
            this.button_del_m.Name = "button_del_m";
            this.button_del_m.Size = new System.Drawing.Size(75, 23);
            this.button_del_m.TabIndex = 7;
            this.button_del_m.Text = "Del";
            this.button_del_m.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 477);
            this.Controls.Add(this.button_del_m);
            this.Controls.Add(this.button_edit_m);
            this.Controls.Add(this.button_new_m);
            this.Controls.Add(this.button_del_so);
            this.Controls.Add(this.button_edit_so);
            this.Controls.Add(this.button_new_so);
            this.Controls.Add(this.listBox_m);
            this.Controls.Add(this.listBox_space_objects);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_space_objects;
        private System.Windows.Forms.ListBox listBox_m;
        private System.Windows.Forms.Button button_new_so;
        private System.Windows.Forms.Button button_edit_so;
        private System.Windows.Forms.Button button_del_so;
        private System.Windows.Forms.Button button_new_m;
        private System.Windows.Forms.Button button_edit_m;
        private System.Windows.Forms.Button button_del_m;
    }
}

