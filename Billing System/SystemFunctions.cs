using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public class SystemFunctions
    {
        public static string ConnectionString()
        {
            return "Data Source = " + Environment.MachineName + "; Initial Catalog = ZahidMedicine; Integrated Security = true;";
        }

        public static void GenerateDatabase()
        {
            List<string> cmds = new List<string>();
            if (File.Exists(Application.StartupPath + "\\script.sql"))
            {
                TextReader tr = new StreamReader(Application.StartupPath + "\\script.sql");
                string line = "";
                string cmd = "";
                while ((line = tr.ReadLine()) != null)
                {
                    if (line.Trim().ToUpper() == "GO")
                    {
                        cmds.Add(cmd);
                        cmd = "";
                    }
                    else
                    {
                        cmd += line + "\r\n";
                    }
                }
                if (cmd.Length > 0)
                {
                    cmds.Add(cmd);
                    cmd = "";
                }
                tr.Close();
            }
            if (cmds.Count > 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = new SqlConnection("Data Source = " + Environment.MachineName + "; Initial Catalog = MASATER; Integrated Security = true;");
                command.Connection.Open();
                for (int i = 0; i < cmds.Count; i++)
                {
                    command.CommandText = cmds[i];
                    command.ExecuteNonQuery();
                }
                command.Connection.Close();
            }
        }

        public static bool checkDatabaseExists()
        {
            SqlConnection con = new SqlConnection(SystemFunctions.ConnectionString());
            try
            {
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
