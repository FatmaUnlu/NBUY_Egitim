using MyCoin.Services;
using MyCoin.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Symbol> _symbols = new List<Symbol>();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var result = new ExchangeInfoServices().Result();
                //Console.WriteLine();
                _symbols = result.Symbols;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
           
            //sadece satışta olanlar gelsin diyelim.
            _symbols = _symbols
                .Where(x => x.status == "TRADING")
                .OrderBy(x => x.symbol)
                .ToList(); //bu işlem geri ınumarable döndürür. o yüazden To list kullanıp listeye çeviriyoruz.

            //1.yol olarak foreachle dönüp hepsini listeye eklyebilirim 
            //2.yol
            lstExchangeInfo.DataSource = _symbols;
            lstExchangeInfo.DisplayMember = nameof(Symbol.symbol); //nameof yanlış yazmamayı garanti eder.

            this.Text = $"{ _symbols.Count} adet Coin listelenmektedir";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                lstExchangeInfo.DataSource = _symbols; //içi boşsa tüm listeyi getir
                this.Text = $"{_symbols.Count} adet Coin listelenmektedir.";
            }
            else //doluysa sartlarauysnı getir
            {
                var result = _symbols.Where(x => x.symbol.Contains(txtAra.Text.ToUpper())).ToList();
                lstExchangeInfo.DataSource = result;
                this.Text = $"{result.Count} adet Coin listelenmektedir.";
            }

            
        }

        private Symbol _seciliSymbol;
        private void lstExchangeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExchangeInfo.SelectedItem == null) return;
            {
                _seciliSymbol = lstExchangeInfo.SelectedItem as Symbol;
            }
            //try
            //{
            //    var result = new SymbolTickerService().Result(_seciliSymbol.symbol);

            //    lblSymbol.Text = result.Symbol;
            //    lblFiyat.Text = $"{ result.LastPrice}\n {result.PriceChangePercent / 100:P}";
            //    lblFiyat.ForeColor = result.PriceChange > 0 ? Color.LimeGreen : Color.Tomato;
            //    lblInfo.Text = $"En Düşük: { result.LowPrice}\n En Yüksek: {result.HighPrice}\n Açılış: {BinanceHelper.DateConverter(result.OpenTime)}\n Kapanış: {BinanceHelper.DateConverter(result.CloseTime)} ";
            //}

            //catch (Exception ex)
            //{

            //    MessageBox.Show($"{ex.Message}");
            //}
            GetCoinInfo();
        }

        private void GetCoinInfo()
        {
            try
            {
                var result = new SymbolTickerService().Result(_seciliSymbol.symbol);

                lblSymbol.Text = result.Symbol;
                lblFiyat.Text = $"{ result.LastPrice}\n {result.PriceChangePercent / 100:P}";
                lblFiyat.ForeColor = result.PriceChange > 0 ? Color.LimeGreen : Color.Tomato;
                lblInfo.Text = $"En Düşük: { result.LowPrice}\n En Yüksek: {result.HighPrice}\n Açılış: {BinanceHelper.DateConverter(result.OpenTime)}\n Kapanış: {BinanceHelper.DateConverter(result.CloseTime)} ";
            }

            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCoinInfo();
        }

        private void lblSymbol_Click(object sender, EventArgs e)
        {
            if (_seciliSymbol == null) return;
            
            var binanceUrl = $"http://www.binance.com/tr/trade/{_seciliSymbol.symbol}";

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = binanceUrl,
                UseShellExecute = true

            };
            Process.Start(psInfo); //url in çalışmasını sağlar

        }
    }
}
