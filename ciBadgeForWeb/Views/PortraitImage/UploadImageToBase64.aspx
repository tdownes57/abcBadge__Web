<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImageToBase64.aspx.cs" Inherits="ciBadgeForWeb.Views.PortraitImage.UploadImageToBase64" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
<asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" 
    onclick="btnUpload_Click" />
<hr />
<asp:Image ID="Image1" Visible = "false" runat="server" Height = "100" Width = "100" />
</form>
</body>
</html>
