<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZMikeMTypePage.aspx.cs" Inherits="ATSCADAWebApp.ZMikeMTypePage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZMikeMType Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="Them/Style.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.12.4.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    
     <script>
         function isNumberKey(evt,idtxt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
        if ((charCode >= 48 && charCode <= 57) || (charCode == 46&&idtxt.value.split('.').length<=1))
            return true;
            return false;
         }  
     </script>
        
    </head>
<body>
    <form id="form1" runat="server">
    <div>            
                        <!-- THESE LINES ARE FROM ATPROCORP, SHOULD NOT BE DELETED -->                        
                        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </ajaxToolkit:ToolkitScriptManager>
                        <!--------------------END----------------------->  
    </div> 
      <div>
          <table style="width: 100%; height: 100%">
                <tr>
                    <td style="width: 100%; height: 100%">
                       <div id="banel">
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td style="width: 20%">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Logo1.png" />
                                </td>
                                <td style="text-align: center; width: 80%">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Z-Mike Meas Type"></asp:Label>
                                </td>
                            </tr>
                          <tr  style="background: #000000;">
                              <td colspan="2">
                                  <ul id="menu">
                                    <li><a href="PartPage.aspx" style="color:white">Work Home</a></li>
                                    <li><a href="ViewPage.aspx">View</a></li>
                                    <li><a href="SettingsPage.aspx" >Settings</a></li>
                                    <li><a href="ReportPage.aspx">Report</a></li>
                                    <li><a href="LoginPage.aspx" >Exit</a></li>
                                  </ul>
                              </td>
                          </tr>
                        </table>
                       </div>
                    </td>
                </tr>
               <tr>
                    <td>
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td style="text-align: center; background-color: #00802b; width: 100%;border-radius: 7px;box-shadow: 5px 5px 5px #808080;">
                                     <ul id="menu2">
                                            <li><a href="PartPage.aspx">Part</a></li>
                                            <li><a href="FrePage.aspx">Frequency</a></li>
                                            <li><a href="FreStPage.aspx">Frequency Standard</a></li>
                                            <li><a href="FlexPage.aspx">Flex</a></li>
                                            <li><a href="FlexStPage.aspx">Flex Standard</a></li>
                                            <li><a href="SwingWPage.aspx">Swing Weight</a></li>
                                            <li><a href="ZMikePage.aspx">Z-Mike</a></li>
                                            <li><a href="ZMikeMTypePage.aspx" style="color:white">Z-Mike Meas Type</a></li>
                                      </ul>
                               </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td style="width: 1%"></td>
                                <td style="width: 98%">
                                     <div style="width: 100%;height:10px">

                                    </div>
                                    <div id="tabs1" style="width: 100%; height: 100%">
                                        <div id="tabs-7">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:150px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button22" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New Meas Type" Width="200px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Meas Type"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddMeasType" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel107" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyAddMT" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyAddMT_Click" />
                                                                          </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                 </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                         
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                    <td style="text-align: center; width: 33.4%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:150px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button28" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Meas Type Name" Width="200px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label59" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Meas Type"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel108" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplEditMeasType" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" EnableTheming="True" OnSelectedIndexChanged="drplEditMeasType_SelectedIndexChanged"   AutoPostBack="True">
                                                                               
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                               <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                  
                                                                      <asp:UpdatePanel ID="UpdatePanel137" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:TextBox ID="txtEditMeasType" runat="server" Font-Names="Times New Roman" Font-Size="110%" Width="98%"></asp:TextBox>
                                                                          </ContentTemplate>
                                                                      </asp:UpdatePanel>

                                                                  
                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                           <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel109" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyEditMT" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyEditMT_Click" />
                                                                          </ContentTemplate>
                                                                      </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                              </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                            
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                    <td style="text-align: center; width: 33.4%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:150px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button30" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Meas Type" Width="200px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label66" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Meas Type"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel115" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDeleteMeasType" runat="server" ForeColor="Black" Font-Size="110%" Width="100%"  EnableTheming="True" AutoPostBack="True">
                                                                                  
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                </td>
                                                               
                                                            </tr>
                                                           <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel116" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyDeleteMT" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyDeleteMT_Click" />
                                                                          </ContentTemplate>
                                                                      </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                              </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                            
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                </tr>
                                              
                                            </table>
                                        </div>
                                         <div style="width: 100%;height:10px">

                                        </div>
                                    </div>

                                </td>
                                <td style="width: 1%"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td style="text-align: center; background-color: #474E5D; width: 100%;border-radius: 7px;box-shadow: 5px 5px 5px #808080;">
                                    <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="ALDILA®"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
               <tr>
                    <td>
                        <table style="width: 100%; height: 100%">
                            <tr>
                                <td style="text-align: center;  width: 100%;border-radius: 7px;box-shadow: 5px 5px 5px #808080;">
                                  
                                     <asp:UpdatePanel ID="UpdatePanel138" runat="server">
                                       <ContentTemplate>
                                          <asp:Label ID="lbltest" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red"></asp:Label>
                                       </ContentTemplate>
                                     </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
           </table>
       </div>
    </form>
</body>
</html>
