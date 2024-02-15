<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZMikePage.aspx.cs" Inherits="ATSCADAWebApp.ZMikePage" %>
<%@ Register assembly="iTools.Web" namespace="ATSCADA.iWebTools" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ZMike Page</title>
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
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="300%" ForeColor="White" Text="Z-Mike"></asp:Label>
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
                                            <li><a href="SwingWPage.aspx">Swing Weight</a></li>
                                            <li><a href="ZMikePage.aspx" style="color:white">Z-Mike</a></li>
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
                                        </div>                                         <div style="width: 100%;height:10px">

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
