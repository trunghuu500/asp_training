<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai3.aspx.cs" Inherits="lab1.bai3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <Items>
                     </Items>
</asp:Menu>
<h2>Tìm số lớn nhất trong 3 số</h2>
        </div>
         <asp:Label ID="label_a" runat="server" Text="Số thứ nhất"></asp:Label>
 <asp:TextBox ID="input_a" runat="server"></asp:TextBox>
         <div>
     <asp:Label ID="label_b" runat="server" Text="Số thứ hai"></asp:Label>
     <asp:TextBox ID="input_b" runat="server"></asp:TextBox>
 </div>
         <div>
    <asp:Label ID="label_c" runat="server" Text="Số thứ ba"></asp:Label>
    <asp:TextBox ID="input_c" runat="server"></asp:TextBox>
     <br />
</div>
          <div>
      <asp:Label ID="resultLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
              </div>          
<asp:Button CssClass="btn btn-primary" ID="button_tim" runat="server" Text="Tìm" OnClick="button_tim_Click" />
    </form>
</body>
</html>
