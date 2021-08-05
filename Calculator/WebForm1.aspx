<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculator</title>
    <link rel="stylesheet" type="text/css" href="Style_1.css" />
    <style type="text/css">
        .auto-style1 {
            width: 55px;
        }
        .auto-style2 {
            width: 55px;
            height: 102px;
        }
        .auto-style3 {
            height: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="285px" style =" text-align:right"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="285px" style =" text-align:right"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="25px" Width="285px" style =" text-align:right"></asp:TextBox>
        <table style="width: 36%;">
            <tr>
                <td class="auto-style1"><asp:ImageButton ID="Btn_raiz" runat="server" Height="25px" Width="50px" ImageUrl="~/Resources/RaizF.JPG" BorderColor="Black" OnClick="Btn_raiz_Click"/><br /><br /></td>
                <td class="auto-style1"><asp:ImageButton ID="Btn_al_cuad" runat="server" Height="25px" Width="50px" ImageUrl="~/Resources/Img1.JPG" BorderColor="Black" OnClick="Btn_al_cuad_Click" /><br /><br /></td>
                <td class="auto-style1"><asp:Button ID="Btn_Log" runat="server" Text="Ln" Height="25px" Width="50px" OnClick="Btn_Log_Click"/><br /><br /></td>
                <td class="auto-style1"><asp:Button ID="Btn_sen" runat="server" Text="sen" Height="25px" Width="50px" OnClick="Btn_sen_Click"/><br /><br /></td>
                <td ><asp:Button ID="Btn_cos" runat="server" Text="cos" Height="25px" Width="50px" OnClick="Btn_cos_Click"/><br /><br /></td>
            </tr>

            <tr>
                <td class="auto-style1"><asp:Button ID="Btn_7" runat="server" Text="7" Height="50px" Width="50px" OnClick="Btn_7_Click" /><br /><br /></td>
                <td class="auto-style1"><asp:Button ID="Btn_8" runat="server" Text="8" class ="dimensiones" OnClick="Btn_8_Click"/><br /><br /></td>
                <td class="auto-style1"><asp:Button ID="Btn_9" runat="server" Text="9" class ="dimensiones" OnClick="Btn_9_Click"/><br /><br /></td>
                <td class="auto-style1"><asp:Button ID="Btn_DEL" runat="server" Text="DEL" class ="dimensiones" OnClick="Btn_DEL_Click"/><br /><br /></td>
                <td ><asp:Button ID="Button5" runat="server" Text="AC" class ="dimensiones" OnClick="Button5_Click"/><br /><br /></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Button ID="Button14" runat="server" Text="4" class ="dimensiones" OnClick="Button14_Click"/><br /><br /></td>
                <td><asp:Button ID="Btn_5" runat="server" Text="5" class ="dimensiones" OnClick="Btn_5_Click"/><br /><br /></td>
                <td><asp:Button ID="Btn_6" runat="server" Text="6" class ="dimensiones" OnClick="Btn_6_Click" /><br /><br /></td>
                <td><asp:Button ID="Btn_x" runat="server" Text="x" class ="dimensiones" OnClick="Btn_x_Click" /><br /><br /></td>
                <td><asp:Button ID="Btn_div" runat="server" Text="÷" class ="dimensiones" OnClick="Btn_div_Click"/><br /><br /></td>
            </tr>
            <tr>
                <td class="auto-style2"><asp:Button ID="Btn_1" runat="server" Text="1" class ="dimensiones" OnClick="Btn_1_Click"/><br /><br /><asp:Button ID="Button16" runat="server" Text="0" class ="dimensiones" OnClick="Button16_Click"/></td>
                <td class="auto-style3"><asp:Button ID="Btn_2" runat="server" Text="2" class ="dimensiones" OnClick="Btn_2_Click"/><br /><br /><asp:Button ID="Btn_pun" runat="server" Text="." class ="dimensiones" Font-Bold="True" Font-Size="Large" OnClick="Btn_pun_Click"/></td>
                <td class="auto-style3"><asp:Button ID="Btn_3" runat="server" Text="3" class ="dimensiones" OnClick="Btn_3_Click"/><br /><br /><asp:Button ID="Btn_pi" runat="server" Text="+ / -" class ="dimensiones" OnClick="Btn_pi_Click"/></td>
                <td class="auto-style3"><asp:Button ID="Btn_sum" runat="server" Text="+" class ="dimensiones" OnClick="Btn_sum_Click"/><br/><br /><asp:Button ID="Btn_men" runat="server" Text="-" class ="dimensiones" OnClick="Btn_men_Click"/></td>
                <td class="auto-style3"><asp:Button ID="Btn_igu" runat="server" Text="=" Height="120px" Width="50px" OnClick="Btn_igu_Click"/></td>
            </tr>
            
        </table>

    
    </div>
    </form>
</body>
</html>
