using System;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public partial class basket : Form
    {
        public basket()
        {
            InitializeComponent();
        }

        private void basket_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Globals.logic.getDataTable(@"SELECT        dbo.Costume.name AS [Название костюма], dbo.Costume.daylyPrice AS [Цена за день], dbo.Costume.price AS Стоимость, dbo.Size.international AS Размер, dbo.OrderBody.count AS Количество
FROM            dbo.OrderBody INNER JOIN
                         dbo.Costume ON dbo.OrderBody.id = dbo.Costume.id INNER JOIN
                         dbo.Size ON dbo.OrderBody.id = dbo.Size.id");
            dataGridView1.Refresh();
        }
    }
}
