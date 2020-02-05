namespace WindowsFormsApp1
{


    partial class Тестовая_бд_DataSet
    {
        partial class УловыDataTable
        {
        }
    }
}

namespace WindowsFormsApp1.Тестовая_бд_DataSetTableAdapters
{
    partial class ПробыTableAdapter
    {
    }

    partial class БАTableAdapter
    {
    }

    public partial class уловыTableAdapter
    {
         public string query
        {
            get
            {
                return "sl";
            }
            set
            {
                this.Adapter.SelectCommand.CommandText = value;
            }
        }
    }
}
