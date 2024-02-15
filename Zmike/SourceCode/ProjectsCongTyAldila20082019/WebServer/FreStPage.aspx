<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FreStPage.aspx.cs" Inherits="ATSCADAWebApp.FreStPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FreSt Page</title>
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Frequency Standard"></asp:Label>
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
                                            <li><a href="FreStPage.aspx" style="color:white">Frequency Standard</a></li>
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
                                    <div id="tabs1" style="width: 100%; height: 100%">
                                         <div id="tabs-2">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:380px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New Std." Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddNumber" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
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

                                                                      <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyAddNumber" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyAddNumber_Click" />
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
                                                    <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:380px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Standard" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                            <tr>
                                                                <td style="text-align: center; " colspan="4">

                                                                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; " colspan="4">

                                                                       <asp:UpdatePanel ID="UpdatePanel34" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplEditStand" runat="server" ForeColor="Black" Font-Size="110%" Width="70%" AutoPostBack="True" EnableTheming="True" OnSelectedIndexChanged="drplEditStand_SelectedIndexChanged" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="4" >
                                                                    <asp:UpdatePanel ID="UpdatePanel136" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:TextBox ID="txtEditStd" runat="server" Font-Names="Times New Roman" Font-Size="110%" Width="69%"></asp:TextBox>
                                                                          </ContentTemplate>
                                                                      </asp:UpdatePanel>
                                                               </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 1"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 1"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL6" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 6"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL6" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 6"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL2" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 2"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL2" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 2"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 7"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 7"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 3"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 3"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 8"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text=" LL 8"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel36" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 4"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 4"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL9" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 9"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL9" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 9"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel40" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel41" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL5" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 5"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL5" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 5"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblUL10" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="UL 10"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="lblLL10" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="LL 10"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel42" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel43" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel44" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtUL10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel45" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLL10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="4" >

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="4" >

                                                                   <asp:UpdatePanel ID="UpdatePanel46" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditNumber" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyEditNumber_Click" />
                                                                       </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="4" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                 
                                                    </td>
                                                     <td style="text-align: center; width: 33.4%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:380px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button7" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Standard" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDeleteStand" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" AutoPostBack="True" EnableTheming="True" >
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

                                                                      <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyDeleteNumber" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyDeleteNumber_Click" />
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
