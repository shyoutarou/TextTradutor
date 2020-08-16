namespace WHTradutor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtTraduzido = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.txtPagIni = new System.Windows.Forms.TextBox();
            this.lblPagina = new System.Windows.Forms.Label();
            this.lblPagFim = new System.Windows.Forms.Label();
            this.txtPagFim = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearvh = new System.Windows.Forms.ListBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbDe = new System.Windows.Forms.ComboBox();
            this.lblArquvo = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.cbPara = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(515, 12);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(297, 74);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginal.Size = new System.Drawing.Size(389, 161);
            this.txtOriginal.TabIndex = 1;
            // 
            // txtTraduzido
            // 
            this.txtTraduzido.Location = new System.Drawing.Point(297, 241);
            this.txtTraduzido.Multiline = true;
            this.txtTraduzido.Name = "txtTraduzido";
            this.txtTraduzido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraduzido.Size = new System.Drawing.Size(389, 166);
            this.txtTraduzido.TabIndex = 2;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(596, 13);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(75, 23);
            this.btnTraduzir.TabIndex = 3;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // txtPagIni
            // 
            this.txtPagIni.Location = new System.Drawing.Point(351, 15);
            this.txtPagIni.Name = "txtPagIni";
            this.txtPagIni.Size = new System.Drawing.Size(54, 20);
            this.txtPagIni.TabIndex = 4;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(294, 18);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(61, 13);
            this.lblPagina.TabIndex = 5;
            this.lblPagina.Text = "Pág. Inixial:";
            // 
            // lblPagFim
            // 
            this.lblPagFim.AutoSize = true;
            this.lblPagFim.Location = new System.Drawing.Point(411, 18);
            this.lblPagFim.Name = "lblPagFim";
            this.lblPagFim.Size = new System.Drawing.Size(51, 13);
            this.lblPagFim.TabIndex = 7;
            this.lblPagFim.Text = "Pág. Fim:";
            // 
            // txtPagFim
            // 
            this.txtPagFim.Location = new System.Drawing.Point(460, 15);
            this.txtPagFim.Name = "txtPagFim";
            this.txtPagFim.Size = new System.Drawing.Size(48, 20);
            this.txtPagFim.TabIndex = 6;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(297, 48);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(389, 20);
            this.txtFileName.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Pesquisa";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearvh
            // 
            this.lbSearvh.FormattingEnabled = true;
            this.lbSearvh.HorizontalScrollbar = true;
            this.lbSearvh.Location = new System.Drawing.Point(15, 74);
            this.lbSearvh.Name = "lbSearvh";
            this.lbSearvh.Size = new System.Drawing.Size(273, 329);
            this.lbSearvh.TabIndex = 12;
            this.lbSearvh.SelectedIndexChanged += new System.EventHandler(this.lbSearvh_SelectedIndexChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "pdf",
            "txt",
            "md"});
            this.cbTipo.Location = new System.Drawing.Point(45, 15);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(47, 21);
            this.cbTipo.TabIndex = 13;
            // 
            // cbDe
            // 
            this.cbDe.FormattingEnabled = true;
            this.cbDe.Items.AddRange(new object[] {
            "pt",
            "en",
            "ja",
            "de"});
            this.cbDe.Location = new System.Drawing.Point(119, 15);
            this.cbDe.Name = "cbDe";
            this.cbDe.Size = new System.Drawing.Size(56, 21);
            this.cbDe.TabIndex = 14;
            // 
            // lblArquvo
            // 
            this.lblArquvo.AutoSize = true;
            this.lblArquvo.Location = new System.Drawing.Point(12, 22);
            this.lblArquvo.Name = "lblArquvo";
            this.lblArquvo.Size = new System.Drawing.Size(31, 13);
            this.lblArquvo.TabIndex = 15;
            this.lblArquvo.Text = "Tipo:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(98, 23);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 16;
            this.lblDe.Text = "De:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(181, 22);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 17;
            this.lblPara.Text = "Para:";
            // 
            // cbPara
            // 
            this.cbPara.FormattingEnabled = true;
            this.cbPara.Items.AddRange(new object[] {
            "pt",
            "en",
            "ja",
            "de"});
            this.cbPara.Location = new System.Drawing.Point(219, 15);
            this.cbPara.Name = "cbPara";
            this.cbPara.Size = new System.Drawing.Size(56, 21);
            this.cbPara.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 419);
            this.Controls.Add(this.cbPara);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblArquvo);
            this.Controls.Add(this.cbDe);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbSearvh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblPagFim);
            this.Controls.Add(this.txtPagFim);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.txtPagIni);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.txtTraduzido);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnCarregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtTraduzido;
        private System.Windows.Forms.Button btnTraduzir;
        private System.Windows.Forms.TextBox txtPagIni;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label lblPagFim;
        private System.Windows.Forms.TextBox txtPagFim;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSearvh;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbDe;
        private System.Windows.Forms.Label lblArquvo;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.ComboBox cbPara;
    }
}

