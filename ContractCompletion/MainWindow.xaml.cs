using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ContractCompletion
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {
            if (tenantTextBlock.Text == "" || issuingAuthorityTextBlock.Text == "" || passportNumberTenantTextBlock.Text == ""
                || passportSeriesTenantTextBlock.Text == "" || dateTextBlock.Text == "")
            {
                MessageBox.Show("Договор заполнен не в полном объеме");
            }
            else
            {
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    print.PrintDocument(((IDocumentPaginatorSource)flowDocumentScrollViewer.Document).DocumentPaginator, "A flow Document");
                }
            }
        }
    }
}
