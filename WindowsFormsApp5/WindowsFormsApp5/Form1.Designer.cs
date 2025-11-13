namespace QLThuVien 
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxTongQuan = new System.Windows.Forms.GroupBox();
            this.lblSachQuaHan = new System.Windows.Forms.Label();
            this.lblTraTrongTuan = new System.Windows.Forms.Label();
            this.lblMuonTrongTuan = new System.Windows.Forms.Label();
            this.lblTraTrongNgay = new System.Windows.Forms.Label();
            this.lblMuonTrongNgay = new System.Windows.Forms.Label();
            this.lblSoNXB = new System.Windows.Forms.Label();
            this.lblSoTacGia = new System.Windows.Forms.Label();
            this.lblSoDocGia = new System.Windows.Forms.Label();
            this.lblBiHong = new System.Windows.Forms.Label();
            this.lblCoSan = new System.Windows.Forms.Label();
            this.lblDangMuon = new System.Windows.Forms.Label();
            this.lblTongSoSach = new System.Windows.Forms.Label();
            this.groupBoxBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTongQuan.SuspendLayout();
            this.groupBoxBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTongQuan
            // 
            this.groupBoxTongQuan.Controls.Add(this.lblSachQuaHan);
            this.groupBoxTongQuan.Controls.Add(this.lblTraTrongTuan);
            this.groupBoxTongQuan.Controls.Add(this.lblMuonTrongTuan);
            this.groupBoxTongQuan.Controls.Add(this.lblTraTrongNgay);
            this.groupBoxTongQuan.Controls.Add(this.lblMuonTrongNgay);
            this.groupBoxTongQuan.Controls.Add(this.lblSoNXB);
            this.groupBoxTongQuan.Controls.Add(this.lblSoTacGia);
            this.groupBoxTongQuan.Controls.Add(this.lblSoDocGia);
            this.groupBoxTongQuan.Controls.Add(this.lblBiHong);
            this.groupBoxTongQuan.Controls.Add(this.lblCoSan);
            this.groupBoxTongQuan.Controls.Add(this.lblDangMuon);
            this.groupBoxTongQuan.Controls.Add(this.lblTongSoSach);
            this.groupBoxTongQuan.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTongQuan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTongQuan.Name = "groupBoxTongQuan";
            this.groupBoxTongQuan.Size = new System.Drawing.Size(230, 390);
            this.groupBoxTongQuan.TabIndex = 0;
            this.groupBoxTongQuan.TabStop = false;
            this.groupBoxTongQuan.Text = "Thống kê tổng quan";
            // 
            // lblSachQuaHan
            // 
            this.lblSachQuaHan.AutoSize = true;
            this.lblSachQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lblSachQuaHan.Location = new System.Drawing.Point(15, 350);
            this.lblSachQuaHan.Name = "lblSachQuaHan";
            this.lblSachQuaHan.Size = new System.Drawing.Size(121, 16);
            this.lblSachQuaHan.TabIndex = 11;
            this.lblSachQuaHan.Text = "Phiếu quá hạn: 0";
            // 
            // lblTraTrongTuan
            // 
            this.lblTraTrongTuan.AutoSize = true;
            this.lblTraTrongTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraTrongTuan.Location = new System.Drawing.Point(15, 321);
            this.lblTraTrongTuan.Name = "lblTraTrongTuan";
            this.lblTraTrongTuan.Size = new System.Drawing.Size(94, 16);
            this.lblTraTrongTuan.TabIndex = 10;
            this.lblTraTrongTuan.Text = "Trả tuần này: 0";
            // 
            // lblMuonTrongTuan
            // 
            this.lblMuonTrongTuan.AutoSize = true;
            this.lblMuonTrongTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuonTrongTuan.Location = new System.Drawing.Point(15, 292);
            this.lblMuonTrongTuan.Name = "lblMuonTrongTuan";
            this.lblMuonTrongTuan.Size = new System.Drawing.Size(106, 16);
            this.lblMuonTrongTuan.TabIndex = 9;
            this.lblMuonTrongTuan.Text = "Mượn tuần này: 0";
            // 
            // lblTraTrongNgay
            // 
            this.lblTraTrongNgay.AutoSize = true;
            this.lblTraTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraTrongNgay.Location = new System.Drawing.Point(15, 263);
            this.lblTraTrongNgay.Name = "lblTraTrongNgay";
            this.lblTraTrongNgay.Size = new System.Drawing.Size(95, 16);
            this.lblTraTrongNgay.TabIndex = 8;
            this.lblTraTrongNgay.Text = "Trả hôm nay: 0";
            // 
            // lblMuonTrongNgay
            // 
            this.lblMuonTrongNgay.AutoSize = true;
            this.lblMuonTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuonTrongNgay.Location = new System.Drawing.Point(15, 234);
            this.lblMuonTrongNgay.Name = "lblMuonTrongNgay";
            this.lblMuonTrongNgay.Size = new System.Drawing.Size(107, 16);
            this.lblMuonTrongNgay.TabIndex = 7;
            this.lblMuonTrongNgay.Text = "Mượn hôm nay: 0";
            // 
            // lblSoNXB
            // 
            this.lblSoNXB.AutoSize = true;
            this.lblSoNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNXB.Location = new System.Drawing.Point(15, 205);
            this.lblSoNXB.Name = "lblSoNXB";
            this.lblSoNXB.Size = new System.Drawing.Size(67, 16);
            this.lblSoNXB.TabIndex = 6;
            this.lblSoNXB.Text = "Số NXB: 0";
            // 
            // lblSoTacGia
            // 
            this.lblSoTacGia.AutoSize = true;
            this.lblSoTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTacGia.Location = new System.Drawing.Point(15, 176);
            this.lblSoTacGia.Name = "lblSoTacGia";
            this.lblSoTacGia.Size = new System.Drawing.Size(80, 16);
            this.lblSoTacGia.TabIndex = 5;
            this.lblSoTacGia.Text = "Số tác giả: 0";
            // 
            // lblSoDocGia
            // 
            this.lblSoDocGia.AutoSize = true;
            this.lblSoDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDocGia.Location = new System.Drawing.Point(15, 147);
            this.lblSoDocGia.Name = "lblSoDocGia";
            this.lblSoDocGia.Size = new System.Drawing.Size(85, 16);
            this.lblSoDocGia.TabIndex = 4;
            this.lblSoDocGia.Text = "Số đọc giả: 0";
            // 
            // lblBiHong
            // 
            this.lblBiHong.AutoSize = true;
            this.lblBiHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiHong.Location = new System.Drawing.Point(15, 118);
            this.lblBiHong.Name = "lblBiHong";
            this.lblBiHong.Size = new System.Drawing.Size(79, 16);
            this.lblBiHong.TabIndex = 3;
            this.lblBiHong.Text = "Hỏng/Mất: 0";
            // 
            // lblCoSan
            // 
            this.lblCoSan.AutoSize = true;
            this.lblCoSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoSan.Location = new System.Drawing.Point(15, 89);
            this.lblCoSan.Name = "lblCoSan";
            this.lblCoSan.Size = new System.Drawing.Size(62, 16);
            this.lblCoSan.TabIndex = 2;
            this.lblCoSan.Text = "Có sẵn: 0";
            // 
            // lblDangMuon
            // 
            this.lblDangMuon.AutoSize = true;
            this.lblDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangMuon.Location = new System.Drawing.Point(15, 60);
            this.lblDangMuon.Name = "lblDangMuon";
            this.lblDangMuon.Size = new System.Drawing.Size(88, 16);
            this.lblDangMuon.TabIndex = 1;
            this.lblDangMuon.Text = "Đang mượn: 0";
            // 
            // lblTongSoSach
            // 
            this.lblTongSoSach.AutoSize = true;
            this.lblTongSoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoSach.Location = new System.Drawing.Point(15, 31);
            this.lblTongSoSach.Name = "lblTongSoSach";
            this.lblTongSoSach.Size = new System.Drawing.Size(117, 16);
            this.lblTongSoSach.TabIndex = 0;
            this.lblTongSoSach.Text = "Tổng số sách: 0";
            // 
            // groupBoxBaoCao
            // 
            this.groupBoxBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBaoCao.Controls.Add(this.dgvBaoCao);
            this.groupBoxBaoCao.Controls.Add(this.btnXemBaoCao);
            this.groupBoxBaoCao.Controls.Add(this.cboLoaiBaoCao);
            this.groupBoxBaoCao.Controls.Add(this.label5);
            this.groupBoxBaoCao.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBaoCao.Location = new System.Drawing.Point(248, 12);
            this.groupBoxBaoCao.Name = "groupBoxBaoCao";
            this.groupBoxBaoCao.Size = new System.Drawing.Size(524, 426);
            this.groupBoxBaoCao.TabIndex = 1;
            this.groupBoxBaoCao.TabStop = false;
            this.groupBoxBaoCao.Text = "Báo cáo chi tiết";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.Location = new System.Drawing.Point(15, 60);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoCao.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBaoCao.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoCao.Size = new System.Drawing.Size(493, 350);
            this.dgvBaoCao.TabIndex = 3;
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellContentClick);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(403, 27);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(105, 25);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(125, 28);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(272, 23);
            this.cboLoaiBaoCao.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn loại báo cáo:";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.groupBoxBaoCao);
            this.Controls.Add(this.groupBoxTongQuan);
            this.Name = "frmThongKe";
            this.Text = "Thống kê - Báo cáo";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBoxTongQuan.ResumeLayout(false);
            this.groupBoxTongQuan.PerformLayout();
            this.groupBoxBaoCao.ResumeLayout(false);
            this.groupBoxBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTongQuan;
        private System.Windows.Forms.Label lblBiHong;
        private System.Windows.Forms.Label lblCoSan;
        private System.Windows.Forms.Label lblDangMuon;
        private System.Windows.Forms.Label lblTongSoSach;
        private System.Windows.Forms.GroupBox groupBoxBaoCao;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoNXB;
        private System.Windows.Forms.Label lblSoTacGia;
        private System.Windows.Forms.Label lblSoDocGia;
        private System.Windows.Forms.Label lblTraTrongTuan;
        private System.Windows.Forms.Label lblMuonTrongTuan;
        private System.Windows.Forms.Label lblTraTrongNgay;
        private System.Windows.Forms.Label lblMuonTrongNgay;
        private System.Windows.Forms.Label lblSachQuaHan;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}