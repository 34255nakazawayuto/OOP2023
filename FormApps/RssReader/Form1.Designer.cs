
namespace RssReader {
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btUrl = new System.Windows.Forms.Button();
            this.CbKeep = new System.Windows.Forms.ComboBox();
            this.cbLinq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(854, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(892, 11);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(96, 32);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 139);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(976, 88);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 251);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(976, 411);
            this.wbBrowser.TabIndex = 3;
            // 
            // btUrl
            // 
            this.btUrl.Location = new System.Drawing.Point(12, 59);
            this.btUrl.Name = "btUrl";
            this.btUrl.Size = new System.Drawing.Size(126, 37);
            this.btUrl.TabIndex = 4;
            this.btUrl.Text = "お気に入り登録ボタン";
            this.btUrl.UseVisualStyleBackColor = true;
            this.btUrl.Click += new System.EventHandler(this.btUrl_Click);
            // 
            // CbKeep
            // 
            this.CbKeep.FormattingEnabled = true;
            this.CbKeep.Location = new System.Drawing.Point(157, 76);
            this.CbKeep.Name = "CbKeep";
            this.CbKeep.Size = new System.Drawing.Size(260, 20);
            this.CbKeep.TabIndex = 5;
            this.CbKeep.SelectedValueChanged += new System.EventHandler(this.CbKeep_SelectedValueChanged);
            // 
            // cbLinq
            // 
            this.cbLinq.FormattingEnabled = true;
            this.cbLinq.Location = new System.Drawing.Point(606, 76);
            this.cbLinq.Name = "cbLinq";
            this.cbLinq.Size = new System.Drawing.Size(260, 20);
            this.cbLinq.TabIndex = 6;
            this.cbLinq.SelectedIndexChanged += new System.EventHandler(this.CbLinq_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "タイトル一覧";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLinq);
            this.Controls.Add(this.CbKeep);
            this.Controls.Add(this.btUrl);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btUrl;
        private System.Windows.Forms.ComboBox CbKeep;
        private System.Windows.Forms.ComboBox cbLinq;
        private System.Windows.Forms.Label label1;
    }
}

