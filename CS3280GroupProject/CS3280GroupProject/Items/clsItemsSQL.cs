using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS3280GroupProject.Items
{
    class clsItemsSQL
    {
        public static string GetItems()
        {
            try
            {
                string sSQL = "select ItemCode, ItemDesc, Cost from ItemDesc";
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + ".");

            }
        }

        public static string GetInvoice(string itemCode)
        {
            try
            {
                string sSQL = "select distinct(InvoiceNum) from LineItems where ItemCode = " + itemCode;
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + ".");

            }
        }

        public static string UpdateItem(string itemDesc, string itemCode)
        {
            try
            {
                string sSQL = "Update ItemDesc Set ItemDesc = " + itemDesc + ", Cost = 123 where ItemCode = " + itemCode;
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + ".");

            }
        }

        public static string CreateItem(string itemcode, string itemDesc, int cost)
        {
            try
            {
                string sSQL = "Insert into ItemDesc (ItemCode, ItemDesc, Cost) Values (" + itemcode + ", " + itemDesc + ", " + cost + ")";
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + ".");

            }
        }

        public static string DeleteItem(string itemCode)
        {
            try
            {
                string sSQL = "Delete from ItemDesc Where ItemCode = " + itemCode;
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + ".");

            }
        }
    }
}