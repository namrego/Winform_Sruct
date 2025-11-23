namespace WinForm_struct
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
            this.dgbStudent = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbStudent)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbStudent
            // 
            this.dgbStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbStudent.Location = new System.Drawing.Point(12, 12);
            this.dgbStudent.Name = "dgbStudent";
            this.dgbStudent.RowTemplate.Height = 23;
            this.dgbStudent.Size = new System.Drawing.Size(404, 229);
            this.dgbStudent.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 1;
            // 
            // txtKor
            // 
            this.txtKor.Location = new System.Drawing.Point(279, 18);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(100, 21);
            this.txtKor.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(279, 45);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 21);
            this.txtEng.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "국어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "영어";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(279, 72);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 21);
            this.txtMat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "수학";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "총학생수";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(177, 75);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(11, 12);
            this.lblTot.TabIndex = 12;
            this.lblTot.Text = "0";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.lblTot);
            this.groupbox1.Controls.Add(this.txtId);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.txtKor);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.txtEng);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.txtMat);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.txtName);
            this.groupbox1.Location = new System.Drawing.Point(12, 262);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(404, 103);
            this.groupbox1.TabIndex = 13;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "학생정보";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "전체석차1등";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 422);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgbStudent);
            this.Controls.Add(this.groupbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgbStudent)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgbStudent;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
=======
>>>>>>> d3cd7055e63e4a35cce8b159de3cdf341d75b0bc
    }
}

