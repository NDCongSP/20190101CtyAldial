<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SettingsPage.aspx.cs" Inherits="ATSCADAWebApp.SettingsPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Setting Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="Them/Style.css" rel="stylesheet" />
      <link rel="stylesheet" href="Scripts/jquery-ui.css" />
    <%-- <link rel="stylesheet" href="/resources/demos/style.css" /> --%>
    <script src="Scripts/jquery-1.12.4.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>

    <script>
        $(function () {
            $("#tabs").tabs();
        });
    </script>
     <script>
         function isNumberKey(evt,idtxt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
        if ((charCode >= 48 && charCode <= 57) || (charCode == 46 && idtxt.value.split('.').length<=1))
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="SETTINGS"></asp:Label>
                                </td>
                            </tr>
                          <tr  style="background: #000000;">
                              <td colspan="2">
                                  <ul id="menu">
                                   <li><a href="PartPage.aspx">Work Home</a></li>
                                    <li><a href="ViewPage.aspx">View</a></li>
                                    <li><a href="SettingsPage.aspx" style="color:white">Settings</a></li>
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
                                <td style="width: 5%"></td>
                                <td style="width: 90%;border-radius:5px">

                                    <div id="tabs" style="width: 99%; height: 100%">                                     
                                        <ul  id="menutab" style="text-align: center;font: bold; background-color: #00802b ">
                                            <li><a href="#tabs-1" style="width:110px">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Butt Stop Location"></asp:Label></a></li>
                                             <li><a href="#tabs-4" style="width:110px">
                                                <asp:Label ID="Label42" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Weight"></asp:Label></a></li>
                                            <li><a href="#tabs-2" style="width:110px">
                                                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="User Account"></asp:Label></a></li>
                                             <li><a href="#tabs-3" style="width:110px">
                                                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Machine Name"></asp:Label></a></li>
                                        </ul>
                               
                                      <div id="tabs-1">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                        <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:380px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Butt Stop Location" Width="220px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                           
                                                             <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 1"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 6"></asp:Label>

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation1" runat="server" onkeypress="return isNumberKey(event)" Width="80%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                             
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 2"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 7"></asp:Label>

                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 3"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 8"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label36" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 4"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label37" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 9"></asp:Label>

                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                             
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label40" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 5"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 25%" >

                                                                    <asp:Label ID="Label41" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Location 10"></asp:Label>

                                                                </td>
                                                           
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel42" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 25%">

                                                                       <asp:UpdatePanel ID="UpdatePanel43" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtLocation10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
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
                                                                           <asp:Button ID="btnApplyLocation" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyLocation_Click" />
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
                                                <td style="text-align: center; width: 33.3%">
                                                     
                                                 </td>
                                                 
                                                <td style="text-align: center; width: 33.4%">
                                                 
                                                 </td>
                                               </tr>
                                            </table>
                                        </div>
                                        <div id="tabs-2">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                           <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New User" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="User" ></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddUser" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Role"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="DrplAddRole" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" >
                                                                                   <asp:ListItem>Admin</asp:ListItem>
                                                                                   <asp:ListItem>Operator</asp:ListItem>
                                                                                   <asp:ListItem>User</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >
                                                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                  </td>
                                                                
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">
                                                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Confirm Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width:60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddCfPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                             </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                            <tr>
                                                               <td style="text-align: right; " colspan="2">

                                                                    &nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyAddUser" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyAddUser_Click" />
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
                                           
                                                <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button10" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit User" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">

                                                                    <asp:Label ID="Label65" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="User"></asp:Label>

                                                                 </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="DrplEditUser" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                 </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Old Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditOldPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">

                                                                    <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Role"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel66" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="DrplEditRole" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" >
                                                                                   <asp:ListItem>Admin</asp:ListItem>
                                                                                   <asp:ListItem>Operator</asp:ListItem>
                                                                                   <asp:ListItem>User</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="New Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >
                                                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditNewPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                  </td>
                                                                
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">
                                                                    <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Confirm Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditCfPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                             </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel63" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditUser" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%" Text="Apply" Width="70%" OnClick="btnApplyEditUser_Click" />
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
                                                    <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete User" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">

                                                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="User"></asp:Label>

                                                                 </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="DrplDeleteUser" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                 </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Old Pass"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDeleteOldPass" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" TextMode="Password" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; " colspan="2">

                                                                    &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                                 <tr>
                                                               <td style="text-align: right;  " colspan="2" >

                                                                    &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; " colspan="2">
                                                                    &nbsp;&nbsp;</td>
                                                              
                                                             </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyDeleteUser" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%" Text="Apply" Width="70%" OnClick="btnApplyDeleteUser_Click" />
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
                                                </tr>
                                              
                                            </table>
                                        </div>
                                          <div id="tabs-3">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                           <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="New Station Name" Width="190px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                              <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Type"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplAddMchType" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="drplAddMchType_SelectedIndexChanged" >
                                                                                   <asp:ListItem>Z-Mike</asp:ListItem>
                                                                                   <asp:ListItem>Frequency</asp:ListItem>
                                                                                   <asp:ListItem>Flex</asp:ListItem>
                                                                                   <asp:ListItem>S-Weight</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Name" ></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:TextBox ID="txtAddMchName" runat="server" Font-Names="Times New Roman" Font-Size="110%" Width="96%"></asp:TextBox>
                                                                           </ContentTemplate>
                                                                       </asp:UpdatePanel>
                                                                 </td>
                                                                
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Task Name" ></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:TextBox ID="txtAddTask" runat="server" Font-Names="Times New Roman" Font-Size="110%" Width="96%"></asp:TextBox>
                                                                           </ContentTemplate>
                                                                       </asp:UpdatePanel>
                                                                 </td>
                                                                
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: right;  padding-right:10%" colspan="2" >

                                                                    &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                            
                                                           
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                            
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyAddMch" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyAddMch_Click"  />
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
                                           
                                                <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button5" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Station Name" Width="190px" />
                                                            </legend>
                                                          <table style="width: 100%; height: 100%">
                                                              <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Type"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplEditMchType" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="drplEditMchType_SelectedIndexChanged" >
                                                                                   <asp:ListItem>Z-Mike</asp:ListItem>
                                                                                   <asp:ListItem>Frequency</asp:ListItem>
                                                                                   <asp:ListItem>Flex</asp:ListItem>
                                                                                   <asp:ListItem>S-Weight</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Name"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplEditMchName" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="drplEditMchName_SelectedIndexChanged" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label66" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="New Name" ></asp:Label>

                                                                  </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditMchName" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                                <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Task Name" ></asp:Label>

                                                                  </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditTask" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                            <tr>
                                                               <td style="text-align: right; " colspan="2">

                                                                    &nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditMch" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyEditMch_Click" />
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
                                                    <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:250px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Station Name" Width="190px" />
                                                            </legend>
                                                            <table style="width: 100%; height: 100%">
                                                              <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Type"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDelMchType" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="drplDelMchType_SelectedIndexChanged" >
                                                                                   <asp:ListItem>Z-Mike</asp:ListItem>
                                                                                   <asp:ListItem>Frequency</asp:ListItem>
                                                                                   <asp:ListItem>Flex</asp:ListItem>
                                                                                   <asp:ListItem>S-Weight</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right; width:40% ;padding-right:10%">

                                                                    <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Station Name"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDelMchName" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                
                                                            </tr>
                                                              <tr>
                                                               <td style="text-align: right;  padding-right:10%" colspan="2" >

                                                                    &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                            <tr>
                                                               <td style="text-align: right; " colspan="2">

                                                                    &nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyDelMch" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyDelMch_Click"/>
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
                                                </tr>
                                            </table>
                                         </div>
                                            <div id="tabs-4">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                           <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:180px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button4" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New Weight" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Weight" ></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtWeight" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                          
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                            <tr>
                                                               <td style="text-align: right; " colspan="2">

                                                                    &nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyWeight" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="70%" OnClick="btnApplyWeight_Click"  />
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
                                              
                                                <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:180px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button9" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Weight" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">

                                                                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Old Weight"></asp:Label>

                                                                 </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel36" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplWeight" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="drplWeight_SelectedIndexChanged">
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                 </td>
                                                                
                                                            </tr>
                                                            
                                                             <tr>
                                                               <td style="text-align: right;  width: 40% ;padding-right:10%" >

                                                                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="New Weight"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 60%" >

                                                                       <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtEditWeight" runat="server" Width="96%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               
                                                            </tr>
                                                           
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;</td>
                  
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel45" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditWeight" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%" Text="Apply" Width="70%" OnClick="btnApplyEditWeight_Click"  />
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
                                                    <td style="text-align: center; width:33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:180px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button12" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Weight" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             <tr>
                                                               <td style="text-align: right; width: 40% ;padding-right:10%">

                                                                    <asp:Label ID="Label38" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Weight"></asp:Label>

                                                                 </td>
                                                              
                                                                  <td style="text-align: center; width: 60%">

                                                                       <asp:UpdatePanel ID="UpdatePanel47" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDeleteWeight" runat="server" ForeColor="Black" Font-Size="110%" Width="98%" EnableTheming="True" AutoPostBack="True" >
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                 </td>
                                                                
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: right; " colspan="2">
                                                                    &nbsp;&nbsp;</td>
                                                              
                                                             </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   &nbsp;&nbsp;</td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="2" >

                                                                   <asp:UpdatePanel ID="UpdatePanel49" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnDelWeight" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%" Text="Apply" Width="70%" OnClick="btnDelWeight_Click"  />
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
                                                </tr>
                                              
                                            </table>
                                        </div>
                                   </div>

                                </td>
                                <td style="width: 5%"></td>
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
