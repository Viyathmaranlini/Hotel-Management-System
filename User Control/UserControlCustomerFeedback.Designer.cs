
namespace hotel_management.User_Control
{
    partial class UserControlCustomerFeedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCancellation = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsernamecC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCancellation
            // 
            this.labelCancellation.AutoSize = true;
            this.labelCancellation.BackColor = System.Drawing.Color.Transparent;
            this.labelCancellation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancellation.Location = new System.Drawing.Point(38, 18);
            this.labelCancellation.Name = "labelCancellation";
            this.labelCancellation.Size = new System.Drawing.Size(130, 23);
            this.labelCancellation.TabIndex = 1;
            this.labelCancellation.Text = "Cancellation";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(182, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(456, 22);
            this.textBoxPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Name :";
            // 
            // textBoxUsernamecC
            // 
            this.textBoxUsernamecC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsernamecC.Location = new System.Drawing.Point(182, 100);
            this.textBoxUsernamecC.Name = "textBoxUsernamecC";
            this.textBoxUsernamecC.Size = new System.Drawing.Size(456, 22);
            this.textBoxUsernamecC.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resevation Id :";
            // 
            // UserControlCustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsernamecC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCancellation);
            this.Name = "UserControlCustomerFeedback";
            this.Size = new System.Drawing.Size(1102, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCancellation;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsernamecC;
        private System.Windows.Forms.Label label2;
    }
}
