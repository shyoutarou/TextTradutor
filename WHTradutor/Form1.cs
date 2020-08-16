using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WHTradutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] Chop(string value, int length)
        {
            int strLength = value.Length;
            int strCount = (strLength + length - 1) / length;
            string[] result = new string[strCount];
            for (int i = 0; i < strCount; ++i)
            {
                result[i] = value.Substring(i * length, Math.Min(length, strLength));
                strLength -= length;
            }
            return result;
        }

        private static string LoadText(string file, string pagini, string pagfim)
        {
            string pageContent = "";

            using (PdfReader pdfReader = new PdfReader(file))
            {
                using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
                {
                    for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                    {
                        if (page >= Convert.ToInt32(pagini) && ((pagfim == "") || (pagfim != "" && page <= Convert.ToInt32(pagfim))))
                        {
                            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                            pageContent += PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
                        }
                    }
                }
            }

            return pageContent;
        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            var txtsemlinhas = txtOriginal.Text.Replace("\n", "    ");
            txtsemlinhas = txtsemlinhas.Replace("#", "...");
            txtsemlinhas = txtsemlinhas.Replace("&", "ATENÇÂO");
            
            // Translation Data
            string translation = "";

            IEnumerable<string> listresult = Chop(txtsemlinhas, 8000);

            foreach (var texto in listresult)
            {
                var languageDe = cbDe.SelectedItem;
                var languagePara = cbPara.SelectedItem;

                //"ja"  "en", "pt", "de"
                string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
           languageDe, languagePara, Uri.EscapeUriString(texto));
                HttpClient httpClient = new HttpClient();

                var conexao = httpClient.GetStringAsync(url);

                if (conexao != null)
                {
                    string result = conexao.Result;

                    // Get all json data
                    var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

                    // Extract just the first array element (This is the only data we are interested in)
                    var translationItems = jsonData[0];

                    // Loop through the collection extracting the translated objects
                    foreach (object item in translationItems)
                    {
                        // Convert the item array to IEnumerable
                        IEnumerable<dynamic> translationLineObject = item as IEnumerable<dynamic>;

                        // Convert the IEnumerable translationLineObject to a IEnumerator
                        IEnumerator<dynamic> translationLineString = translationLineObject.GetEnumerator();

                        // Get first object in IEnumerator
                        translationLineString.MoveNext();

                        // Save its value (translated text)
                        translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                    }
                }
                else txtTraduzido.Text = "SEM CONEXÃO";
            }

            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };

            txtTraduzido.Text = translation;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbSearvh.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = @"C:\Users\x_kat\Downloads\Linguagens\paradigma_OO\5_C#\";

            switch (cbTipo.SelectedItem)
            {
                case "pdf":
                    dialog.Filter = "PDF files | *.pdf";
                    break;
                case "txt":
                    dialog.Filter = "txt files (*.txt) | *.txt";
                    break;
                case "md":
                    dialog.Filter = "MarkDown (*.md) | *.md";
                    break;
                default:
                    dialog.Filter = "All files(*.*) | *.* ";
                    break;
            }
         
            
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            txtTraduzido.Text = "";

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                if (dialog.FileName.Contains("pdf"))
                {
                    using (PdfReader pdfReader = new PdfReader(dialog.FileName))
                    {
                        using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
                        {
                            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                            {
                                if (txtSearch.Text != "")
                                {
                                    txtFileName.Text = dialog.FileName;

                                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                                    var pageContent = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);

                                    if (pageContent.Contains(txtSearch.Text))
                                    {
                                        var indextrecho = pageContent.IndexOf(txtSearch.Text);
                                        var difflenght = pageContent.Length - indextrecho;

                                        var trecho = pageContent.Substring(indextrecho, difflenght > 100 ? 100 : difflenght);
                                        trecho = trecho.Replace("\n", "");

                                        var item = page.ToString() + " - " + trecho + "\n";
                                        lbSearvh.Items.Add(item);
                                    }
                                }
                            }

                            if (lbSearvh.Items.Count == 0) lbSearvh.Items.Add("SEM RESULTADOS");
                        }
                    }
                }
                else
                {
                    // Para ler o arquivo chamado "Arquivo"
                    string fileContent = File.ReadAllText(dialog.FileName);
                    txtFileName.Text = dialog.FileName;
                    txtOriginal.Text = fileContent;
                }
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            var pagini = txtPagIni.Text;
            var pagfim = txtPagFim.Text;

            if (pagini != "")
            {
                if (txtFileName.Text == "")
                {
                    OpenFileDialog dialog = new OpenFileDialog();

                    dialog.InitialDirectory = @"C:\Users\x_kat\Downloads\";
                    dialog.Filter = "PDF files | *.pdf|txt files (*.txt)|*.txt|All files (*.*)|*.*"; // file types, that will be allowed to upload
                    dialog.Multiselect = false; // allow/deny user to upload more than one file at a time

                    if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                    {
                        txtFileName.Text = dialog.FileName;
                        txtOriginal.Text = LoadText(txtFileName.Text, pagini, pagfim);
                    }
                }
                else
                {
                    txtOriginal.Text = LoadText(txtFileName.Text, pagini, pagfim);
                }

                txtTraduzido.Text = "";
            }
            else
            {
                MessageBox.Show("Informe Página.");
            }
        }

        private void lbSearvh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = lbSearvh.SelectedItem.ToString();
            var pagina = sel.Substring(0, sel.IndexOf('-'));
            txtPagIni.Text = pagina;
            txtPagFim.Text = pagina;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
