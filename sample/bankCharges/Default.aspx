<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Week 6 - Bank Charges - Greg Teasdale</title>

    <style type="text/css">
        .style1
        {
            height: 33px;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 33px;
            width: 178px;
        }
        .style4
        {
            height: 23px;
            width: 178px;
        }
        .style5
        {
            width: 178px;
        }
        .style9
        {
            height: 31px;
            width: 178px;
        }
        .style11
        {
            height: 31px;
        }
        .style12
        {
            height: 33px;
            width: 284px;
        }
        .style13
        {
            height: 23px;
            width: 284px;
        }
        .style14
        {
            height: 31px;
            width: 284px;
        }
        .style15
        {
            width: 284px;
        }
    </style>

    <script language="javascript" type="text/javascript">
    </script>
</head>
<body bgcolor="#000000" text="#ffffff">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style3">
                <h2>
                    Bank Charges</h2>
            </td>
            <td class="style12">
                &nbsp;</td>
            <td class="style1">
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style13">
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td align="right" class="style9">
                Number of checks written:</td>
            <td class="style14">
                <asp:TextBox ID="txtChecks" runat="server" Width="101px"></asp:TextBox>
                <!--Validates against checks being empty, must input something -->
                <asp:RequiredFieldValidator ID="rfvNumChecks" runat="server" 
                    ControlToValidate="txtChecks" ErrorMessage="Checks is a required field" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style11">
            <!--validates that checks is greater than 0-->
                <asp:RangeValidator ID="rvNumChecks" runat="server" 
                    ControlToValidate="txtChecks" 
                    ErrorMessage="Checks must be numeric and greater than 0" ForeColor="Red" 
                    MaximumValue="99999999" MinimumValue="1"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style5">
                Bank service fees:</td>
            <td class="style15">
                <asp:Label ID="lblFees" runat="server" BorderStyle="Inset" Height="17px" 
                    Width="96px"></asp:Label>
            </td>
            <td>
             
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style5">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style5">
                <asp:Button ID="btnCalc" runat="server" Text="Calculate Fees" Width="115px" />
            </td>
            <td class="style15">
                <asp:Button ID="btnClear" runat="server" CausesValidation="False" 
                    style="margin-left: 85px" Text="Clear" />
            </td>
            <td>
                <input id="btnAbout" type="button" value="About" 
                    onclick="window.location='about.aspx'" /></td>
        </tr>
    </table>
    </form>
    </body>
</html>
