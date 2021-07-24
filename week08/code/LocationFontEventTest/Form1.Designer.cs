namespace LocationFontEventTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHorse = new System.Windows.Forms.Label();
            this.btnSizeUp = new System.Windows.Forms.Button();
            this.btnSizeDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpLeft = new System.Windows.Forms.Button();
            this.btnUpRight = new System.Windows.Forms.Button();
            this.btnDownLeft = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDownRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.BackColor = System.Drawing.Color.Aqua;
            this.lblHorse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHorse.Location = new System.Drawing.Point(169, 89);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(69, 12);
            this.lblHorse.TabIndex = 0;
            this.lblHorse.Text = "움직이는 말";
            // 
            // btnSizeUp
            // 
            this.btnSizeUp.Location = new System.Drawing.Point(367, 36);
            this.btnSizeUp.Name = "btnSizeUp";
            this.btnSizeUp.Size = new System.Drawing.Size(47, 23);
            this.btnSizeUp.TabIndex = 1;
            this.btnSizeUp.Text = "크게";
            this.btnSizeUp.UseVisualStyleBackColor = true;
            this.btnSizeUp.Click += new System.EventHandler(this.btnSizeUp_Click);
            // 
            // btnSizeDown
            // 
            this.btnSizeDown.Location = new System.Drawing.Point(367, 65);
            this.btnSizeDown.Name = "btnSizeDown";
            this.btnSizeDown.Size = new System.Drawing.Size(47, 23);
            this.btnSizeDown.TabIndex = 2;
            this.btnSizeDown.Text = "작게";
            this.btnSizeDown.UseVisualStyleBackColor = true;
            this.btnSizeDown.Click += new System.EventHandler(this.btnSizeDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(163, 218);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "위";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpLeft
            // 
            this.btnUpLeft.Location = new System.Drawing.Point(132, 218);
            this.btnUpLeft.Name = "btnUpLeft";
            this.btnUpLeft.Size = new System.Drawing.Size(25, 23);
            this.btnUpLeft.TabIndex = 4;
            this.btnUpLeft.UseVisualStyleBackColor = true;
            this.btnUpLeft.Click += new System.EventHandler(this.btnUpLeft_Click);
            // 
            // btnUpRight
            // 
            this.btnUpRight.Location = new System.Drawing.Point(244, 218);
            this.btnUpRight.Name = "btnUpRight";
            this.btnUpRight.Size = new System.Drawing.Size(25, 23);
            this.btnUpRight.TabIndex = 5;
            this.btnUpRight.UseVisualStyleBackColor = true;
            this.btnUpRight.Click += new System.EventHandler(this.btnUpRight_Click);
            // 
            // btnDownLeft
            // 
            this.btnDownLeft.Location = new System.Drawing.Point(132, 276);
            this.btnDownLeft.Name = "btnDownLeft";
            this.btnDownLeft.Size = new System.Drawing.Size(25, 23);
            this.btnDownLeft.TabIndex = 6;
            this.btnDownLeft.UseVisualStyleBackColor = true;
            this.btnDownLeft.Click += new System.EventHandler(this.btnDownLeft_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(82, 247);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "왼쪽";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(244, 247);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "오른쪽";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDownRight
            // 
            this.btnDownRight.Location = new System.Drawing.Point(244, 276);
            this.btnDownRight.Name = "btnDownRight";
            this.btnDownRight.Size = new System.Drawing.Size(25, 23);
            this.btnDownRight.TabIndex = 9;
            this.btnDownRight.UseVisualStyleBackColor = true;
            this.btnDownRight.Click += new System.EventHandler(this.btnDownRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(163, 276);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "아래";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 376);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnDownRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDownLeft);
            this.Controls.Add(this.btnUpRight);
            this.Controls.Add(this.btnUpLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSizeDown);
            this.Controls.Add(this.btnSizeUp);
            this.Controls.Add(this.lblHorse);
            this.Name = "Form1";
            this.Text = "위치, 포트크기 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Button btnSizeUp;
        private System.Windows.Forms.Button btnSizeDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpLeft;
        private System.Windows.Forms.Button btnUpRight;
        private System.Windows.Forms.Button btnDownLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDownRight;
        private System.Windows.Forms.Button btnDown;
    }
}

