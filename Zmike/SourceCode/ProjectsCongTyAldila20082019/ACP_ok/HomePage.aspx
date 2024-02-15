<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ATSCADAWebApp.HomePage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PageHome</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="Them/Style.css" rel="stylesheet" />
    <link rel="stylesheet" href="Scripts/jquery-ui.css" />
    <script src="Scripts/jquery-1.12.4.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/select2.min.js"></script>
     <script>
        $(function () {
            $("#tabs").tabs();
        });
    </script>
     <script>
         function isNumberKey(evt,idtxt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
        if ((charCode >= 48 && charCode <= 57) || (charCode == 46&&idtxt.value.split('.').length<=1))
            return true;
            return false;
         }  
     </script>
        <link href="Scripts/select2.min.css" rel="stylesheet" />
        <script type="text/javascript">
           function pageLoad() {
              $(".loadcombo").select2();
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="WORK HOME"></asp:Label>
                                </td>
                            </tr>
                          <tr  style="background: #000000;">
                              <td colspan="2">
                                  <ul id="menu">
                                    <li><a href="HomePage.aspx">Work Home</a></li>
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
                                <td style="width: 5%"></td>
                                <td style="width: 90%;border-radius:5px">
                                     
                                    <div id="tabs" style="width: 99%; height: 100%">
                                        <div>
                                             <table style="width: 100%; height: 100%">
                                                   <tr>
                                                       <td style="text-align: right;width: 33%">
                                                            
                                                        <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="150%" ForeColor="Red" Text="Select Work Part "></asp:Label>
                                                       </td>
                                                       <td style="width: 33%">
                                                           <asp:UpdatePanel ID="UpdatePanel47" runat="server" >
                                                              <ContentTemplate>
                                                                <asp:DropDownList ID="drplPart"  runat="server" ForeColor="Black" Font-Size="150%" Width="100%"  EnableTheming="True" OnSelectedIndexChanged="drplPart_SelectedIndexChanged" class="form-control loadcombo" AutoPostBack="True">
                                                                </asp:DropDownList>
                                                             </ContentTemplate>
                                                         </asp:UpdatePanel>
                                                       </td>
                                                       <td style="width: 34%">
                                                           <asp:UpdatePanel ID="UpdatePanel118" runat="server">
                                                              <ContentTemplate>
                                                             <asp:Label ID="lblPartSelecte" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="150%" ForeColor="Red" Text="Part Selected"></asp:Label>
                                                           </ContentTemplate>
                                                         </asp:UpdatePanel>
                                                       </td>
                                                   </tr>
                                             </table>
                                        </div>
                                        <ul  id="menutab" style="text-align: center;font: bold; background-color: #00802b ">
                                             <li><a href="#tabs-8" style="width:110px">
                                                <asp:Label ID="Label62" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Part"></asp:Label></a></li>
                                            <li><a href="#tabs-1"style="width:110px">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Frequency"></asp:Label></a></li>
                                            <li><a href="#tabs-2"style="width:110px">
                                                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Frequency Standard"></asp:Label></a></li>
                                            <li><a href="#tabs-3"style="width:110px">
                                                <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Flex"></asp:Label></a></li>
                                            <li><a href="#tabs-4"style="width:110px">
                                                <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Flex Standard"></asp:Label></a></li>
                                            <li> <a href="#tabs-5"style="width:110px">
                                                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Swing Weight"></asp:Label></a></li>
                                             <li><a href="#tabs-6"style="width:110px">
                                                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Z-Mike"></asp:Label></a></li>
                                            <li><a href="#tabs-7"style="width:110px">
                                                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Z-Mike Meas Type"></asp:Label></a></li>
                                        </ul>
                                            <div id="tabs-8"  >
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                <td style="text-align: center; width: 33.3%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:150px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button9" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Add New Part" Width="200px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                      &nbsp;</td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel110" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtAddPart" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
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
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel111" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyAddPart" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyAddPart_Click" />
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
                                                                <asp:Button ID="Button13" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Part Number" Width="200px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label60" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel112" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplEditPart" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" EnableTheming="True" OnSelectedIndexChanged="drplEditPart_SelectedIndexChanged" class="form-control loadcombo"  AutoPostBack="True">
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

                                                                      <asp:UpdatePanel ID="UpdatePanel135" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:TextBox ID="txtEditPart" runat="server" Font-Names="Times New Roman" Font-Size="110%" Width="98%"></asp:TextBox>
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

                                                                      <asp:UpdatePanel ID="UpdatePanel113" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyEditPart" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyEditPart_Click" />
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
                                                                <asp:Button ID="Button16" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Delete Part" Width="200px" />
                                                            </legend>
                                                            <div >
                                                                  <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label61" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Number"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel114" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplDeletePart" runat="server" ForeColor="Black" Font-Size="110%" Width="100%"  EnableTheming="True" class="form-control loadcombo"  AutoPostBack="True">
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

                                                                      <asp:UpdatePanel ID="UpdatePanel117" runat="server">
                                                                          <ContentTemplate>
                                                                              <asp:Button ID="btnApplyDeletePart" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="btnApplyDeletePart_Click" />
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


                                                            </div>
                                                       
                                                       </fieldset>
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
                                      <div id="tabs-3">
                                            <table style="text-align: center;width: 100%; height: 100%">
                                                <tr>
                                                    <td style="text-align: center; width: 25%">
                                                        <fieldset style="text-align: center;border-style: groove; border-color: #00802b;height:160px" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Flex" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="Upper Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">
                                                                       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtFlexUP" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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

                                                                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Lower Limit"></asp:Label>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                </td>
                                                               
                                                            </tr>
                                                              <tr>
                                                                <td style="text-align: center; width: 15%">

                                                                </td>
                                                                  <td style="text-align: center; width: 70%">

                                                                      <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtFlexLow" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" onkeypress="return isNumberKey(event,this)"></asp:TextBox>
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
                                                                    <asp:UpdatePanel ID="UpdatePanel48" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="bntApplyEditFlex" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="100%" OnClick="bntApplyEditFlex_Click" />
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
                                                      
                                                        &nbsp;</td>
                                                     <td style="text-align: center; width: 25%">
                                                      
                                                         &nbsp;</td>
                                                     <td style="text-align: center; width: 25%">
                                                      
                                                         &nbsp;</td> 
                                                </tr>
                                            </table>
                                        </div>
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
                                           <div id="tabs-6">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                <td style="text-align: center; width: 10%">
                                                    
                                                    </td>
                                                     <td style="text-align: center; width:80%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;height:400px"  class="table">
                                                            <legend>
                                                                <asp:Button ID="Button26" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Red" Height="100%" Text="Edit Z-Mike" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                            
                                                            <tr>
                                                                <td style="text-align: center; " colspan="5">

                                                                    <asp:Label ID="Label53" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Qty Meas Types"></asp:Label>

                                                                </td>
                                                              
                                                            </tr>
                                                             <tr>
                                                               <td style="text-align: center; " colspan="5">

                                                                       <asp:UpdatePanel ID="UpdatePanel54" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplQtyMeasTypes" runat="server" ForeColor="Black" Font-Size="110%" Width="50%" AutoPostBack="True" EnableTheming="True" OnSelectedIndexChanged="drplQtyMeasTypes_SelectedIndexChanged" >
                                                                                   <asp:ListItem></asp:ListItem>
                                                                                   <asp:ListItem>3</asp:ListItem>
                                                                                   <asp:ListItem>4</asp:ListItem>
                                                                                   <asp:ListItem>5</asp:ListItem>
                                                                                   <asp:ListItem>6</asp:ListItem>
                                                                                   <asp:ListItem>7</asp:ListItem>
                                                                                   <asp:ListItem>8</asp:ListItem>
                                                                                   <asp:ListItem>9</asp:ListItem>
                                                                                   <asp:ListItem>10</asp:ListItem>
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>
                                                                </td>
                                                            </tr>
                                                             <tr>
                                                                <td style="text-align: center;  width: 40%" >

                                                                    <asp:Label ID="Label52" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Meas Type"></asp:Label>

                                                                </td>
                                                               <td style="text-align: center;  width: 15%" >

                                                                    <asp:Label ID="Label54" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Diam LL"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 15%" >

                                                                    <asp:Label ID="Label55" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Diam UL"></asp:Label>

                                                                </td>
                                                                 <td style="text-align: center;  width: 15%" >

                                                                    <asp:Label ID="Label56" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Min Under"></asp:Label>

                                                                </td>
                                                              
                                                                  <td style="text-align: center;  width: 15%" >

                                                                    <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Max Over"></asp:Label>

                                                                </td>
                                                            </tr>
                                                             <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType1" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel55" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel56" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel57" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel58" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder1" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel53" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType2" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                 
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel59" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel60" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel61" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel62" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder2" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel66" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType3" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                 
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel67" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel68" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel69" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel70" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder3" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel71" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType4" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                 
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel72" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel73" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel74" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel75" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder4" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel76" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType5" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel77" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel79" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel80" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel81" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder5" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel82" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType6" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                  
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel83" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel84" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel85" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel86" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder6" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel87" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType7" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                  
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel88" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel89" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel90" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel91" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder7" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel92" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType8" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                  
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel93" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel94" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel95" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel96" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder8" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel97" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType9" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                 
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel98" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel99" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel100" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel101" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder9" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                              <tr>
                                                              <td style="text-align: center; width: 40%">

                                                                       <asp:UpdatePanel ID="UpdatePanel102" runat="server">
                                                                           <ContentTemplate>
                                                                               <asp:DropDownList ID="drplMeasType10" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="70%">
                                                                                  
                                                                               </asp:DropDownList>
                                                                           </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                               <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel103" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamLL10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel104" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtDiamUL10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel105" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMinUnder10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                              
                                                                  <td style="text-align: center; width: 15%">

                                                                       <asp:UpdatePanel ID="UpdatePanel106" runat="server">
                                                                            <ContentTemplate>
                                                                                <asp:TextBox ID="txtMaxOder10" runat="server" Width="80%" Font-Names="Times New Roman" Font-Size="110%"  onkeypress="return isNumberKey(event,this)"></asp:TextBox>
                                                                            </ContentTemplate>
                                                                        </asp:UpdatePanel>

                                                                </td>
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="5" >

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="5" >

                                                                   <asp:UpdatePanel ID="UpdatePanel78" runat="server">
                                                                       <ContentTemplate>
                                                                           <asp:Button ID="btnApplyEditZmike" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="Blue" Height="100%"  Text="Apply" Width="50%" OnClick="btnApplyEditZmike_Click" />
                                                                       </ContentTemplate>
                                                                   </asp:UpdatePanel>

                                                                   </td>
                                                              
                                                            </tr>
                                                               <tr>
                                                               <td style="text-align: center;  " colspan="5" >

                                                                   &nbsp;</td>
                                                              
                                                            </tr>
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                     <td style="text-align: center; width: 10%">
                                                   
                                                    </td>
                                                </tr>
                                              
                                            </table>
                                        </div>
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
                                                                               <asp:DropDownList ID="drplEditMeasType" runat="server" ForeColor="Black" Font-Size="110%" Width="100%" EnableTheming="True" OnSelectedIndexChanged="drplEditMeasType_SelectedIndexChanged" class="form-control loadcombo"  AutoPostBack="True">
                                                                               
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
                                                                               <asp:DropDownList ID="drplDeleteMeasType" runat="server" ForeColor="Black" Font-Size="110%" Width="100%"  EnableTheming="True" class="form-control loadcombo"  AutoPostBack="True">
                                                                                  
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
