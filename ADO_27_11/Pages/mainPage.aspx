<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainPage.aspx.cs" Inherits="ADO_27_11.Pages.mainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input id="Button1" type="button" value="Delete" runat="server" onserverclick="Delete" />
        <div  runat="server"  id="tableDiv">
        </div>
    </form>
</body>
</html>
