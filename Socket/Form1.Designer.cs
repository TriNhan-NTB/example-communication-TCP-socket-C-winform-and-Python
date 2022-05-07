
namespace Socket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_send = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_data_recv = new System.Windows.Forms.TextBox();
            this.button_recv = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(223, 58);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(86, 39);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(111, 63);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(94, 29);
            this.connect.TabIndex = 1;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(223, 112);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(125, 27);
            this.textBox_send.TabIndex = 2;
            // 
            // textBox_data_recv
            // 
            this.textBox_data_recv.Location = new System.Drawing.Point(397, 112);
            this.textBox_data_recv.Name = "textBox_data_recv";
            this.textBox_data_recv.Size = new System.Drawing.Size(125, 27);
            this.textBox_data_recv.TabIndex = 3;
            // 
            // button_recv
            // 
            this.button_recv.Location = new System.Drawing.Point(411, 63);
            this.button_recv.Name = "button_recv";
            this.button_recv.Size = new System.Drawing.Size(86, 39);
            this.button_recv.TabIndex = 4;
            this.button_recv.Text = "recv";
            this.button_recv.UseVisualStyleBackColor = true;
            this.button_recv.Click += new System.EventHandler(this.button_recv_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(111, 112);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(94, 29);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_recv);
            this.Controls.Add(this.textBox_data_recv);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.button_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_data_recv;
        private System.Windows.Forms.Button button_recv;
        private System.Windows.Forms.Button button_disconnect;
    }
}

