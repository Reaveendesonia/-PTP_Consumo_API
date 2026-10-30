using Consumo_API_CSharp.Models;
using Consumo_API_CSharp.Services;

namespace Consumo_API_CSharp.UI;

public partial class MainForm : Form
{
    private const int PageSize = 10;

    private static readonly Color MutedTextColor = Color.FromArgb(100, 116, 139);
    private static readonly Color ErrorColor = Color.FromArgb(220, 38, 38);
    private static readonly Color SuccessColor = Color.FromArgb(5, 150, 105);

    private readonly QuoteApiService _api = new();

    private int _currentPage = 1;
    private int _totalQuotes;
    private string _activeSearch = string.Empty;
    private IReadOnlyList<Quote>? _searchResults;
    private bool _isLoading;

    public MainForm()
    {
        InitializeComponent();
    }

    protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        await LoadQuotesAsync();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _api.Dispose();
        base.OnFormClosed(e);
    }

    private async Task LoadQuotesAsync()
    {
        if (_isLoading)
        {
            return;
        }

        SetLoading(true);
        SetStatus("A carregar citações...", MutedTextColor);

        try
        {
            IReadOnlyList<Quote> quotes;

            if (string.IsNullOrWhiteSpace(_activeSearch))
            {
                QuotesResponse response = await _api.GetQuotesAsync(PageSize, (_currentPage - 1) * PageSize);
                _totalQuotes = response.Total;
                quotes = response.Quotes;
            }
            else
            {
                if (_searchResults is null)
                {
                    SetStatus("A carregar o catálogo completo para pesquisa...", MutedTextColor);
                    _searchResults = await _api.SearchQuotesAsync(_activeSearch);
                }

                _totalQuotes = _searchResults.Count;
                quotes = _searchResults
                    .Skip((_currentPage - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }

            ShowQuotes(quotes);

            string status = string.IsNullOrWhiteSpace(_activeSearch)
                ? $"{_totalQuotes} citações disponíveis na API"
                : $"{_totalQuotes} resultado(s) para \"{_activeSearch}\"";

            SetStatus(status, MutedTextColor);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        finally
        {
            SetLoading(false);
        }
    }

    private void ShowQuotes(IReadOnlyList<Quote> quotes)
    {
        dgvQuotes.Rows.Clear();

        foreach (Quote quote in quotes)
        {
            int index = dgvQuotes.Rows.Add(quote.Id, quote.Author, quote.Text);
            dgvQuotes.Rows[index].Tag = quote;
        }

        UpdatePagination();

        if (dgvQuotes.Rows.Count > 0)
        {
            dgvQuotes.ClearSelection();
            dgvQuotes.CurrentCell = dgvQuotes.Rows[0].Cells[0];
            dgvQuotes.Rows[0].Selected = true;
        }
        else
        {
            ClearDetails();
        }
    }

    private void DgvQuotes_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvQuotes.CurrentRow?.Tag is Quote quote)
        {
            ShowDetails(quote, "Citação selecionada");
        }
        else
        {
            ClearDetails();
        }
    }

    private void ShowDetails(Quote quote, string context)
    {
        lblDetailTitle.Text = context.ToUpperInvariant();
        lblDetailAuthor.Text = quote.Author;
        lblDetailQuote.Text = $"“{quote.Text}”";
        lblDetailMeta.Text = $"ID {quote.Id}";
    }

    private void ClearDetails()
    {
        lblDetailTitle.Text = "CITAÇÃO SELECIONADA";
        lblDetailAuthor.Text = "Selecione uma citação na lista";
        lblDetailQuote.Text = string.Empty;
        lblDetailMeta.Text = string.Empty;
    }

    private async void BtnSearch_Click(object? sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        _activeSearch = txtSearch.Text.Trim();
        _searchResults = null;
        _currentPage = 1;

        await LoadQuotesAsync();
    }

    private async void BtnClear_Click(object? sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        txtSearch.Clear();
        _activeSearch = string.Empty;
        _searchResults = null;
        _currentPage = 1;

        await LoadQuotesAsync();
    }

    private async void BtnPrevious_Click(object? sender, EventArgs e)
    {
        if (_isLoading || _currentPage <= 1)
        {
            return;
        }

        _currentPage--;
        await LoadQuotesAsync();
    }

    private async void BtnNext_Click(object? sender, EventArgs e)
    {
        if (_isLoading || _currentPage >= TotalPages())
        {
            return;
        }

        _currentPage++;
        await LoadQuotesAsync();
    }

    private async void BtnRandom_Click(object? sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        SetLoading(true);
        SetStatus("A obter uma citação aleatória...", MutedTextColor);

        try
        {
            Quote quote = await _api.GetRandomQuoteAsync();
            dgvQuotes.ClearSelection();
            ShowDetails(quote, "Citação aleatória");
            SetStatus($"Citação #{quote.Id} obtida com sucesso", SuccessColor);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        finally
        {
            SetLoading(false);
        }
    }

    private async void BtnById_Click(object? sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        int id = (int)numId.Value;

        SetLoading(true);
        SetStatus($"A consultar a citação #{id}...", MutedTextColor);

        try
        {
            Quote quote = await _api.GetQuoteByIdAsync(id);
            dgvQuotes.ClearSelection();
            ShowDetails(quote, $"Citação #{id}");
            SetStatus($"Citação #{id} carregada com sucesso", SuccessColor);
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
        finally
        {
            SetLoading(false);
        }
    }

    private int TotalPages()
    {
        return Math.Max(1, (int)Math.Ceiling(_totalQuotes / (double)PageSize));
    }

    private void UpdatePagination()
    {
        lblPage.Text = $"Página {_currentPage} de {TotalPages()}";
        btnPrevious.Enabled = !_isLoading && _currentPage > 1;
        btnNext.Enabled = !_isLoading && _currentPage < TotalPages();
    }

    private void SetLoading(bool loading)
    {
        _isLoading = loading;
        UseWaitCursor = loading;

        bool enabled = !loading;
        txtSearch.Enabled = enabled;
        btnSearch.Enabled = enabled;
        btnClear.Enabled = enabled;
        numId.Enabled = enabled;
        btnById.Enabled = enabled;
        btnRandom.Enabled = enabled;
        dgvQuotes.Enabled = enabled;

        UpdatePagination();
    }

    private void SetStatus(string message, Color color)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = color;
    }

    private void HandleError(Exception exception)
    {
        string message = exception switch
        {
            ApiException apiException => apiException.Message,
            HttpRequestException => "Falha de ligação à API. Verifique a ligação à Internet e tente novamente.",
            TaskCanceledException => "O pedido expirou. A API demorou demasiado tempo a responder.",
            _ => $"Ocorreu um erro inesperado: {exception.Message}"
        };

        SetStatus("Ocorreu um erro.", ErrorColor);
        MessageBox.Show(this, message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
