Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxTreeList

Namespace OptionalCellTemplates
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim nodeRoot As TreeListNode = ASPxTreeList1.AppendNode(1)
			nodeRoot.SetValue("Column1", "root")
			Dim nodeChild As TreeListNode = ASPxTreeList1.AppendNode(2, nodeRoot)
			nodeChild.SetValue("Column1", "child")
			ASPxTreeList1.ExpandAll()
		End Sub

		Protected Function IsNodeImageVisible(ByVal obj As Object) As Boolean
			Dim container As TreeListDataCellTemplateContainer = CType(obj, TreeListDataCellTemplateContainer)
			Return container.Level = 1
		End Function

		Protected Function IsNodeTextVisible(ByVal obj As Object) As Boolean
			Dim container As TreeListDataCellTemplateContainer = CType(obj, TreeListDataCellTemplateContainer)
			Return container.Level <> 1
		End Function
	End Class
End Namespace
