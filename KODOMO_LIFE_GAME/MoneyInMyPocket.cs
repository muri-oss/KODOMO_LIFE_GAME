using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KODOMO_LIFE_GAME
{
    public partial class MoneyInMyPocket : UserControl
    {
        private int m_Total;
        private int m_InOut;
        public MoneyInMyPocket()
        {
            InitializeComponent();

            m_Total = 0;
            m_InOut = 0;
            ShowMoney();
        }

        private void ShowMoney()
        {
            TboxTotal.Text = "$" + m_Total.ToString();
            TboxInOut.Text = "$" + m_InOut.ToString();
        }

        private void Btn1000_Click(object sender, EventArgs e)
        {
            m_InOut += 1000;
            ShowMoney();
        }

        private void Btn5000_Click(object sender, EventArgs e)
        {
            m_InOut += 5000;
            ShowMoney();
        }

        private void Btn100_Click(object sender, EventArgs e)
        {
            m_InOut += 100;
            ShowMoney();
        }

        private void Btn10000_Click(object sender, EventArgs e)
        {
            m_InOut += 10000;
            ShowMoney();
        }

        private void Btn50000_Click(object sender, EventArgs e)
        {
            m_InOut += 50000;
            ShowMoney();
        }

        private void BtnIncome_Click(object sender, EventArgs e)
        {
            m_Total += m_InOut;
            m_InOut = 0;
            ShowMoney();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            m_Total -= m_InOut;
            m_InOut = 0;
            ShowMoney();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_InOut = 0;
            ShowMoney();
        }

    }
}
