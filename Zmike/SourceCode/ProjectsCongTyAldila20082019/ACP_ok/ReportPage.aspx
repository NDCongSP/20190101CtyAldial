<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportPage.aspx.cs" Inherits="ATSCADAWebApp.ReportPage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link href="Them/Style.css" rel="stylesheet" />
      <link rel="stylesheet" href="Scripts/jquery-ui.css" />
    <%-- <link rel="stylesheet" href="/resources/demos/style.css" /> --%>
    <script src="Scripts/jquery-1.12.4.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
      
    <script>
        $(function ab() {
            var dateFormat = "MM/dd/yyyy",
              from = $("#FromData")
                .datepicker({
                    defaultDate: "+1w",
                    changeMonth: true,
                    numberOfMonths: 1
                })
                .on("change", function () {
                    to.datepicker("option", "minDate", getDate(this));
                }),
              to = $("#ToData").datepicker({
                  defaultDate: "+1w",
                  changeMonth: true,
                  numberOfMonths: 1
              })
              .on("change", function () {
                  from.datepicker("option", "maxDate", getDate(this));
              });
            function getDate(element) {
                var date;
                try {
                    date = $.datepicker.parseDate(dateFormat, element.value);
                } catch (error) {
                    date = null;
                }
                return date;
            }
        });
    </script>
    <script>
        $(function () {
            $("#tabs").tabs();
        });
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Report"></asp:Label>
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
                              
                                <td style="width: 100%;border-radius:5px">

                                    <div id="tabs" style="width: 99%; height: 100%">                                     
                                        <ul  id="menutab" style="text-align: center;font: bold; background-color: #00802b ">
                                            <li><a href="#tabs-1" style="width:110px">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Z-Mike"></asp:Label></a></li>
                                            <li><a href="#tabs-2" style="width:110px">
                                                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Frequency"></asp:Label></a></li>
                                            <li><a href="#tabs-3" style="width:110px">
                                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Flex"></asp:Label></a></li>
                                            <li><a href="#tabs-4" style="width:110px">
                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="S-Weight"></asp:Label></a></li>
                                        </ul>
                                          <div id="tabs-1">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                     <td style="text-align: center; width:100%">
                                                        <fieldset style="border-style: groove; border-color: #00802b;border-radius: 7px;box-shadow: 5px 5px 5px #808080" >
                                                            <legend>
                                                                <asp:Button ID="Button26" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#0000CC" Height="100%" Text="Z-Mike" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                                   <tr style="height: 10%">
                                                                    <td style="text-align: left; width: 20%">
                                                                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="From"></asp:Label>
                                                                    </td>
                                                                    <td style="text-align: left; width: 20%">
                                                      
                                                                         <asp:UpdatePanel ID="UpdatePanel110" runat="server">
                                                                            <ContentTemplate>
                                                                                 <asp:TextBox ID="FromData" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                         </asp:UpdatePanel>
                                                                    </td>
                                                                    <td style="text-align: left; width: 10%">&nbsp;</td>

                                                                    <td style="text-align: left; width: 20%">
                                                                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802b" Text="To"></asp:Label>
                                                                    </td>
                                                                    <td colspan="2" style="text-align: left; width: 20%">
                                                                         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                            <ContentTemplate>
                                                                                 <asp:TextBox ID="ToData" runat="server" Width="99%" Font-Names="Times New Roman" Font-Size="110%" ></asp:TextBox>
                                                                            </ContentTemplate>
                                                                         </asp:UpdatePanel>
                                                                    </td>
                                                                    <td style="text-align: left; width: 10%">&nbsp;</td>
                                                                </tr>
                                                               <tr style="height: 10%">
                                                                        <td style="text-align: left; width: 20%">
                                                                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#00802B" Text="Name"></asp:Label>
                                                                        </td>
                                                                        <td style="text-align: left; width: 20%">
                                                                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                                                <ContentTemplate>
                                                                                    <asp:DropDownList ID="drplName" runat="server" AutoPostBack="True" EnableTheming="True" Font-Size="110%" ForeColor="Black"  Width="100%">
                                                                                    </asp:DropDownList>
                                                                                </ContentTemplate>
                                                                            </asp:UpdatePanel>
                                                                        </td>
                                                                        <td style="text-align: left; width: 10%">&nbsp;</td>

                                                                        <td style="text-align: left; width: 20%">
                                                                            &nbsp;</td>
                                                                         <td style="text-align: left; width: 10%">
                                                                            
                                                                                    <asp:Button ID="btnSerch" runat="server" Font-Bold="True" Font-Names="Times New Roman" ForeColor="Blue" Font-Size="110%" Height="100%" Text="Search" Width="100%" OnClick="btnSerch_Click" />
                                                                              
                                                                        </td>
                                                                        <td style="text-align: left; width: 10%">

                                                                            <asp:Button ID="btnDowload" runat="server" Font-Bold="True" Font-Names="Times New Roman" ForeColor="Blue" Font-Size="110%" Height="100%" Text="Download" Width="100%" OnClick="btnDowload_Click"  />

                                                                        </td>
                                                                        <td style="text-align: left; width: 10%">&nbsp;</td>
                                                                    </tr>
                                                                     <tr >
                                                                        <td style="text-align: center;  " colspan="7" >
                                                                        </td>
                                                                    </tr>
                                                                    <tr >
                                                                        <td style="text-align: center;  " colspan="7" >
                                                                             <div style="overflow-y: scroll; overflow-x: scroll; height: 400px">
                                                                                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                                                    <ContentTemplate>
                                                                                        <asp:GridView ID="Data" runat="server" Style=" bottom: 0%; top: 0%; left: 0%; right: 0%"
                                                                                            Font-Bold="True" Font-Names="Times New Roman" Font-Size="110%" width="100%"  height="100%" 
                                                                                            BackColor="White" BorderColor="#009933" BorderStyle="Double" BorderWidth="3px" CellPadding="4"
                                                                                            EmptyDataText="No Data" ShowHeaderWhenEmpty="True" OnRowDataBound="Data_RowDataBound">

                                                                                            <FooterStyle BackColor="White" ForeColor="#333333" />
                                                                                            <HeaderStyle BackColor="#00802b" Font-Bold="True" ForeColor="White" />
                                                                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#00802b" />
                                                                                            <RowStyle BackColor="White" ForeColor="#333333" />
                                                                                            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                                                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                                                                            <SortedAscendingHeaderStyle BackColor="#487575" />
                                                                                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                                                                            <SortedDescendingHeaderStyle BackColor="#275353" />
                                                                                        </asp:GridView>
                                                                                    </ContentTemplate>
                                                                                </asp:UpdatePanel>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr >
                                                                        <td style="text-align: center;  " colspan="7" >
                                                                        </td>
                                                                    </tr>
                                                                 </table>
                                                               </fieldset>
                                                            </td>
                                                        </tr>
                                            </table>
                                        </div>
                                          <div id="tabs-2">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                     <td style="text-align: center; width:100%">
                                                        <fieldset style="border-style: groove; border-color: #00802b" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#0000CC" Height="100%" Text="Frequency" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                       
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                          <div id="tabs-3">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                     <td style="text-align: center; width:100%">
                                                        <fieldset style="border-style: groove; border-color: #00802b" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#0000CC" Height="100%" Text="Flex" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                             
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                          <div id="tabs-4">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                     <td style="text-align: center; width:100%">
                                                        <fieldset style="border-style: groove; border-color: #00802b" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#0000CC" Height="100%" Text="S-Weight" Width="180px" />
                                                            </legend>
                                                         <table style="width: 100%; height: 100%">
                                                               
                                                         </table>
                                                       </fieldset>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                  </div>
                                </td>
                             
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
           </table>
       </div>
    </form>
</body>
</html>
