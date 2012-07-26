<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmRoomCharge.aspx.vb" Inherits="frmRoomCharge" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Highlander Hotel Room Charges</title>
    <style type="text/css">
        #Text2
        {
            height: 21px;
            width: 78px;
        }
        #Text1
        {
            width: 74px;
            height: 22px;
        }
        .style1
        {
            width: 178px;
        }
        .style3
        {
            width: 295px;
        }
        .style4
        {
            width: 295px;
            height: 26px;
        }
        .style5
        {
            height: 26px;
        }
        .style6
        {
            width: 162px;
        }
        .style7
        {
            width: 162px;
            height: 26px;
        }
        .style8
        {
            width: 149px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
   
    
        <h2>
            Highlander Hotel</h2>
    
    

     <div style="height: 42px; width: 100%;" align="right">
        <asp:Label ID="lblToday" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTime" runat="server"></asp:Label>
    </div>

    
   
    <div style="height: 415px; width: 890px">
        <div style="float:left; width: 385px;">
            <table style="width:100%;" bgcolor="White" cellspacing="0">
                <tr>
                    <td bgcolor="#CCCCCC">
                        <strong>Room Charges</strong></td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC">
                        Nights:</td>
                    <td bgcolor="#CCCCCC">
                        <asp:TextBox ID="txtNights" runat="server" Width="98px"></asp:TextBox>
                        <asp:RangeValidator ID="rvNights" runat="server" ControlToValidate="txtNights" 
                            ErrorMessage="Number must be 1-30" ForeColor="Red" MaximumValue="30" 
                            MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        <asp:RequiredFieldValidator ID="rfvNights" runat="server" 
                            ControlToValidate="txtNights" ErrorMessage="Nights is required" ForeColor="Red" 
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC">
                        Nightly Charges:</td>
                    <td bgcolor="#CCCCCC">
                        <asp:TextBox ID="txtNightlyCharges" runat="server" Width="97px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ControlToValidate="txtNightlyCharges" ErrorMessage="Must be 1-209.99" 
                            ForeColor="#CC0000" MaximumValue="209.99" MinimumValue="1" Type="Double"></asp:RangeValidator>
                    </td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        <asp:RequiredFieldValidator ID="rfvNightly" runat="server" 
                            ControlToValidate="txtNightlyCharges" 
                            ErrorMessage="Nightly Charges is required" ForeColor="Red" 
                            SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div style="float:right; height: 129px;">
            <table style="width:100%; height: 124px;" cellspacing="0">
                <tr>
                    <td bgcolor="#CCCCCC" class="style1">
                        <strong>Additional Information</strong></td>
                    <td bgcolor="#CCCCCC" class="style8">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td bgcolor="#CCCCCC" class="style1">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC" class="style8">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC" class="style1">
                        Room service:</td>
                    <td bgcolor="#CCCCCC" class="style8">
                        <asp:TextBox ID="txtRoomSvc" runat="server" Width="102px"></asp:TextBox>
                    </td>
                    <td bgcolor="#CCCCCC">
                        <asp:RangeValidator ID="RangeValidator5" runat="server" 
                            ControlToValidate="txtRoomSvc" ErrorMessage="Must be 0 or positive #" 
                            ForeColor="Red" MaximumValue="999999" MinimumValue="0"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC" class="style1">
                        Telephone:</td>
                    <td bgcolor="#CCCCCC" class="style8">
                        <asp:TextBox ID="txtPhone" runat="server" Width="102px"></asp:TextBox>
                    </td>
                    <td bgcolor="#CCCCCC">
                        <asp:RangeValidator ID="RangeValidator3" runat="server" 
                            ControlToValidate="txtPhone" ErrorMessage="Must be 0 or positive #" 
                            ForeColor="Red" MaximumValue="999999" MinimumValue="0"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC" class="style1">
                        Misc:</td>
                    <td bgcolor="#CCCCCC" class="style8">
                        <asp:TextBox ID="txtMisc" runat="server" Width="102px"></asp:TextBox>
                    </td>
                    <td bgcolor="#CCCCCC">
                        <asp:RangeValidator ID="RangeValidator4" runat="server" 
                            ControlToValidate="txtMisc" ErrorMessage="Must be 0 or positive #" 
                            ForeColor="Red" MaximumValue="999999" MinimumValue="0"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" bgcolor="#CCCCCC" class="style1">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC" class="style8">
                        &nbsp;</td>
                    <td bgcolor="#CCCCCC">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <br />
        <div align="center" style="clear:both;">
            <table style="width: 100%; height: 138px; margin-top: 18px;">
                <tr>
                    <td class="style3">
                        &nbsp;
                    </td>
                    <td class="style6">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Room Charges: Room Charges:</td>
                    <td class="style6">
                        <asp:Label ID="lblRmCharges" runat="server" BorderStyle="Inset" Height="16px" 
                            Width="99px"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Additional Charges:</td>
                    <td class="style6">
                        <asp:Label ID="lblAddCharges" runat="server" BorderStyle="Inset" Height="16px" 
                            Width="99px"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Subtotal:</td>
                    <td class="style6">
                        <asp:Label ID="lblSubtotal" runat="server" BorderStyle="Inset" Height="16px" 
                            Width="99px"></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Tax:</td>
                    <td class="style6">
                        <asp:Label ID="lblTax" runat="server" BorderStyle="Inset" Height="16px" 
                            Width="99px"></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        Total Charges:</td>
                    <td class="style7">
                        <asp:Label ID="lblTotalCharges" runat="server" BorderStyle="Inset" Height="16px" 
                            Width="99px"></asp:Label>
                    </td>
                    <td class="style5">
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        &nbsp;</td>
                    <td class="style7">
                        &nbsp;</td>
                    <td class="style5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        <asp:Button ID="btnCalc" runat="server" Text="Calculate Charges" />
                    </td>
                    <td class="style7">
          &nbsp;</td>
                    <td class="style5">
                        <asp:Button ID="btnClear" runat="server" style="margin-left: 0px" Text="Clear" 
                            Width="55px" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </div>
    </div>

    
   
    </form>
    </body>
</html>
