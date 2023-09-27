
namespace Section01 {
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
            this.RunNotepad = new System.Windows.Forms.Button();
            this.RunWateNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunNotepad
            // 
            this.RunNotepad.Location = new System.Drawing.Point(99, 91);
            this.RunNotepad.Name = "RunNotepad";
            this.RunNotepad.Size = new System.Drawing.Size(110, 39);
            this.RunNotepad.TabIndex = 0;
            this.RunNotepad.Text = "RunNotepad";
            this.RunNotepad.UseVisualStyleBackColor = true;
            this.RunNotepad.Click += new System.EventHandler(this.RunNotepad_Click);
            // 
            // RunWateNotepad
            // 
            this.RunWateNotepad.Location = new System.Drawing.Point(381, 91);
            this.RunWateNotepad.Name = "RunWateNotepad";
            this.RunWateNotepad.Size = new System.Drawing.Size(113, 39);
            this.RunWateNotepad.TabIndex = 1;
            this.RunWateNotepad.Text = "RunWateNotepad";
            this.RunWateNotepad.UseVisualStyleBackColor = true;
            this.RunWateNotepad.Click += new System.EventHandler(this.RunWateNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunWateNotepad);
            this.Controls.Add(this.RunNotepad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunNotepad;
        private System.Windows.Forms.Button RunWateNotepad;
    }
}

