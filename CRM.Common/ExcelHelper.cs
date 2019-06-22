using log4net;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    public class ExcelHelper
    {
        public static ExcelHelper Instance { get; set; }
        ILog logger;
        static ExcelHelper()
        {
            Instance = new ExcelHelper();
        }
        private ExcelHelper()
        {
            logger = LogManager.GetLogger(typeof(ExcelHelper));
        }

        public DataSet ExcelToDataSet(string filePath)
        {
            //bool hasTitle = true;
            string fileType = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileType)) return null;
            DataSet ds = new DataSet();
            //string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.{0}.0;" +
            //               "Extended Properties=\"Excel {1}.0;HDR={2};IMEX=1;\";" +
            //               "data source={3};",
            //               (fileType == ".xls" ? 4 : 12), (fileType == ".xls" ? 8 : 12), (hasTitle ? "Yes" : "NO"), filePath);

            string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1;\";data source={0};", filePath);


            using (OleDbConnection myConn = new OleDbConnection(strCon))
            {
                myConn.Open();
                System.Data.DataTable table = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string tableName = table.Rows[0]["Table_Name"].ToString();
                string strExcel = $"select * from [{ tableName }]";
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, myConn);
                myCommand.Fill(ds);
            }
            if (ds == null || ds.Tables.Count <= 0) return null;
            return ds;
        }

        public void SaveDataToExcelFile<T>(List<T> list, string filePath = "D:\\1.xls")
        {
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //PropertyInfo[] props = typeof(Sales).GetProperties(BindingFlags.Public);
            //for (int i = 0; i < props.Length; i++)
            //{
            //    xlWorkSheet.Cells[1, i + 1] = props[i].Name; //write the column name
            //}
            List<string> descriptionStrList = GetTypeDescriptions(typeof(T));
            //列头
            for (int i = 0; i < descriptionStrList.Count; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = descriptionStrList[i]; //write the column name
            }

            //填充数据
            PropertyInfo[] props = typeof(T).GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                //填写属性数据
                for (int j = 0; j < props.Length; j++)
                {

                    xlWorkSheet.Cells[i + 2, j + 1] = props[j].GetValue(list[i]);

                }
                ////到时候用反射取property
                //xlWorkSheet.Cells[i + 2, 1] = studentList[i].Saler;
                //xlWorkSheet.Cells[i + 2, 2] = studentList[i].SaleCount;
                //xlWorkSheet.Cells[i + 2, 3] = studentList[i].SalerAchievement;
                //xlWorkSheet.Cells[i + 2, 4] = studentList[i].TeamName;
                //xlWorkSheet.Cells[i + 2, 5] = studentList[i].TeamCount;
                //xlWorkSheet.Cells[i + 2, 6] = studentList[i].TeamSaleAchievement;
            }
            //设置列宽自适应
            xlWorkSheet.Columns.AutoFit();
            //对齐方式
            xlWorkSheet.Columns.HorizontalAlignment = XlHAlign.xlHAlignLeft;//文本对齐
            xlWorkSheet.Name = "职业顾问部门信息";
            try
            {
                xlWorkBook.SaveAs(filePath, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

        }

        private List<string> GetTypeDescriptions(Type type)
        {
            List<string> descriptionStrList = new List<string>();
            Type descriptionType = typeof(DescriptionAttribute);
            foreach (PropertyInfo info in type.GetProperties())
            {
                DescriptionAttribute des = (DescriptionAttribute)info.GetCustomAttribute(descriptionType);
                descriptionStrList.Add(des.Description);
            }
            return descriptionStrList;
        }

    }
}
