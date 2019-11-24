<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SitecoreIoT.Index" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Arduino Sitecore Web Control</title>
    <style type="text/css">
        .Panel
        {
            margin-left: 2%;
            margin-top: 2%;
            border-color: white;
            border-width: 20px;
        }
        .Header
        {
            font-family: "Segoe UI";
            font-size: xx-large;
            font-weight: normal;
            font-style: normal;
            font-variant: normal;
            text-transform: none;
            color: #000000;
        }
        .Sub
        {
            font-family: "Segoe UI";
            font-size: x-large;
            font-weight: normal;
            font-style: normal;
            font-variant: normal;
            text-transform: none;
            color: #666666;
        }
    </style>
</head>
<body bgcolor="#CCCCCC">
    <form id="form2" runat="server">
      <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderStyle="Solid"
            Width="317px" CssClass="Panel">
        <div>
        <span class="Header">LED Web Control<br /> </span>
        <span class="Sub">A web control to blink your Arduino LEDs.<br /> </span>
        <table>
            <tr>
                <td>
                    <asp:Button ID="BLUE" runat="server" Text="BLUE" OnClick="BlueOn"
                        BackColor="Blue" BorderStyle="None" Font-Names="Segoe UI" Font-Size="XX-Large"
                        ForeColor="White" Width="310px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Green" runat="server" Text="GREEN" OnClick="GreenOn" BackColor="#33CC33"
                        BorderStyle="None" Font-Names="Segoe UI" Font-Size="XX-Large"
                        ForeColor="White" Width="310px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ORANGE" runat="server" Text="ORANGE" OnClick="OrangeOn"
                        BackColor="#FF6600" BorderStyle="None" Font-Names="Segoe UI" Font-Size="XX-Large"
                        ForeColor="White" Width="310px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="RED" runat="server" Text="RED" OnClick="RedOn"
                        BackColor="#CC0000" BorderStyle="None" Font-Names="Segoe UI" Font-Size="XX-Large"
                        ForeColor="White" Width="310px" />
                </td>
            </tr>
        </table>
        </div>
      </asp:Panel>
    </form>
</body>
</html>