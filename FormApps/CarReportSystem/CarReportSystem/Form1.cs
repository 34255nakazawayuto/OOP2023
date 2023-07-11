﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//データグリッド　インデックス
namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var carReport = new CarReport
            {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                carImage = pbCarImage.Image,
            };
            CarReports.Add(carReport);
        }

        private CarReport.MakerGroup getSelectedMaker() {
            int tag = 0;
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked){
                    tag = int.Parse(((RadioButton)item).Tag.ToString());
                    break;
                }
            }
            return (CarReport.MakerGroup)tag;
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;      //画像項目非表示
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--)
            {
                dgvCarReports[.Rows.RemoveAt(src[i].Index);
            }
    }
    
    }
}

