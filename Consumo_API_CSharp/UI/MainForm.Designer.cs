namespace Consumo_API_CSharp.UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;

    private TableLayoutPanel layoutRoot = null!;
    private Panel pnlHeader = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Label lblAppName = null!;
    private Panel pnlToolbar = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;
    private Button btnClear = null!;
    private Panel pnlToolbarDivider = null!;
    private Label lblId = null!;
    private NumericUpDown numId = null!;
    private Button btnById = null!;
    private Button btnRandom = null!;
    private Button btnPrevious = null!;
    private Button btnNext = null!;
    private Label lblPage = null!;
    private Label lblStatus = null!;
    private Panel pnlGridOuter = null!;
    private DataGridView dgvQuotes = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colAuthor = null!;
    private DataGridViewTextBoxColumn colQuote = null!;
    private Panel pnlDetailOuter = null!;
    private Panel pnlDetailCard = null!;
    private Panel pnlDetailAccent = null!;
    private Label lblDetailTitle = null!;
    private Label lblDetailAuthor = null!;
    private Label lblDetailQuote = null!;
    private Label lblDetailMeta = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        layoutRoot = new TableLayoutPanel();
        pnlHeader = new Panel();
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblAppName = new Label();
        pnlToolbar = new Panel();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnClear = new Button();
        pnlToolbarDivider = new Panel();
        lblId = new Label();
        numId = new NumericUpDown();
        btnById = new Button();
        btnRandom = new Button();
        btnPrevious = new Button();
        btnNext = new Button();
        lblPage = new Label();
        lblStatus = new Label();
        pnlGridOuter = new Panel();
        dgvQuotes = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colAuthor = new DataGridViewTextBoxColumn();
        colQuote = new DataGridViewTextBoxColumn();
        pnlDetailOuter = new Panel();
        pnlDetailCard = new Panel();
        pnlDetailAccent = new Panel();
        lblDetailTitle = new Label();
        lblDetailAuthor = new Label();
        lblDetailQuote = new Label();
        lblDetailMeta = new Label();

        layoutRoot.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
        pnlGridOuter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvQuotes).BeginInit();
        pnlDetailOuter.SuspendLayout();
        pnlDetailCard.SuspendLayout();
        SuspendLayout();

        //
        // layoutRoot
        //
        layoutRoot.BackColor = Color.FromArgb(244, 246, 250);
        layoutRoot.ColumnCount = 1;
        layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutRoot.Controls.Add(pnlHeader, 0, 0);
        layoutRoot.Controls.Add(pnlToolbar, 0, 1);
        layoutRoot.Controls.Add(pnlGridOuter, 0, 2);
        layoutRoot.Controls.Add(pnlDetailOuter, 0, 3);
        layoutRoot.Dock = DockStyle.Fill;
        layoutRoot.Location = new Point(0, 0);
        layoutRoot.Name = "layoutRoot";
        layoutRoot.RowCount = 4;
        layoutRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
        layoutRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
        layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 196F));
        layoutRoot.Size = new Size(1164, 741);
        layoutRoot.TabIndex = 0;

        //
        // pnlHeader
        //
        pnlHeader.BackColor = Color.FromArgb(23, 37, 84);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblAppName);
        pnlHeader.Dock = DockStyle.Fill;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1164, 96);
        pnlHeader.TabIndex = 0;

        //
        // lblTitle
        //
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(24, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(310, 36);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Citações — DummyJSON";

        //
        // lblSubtitle
        //
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9.5F);
        lblSubtitle.ForeColor = Color.FromArgb(164, 181, 215);
        lblSubtitle.Location = new Point(26, 56);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(410, 17);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Consumo de Web API em C#  ·  GET https://dummyjson.com/quotes";

        //
        // lblAppName
        //
        lblAppName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblAppName.Font = new Font("Segoe UI", 9F);
        lblAppName.ForeColor = Color.FromArgb(148, 163, 184);
        lblAppName.Location = new Point(950, 32);
        lblAppName.Name = "lblAppName";
        lblAppName.Size = new Size(190, 24);
        lblAppName.TabIndex = 2;
        lblAppName.Text = "Consumo_API_CSharp";
        lblAppName.TextAlign = ContentAlignment.MiddleRight;

        //
        // pnlToolbar
        //
        pnlToolbar.BackColor = Color.White;
        pnlToolbar.Controls.Add(txtSearch);
        pnlToolbar.Controls.Add(btnSearch);
        pnlToolbar.Controls.Add(btnClear);
        pnlToolbar.Controls.Add(pnlToolbarDivider);
        pnlToolbar.Controls.Add(lblId);
        pnlToolbar.Controls.Add(numId);
        pnlToolbar.Controls.Add(btnById);
        pnlToolbar.Controls.Add(btnRandom);
        pnlToolbar.Controls.Add(btnPrevious);
        pnlToolbar.Controls.Add(btnNext);
        pnlToolbar.Controls.Add(lblPage);
        pnlToolbar.Controls.Add(lblStatus);
        pnlToolbar.Dock = DockStyle.Fill;
        pnlToolbar.Location = new Point(0, 96);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Size = new Size(1164, 122);
        pnlToolbar.TabIndex = 1;

        //
        // txtSearch
        //
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Segoe UI", 10.5F);
        txtSearch.Location = new Point(24, 18);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Pesquisar por autor ou texto...";
        txtSearch.Size = new Size(360, 26);
        txtSearch.TabIndex = 0;

        //
        // btnSearch
        //
        btnSearch.BackColor = Color.FromArgb(37, 99, 235);
        btnSearch.Cursor = Cursors.Hand;
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(396, 16);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(110, 34);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Pesquisar";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += BtnSearch_Click;

        //
        // btnClear
        //
        btnClear.BackColor = Color.White;
        btnClear.Cursor = Cursors.Hand;
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9.75F);
        btnClear.ForeColor = Color.FromArgb(51, 65, 85);
        btnClear.Location = new Point(514, 16);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(90, 34);
        btnClear.TabIndex = 2;
        btnClear.Text = "Limpar";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += BtnClear_Click;

        //
        // pnlToolbarDivider
        //
        pnlToolbarDivider.BackColor = Color.FromArgb(226, 232, 240);
        pnlToolbarDivider.Location = new Point(628, 18);
        pnlToolbarDivider.Name = "pnlToolbarDivider";
        pnlToolbarDivider.Size = new Size(1, 34);
        pnlToolbarDivider.TabIndex = 3;

        //
        // lblId
        //
        lblId.AutoSize = true;
        lblId.Font = new Font("Segoe UI", 10F);
        lblId.ForeColor = Color.FromArgb(71, 85, 105);
        lblId.Location = new Point(650, 24);
        lblId.Name = "lblId";
        lblId.Size = new Size(26, 19);
        lblId.TabIndex = 4;
        lblId.Text = "ID:";

        //
        // numId
        //
        numId.BorderStyle = BorderStyle.FixedSingle;
        numId.Font = new Font("Segoe UI", 10F);
        numId.Location = new Point(684, 19);
        numId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numId.Name = "numId";
        numId.Size = new Size(90, 25);
        numId.TabIndex = 5;
        numId.TextAlign = HorizontalAlignment.Right;
        numId.Value = new decimal(new int[] { 1, 0, 0, 0 });

        //
        // btnById
        //
        btnById.BackColor = Color.FromArgb(37, 99, 235);
        btnById.Cursor = Cursors.Hand;
        btnById.FlatAppearance.BorderSize = 0;
        btnById.FlatStyle = FlatStyle.Flat;
        btnById.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnById.ForeColor = Color.White;
        btnById.Location = new Point(786, 16);
        btnById.Name = "btnById";
        btnById.Size = new Size(100, 34);
        btnById.TabIndex = 6;
        btnById.Text = "Consultar";
        btnById.UseVisualStyleBackColor = false;
        btnById.Click += BtnById_Click;

        //
        // btnRandom
        //
        btnRandom.BackColor = Color.FromArgb(5, 150, 105);
        btnRandom.Cursor = Cursors.Hand;
        btnRandom.FlatAppearance.BorderSize = 0;
        btnRandom.FlatStyle = FlatStyle.Flat;
        btnRandom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnRandom.ForeColor = Color.White;
        btnRandom.Location = new Point(896, 16);
        btnRandom.Name = "btnRandom";
        btnRandom.Size = new Size(160, 34);
        btnRandom.TabIndex = 7;
        btnRandom.Text = "Citação aleatória";
        btnRandom.UseVisualStyleBackColor = false;
        btnRandom.Click += BtnRandom_Click;

        //
        // btnPrevious
        //
        btnPrevious.BackColor = Color.White;
        btnPrevious.Cursor = Cursors.Hand;
        btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnPrevious.FlatStyle = FlatStyle.Flat;
        btnPrevious.Font = new Font("Segoe UI", 9F);
        btnPrevious.ForeColor = Color.FromArgb(51, 65, 85);
        btnPrevious.Location = new Point(24, 74);
        btnPrevious.Name = "btnPrevious";
        btnPrevious.Size = new Size(110, 30);
        btnPrevious.TabIndex = 8;
        btnPrevious.Text = "< Anterior";
        btnPrevious.UseVisualStyleBackColor = false;
        btnPrevious.Click += BtnPrevious_Click;

        //
        // btnNext
        //
        btnNext.BackColor = Color.White;
        btnNext.Cursor = Cursors.Hand;
        btnNext.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
        btnNext.FlatStyle = FlatStyle.Flat;
        btnNext.Font = new Font("Segoe UI", 9F);
        btnNext.ForeColor = Color.FromArgb(51, 65, 85);
        btnNext.Location = new Point(248, 74);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(110, 30);
        btnNext.TabIndex = 9;
        btnNext.Text = "Seguinte >";
        btnNext.UseVisualStyleBackColor = false;
        btnNext.Click += BtnNext_Click;

        //
        // lblPage
        //
        lblPage.AutoSize = true;
        lblPage.Font = new Font("Segoe UI", 9.5F);
        lblPage.ForeColor = Color.FromArgb(71, 85, 105);
        lblPage.Location = new Point(144, 80);
        lblPage.Name = "lblPage";
        lblPage.Size = new Size(82, 17);
        lblPage.TabIndex = 10;
        lblPage.Text = "Página 1 de 1";

        //
        // lblStatus
        //
        lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblStatus.Font = new Font("Segoe UI", 9F);
        lblStatus.ForeColor = Color.FromArgb(100, 116, 139);
        lblStatus.Location = new Point(560, 78);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(580, 24);
        lblStatus.TabIndex = 11;
        lblStatus.Text = "A carregar citações...";
        lblStatus.TextAlign = ContentAlignment.MiddleRight;

        //
        // pnlGridOuter
        //
        pnlGridOuter.BackColor = Color.FromArgb(244, 246, 250);
        pnlGridOuter.Controls.Add(dgvQuotes);
        pnlGridOuter.Dock = DockStyle.Fill;
        pnlGridOuter.Location = new Point(0, 218);
        pnlGridOuter.Name = "pnlGridOuter";
        pnlGridOuter.Padding = new Padding(24, 18, 24, 12);
        pnlGridOuter.Size = new Size(1164, 327);
        pnlGridOuter.TabIndex = 2;

        //
        // dgvQuotes
        //
        dgvQuotes.AllowUserToAddRows = false;
        dgvQuotes.AllowUserToDeleteRows = false;
        dgvQuotes.AllowUserToResizeRows = false;
        dgvQuotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dgvQuotes.BackgroundColor = Color.White;
        dgvQuotes.BorderStyle = BorderStyle.None;
        dgvQuotes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvQuotes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgvQuotes.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = Color.FromArgb(248, 250, 252),
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            SelectionBackColor = Color.FromArgb(248, 250, 252),
            SelectionForeColor = Color.FromArgb(100, 116, 139),
            WrapMode = DataGridViewTriState.False
        };
        dgvQuotes.ColumnHeadersHeight = 40;
        dgvQuotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvQuotes.Columns.AddRange(new DataGridViewColumn[] { colId, colAuthor, colQuote });
        dgvQuotes.DefaultCellStyle = new DataGridViewCellStyle
        {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = Color.White,
            Font = new Font("Segoe UI", 9.75F),
            ForeColor = Color.FromArgb(30, 41, 59),
            Padding = new Padding(6, 8, 6, 8),
            SelectionBackColor = Color.FromArgb(219, 234, 254),
            SelectionForeColor = Color.FromArgb(17, 24, 39),
            WrapMode = DataGridViewTriState.True
        };
        dgvQuotes.Dock = DockStyle.Fill;
        dgvQuotes.EnableHeadersVisualStyles = false;
        dgvQuotes.GridColor = Color.FromArgb(238, 242, 247);
        dgvQuotes.Location = new Point(24, 18);
        dgvQuotes.MultiSelect = false;
        dgvQuotes.Name = "dgvQuotes";
        dgvQuotes.ReadOnly = true;
        dgvQuotes.RowHeadersVisible = false;
        dgvQuotes.RowTemplate.Height = 34;
        dgvQuotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvQuotes.Size = new Size(1116, 297);
        dgvQuotes.TabIndex = 0;
        dgvQuotes.SelectionChanged += DgvQuotes_SelectionChanged;

        //
        // colId
        //
        colId.HeaderText = "ID";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Width = 60;

        //
        // colAuthor
        //
        colAuthor.DefaultCellStyle = new DataGridViewCellStyle
        {
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold),
            ForeColor = Color.FromArgb(23, 37, 84)
        };
        colAuthor.HeaderText = "Autor";
        colAuthor.Name = "colAuthor";
        colAuthor.ReadOnly = true;
        colAuthor.Width = 200;

        //
        // colQuote
        //
        colQuote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colQuote.HeaderText = "Citação";
        colQuote.MinimumWidth = 300;
        colQuote.Name = "colQuote";
        colQuote.ReadOnly = true;

        //
        // pnlDetailOuter
        //
        pnlDetailOuter.BackColor = Color.FromArgb(244, 246, 250);
        pnlDetailOuter.Controls.Add(pnlDetailCard);
        pnlDetailOuter.Dock = DockStyle.Fill;
        pnlDetailOuter.Location = new Point(0, 545);
        pnlDetailOuter.Name = "pnlDetailOuter";
        pnlDetailOuter.Padding = new Padding(24, 0, 24, 20);
        pnlDetailOuter.Size = new Size(1164, 196);
        pnlDetailOuter.TabIndex = 3;

        //
        // pnlDetailCard
        //
        pnlDetailCard.BackColor = Color.White;
        pnlDetailCard.Controls.Add(lblDetailTitle);
        pnlDetailCard.Controls.Add(lblDetailAuthor);
        pnlDetailCard.Controls.Add(lblDetailQuote);
        pnlDetailCard.Controls.Add(lblDetailMeta);
        pnlDetailCard.Controls.Add(pnlDetailAccent);
        pnlDetailCard.Dock = DockStyle.Fill;
        pnlDetailCard.Location = new Point(24, 0);
        pnlDetailCard.Name = "pnlDetailCard";
        pnlDetailCard.Size = new Size(1116, 176);
        pnlDetailCard.TabIndex = 0;

        //
        // pnlDetailAccent
        //
        pnlDetailAccent.BackColor = Color.FromArgb(37, 99, 235);
        pnlDetailAccent.Dock = DockStyle.Left;
        pnlDetailAccent.Location = new Point(0, 0);
        pnlDetailAccent.Name = "pnlDetailAccent";
        pnlDetailAccent.Size = new Size(4, 176);
        pnlDetailAccent.TabIndex = 0;

        //
        // lblDetailTitle
        //
        lblDetailTitle.AutoSize = true;
        lblDetailTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
        lblDetailTitle.ForeColor = Color.FromArgb(100, 116, 139);
        lblDetailTitle.Location = new Point(24, 14);
        lblDetailTitle.Name = "lblDetailTitle";
        lblDetailTitle.Size = new Size(128, 13);
        lblDetailTitle.TabIndex = 1;
        lblDetailTitle.Text = "CITAÇÃO SELECIONADA";

        //
        // lblDetailAuthor
        //
        lblDetailAuthor.AutoSize = true;
        lblDetailAuthor.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
        lblDetailAuthor.ForeColor = Color.FromArgb(15, 23, 42);
        lblDetailAuthor.Location = new Point(24, 34);
        lblDetailAuthor.Name = "lblDetailAuthor";
        lblDetailAuthor.Size = new Size(248, 23);
        lblDetailAuthor.TabIndex = 2;
        lblDetailAuthor.Text = "Selecione uma citação na lista";

        //
        // lblDetailQuote
        //
        lblDetailQuote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblDetailQuote.Font = new Font("Segoe UI", 10.5F);
        lblDetailQuote.ForeColor = Color.FromArgb(51, 65, 85);
        lblDetailQuote.Location = new Point(24, 66);
        lblDetailQuote.Name = "lblDetailQuote";
        lblDetailQuote.Size = new Size(1068, 54);
        lblDetailQuote.TabIndex = 3;
        lblDetailQuote.Text = "";

        //
        // lblDetailMeta
        //
        lblDetailMeta.AutoSize = true;
        lblDetailMeta.Font = new Font("Segoe UI", 8.5F);
        lblDetailMeta.ForeColor = Color.FromArgb(148, 163, 184);
        lblDetailMeta.Location = new Point(24, 136);
        lblDetailMeta.Name = "lblDetailMeta";
        lblDetailMeta.Size = new Size(0, 15);
        lblDetailMeta.TabIndex = 4;

        //
        // MainForm
        //
        AcceptButton = btnSearch;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(244, 246, 250);
        ClientSize = new Size(1164, 741);
        Controls.Add(layoutRoot);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1120, 720);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Consumo_API_CSharp — Citações (DummyJSON)";

        layoutRoot.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlToolbar.ResumeLayout(false);
        pnlToolbar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numId).EndInit();
        pnlGridOuter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvQuotes).EndInit();
        pnlDetailOuter.ResumeLayout(false);
        pnlDetailCard.ResumeLayout(false);
        pnlDetailCard.PerformLayout();
        ResumeLayout(false);
    }
}
