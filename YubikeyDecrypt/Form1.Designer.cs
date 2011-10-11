namespace YubikeyDecrypt
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
            this.lblAesKey = new System.Windows.Forms.Label();
            this.txtInputAesKey = new System.Windows.Forms.TextBox();
            this.lblOtp = new System.Windows.Forms.Label();
            this.txtInputOtp = new System.Windows.Forms.TextBox();
            this.lblCrc = new System.Windows.Forms.Label();
            this.txtOutputCrc = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblInputStatus = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutputPid = new System.Windows.Forms.TextBox();
            this.lblPid = new System.Windows.Forms.Label();
            this.txtOutputRandom = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.txtOutputSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.txtOutputUseCount = new System.Windows.Forms.TextBox();
            this.lblUseCount = new System.Windows.Forms.Label();
            this.txtOutputTimestamp = new System.Windows.Forms.TextBox();
            this.txtOutputTimestampH = new System.Windows.Forms.TextBox();
            this.txtOutputTimestampL = new System.Windows.Forms.TextBox();
            this.lblTimestampTot = new System.Windows.Forms.Label();
            this.lblTimestampH = new System.Windows.Forms.Label();
            this.lblTimestampL = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.txtOutputUidHex = new System.Windows.Forms.TextBox();
            this.txtOutputUid = new System.Windows.Forms.TextBox();
            this.lblUid = new System.Windows.Forms.Label();
            this.txtOutputHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAesKey
            // 
            this.lblAesKey.AutoSize = true;
            this.lblAesKey.Location = new System.Drawing.Point(6, 22);
            this.lblAesKey.Name = "lblAesKey";
            this.lblAesKey.Size = new System.Drawing.Size(48, 13);
            this.lblAesKey.TabIndex = 0;
            this.lblAesKey.Text = "AES key";
            // 
            // txtInputAesKey
            // 
            this.txtInputAesKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputAesKey.Location = new System.Drawing.Point(60, 19);
            this.txtInputAesKey.Name = "txtInputAesKey";
            this.txtInputAesKey.Size = new System.Drawing.Size(274, 20);
            this.txtInputAesKey.TabIndex = 1;
            this.txtInputAesKey.TextChanged += new System.EventHandler(this.txtInputAesKey_TextChanged);
            // 
            // lblOtp
            // 
            this.lblOtp.AutoSize = true;
            this.lblOtp.Location = new System.Drawing.Point(6, 48);
            this.lblOtp.Name = "lblOtp";
            this.lblOtp.Size = new System.Drawing.Size(29, 13);
            this.lblOtp.TabIndex = 2;
            this.lblOtp.Text = "OTP";
            // 
            // txtInputOtp
            // 
            this.txtInputOtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputOtp.Location = new System.Drawing.Point(60, 45);
            this.txtInputOtp.Name = "txtInputOtp";
            this.txtInputOtp.Size = new System.Drawing.Size(274, 20);
            this.txtInputOtp.TabIndex = 3;
            this.txtInputOtp.TextChanged += new System.EventHandler(this.txtInputOtp_TextChanged);
            // 
            // lblCrc
            // 
            this.lblCrc.AutoSize = true;
            this.lblCrc.Location = new System.Drawing.Point(6, 74);
            this.lblCrc.Name = "lblCrc";
            this.lblCrc.Size = new System.Drawing.Size(29, 13);
            this.lblCrc.TabIndex = 4;
            this.lblCrc.Text = "CRC";
            // 
            // txtOutputCrc
            // 
            this.txtOutputCrc.Location = new System.Drawing.Point(70, 71);
            this.txtOutputCrc.Name = "txtOutputCrc";
            this.txtOutputCrc.Size = new System.Drawing.Size(100, 20);
            this.txtOutputCrc.TabIndex = 5;
            this.txtOutputCrc.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.lblInputStatus);
            this.grpInput.Controls.Add(this.txtInputAesKey);
            this.grpInput.Controls.Add(this.lblAesKey);
            this.grpInput.Controls.Add(this.lblOtp);
            this.grpInput.Controls.Add(this.txtInputOtp);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(340, 93);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // lblInputStatus
            // 
            this.lblInputStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInputStatus.Location = new System.Drawing.Point(6, 73);
            this.lblInputStatus.Name = "lblInputStatus";
            this.lblInputStatus.Size = new System.Drawing.Size(328, 16);
            this.lblInputStatus.TabIndex = 4;
            this.lblInputStatus.Text = "Provide AES key and OTP";
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutputPid);
            this.grpOutput.Controls.Add(this.lblPid);
            this.grpOutput.Controls.Add(this.txtOutputRandom);
            this.grpOutput.Controls.Add(this.lblRandom);
            this.grpOutput.Controls.Add(this.txtOutputSession);
            this.grpOutput.Controls.Add(this.lblSession);
            this.grpOutput.Controls.Add(this.txtOutputUseCount);
            this.grpOutput.Controls.Add(this.lblUseCount);
            this.grpOutput.Controls.Add(this.txtOutputTimestamp);
            this.grpOutput.Controls.Add(this.txtOutputTimestampH);
            this.grpOutput.Controls.Add(this.txtOutputTimestampL);
            this.grpOutput.Controls.Add(this.lblTimestampTot);
            this.grpOutput.Controls.Add(this.lblTimestampH);
            this.grpOutput.Controls.Add(this.lblTimestampL);
            this.grpOutput.Controls.Add(this.lblTimestamp);
            this.grpOutput.Controls.Add(this.txtOutputUidHex);
            this.grpOutput.Controls.Add(this.txtOutputUid);
            this.grpOutput.Controls.Add(this.lblUid);
            this.grpOutput.Controls.Add(this.txtOutputHex);
            this.grpOutput.Controls.Add(this.lblHex);
            this.grpOutput.Controls.Add(this.txtOutputCrc);
            this.grpOutput.Controls.Add(this.lblCrc);
            this.grpOutput.Location = new System.Drawing.Point(12, 111);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(340, 230);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Data";
            // 
            // txtOutputPid
            // 
            this.txtOutputPid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPid.Location = new System.Drawing.Point(70, 19);
            this.txtOutputPid.Name = "txtOutputPid";
            this.txtOutputPid.Size = new System.Drawing.Size(264, 20);
            this.txtOutputPid.TabIndex = 1;
            this.txtOutputPid.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(6, 22);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(25, 13);
            this.lblPid.TabIndex = 0;
            this.lblPid.Text = "PID";
            // 
            // txtOutputRandom
            // 
            this.txtOutputRandom.Location = new System.Drawing.Point(70, 201);
            this.txtOutputRandom.Name = "txtOutputRandom";
            this.txtOutputRandom.Size = new System.Drawing.Size(100, 20);
            this.txtOutputRandom.TabIndex = 20;
            this.txtOutputRandom.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(6, 204);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(47, 13);
            this.lblRandom.TabIndex = 19;
            this.lblRandom.Text = "Random";
            // 
            // txtOutputSession
            // 
            this.txtOutputSession.Location = new System.Drawing.Point(70, 123);
            this.txtOutputSession.Name = "txtOutputSession";
            this.txtOutputSession.Size = new System.Drawing.Size(100, 20);
            this.txtOutputSession.TabIndex = 9;
            this.txtOutputSession.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(6, 126);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(44, 13);
            this.lblSession.TabIndex = 8;
            this.lblSession.Text = "Session";
            // 
            // txtOutputUseCount
            // 
            this.txtOutputUseCount.Location = new System.Drawing.Point(70, 175);
            this.txtOutputUseCount.Name = "txtOutputUseCount";
            this.txtOutputUseCount.Size = new System.Drawing.Size(100, 20);
            this.txtOutputUseCount.TabIndex = 18;
            this.txtOutputUseCount.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblUseCount
            // 
            this.lblUseCount.AutoSize = true;
            this.lblUseCount.Location = new System.Drawing.Point(6, 178);
            this.lblUseCount.Name = "lblUseCount";
            this.lblUseCount.Size = new System.Drawing.Size(57, 13);
            this.lblUseCount.TabIndex = 17;
            this.lblUseCount.Text = "Use Count";
            // 
            // txtOutputTimestamp
            // 
            this.txtOutputTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputTimestamp.Location = new System.Drawing.Point(218, 149);
            this.txtOutputTimestamp.Name = "txtOutputTimestamp";
            this.txtOutputTimestamp.Size = new System.Drawing.Size(116, 20);
            this.txtOutputTimestamp.TabIndex = 16;
            this.txtOutputTimestamp.TextChanged += new System.EventHandler(this.txtOutputTimestamp_TextChanged);
            // 
            // txtOutputTimestampH
            // 
            this.txtOutputTimestampH.Location = new System.Drawing.Point(156, 149);
            this.txtOutputTimestampH.Name = "txtOutputTimestampH";
            this.txtOutputTimestampH.Size = new System.Drawing.Size(40, 20);
            this.txtOutputTimestampH.TabIndex = 14;
            this.txtOutputTimestampH.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // txtOutputTimestampL
            // 
            this.txtOutputTimestampL.Location = new System.Drawing.Point(89, 149);
            this.txtOutputTimestampL.Name = "txtOutputTimestampL";
            this.txtOutputTimestampL.Size = new System.Drawing.Size(40, 20);
            this.txtOutputTimestampL.TabIndex = 12;
            this.txtOutputTimestampL.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblTimestampTot
            // 
            this.lblTimestampTot.AutoSize = true;
            this.lblTimestampTot.Location = new System.Drawing.Point(202, 152);
            this.lblTimestampTot.Name = "lblTimestampTot";
            this.lblTimestampTot.Size = new System.Drawing.Size(10, 13);
            this.lblTimestampTot.TabIndex = 15;
            this.lblTimestampTot.Text = ":";
            // 
            // lblTimestampH
            // 
            this.lblTimestampH.AutoSize = true;
            this.lblTimestampH.Location = new System.Drawing.Point(135, 152);
            this.lblTimestampH.Name = "lblTimestampH";
            this.lblTimestampH.Size = new System.Drawing.Size(15, 13);
            this.lblTimestampH.TabIndex = 13;
            this.lblTimestampH.Text = "H";
            // 
            // lblTimestampL
            // 
            this.lblTimestampL.AutoSize = true;
            this.lblTimestampL.Location = new System.Drawing.Point(70, 152);
            this.lblTimestampL.Name = "lblTimestampL";
            this.lblTimestampL.Size = new System.Drawing.Size(13, 13);
            this.lblTimestampL.TabIndex = 11;
            this.lblTimestampL.Text = "L";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(6, 152);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(58, 13);
            this.lblTimestamp.TabIndex = 10;
            this.lblTimestamp.Text = "Timestamp";
            // 
            // txtOutputUidHex
            // 
            this.txtOutputUidHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputUidHex.Location = new System.Drawing.Point(176, 97);
            this.txtOutputUidHex.Name = "txtOutputUidHex";
            this.txtOutputUidHex.Size = new System.Drawing.Size(158, 20);
            this.txtOutputUidHex.TabIndex = 7;
            this.txtOutputUidHex.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // txtOutputUid
            // 
            this.txtOutputUid.Location = new System.Drawing.Point(70, 97);
            this.txtOutputUid.Name = "txtOutputUid";
            this.txtOutputUid.Size = new System.Drawing.Size(100, 20);
            this.txtOutputUid.TabIndex = 7;
            this.txtOutputUid.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(6, 100);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(26, 13);
            this.lblUid.TabIndex = 6;
            this.lblUid.Text = "UID";
            // 
            // txtOutputHex
            // 
            this.txtOutputHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputHex.Location = new System.Drawing.Point(70, 45);
            this.txtOutputHex.Name = "txtOutputHex";
            this.txtOutputHex.Size = new System.Drawing.Size(264, 20);
            this.txtOutputHex.TabIndex = 3;
            this.txtOutputHex.TextChanged += new System.EventHandler(this.txtOutputField_TextChanged);
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(6, 48);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(29, 13);
            this.lblHex.TabIndex = 2;
            this.lblHex.Text = "HEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 350);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "Form1";
            this.Text = "YubikeyDecrypt";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAesKey;
        private System.Windows.Forms.TextBox txtInputAesKey;
        private System.Windows.Forms.Label lblOtp;
        private System.Windows.Forms.TextBox txtInputOtp;
        private System.Windows.Forms.Label lblCrc;
        private System.Windows.Forms.TextBox txtOutputCrc;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblInputStatus;
        private System.Windows.Forms.TextBox txtOutputPid;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.TextBox txtOutputRandom;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TextBox txtOutputUseCount;
        private System.Windows.Forms.Label lblUseCount;
        private System.Windows.Forms.TextBox txtOutputTimestamp;
        private System.Windows.Forms.TextBox txtOutputTimestampH;
        private System.Windows.Forms.TextBox txtOutputTimestampL;
        private System.Windows.Forms.Label lblTimestampH;
        private System.Windows.Forms.Label lblTimestampL;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.TextBox txtOutputUid;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblTimestampTot;
        private System.Windows.Forms.TextBox txtOutputSession;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox txtOutputHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txtOutputUidHex;
    }
}

