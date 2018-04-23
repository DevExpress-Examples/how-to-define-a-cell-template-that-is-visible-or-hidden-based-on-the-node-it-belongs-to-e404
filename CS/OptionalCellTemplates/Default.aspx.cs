using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTreeList;

namespace OptionalCellTemplates {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            TreeListNode nodeRoot = ASPxTreeList1.AppendNode(1);
            nodeRoot.SetValue("Column1", "root");
            TreeListNode nodeChild = ASPxTreeList1.AppendNode(2, nodeRoot);
            nodeChild.SetValue("Column1", "child");
            ASPxTreeList1.ExpandAll();
        }

        protected bool IsNodeImageVisible(object obj) {
            TreeListDataCellTemplateContainer container = (TreeListDataCellTemplateContainer)obj;
            return container.Level == 1;
        }

        protected bool IsNodeTextVisible(object obj) {
            TreeListDataCellTemplateContainer container = (TreeListDataCellTemplateContainer)obj;
            return container.Level != 1;
        }
    }
}
