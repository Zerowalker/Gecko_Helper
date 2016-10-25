namespace Gecko_Helper
{
    partial class Gecko_Helper
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
            this.bConvert = new System.Windows.Forms.Button();
            this.tRegister = new System.Windows.Forms.TextBox();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lRegister = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.cLoad = new System.Windows.Forms.CheckBox();
            this.tOffset = new System.Windows.Forms.TextBox();
            this.tOffsetResult = new System.Windows.Forms.TextBox();
            this.bConvertOffset = new System.Windows.Forms.Button();
            this.lOffset = new System.Windows.Forms.Label();
            this.tDectoHex = new System.Windows.Forms.TextBox();
            this.tHextoDec = new System.Windows.Forms.TextBox();
            this.bToHex = new System.Windows.Forms.Button();
            this.lDecToHex = new System.Windows.Forms.Label();
            this.bToDec = new System.Windows.Forms.Button();
            this.bFloattoHex = new System.Windows.Forms.Button();
            this.bHextoFloat = new System.Windows.Forms.Button();
            this.lFloatToHex = new System.Windows.Forms.Label();
            this.tFloatToHex = new System.Windows.Forms.TextBox();
            this.tHextoFloat = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.lHexOffset = new System.Windows.Forms.Label();
            this.tHexOffset = new System.Windows.Forms.TextBox();
            this.tHexOffset2 = new System.Windows.Forms.TextBox();
            this.tHexOffsetResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(37, 62);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(75, 23);
            this.bConvert.TabIndex = 0;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // tRegister
            // 
            this.tRegister.Location = new System.Drawing.Point(12, 32);
            this.tRegister.Name = "tRegister";
            this.tRegister.Size = new System.Drawing.Size(100, 20);
            this.tRegister.TabIndex = 1;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(118, 32);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(148, 20);
            this.tAddress.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 100);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 150);
            this.textBox3.TabIndex = 3;
            // 
            // lRegister
            // 
            this.lRegister.AutoSize = true;
            this.lRegister.Location = new System.Drawing.Point(9, 16);
            this.lRegister.Name = "lRegister";
            this.lRegister.Size = new System.Drawing.Size(74, 13);
            this.lRegister.TabIndex = 4;
            this.lRegister.Text = "Register (r20*)";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(115, 16);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(146, 13);
            this.lAddress.TabIndex = 4;
            this.lAddress.Text = "Memory Address (81234567*)";
            // 
            // cLoad
            // 
            this.cLoad.AutoSize = true;
            this.cLoad.Location = new System.Drawing.Point(118, 68);
            this.cLoad.Name = "cLoad";
            this.cLoad.Size = new System.Drawing.Size(117, 17);
            this.cLoad.TabIndex = 5;
            this.cLoad.Text = "Load From Address";
            this.cLoad.UseVisualStyleBackColor = true;
            // 
            // tOffset
            // 
            this.tOffset.Location = new System.Drawing.Point(418, 32);
            this.tOffset.Name = "tOffset";
            this.tOffset.Size = new System.Drawing.Size(100, 20);
            this.tOffset.TabIndex = 6;
            // 
            // tOffsetResult
            // 
            this.tOffsetResult.Location = new System.Drawing.Point(418, 87);
            this.tOffsetResult.Name = "tOffsetResult";
            this.tOffsetResult.Size = new System.Drawing.Size(100, 20);
            this.tOffsetResult.TabIndex = 7;
            // 
            // bConvertOffset
            // 
            this.bConvertOffset.Location = new System.Drawing.Point(418, 58);
            this.bConvertOffset.Name = "bConvertOffset";
            this.bConvertOffset.Size = new System.Drawing.Size(100, 23);
            this.bConvertOffset.TabIndex = 8;
            this.bConvertOffset.Text = "Convert Offset";
            this.bConvertOffset.UseVisualStyleBackColor = true;
            this.bConvertOffset.Click += new System.EventHandler(this.bConvertOffset_Click);
            // 
            // lOffset
            // 
            this.lOffset.AutoSize = true;
            this.lOffset.Location = new System.Drawing.Point(418, 16);
            this.lOffset.Name = "lOffset";
            this.lOffset.Size = new System.Drawing.Size(147, 13);
            this.lOffset.TabIndex = 9;
            this.lOffset.Text = "Memory Offset (In Line Count)";
            // 
            // tDectoHex
            // 
            this.tDectoHex.Location = new System.Drawing.Point(418, 126);
            this.tDectoHex.Name = "tDectoHex";
            this.tDectoHex.Size = new System.Drawing.Size(100, 20);
            this.tDectoHex.TabIndex = 10;
            // 
            // tHextoDec
            // 
            this.tHextoDec.Location = new System.Drawing.Point(418, 181);
            this.tHextoDec.Name = "tHextoDec";
            this.tHextoDec.Size = new System.Drawing.Size(100, 20);
            this.tHextoDec.TabIndex = 10;
            // 
            // bToHex
            // 
            this.bToHex.Location = new System.Drawing.Point(418, 152);
            this.bToHex.Name = "bToHex";
            this.bToHex.Size = new System.Drawing.Size(53, 23);
            this.bToHex.TabIndex = 8;
            this.bToHex.Text = "To Hex";
            this.bToHex.UseVisualStyleBackColor = true;
            this.bToHex.Click += new System.EventHandler(this.bToHex_Click);
            // 
            // lDecToHex
            // 
            this.lDecToHex.AutoSize = true;
            this.lDecToHex.Location = new System.Drawing.Point(415, 110);
            this.lDecToHex.Name = "lDecToHex";
            this.lDecToHex.Size = new System.Drawing.Size(119, 13);
            this.lDecToHex.TabIndex = 9;
            this.lDecToHex.Text = "Convert Decimal to Hex";
            // 
            // bToDec
            // 
            this.bToDec.Location = new System.Drawing.Point(465, 152);
            this.bToDec.Name = "bToDec";
            this.bToDec.Size = new System.Drawing.Size(53, 23);
            this.bToDec.TabIndex = 8;
            this.bToDec.Text = "To Dec";
            this.bToDec.UseVisualStyleBackColor = true;
            this.bToDec.Click += new System.EventHandler(this.bToDec_Click);
            // 
            // bFloattoHex
            // 
            this.bFloattoHex.Location = new System.Drawing.Point(294, 194);
            this.bFloattoHex.Name = "bFloattoHex";
            this.bFloattoHex.Size = new System.Drawing.Size(50, 23);
            this.bFloattoHex.TabIndex = 8;
            this.bFloattoHex.Text = "To Hex";
            this.bFloattoHex.UseVisualStyleBackColor = true;
            this.bFloattoHex.Click += new System.EventHandler(this.bFloattoHex_Click);
            // 
            // bHextoFloat
            // 
            this.bHextoFloat.Location = new System.Drawing.Point(341, 194);
            this.bHextoFloat.Name = "bHextoFloat";
            this.bHextoFloat.Size = new System.Drawing.Size(54, 23);
            this.bHextoFloat.TabIndex = 8;
            this.bHextoFloat.Text = "To Float";
            this.bHextoFloat.UseVisualStyleBackColor = true;
            this.bHextoFloat.Click += new System.EventHandler(this.bHextoFloat_Click);
            // 
            // lFloatToHex
            // 
            this.lFloatToHex.AutoSize = true;
            this.lFloatToHex.Location = new System.Drawing.Point(291, 152);
            this.lFloatToHex.Name = "lFloatToHex";
            this.lFloatToHex.Size = new System.Drawing.Size(104, 13);
            this.lFloatToHex.TabIndex = 9;
            this.lFloatToHex.Text = "Convert Float to Hex";
            // 
            // tFloatToHex
            // 
            this.tFloatToHex.Location = new System.Drawing.Point(294, 168);
            this.tFloatToHex.Name = "tFloatToHex";
            this.tFloatToHex.Size = new System.Drawing.Size(100, 20);
            this.tFloatToHex.TabIndex = 10;
            // 
            // tHextoFloat
            // 
            this.tHextoFloat.Location = new System.Drawing.Point(294, 223);
            this.tHextoFloat.Name = "tHextoFloat";
            this.tHextoFloat.Size = new System.Drawing.Size(100, 20);
            this.tHextoFloat.TabIndex = 10;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(293, 56);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(48, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(347, 56);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(48, 23);
            this.bSub.TabIndex = 8;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // lHexOffset
            // 
            this.lHexOffset.AutoSize = true;
            this.lHexOffset.Location = new System.Drawing.Point(308, 16);
            this.lHexOffset.Name = "lHexOffset";
            this.lHexOffset.Size = new System.Drawing.Size(76, 13);
            this.lHexOffset.TabIndex = 9;
            this.lHexOffset.Text = "Hex Calculator";
            // 
            // tHexOffset
            // 
            this.tHexOffset.Location = new System.Drawing.Point(293, 32);
            this.tHexOffset.Name = "tHexOffset";
            this.tHexOffset.Size = new System.Drawing.Size(100, 20);
            this.tHexOffset.TabIndex = 10;
            // 
            // tHexOffset2
            // 
            this.tHexOffset2.Location = new System.Drawing.Point(295, 85);
            this.tHexOffset2.Name = "tHexOffset2";
            this.tHexOffset2.Size = new System.Drawing.Size(100, 20);
            this.tHexOffset2.TabIndex = 10;
            // 
            // tHexOffsetResult
            // 
            this.tHexOffsetResult.Location = new System.Drawing.Point(293, 126);
            this.tHexOffsetResult.Name = "tHexOffsetResult";
            this.tHexOffsetResult.ReadOnly = true;
            this.tHexOffsetResult.Size = new System.Drawing.Size(100, 20);
            this.tHexOffsetResult.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculation Result";
            // 
            // cOnTop
            // 
            this.cOnTop.AutoSize = true;
            this.cOnTop.Location = new System.Drawing.Point(441, 225);
            this.cOnTop.Name = "cOnTop";
            this.cOnTop.Size = new System.Drawing.Size(98, 17);
            this.cOnTop.TabIndex = 11;
            this.cOnTop.Text = "Always On Top";
            this.cOnTop.UseVisualStyleBackColor = true;
            this.cOnTop.CheckedChanged += new System.EventHandler(this.cOnTop_CheckedChanged);
            // 
            // Gecko_Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.cOnTop);
            this.Controls.Add(this.tHexOffsetResult);
            this.Controls.Add(this.tHexOffset2);
            this.Controls.Add(this.tHextoFloat);
            this.Controls.Add(this.tHextoDec);
            this.Controls.Add(this.tHexOffset);
            this.Controls.Add(this.tFloatToHex);
            this.Controls.Add(this.tDectoHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lHexOffset);
            this.Controls.Add(this.lFloatToHex);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.lDecToHex);
            this.Controls.Add(this.bHextoFloat);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lOffset);
            this.Controls.Add(this.bFloattoHex);
            this.Controls.Add(this.bToDec);
            this.Controls.Add(this.bToHex);
            this.Controls.Add(this.bConvertOffset);
            this.Controls.Add(this.tOffsetResult);
            this.Controls.Add(this.tOffset);
            this.Controls.Add(this.cLoad);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lRegister);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tAddress);
            this.Controls.Add(this.tRegister);
            this.Controls.Add(this.bConvert);
            this.Name = "Gecko_Helper";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.TextBox tRegister;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lRegister;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.CheckBox cLoad;
        private System.Windows.Forms.TextBox tOffset;
        private System.Windows.Forms.TextBox tOffsetResult;
        private System.Windows.Forms.Button bConvertOffset;
        private System.Windows.Forms.Label lOffset;
        private System.Windows.Forms.TextBox tDectoHex;
        private System.Windows.Forms.TextBox tHextoDec;
        private System.Windows.Forms.Button bToHex;
        private System.Windows.Forms.Label lDecToHex;
        private System.Windows.Forms.Button bToDec;
        private System.Windows.Forms.Button bFloattoHex;
        private System.Windows.Forms.Button bHextoFloat;
        private System.Windows.Forms.Label lFloatToHex;
        private System.Windows.Forms.TextBox tFloatToHex;
        private System.Windows.Forms.TextBox tHextoFloat;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Label lHexOffset;
        private System.Windows.Forms.TextBox tHexOffset;
        private System.Windows.Forms.TextBox tHexOffset2;
        private System.Windows.Forms.TextBox tHexOffsetResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cOnTop;
    }
}

