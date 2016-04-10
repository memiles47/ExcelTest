using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace DataSheetOne
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            this.Startup += new System.EventHandler(this.Sheet1_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);

        }

        #endregion

        private void btn_text_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Text");
        }
    }
}
