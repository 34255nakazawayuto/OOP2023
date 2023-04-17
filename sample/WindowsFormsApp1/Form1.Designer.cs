
namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btPow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(73, 133);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 19);
            this.nudX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(243, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(313, 133);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 19);
            this.nudY.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(450, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "乗は";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(529, 137);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(154, 19);
            this.tbResult.TabIndex = 2;
            // 
            // btPow
            // 
            this.btPow.Location = new System.Drawing.Point(581, 211);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(123, 46);
            this.btPow.TabIndex = 3;
            this.btPow.Text = "計算";
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(712, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "です";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.Label label3;
    }
}

