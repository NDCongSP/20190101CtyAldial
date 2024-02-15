<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ATSCADAWebApp.LoginPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>LOGIN</title>
    <meta charset="utf-8" />
    <style type="text/css">    
        .login {
            height: 100%;
            width: 100%;
            background-position: left center;
            background-image: url('log-in.svg');
            background-size:auto 30%;
            background-repeat: no-repeat;
        }
        .user {
            height: 100%;
            width: 100%;
            background-position: right center;
            background-image: url('user.png');
            background-size: auto 30%;
            background-repeat: no-repeat;
        }
        .password {
            height: 100%;
            width: 100%;
            background-position: right center;
            background-image: url('keys.png');
            background-size: auto 30%;
            background-repeat: no-repeat;
        }       
         .role {
            height: 100%;
            width: 100%;
            background-position: right center;
            background-image: url('user-icon.jpg');
            background-size: auto 30%;
            background-repeat: no-repeat;
        }       
    </style>
</head>

<body>
    <form id="form2" runat="server">
            <div style="width: 100%">
                  <!-- THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED -->                        
                        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </ajaxToolkit:ToolkitScriptManager>
                        <!--------------------END----------------------->
            </div>
            <div style="width: 100%">
            <table style="border: medium solid #474E5D; width: 46%; height: 60%; top: 20%; left: 27%; position: fixed;border-radius:12px; box-shadow: 5px 5px 5px #808080;">
                <tr style="width: 100%; height: 20%">
                    <td colspan="4" style="text-align: center; background-color: #474E5D;">
                        <asp:Label ID="lblHeader" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="250%" ForeColor="White" Text="LOGIN"></asp:Label>
                    </td>
                </tr>
                <tr style="height: 10%">
                    <td colspan="4"></td>
                </tr>
                <tr style="width: 100%; height: 15%">
                    <td style="width: 10%"></td>
                    <td style="background-color: #00802b; width: 40%; text-align: center">
                        <asp:Label ID="lblUser" runat="server" Font-Bold="True" Font-Size="150%" ForeColor="White" Text="User" Font-Names="Times New Roman"></asp:Label>
                    </td>
                    <td style="background-color: #00802b; width: 40%">
                        <asp:TextBox ID="txtUser" CssClass="user" runat="server"  Height="100%" Width="100%" Font-Size="150%" TabIndex="1" Font-Bold="True" Font-Names="Times New Roman"></asp:TextBox>
                    </td>
                    <td style="width:10%"></td>
                </tr>
                <tr style="width: 100%; height: 15%">
                    <td style="width: 10%"></td>

                    <td style="background-color: #00802b; width: 40%; text-align: center;">
                        <asp:Label ID="lblPassword" runat="server" Font-Bold="True" Font-Size="150%" ForeColor="White" Text="Password" Font-Names="Times New Roman"></asp:Label>
                    </td>
                    <td style="background-color: #00802b; width: 40%">
                        <asp:TextBox ID="txtPassword" CssClass="password" runat="server" Height="100%" Width="100%" Font-Size="150%" TextMode="Password" TabIndex="2" Font-Bold="True" Font-Names="Times New Roman"></asp:TextBox>
                    </td>
                    <td style="width: 10%"></td>
                </tr>   
               
                <tr style="height: 5%">
                    <td colspan="4"></td>
                </tr>           
                 <tr style="width: 100%; height: 15%">
                      <td style="width: 10%"></td>
                     <td colspan="2" style="width: 80%">                         
                            <asp:Button ID="btn_Login" CssClass="login" style="text-align:center" runat="server" Font-Bold="True" Font-Size="150%" ForeColor="Red" Height="100%" OnClick="btn_Login_Click" Text="LOGIN" Width="100%" TabIndex="3" Font-Names="Times New Roman" />                       
                     </td>
                     <td style="width: 10%"></td>
                 </tr> 
                <tr style="height: 10%">
                    <td colspan="4"></td>
                </tr>
                <tr style="width: 100%; height: 10%">
                    <td colspan="4" style="text-align: center; background-color: #474E5D;">
                        <asp:Label ID="lblFooter" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="ALDILA®"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
