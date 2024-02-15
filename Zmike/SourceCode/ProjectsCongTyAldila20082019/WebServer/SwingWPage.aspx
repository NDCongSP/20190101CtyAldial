<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SwingWPage.aspx.cs" Inherits="ATSCADAWebApp.SwingWPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SwingW Page</title>
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Swing Weight"></asp:Label>
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
                                            <li><a href="FlexStPage.aspx" >Flex Standard</a></li>
                                            <li><a href="SwingWPage.aspx" style="color:white">Swing Weight</a></li>
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
                                       <div >
                                             <table style="width: 100%; height: 100%">
                                                   <tr>
                                                       <td style="text-align: center;">
                                                             <asp:Label ID="lblPartSelecte" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="200%" ForeColor="Red" Text="Part Selected"></asp:Label>
                                                       
                                                       </td>
                                                   </tr>
                                             </table>
                                        </div>
                                           <div id="tabs-5">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                   
                                                     <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:200px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button21" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Measurement Type" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                            <tr>
                                                                <td style="text-align: left; width: 100%">
                                                                    <asp:UpdatePanel ID="UpdatePanel129" runat="server">
                                                                          <ContentTemplate>
                                                                    <asp:RadioButton ID="rbtnInchGrams" runat="server" GroupName="Measurement " Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Inch Grams" AutoPostBack="True" OnCheckedChanged="rbtnInchGrams_CheckedChanged"/>
                                                                        </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                </td>
                                                              
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left; width: 100%">
                                                                   <asp:UpdatePanel ID="UpdatePanel130" runat="server">
                                                                          <ContentTemplate>
                                                                   <asp:RadioButton ID="rbtnInchOuces" runat="server" GroupName="Measurement " Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Inch Ouces" AutoPostBack="True" OnCheckedChanged="rbtnInchOuces_CheckedChanged"/>
                                                                        </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left;  width: 100%" >
                                                                   <asp:UpdatePanel ID="UpdatePanel132" runat="server">
                                                                          <ContentTemplate>
                                                                   <asp:RadioButton ID="rbtnGramSwW" runat="server" GroupName="Measurement " Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Gram Swing Weight" AutoPostBack="True" OnCheckedChanged="rbtnGramSwW_CheckedChanged"/>
                                                                        </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: left; width: 100%">
                                                                   <asp:UpdatePanel ID="UpdatePanel131" runat="server">
                                                                          <ContentTemplate>
                                                                   <asp:RadioButton ID="rbtnGramSwWghtPoint" runat="server" GroupName="Measurement " Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Swing Weight Points" AutoPostBack="True" OnCheckedChanged="rbtnGramSwWghtPoint_CheckedChanged"/>
                                                                        </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                </td>
                                                              
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: left; width: 100%">
                                                                   <asp:UpdatePanel ID="UpdatePanel133" runat="server">
                                                                          <ContentTemplate>
                                                                   <asp:RadioButton ID="rbtnCenterOfGra" runat="server" GroupName="Measurement " Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Center of Gravity" AutoPostBack="True" OnCheckedChanged="rbtnCenterOfGra_CheckedChanged"/>
                                                                        </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                                </td>
                                                              
                                                               
                                                            </tr>
                                                             <tr>
                                                                 <td style="text-align: center; width: 100%">

                                                                    &nbsp;</td>
                                                                 
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                         <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:200px" class="table">
                                                            <legend>
                                                                 <asp:UpdatePanel ID="UpdatePanel134" runat="server">
                                                                   <ContentTemplate>
                                                                     <asp:Button ID="btnMeasType" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Thông Tin" Width="180px" />
                                                                   </ContentTemplate>
                                                                 </asp:UpdatePanel>
                                                         </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="Upper Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUpLimit" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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

                                                                    <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Lower Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLowLimit" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:200px" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button20" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Weight" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label49" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="Upper Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtWeightUp" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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

                                                                    <asp:Label ID="Label50" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Lower Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel49" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtWeightLow" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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
                                                 <tr>
                                                       <td style="text-align: center; width: 33.3%">

                                                       </td>
                                                        <td style="text-align: center; width: 33.3%">

                                                        </td>
                                                      
                                                       <td style="text-align: center; width: 33.4%">
                                                           <table style="text-align: center; width: 100%">
                                                               <tr>
                                                                     <td style="text-align: left; ">
                                                                        <asp:UpdatePanel ID="UpdatePanel50" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:Button ID="btnApplySwingWeight" runat="server" Font-Bold="True" Font-Names="Times New Roman" ForeColor="Blue" Font-Size="110%" Height="100%" Text="Apply" Width="100%" OnClick="btnApplySwingWeight_Click"  />
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
