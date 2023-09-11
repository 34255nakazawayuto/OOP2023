using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private PictureBoxSizeMode mode;

        //設定情報保存用オブジェクト
        Settings setting = Settings.getInstans();

        public Form1() {
            InitializeComponent();
            // dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();　//ステータスラベルのテキスト非表示
            if (cbAuthor.Text.Equals(""))
            {
                statasLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text.Equals(""))
            {
                statasLabelDisp("車名を入力してください");
                return;
            }


            DataRow newRow = infosys202326DataSet.CarReportTable.NewRow();

            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202326DataSet.CarReportTable.Rows.Add(newRow);
            //this.carReportTableTableAdapter.Update(infosys202326DataSet.CarReportTable);


            setCbAuthor(cbAuthor.Text);     //記録者コンボボックスの履歴登録処理
            setCbCarName(cbCarName.Text);   //車名コンボボックスの履歴登録処理

            editItemsClear();   //項目クリア処理
        }

        //記録者コンボボックスの履歴登録処理
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
            {
                cbAuthor.Items.Add(author);
            }
        }
        //車名コンボボックスの履歴登録処理
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname))
            {
                cbCarName.Items.Add(carname);
            }
        }

        //項目クリア処理
        private void editItemsClear() {
            cbAuthor.Text = "";
            setSelectedMaker("トヨタ");
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;

            dgvCarReports.ClearSelection();     //選択解除
            btModifyReport.Enabled = true;     //修正ボタン
            btDeleteReport.Enabled = true;     //削除ボタン
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls)
            {
                if (((RadioButton)item).Checked)
                {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {



            tsInfoText.Text = "";   //情報表示領域のテキストを初期化
            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvCarReports.Columns[6].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false; //修正ボタン無効
            btDeleteReport.Enabled = false; //削除ボタン無効

            try
            {
                //設定ファイルを逆シリアル化して背景化設定
                using (var reader = XmlReader.Create("settings.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    setting = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(setting.MainFormColor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);

            carReportTableTableAdapter.Update(infosys202326DataSet.CarReportTable);
            editItemsClear();
        }

        //レコードの選択時
        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.Rows.Count != 0)
            {

                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                                    && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                                    ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;


            }
        }

        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {


            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

            //CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            //CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            //CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            //CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            //CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            //dgvCarReports.Refresh();    //一覧更新
            //}
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202326DataSet);

        }

        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void カラーToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                BackColor = cdColor.Color;
                setting.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            pbCarImage.SizeMode
           = mode <= PictureBoxSizeMode.Zoom ?
                ((mode == PictureBoxSizeMode.StretchImage) ? PictureBoxSizeMode.CenterImage : ++mode)
                                                                                : PictureBoxSizeMode.Normal;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("settings.xml"))
            {
                var serializer = new XmlSerializer(setting.GetType());
                serializer.Serialize(writer, setting);
            }

        }

        private void time_Tick(object sender, EventArgs e) {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel1.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");

        }


        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;



        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }



        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202326DataSet);

        }
        //接続ボタンイベントハンドラ
        // private void btConnection_Click(object sender, EventArgs e) {
        // TODO: このコード行はデータを 'infosys202326DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        //this.carReportTableTableAdapter.Fill(this.infosys202326DataSet.CarReportTable);
        // dgvCarReports.ClearSelection();//選択解除

        //  foreach (var carReport in infosys202326DataSet.CarReportTable){
        //      setCbAuthor(carReport.Author);
        //     setCbCarName(carReport.CarName);

        // }
        // }


        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202326DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202326DataSet.CarReportTable);
            dgvCarReports.ClearSelection();//選択解除

            foreach (var carReport in infosys202326DataSet.CarReportTable){
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }
        }
    }
}

