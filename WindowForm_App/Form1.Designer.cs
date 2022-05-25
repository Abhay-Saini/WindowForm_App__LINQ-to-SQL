
namespace WindowForm_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDLable = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GenderLable = new System.Windows.Forms.Label();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.AgeLable = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.ClassLable = new System.Windows.Forms.Label();
            this.StandardTextBox = new System.Windows.Forms.TextBox();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Details";
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLable.Location = new System.Drawing.Point(113, 91);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(23, 17);
            this.IDLable.TabIndex = 1;
            this.IDLable.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(228, 90);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(157, 20);
            this.IDTextBox.TabIndex = 2;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLable.Location = new System.Drawing.Point(113, 130);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(49, 17);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Name";
            this.NameLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(228, 129);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(157, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // GenderLable
            // 
            this.GenderLable.AutoSize = true;
            this.GenderLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLable.Location = new System.Drawing.Point(113, 168);
            this.GenderLable.Name = "GenderLable";
            this.GenderLable.Size = new System.Drawing.Size(62, 17);
            this.GenderLable.TabIndex = 1;
            this.GenderLable.Text = "Gender";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(228, 167);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(157, 20);
            this.GenderTextBox.TabIndex = 2;
            // 
            // AgeLable
            // 
            this.AgeLable.AutoSize = true;
            this.AgeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLable.Location = new System.Drawing.Point(113, 208);
            this.AgeLable.Name = "AgeLable";
            this.AgeLable.Size = new System.Drawing.Size(36, 17);
            this.AgeLable.TabIndex = 1;
            this.AgeLable.Text = "Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(228, 207);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(157, 20);
            this.AgeTextBox.TabIndex = 2;
            // 
            // ClassLable
            // 
            this.ClassLable.AutoSize = true;
            this.ClassLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLable.Location = new System.Drawing.Point(113, 256);
            this.ClassLable.Name = "ClassLable";
            this.ClassLable.Size = new System.Drawing.Size(47, 17);
            this.ClassLable.TabIndex = 1;
            this.ClassLable.Text = "Class";
            // 
            // StandardTextBox
            // 
            this.StandardTextBox.Location = new System.Drawing.Point(228, 253);
            this.StandardTextBox.Name = "StandardTextBox";
            this.StandardTextBox.Size = new System.Drawing.Size(157, 20);
            this.StandardTextBox.TabIndex = 2;
            // 
            // Previousbutton
            // 
            this.Previousbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previousbutton.Location = new System.Drawing.Point(127, 314);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(90, 30);
            this.Previousbutton.TabIndex = 4;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.Location = new System.Drawing.Point(270, 314);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(90, 30);
            this.Nextbutton.TabIndex = 4;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 419);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.StandardTextBox);
            this.Controls.Add(this.ClassLable);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLable);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.GenderLable);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLable;
        private  System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label GenderLable;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.Label AgeLable;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label ClassLable;
        private System.Windows.Forms.TextBox StandardTextBox;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
    }
}

