namespace BookInfoWindowApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnOfS = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ebook Info";
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(183, 257);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 23);
            this.btnSale.TabIndex = 15;
            this.btnSale.Text = "할인";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(77, 259);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 21);
            this.txtDiscount.TabIndex = 17;
            // 
            // btnOfS
            // 
            this.btnOfS.Location = new System.Drawing.Point(274, 257);
            this.btnOfS.Name = "btnOfS";
            this.btnOfS.Size = new System.Drawing.Size(75, 23);
            this.btnOfS.TabIndex = 18;
            this.btnOfS.Text = "품절";
            this.btnOfS.UseVisualStyleBackColor = true;
            this.btnOfS.Click += new System.EventHandler(this.btnOfS_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(19, 299);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(19, 328);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(415, 185);
            this.txtResult.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "TItle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(80, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(233, 21);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 41);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(80, 68);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(57, 21);
            this.txtPages.TabIndex = 5;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(80, 95);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 21);
            this.txtISBN.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(80, 122);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(144, 21);
            this.txtPublisher.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(80, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(144, 21);
            this.txtPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.txtPages);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 182);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnOfS);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnOfS;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}

