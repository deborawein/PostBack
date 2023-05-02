<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestMultiControl.aspx.cs" Inherits="PostBack.TestMultiControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <asp:PlaceHolder ID="PhAnswers3" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
