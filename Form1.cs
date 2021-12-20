using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestWork23
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=docs.mdb;";
        
        public Form1()
        {
            InitializeComponent();
        }
        public void SetValue(OleDbCommand command, object value, string field)
        {
            command.Parameters.Add(field, OleDbType.VarChar).Value = value;
        }

        public void LoadDataResult(OleDbCommand command, DataGridView dtg)
        {
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dtg.DataSource = dt;
        }

        public bool IsEmpty(object value)
        {
            return value == null || value == "";
        }

        public void NullCheck(ref object value)
        {
            if (IsEmpty(value)) 
                value = DBNull.Value;
        }

        private void buttonSearch_Click(object sender, EventArgs e) 
        {
            // Возьмем введеные значения
            object nameFirm = txtNameFirm.Text;
            object jurCityId = txtJurAdr.Text;
            object postCityId = txtPostAdr.Text;

            using (OleDbConnection oleDbCon = new OleDbConnection(connectString))
            {
                oleDbCon.Open();

                OleDbCommand commandResult = new OleDbCommand("REQUEST_FULL", oleDbCon);
                commandResult.CommandType = CommandType.StoredProcedure;

                OleDbCommand commandByFirm = new OleDbCommand("TABLE_ALL_SUMS_BY_FIRM", oleDbCon);
                commandByFirm.CommandType = CommandType.StoredProcedure;

                NullCheck(ref nameFirm);
                NullCheck(ref jurCityId);
                NullCheck(ref postCityId);

                SetValue(commandResult, nameFirm, "[Название организации]");
                SetValue(commandResult, jurCityId, "[Юридический адрес]");
                SetValue(commandResult, postCityId, "[Почтовый адрес]");

                SetValue(commandByFirm, nameFirm, "[Название организации]");
                SetValue(commandByFirm, jurCityId, "[Юридический адрес]");
                SetValue(commandByFirm, postCityId, "[Почтовый адрес]");

                LoadDataResult(commandResult, dtgResult);
                LoadDataResult(commandByFirm, dtgByFirm);
            }
        }

        private void dtgResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
