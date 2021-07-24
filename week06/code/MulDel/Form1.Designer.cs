namespace MulDel
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
            this.btnRun = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(56, 256);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(181, 256);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(101, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 326);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "덧셈";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(93, 326);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 23);
            this.BtnSub.TabIndex = 3;
            this.BtnSub.Text = "뺄셈";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(174, 326);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(75, 23);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "곱셈";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(255, 326);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 23);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "나눗셈";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "값1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "값2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 238);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 361);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "멀티캐스트 델리게이션";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

