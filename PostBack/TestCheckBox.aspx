<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCheckBox.aspx.cs" Inherits="PostBack.TestCheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
            <asp:PlaceHolder ID="PhAnswers2" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
