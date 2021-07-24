namespace AdControlWindowApp
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
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("C 프로그래밍");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Java Programming");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("윈도우프로그래밍");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("자료구조");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("컴퓨터공학과", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("전자공학과");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("디지털콘텐츠학과");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("교과목", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            this.button1 = new System.Windows.Forms.Button();
            this.courseTree = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // courseTree
            // 
            this.courseTree.Location = new System.Drawing.Point(12, 12);
            this.courseTree.Name = "courseTree";
            treeNode25.Name = "노드4";
            treeNode25.Text = "C 프로그래밍";
            treeNode26.Name = "노드5";
            treeNode26.Text = "Java Programming";
            treeNode27.Name = "노드6";
            treeNode27.Text = "윈도우프로그래밍";
            treeNode28.Name = "노드7";
            treeNode28.Text = "자료구조";
            treeNode29.Name = "노드1";
            treeNode29.Text = "컴퓨터공학과";
            treeNode30.Name = "노드2";
            treeNode30.Text = "전자공학과";
            treeNode31.Name = "노드3";
            treeNode31.Text = "디지털콘텐츠학과";
            treeNode32.Name = "노드0";
            treeNode32.Text = "교과목";
            this.courseTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
            this.courseTree.Size = new System.Drawing.Size(204, 280);
            this.courseTree.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(303, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 280);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "선택노드삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "선택삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Node 명";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "노드 추가";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "노드 검색";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 489);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.courseTree);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TreeViewControlExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView courseTree;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

