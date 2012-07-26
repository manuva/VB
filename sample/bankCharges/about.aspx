<%@ Page Language="VB" AutoEventWireup="false" CodeFile="about.aspx.vb" Inherits="about" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function btnHome_onclick() {
            window.location = "default.aspx";
        }

// ]]>
    </script>
</head>
<body bgcolor="#000000" text="#ffffff">
    <form id="form1" runat="server">
    <div>
    
        <h2>
    
        <span style="text-align: center">About this Application</span></h2>
        <p>
            <span style="text-align: center">This web app is for ITCS1230 - Week 6</span></p>
        <p>
            Programmer: Greg Teasdale</p>
        <p>
            Takes in a user input for number of checks and computes and displays the proper 
            service fees.</p>
        <input id="btnHome" type="button" value="Bank Page" onclick="return btnHome_onclick()" /><span style="text-align: center"><br />
        <br />
    
    </div>
    </form>
</body>
</html>
