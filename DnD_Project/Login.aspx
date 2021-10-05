<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DnD_Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <link rel="stylesheet" href="CSS/Login.css">
    
</head>

    <body>
    <div class="login-dark">
        <form method="post" runat="server">
            <div class="messagealert" id="alert_container"></div>
            <h2 class="sr-only">Login Form</h2>
            <div class="illustration"><i class="icon ion-ios-locked-outline"></i></div>
            <div class="form-group"><input type ="text" class="form-control"  placeholder="Username" name="UName"></div>
            <div class="form-group"><input  class="form-control" type="password" name="password" placeholder="Password"></div>
            <div class="form-group"><asp:button ID="Button1" runat="server" CSSClass="btn btn-primary btn-block" text="Log In"  OnClick ="B1" ></asp:button></div>
            <div class="form-group"><asp:button ID="Button2" runat="server" CSSClass="btn btn-primary btn-block" text="Sign Up"></asp:button></div>
            <div class="MessagePanelDiv">
</div>
            <a href="#" class="forgot">Forgot your email or password?</a></form>
    </div>
         
        
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js"></script>
</body>

</html>

