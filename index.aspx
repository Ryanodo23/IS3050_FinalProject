<!-- 
Members
Layth Alfwaress - Github: alfwarll
Ayah Faour - Github: faouraj
Ryan O'Donnell - Github: Ryanodo23
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Forecasters_FinalProject.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forecasters</title>
    <style>
        /* Button Styles */
        .button-solution-4 {
            background-color: red;
            color: white;
        }
        .button-solution-30 {
            background-color: blue;
            color: white;
        }
        .button-solution-41 {
            background-color: green;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>We are the Forecasters!</h1>
        <p style="font-size: 24px;">Team Members: Layth Alfwaress, Ayah Faour, & Ryan O'Donnell</p>

        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    Clear Leetcode Solutions
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="Solution #4" OnClick="Button1_Click" CssClass="button-solution-4" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button2" runat="server" Text="Solution #30" OnClick="Button2_Click" CssClass="button-solution-30" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button3" runat="server" Text="Solution #41" OnClick="Button3_Click" CssClass="button-solution-41" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table> 

        <br />
        <asp:Label ID="MessageLabel" runat="server" Text="" ForeColor="Green" />
    </form>
</body>
</html>
