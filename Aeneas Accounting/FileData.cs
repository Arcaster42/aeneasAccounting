using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Aeneas_Accounting
{
    public static class FileData
    {
        const string tranFile = "trans.dat";
        const string expFile = "exp.dat";

        public static void SaveData(List<Transaction> allTrans, List<Expense> allExp)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                FileStream writer = new FileStream(tranFile, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writer, allTrans);
                FileStream writer2 = new FileStream(expFile, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writer2, allExp);
                writer.Close();
                writer2.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show("Error Saving File");
                MessageBox.Show(excp.ToString());
            }
        }

        public static List<Transaction> LoadTrans()
        {
            if (File.Exists(tranFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream reader = new FileStream(tranFile, FileMode.Open, FileAccess.Read);
                    List<Transaction> savedTrans = (List<Transaction>)formatter.Deserialize(reader);
                    reader.Close();
                    return savedTrans;
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Error Loading File");
                    MessageBox.Show(excp.ToString());
                }
            }
            else
            {
                MessageBox.Show("No Save Data");
                return null;
            }
            return null;
        }

        public static List<Expense> LoadExp()
        {
            if (File.Exists(expFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream reader = new FileStream(expFile, FileMode.Open, FileAccess.Read);
                    List<Expense> savedExp = (List<Expense>)formatter.Deserialize(reader);
                    reader.Close();
                    return savedExp;
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Error Loading File");
                    MessageBox.Show(excp.ToString());
                }
            }
            else
            {
                MessageBox.Show("No Save Data");
                return null;
            }
            return null;
        }
    }
}
