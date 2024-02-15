<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPage.aspx.cs" Inherits="ATSCADAWebApp.ViewPage" %>

<%@ Register Assembly="iTools.Web" Namespace="ATSCADA.iWebTools" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
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

    <style type="text/css">
        .auto-style1 {
            width: 14.3%;
        }

        .auto-style2 {
            width: 14.2%;
        }

        .auto-style3 {
            width: 99%;
            height: 100%;
        }
    </style>

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
                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="View"></asp:Label>
                                    </td>
                                </tr>
                                <tr style="background: #000000;">
                                    <td colspan="2">
                                        <ul id="menu">
                                            <li><a href="PartPage.aspx">Work Home</a></li>
                                            <li><a href="ViewPage.aspx" style="color: white">View</a></li>
                                            <li><a href="SettingsPage.aspx">Settings</a></li>
                                            <li><a href="ReportPage.aspx">Report</a></li>
                                            <li><a href="LoginPage.aspx">Exit</a></li>
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

                                <td style="width: 100%; border-radius: 5px">

                                    <div id="tabs" class="auto-style3">
                                        <ul id="menutab" style="text-align: center; font: bold; background-color: #00802b">
                                            <li><a href="#tabs-1" style="width: 110px">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Z-Mike"></asp:Label></a></li>
                                            <li><a href="#tabs-2" style="width: 110px">
                                                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Frequency"></asp:Label></a></li>
                                            <li><a href="#tabs-3" style="width: 110px">
                                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="Flex"></asp:Label></a></li>
                                            <li><a href="#tabs-4" style="width: 110px">
                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" Text="S-Weight"></asp:Label></a></li>
                                        </ul>
                                        <div id="tabs-1">
                                            <table style="width: 100%; height: 100%">
                                                <tr>
                                                    <td style="text-align: center; width: 100%">
                                                        <fieldset style="border-style: groove; border-color: #00802b" class="table">
                                                            <legend>
                                                                <asp:Button ID="Button26" runat="server" Font-Bold="True" Enabled="False" Font-Names="Times New Roman" Font-Size="110%" ForeColor="#0000CC" Height="100%" Text="Z-Mike" Width="180px" />
                                                            </legend>
                                                            <table style="width: 100%; height: 100%">

                                                                <tr style="background-color: lightblue">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label52" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Station"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label54" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Part"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label55" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Work Order"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label56" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Sensor"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Meas Type"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Diam Reading"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="100%" ForeColor="Red" Text="Results"></asp:Label>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel20" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel1" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Station"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel21" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel2" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Part"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel22" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel3" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.WorkOrder"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label58" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S1"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel4" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel4" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.MeasType1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel6" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel5" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.S1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel7" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel6" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Result1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label59" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S2"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel9" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel7" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.MeasType2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel10" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel8" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.S2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel11" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel9" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Result2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" class="auto-style1">

                                                                        <asp:Label ID="Label60" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S3"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel13" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel10" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.MeasType3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel14" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel11" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.S3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel15" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel12" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Result3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label61" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S4"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel17" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel13" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.MeasType4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel18" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel14" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.S4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel19" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel15" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike1.Result4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel1" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel16" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Station"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel2" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel17" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Part"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel3" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel18" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.WorkOrder"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label5" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S1"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel5" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel19" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.MeasType1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel8" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel20" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.S1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel12" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel21" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Result1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>

                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label6" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S2"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel16" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel22" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.MeasType2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel23" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel23" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.S2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel24" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel24" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Result2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" class="auto-style1">

                                                                        <asp:Label ID="Label9" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S3"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel25" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel25" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.MeasType3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel26" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel26" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.S3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel27" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel27" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Result3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label10" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S4"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel28" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel28" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.MeasType4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel29" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel29" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.S4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel30" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel30" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike2.Result4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>

                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel31" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel31" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Station"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel32" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel32" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Part"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel33" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel33" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.WorkOrder"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label11" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S1"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel34" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel34" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.MeasType1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel35" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel35" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.S1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel36" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel36" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Result1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>

                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label12" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S2"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel37" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel37" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.MeasType2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel38" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel38" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.S2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel39" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel39" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Result2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" class="auto-style1">

                                                                        <asp:Label ID="Label13" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S3"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel40" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel40" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.MeasType3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel41" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel41" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.S3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel42" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel42" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Result3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label15" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S4"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel43" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel43" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.MeasType4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel44" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel44" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.S4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel45" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel45" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike3.Result4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>

                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel46" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel46" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Station"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel47" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel47" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Part"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" rowspan="4">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel48" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel48" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.WorkOrder"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label16" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S1"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel49" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel49" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.MeasType1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel50" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel50" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.S1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel51" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel51" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Result1"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>

                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label17" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S2"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel52" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel52" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.MeasType2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel53" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel53" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.S2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel54" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel54" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Result2"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center;" class="auto-style1">

                                                                        <asp:Label ID="Label18" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S3"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel55" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel55" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.MeasType3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel56" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel56" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.S3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center;" class="auto-style2">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel57" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel57" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Result3"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>
                                                                <tr style="background-color: #474E5D">
                                                                    <td style="text-align: center; width: 14.3%">

                                                                        <asp:Label ID="Label20" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" Text="S4"></asp:Label>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel58" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel58" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.MeasType4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel59" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel59" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.S4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                    <td style="text-align: center; width: 14.2%">

                                                                        <cc1:iUpdatePanel ID="iUpdatePanel60" runat="server">
                                                                            <ContentTemplate>
                                                                                <cc1:iLabel ID="iLabel60" runat="server" Font-Names="Times New Roman" Font-Size="100%" ForeColor="White" WebTagName="InternalTask_ZMike4.Result4"></cc1:iLabel>
                                                                            </ContentTemplate>
                                                                        </cc1:iUpdatePanel>

                                                                    </td>
                                                                </tr>

                                                                

                                                                <tr>
                                                                    <td style="text-align: center;" colspan="7"></td>
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
                                                    <td style="text-align: center; width: 100%">
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
                                                    <td style="text-align: center; width: 100%">
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
                                                    <td style="text-align: center; width: 100%">
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
                                <td style="text-align: center; background-color: #474E5D; width: 100%; border-radius: 7px; box-shadow: 5px 5px 5px #808080;">
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
