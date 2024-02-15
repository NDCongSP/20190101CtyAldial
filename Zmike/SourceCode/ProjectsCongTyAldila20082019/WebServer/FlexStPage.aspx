<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlexStPage.aspx.cs" Inherits="ATSCADAWebApp.FlexStPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FlexSt Page</title>
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Flex Standard"></asp:Label>
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
                                            <li><a href="FlexStPage.aspx" style="color:white">Flex Standard</a></li>
                                            <li><a href="SwingWPage.aspx">Swing Weight</a></li>
                                            <li><a href="ZMikePage.aspx">Z-Mike</a></li>
                                            <li><a href="ZMikeMTypePage.aspx" >Z-Mike Meas Type</a></li>
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
                                       <div id="tabs-4">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:270px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New Std." Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtNumAddFlex" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
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

                                                                      <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyAddNumFlex" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyAddNumFlex_Click" />
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
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:270px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button10" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Standard" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                            <tr>
                                                                <td style="text-align: center; " colspan="2">

                                                                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; " colspan="2">

                                                                       <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplNumEditFlex" runat="server" ForeColor="Black" Font-Size="110%" Width="70%" AutoPostBack="True" EnableTheming="True" OnSelectedIndexChanged="drplNumEditFlex_SelectedIndexChanged" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                                                           <ContentTemplate>

                                                                               <asp:TextBox ID="txtNumEditFlex" runat="server" Font-Names="Times New Roman" Font-Size="110%"  Width="69%"></asp:TextBox>

                                                                           </ContentTemplate>
                                                                   </asp:UpdatePanel>
                                                               </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Clamp To Wt."></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Flex Value"></asp:Label>

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtClampToWt" runat="server" Width="70%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtFlexValue" runat="server" Width="70%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Clamp To Sensor"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label48" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B">Hole Number</asp:Label>

                                                                </td>
                                                                
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtClampToSen" runat="server" Width="70%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtHoleNumber" runat="server" Width="70%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label51" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Clamp To Tip"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                      &nbsp;</td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel51" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtClampToTip" runat="server" Width="70%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       &nbsp;</td>
                                                                
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel63" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditNumFlex" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyEditNumFlex_Click" />
                                                                       </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                <td style="text-align: center; width: 33.4%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:270px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button12" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Standard" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label63" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel64" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplNumDeleteFlex" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" AutoPostBack="True" EnableTheming="True" >
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

                                                                      <asp:UpdatePanel ID="UpdatePanel65" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyDeleteNumFlex" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyDeleteNumFlex_Click" />
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
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                               <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; " colspan="3">

                                                                    &nbsp;</td>
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
