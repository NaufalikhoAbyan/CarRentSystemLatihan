using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.RiwayatTransaksi
{
    public partial class RiwayatTransaksiManagement : Form
    {
        DataTable transactionTable = new DataTable();

        double pageNumber;
        int currentpage = 1;
        int dataIndex;

        List<int> cardIds = new List<int>();
        public RiwayatTransaksiManagement()
        {
            InitializeComponent();
            for(int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_Data();
            Fill_Data();
        }

        private void Get_Data()
        {
            transactionTable = transactionsTableAdapter.GetData();
            pageNumber = Math.Ceiling(Convert.ToDouble(transactionTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            if(transactionTable.Rows.Count > 0)
            {
                int dataCardNumber = 1;
                for(int i = dataIndex; i < dataIndex + 3;  i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var renterLabel = Controls.Find("renterLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var rentDateLabel = Controls.Find("rentDateLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var returnDateLabel = Controls.Find("returnDateLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var priceLabel = Controls.Find("priceLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if(i < transactionTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        renterLabel.Text = $"{carsTableAdapter.GetDataById(Convert.ToInt32(transactionTable.Rows[i]["car_id"])).Rows[0]["brand"]} → {customersTableAdapter.GetDataById(Convert.ToInt32(transactionTable.Rows[i]["customer_id"])).Rows[0]["name"]}";
                        rentDateLabel.Text = transactionTable.Rows[i]["rent_date"].ToString();
                        returnDateLabel.Text = transactionTable.Rows[i]["return_date"].ToString();
                        priceLabel.Text = transactionTable.Rows[i]["total_price"].ToString() ;
                        dataCardNumber++;
                        cardIds[dataCardNumber] = Convert.ToInt32(transactionTable.Rows[i]["transaction_id"]);
                    }

                }


            }
        }
    }
}
