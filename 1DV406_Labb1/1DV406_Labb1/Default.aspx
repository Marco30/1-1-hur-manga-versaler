<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1DV406_Labb1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">

        <h2>
        <asp:Label ID="Label3" runat="server" Text="Antal versaler i texten?"></asp:Label>
        </h2>

    <div>
    <asp:TextBox ID="TextBox1" TextMode="multiline" Columns="50" Rows="30" runat="server"></asp:TextBox>
    </div>

        <p>
        <asp:Label ID="Resultat" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>

        <p>
        <asp:button ID="Knap" runat="server" Text="Antal versaler" OnClick="Knap_Click" />
        </p>

    </form>
</body>

</html>
