<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="pdftotext.teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblText" Font-Bold="true" Font-Size="Larger" runat="server" Text="Aqui vai ter o texo do PDF"></asp:Label>
        <p>
              <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Converter todo o PDF para texto" />
       
              <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Converter parte do PDF para texto" />

              <asp:Button ID="bntLimpar" runat="server" OnClick="bntLimpar_Click" Text="Limpar" />
               
        </p>
    </form>
</body>
</html>
