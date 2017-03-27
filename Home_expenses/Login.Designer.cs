namespace Home_expenses
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_pass2 = new System.Windows.Forms.TextBox();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.button_exit2 = new System.Windows.Forms.Button();
            this.button_sign2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_signUP = new System.Windows.Forms.Button();
            this.button_clear_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pass2
            // 
            this.textBox_pass2.Location = new System.Drawing.Point(114, 106);
            this.textBox_pass2.Name = "textBox_pass2";
            this.textBox_pass2.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass2.TabIndex = 20;
            this.textBox_pass2.UseSystemPasswordChar = true;
            // 
            // textBox_login2
            // 
            this.textBox_login2.Location = new System.Drawing.Point(114, 72);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(100, 20);
            this.textBox_login2.TabIndex = 19;
            // 
            // button_exit2
            // 
            this.button_exit2.Location = new System.Drawing.Point(26, 185);
            this.button_exit2.Name = "button_exit2";
            this.button_exit2.Size = new System.Drawing.Size(75, 23);
            this.button_exit2.TabIndex = 18;
            this.button_exit2.Text = "Exit";
            this.button_exit2.UseVisualStyleBackColor = true;
            this.button_exit2.Click += new System.EventHandler(this.button_exit2_Click);
            // 
            // button_sign2
            // 
            this.button_sign2.Location = new System.Drawing.Point(26, 152);
            this.button_sign2.Name = "button_sign2";
            this.button_sign2.Size = new System.Drawing.Size(75, 23);
            this.button_sign2.TabIndex = 17;
            this.button_sign2.Text = "Sign IN";
            this.button_sign2.UseVisualStyleBackColor = true;
            this.button_sign2.Click += new System.EventHandler(this.button_sign2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(95, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Authorization";
            // 
            // button_signUP
            // 
            this.button_signUP.Location = new System.Drawing.Point(277, 18);
            this.button_signUP.Name = "button_signUP";
            this.button_signUP.Size = new System.Drawing.Size(75, 23);
            this.button_signUP.TabIndex = 22;
            this.button_signUP.Text = "Sign Up";
            this.button_signUP.UseVisualStyleBackColor = true;
            this.button_signUP.Click += new System.EventHandler(this.button_signUP_Click);
            // 
            // button_clear_user
            // 
            this.button_clear_user.Location = new System.Drawing.Point(277, 185);
            this.button_clear_user.Name = "button_clear_user";
            this.button_clear_user.Size = new System.Drawing.Size(75, 23);
            this.button_clear_user.TabIndex = 23;
            this.button_clear_user.Text = "Clear users";
            this.button_clear_user.UseVisualStyleBackColor = true;
            this.button_clear_user.Click += new System.EventHandler(this.button_clear_user_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 226);
            this.Controls.Add(this.button_clear_user);
            this.Controls.Add(this.button_signUP);
            this.Controls.Add(this.textBox_pass2);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.button_exit2);
            this.Controls.Add(this.button_sign2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pass2;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.Button button_exit2;
        private System.Windows.Forms.Button button_sign2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_signUP;
        private System.Windows.Forms.Button button_clear_user;
    }
}