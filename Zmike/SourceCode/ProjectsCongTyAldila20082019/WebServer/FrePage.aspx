<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrePage.aspx.cs" Inherits="ATSCADAWebApp.FrePage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Frequency Page</title>
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Frequency"></asp:Label>
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
                                            <li><a href="FrePage.aspx" style="color:white">Frequency</a></li>
                                            <li><a href="FreStPage.aspx" >Frequency Standard</a></li>
                                            <li><a href="FlexPage.aspx">Flex</a></li>
                                            <li><a href="FlexStPage.aspx" >Flex Standard</a></li>
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
                                    <div id="tabs" style="width: 100%; height: 100%">
                                         
                                         <div>
                                             <table style="width: 100%; height: 100%">
                                                   <tr>
                                                       <td style="text-align: center;">
                                                             <asp:Label ID="lblPartSelecte" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="200%" ForeColor="Red" Text="Part Selected"></asp:Label>
                                                       
                                                       </td>
                                                   </tr>
                                             </table>
                                        </div>
                                         <div id="tabs-1" >
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                    <td style="text-align: center; width: 25%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:160px" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button14" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Freaquency (CPM)" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="Upper Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtFreqUp" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"> </asp:TextBox>
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

                                                                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Lower Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtFreqLow" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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
                                                <td style="text-align: center; width: 25%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:160px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Standard" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Select Standard"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplStandard" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" AutoPostBack="True" EnableTheming="False" >
                                                                               </asp:DropDownList>
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
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                     <td style="text-align: center; width: 25%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:160px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button4" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Butt Stop Location" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                            <tr>
                                                                <td style="text-align: left; width: 50%">
                                                                    <asp:UpdatePanel ID="UpdatePanel119" runat="server">
                                                                           <ContentTemplate>

                                                                    <asp:RadioButton ID="rbtnLocation1" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>
                                                                </td>
                                                              
                                                                  <td style="text-align: left; width: 50%">
                                                                      <asp:UpdatePanel ID="UpdatePanel120" runat="server">
                                                                           <ContentTemplate>

                                                                      <asp:RadioButton ID="rbtnLocation6" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                      </ContentTemplate>
                                                                   </asp:UpdatePanel>
                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left; width: 50%">
                                                                   <asp:UpdatePanel ID="UpdatePanel121" runat="server">
                                                                           <ContentTemplate>

                                                                   <asp:RadioButton ID="rbtnLocation2" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>
                                                                </td>
                                                              
                                                                  <td style="text-align: left; width: 50%">
                                                                      <asp:UpdatePanel ID="UpdatePanel122" runat="server">
                                                                           <ContentTemplate>

                                                                      <asp:RadioButton ID="rbtnLocation7" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left;  width: 50%" >
                                                                   <asp:UpdatePanel ID="UpdatePanel123" runat="server">
                                                                           <ContentTemplate>

                                                                   <asp:RadioButton ID="rbtnLocation3" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: left;  width: 50%" >
                                                                      <asp:UpdatePanel ID="UpdatePanel124" runat="server">
                                                                           <ContentTemplate>

                                                                      <asp:RadioButton ID="rbtnLocation8" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left; width: 50%">
                                                                   <asp:UpdatePanel ID="UpdatePanel125" runat="server">
                                                                           <ContentTemplate>

                                                                   <asp:RadioButton ID="rbtnLocation4" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: left; width: 50%">
                                                                      <asp:UpdatePanel ID="UpdatePanel126" runat="server">
                                                                           <ContentTemplate>

                                                                      <asp:RadioButton ID="rbtnLocation9" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: left; width: 50%">
                                                                   <asp:UpdatePanel ID="UpdatePanel127" runat="server">
                                                                           <ContentTemplate>

                                                                   <asp:RadioButton ID="rbtnLocation5" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: left; width: 50%">
                                                                      <asp:UpdatePanel ID="UpdatePanel128" runat="server">
                                                                           <ContentTemplate>

                                                                      <asp:RadioButton ID="rbtnLocation10" runat="server" GroupName="ButtStop" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B"/>
                                                                     </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; " colspan="2">

                                                                    &nbsp;</td>
                                                                 
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                     <td style="text-align: center; width: 25%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:160px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button5" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Weight (gr.)" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Select Weight"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplWeight" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="100%">
                                                                                  
                                                                               </asp:DropDownList>
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
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                       <td style="text-align: center; width: 25%">

                                                       </td>
                                                        <td style="text-align: center; width: 25%">

                                                        </td>
                                                        <td style="text-align: center; width:25%">

                                                            &nbsp;</td>
                                                       <td style="text-align: center; width: 25%">
                                                           <table style="text-align: center; width: 100%">
                                                               <tr>
                                                                     <td style="text-align: left; ">
                                                                        <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:Button ID="btnApplyFreq" runat="server" Font-Bold="True" Font-Names="Times New Roman" ForeColor="Blue" Font-Size="110%" Height="100%" Text="Apply" Width="100%" OnClick="btnApplyFreq_Click"  />
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                    </td>
                                                               </tr>
                                                           </table>
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
