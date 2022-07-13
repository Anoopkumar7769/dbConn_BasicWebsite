<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Student USN:</td>
                    <td><asp:TextBox ID="usn" runat="server" OnTextChanged="usn_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><asp:TextBox ID="city" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone no</td>
                    <td><asp:TextBox ID="Phone_no" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click"/>
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click"/>
                        <asp:Button ID="Button4" runat="server" Text="View" OnClick="Button4_Click"/>
                    </td>
                </tr>
                    <tr>
                    <td>Enter USN For Update</td>
                    <td><asp:TextBox ID="usn1" runat="server" OnTextChanged="usn1_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
