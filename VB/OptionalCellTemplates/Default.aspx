<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="OptionalCellTemplates._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=9B171C9FD64DA1D1"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=9B171C9FD64DA1D1"
	Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" AutoGenerateColumns="False" Width="296px">
			<Columns>
				<dxwtl:TreeListTextColumn Name="Column1" VisibleIndex="0">
					<DataCellTemplate>
						<img runat="server" src="~/Images/content16x16.png" visible="<%#IsNodeImageVisible(Container)%>" />
						<dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%#Eval("Column1")%>' Visible="<%#IsNodeTextVisible(Container)%>">
						</dxe:ASPxLabel>
					</DataCellTemplate>
				</dxwtl:TreeListTextColumn>
			</Columns>
		</dxwtl:ASPxTreeList>
		&nbsp;
	</div>
	</form>
</body>
</html>
