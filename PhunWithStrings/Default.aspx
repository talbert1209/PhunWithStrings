<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Phun With Strings</h1>
        </div>
        <div>
            Challenge #1 - Reverse a name<br />
            <br />
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="challenge1Button" runat="server" Text="Check Challenge 1" />
            <br />
            <asp:Label ID="challenge1ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            Challegne #2 - Reverse this sequence &quot;<asp:Label ID="sequenceLabel" runat="server" Text="Luke,Leia,Han,Chewbacca"></asp:Label>
            &quot;<br />
            <asp:Button ID="challenge2Button" runat="server" Text="Check Challenge 2" />
            <br />
            <asp:Label ID="challenge2ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            Challenge #3 - Use the sequence to create ascii art:<br />
            <asp:Button ID="challenge3Button" runat="server" Text="Check Challenge 3" />
            <br />
            <asp:Label ID="challenge3ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            Challenge #4 string puzzle = &quot;NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.&quot; <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Should read &quot;Now is the time for all good men to come to the aid of their country.&quot;<br />
            <asp:Button ID="challenge4Button" runat="server" Text="Check Challenge 4" />
            <br />
            <asp:Label ID="challenge4ResultLabel" runat="server"></asp:Label>
    </form>
    </body>
</html>
