<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Roles.aspx.vb" Inherits="Web_Desing_LivingYDeco.Roles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Roles</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 121px;
        }
        .auto-style3 {
            width: 260px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" colspan="3">Roles</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_ID_Rol" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Cargar" runat="server" Text="Cargar" Width="99px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_NombreRol" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Width="99px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Estado</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="chk_Estado" runat="server" />
                </td>
                <td>
                    <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Width="98px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="grlGrilla" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
