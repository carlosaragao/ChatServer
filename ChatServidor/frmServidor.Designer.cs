namespace ChatServidor
{
    partial class frmServidor
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(103, 35);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(180, 20);
            this.txtIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço IP";
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Enabled = false;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLog.Location = new System.Drawing.Point(12, 94);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(400, 275);
            this.txtLog.TabIndex = 3;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtender.BackgroundImage = global::ChatServidor.Properties.Resources.inicatendimento32002W;
            this.btnAtender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtender.CausesValidation = false;
            this.btnAtender.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtender.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAtender.Location = new System.Drawing.Point(348, 10);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(64, 64);
            this.btnAtender.TabIndex = 1;
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.txtIP);
            this.Name = "frmServidor";
            this.Text = "Chat Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
    }
}

