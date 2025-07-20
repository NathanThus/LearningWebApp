namespace CSharp_Form
{
    partial class MainForm
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tB_URL = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.tB_Database = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lB_Results = new System.Windows.Forms.ListBox();
            this.btn_Request = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.tB_ConnectionState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 85);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(230, 23);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tB_URL
            // 
            this.tB_URL.Location = new System.Drawing.Point(50, 6);
            this.tB_URL.Name = "tB_URL";
            this.tB_URL.Size = new System.Drawing.Size(195, 20);
            this.tB_URL.TabIndex = 1;
            this.tB_URL.Text = "http://localhost:3000/";
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Location = new System.Drawing.Point(12, 9);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(32, 13);
            this.lbl_URL.TabIndex = 2;
            this.lbl_URL.Text = "URL:";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(12, 36);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(24, 13);
            this.lbl_Database.TabIndex = 3;
            this.lbl_Database.Text = "API";
            // 
            // tB_Database
            // 
            this.tB_Database.Location = new System.Drawing.Point(50, 33);
            this.tB_Database.Name = "tB_Database";
            this.tB_Database.Size = new System.Drawing.Size(195, 20);
            this.tB_Database.TabIndex = 4;
            this.tB_Database.Text = "randomtest";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(251, 6);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "Result";
            // 
            // lB_Results
            // 
            this.lB_Results.FormattingEnabled = true;
            this.lB_Results.Location = new System.Drawing.Point(251, 23);
            this.lB_Results.Name = "lB_Results";
            this.lB_Results.Size = new System.Drawing.Size(376, 381);
            this.lB_Results.TabIndex = 6;
            // 
            // btn_Request
            // 
            this.btn_Request.Location = new System.Drawing.Point(15, 212);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(230, 23);
            this.btn_Request.TabIndex = 7;
            this.btn_Request.Text = "Request";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(12, 114);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(230, 23);
            this.btn_Disconnect.TabIndex = 8;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // tB_ConnectionState
            // 
            this.tB_ConnectionState.BackColor = System.Drawing.Color.Red;
            this.tB_ConnectionState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ConnectionState.Location = new System.Drawing.Point(12, 59);
            this.tB_ConnectionState.Name = "tB_ConnectionState";
            this.tB_ConnectionState.ReadOnly = true;
            this.tB_ConnectionState.Size = new System.Drawing.Size(233, 20);
            this.tB_ConnectionState.TabIndex = 9;
            this.tB_ConnectionState.Text = "NOT CONNECTED";
            this.tB_ConnectionState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 416);
            this.Controls.Add(this.tB_ConnectionState);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Request);
            this.Controls.Add(this.lB_Results);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.tB_Database);
            this.Controls.Add(this.lbl_Database);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.tB_URL);
            this.Controls.Add(this.btn_Connect);
            this.Name = "MainForm";
            this.Text = "Test Database Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tB_URL;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox tB_Database;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.ListBox lB_Results;
        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox tB_ConnectionState;
    }
}

