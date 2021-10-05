<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="DnD_Project.Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>--%>
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js"></script>
    <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.5.0/css/all.css' integrity='sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU' crossorigin='anonymous'>
	<link rel="stylesheet" href="CSS/Login2.css">
	<h1>D&D World</h1>
	<script src="Scripts/ErrorMessage.js"></script>
</head>
<body>
    <div class="" style="background-color:black; color:red;">
	<div class="container d-flex justify-content-center" style="background-color:black; color:red;">
		<div class="row" style="background-color:red; color:red;">
			<div class="card" style="background-color:red; color:red;">
				<div class="card-header" style="background-color:black; color:red;" >
				</div>
				<div class="card-body" style="background-color:black; color:red;" >
					<form name="login" id="login" runat="server">
						<div class="row">
							<div class="col">
								<span class="profile-img">
									<i class='fab fa-d-and-d' style='font-size:120px'></i>
								</span>
							</div>
						</div>
						<div class="row">
							<div class="col">
								<hr> <!-- other content  -->
							</div>
						</div>
						<div class="row">
							<div class="col">
								<div class="form-group">
									<div class="input-group mb-3">
										<div class="input-group-prepend">
											<span class="input-group-text" id="basic-addon1">
												<i class='fas fa-hat-wizard'></i>
											</span>
										</div>
										<input class="form-control" placeholder="Username" id="Username" name="Username" type="text" autofocus>
									</div>
								</div>
								<div class="form-group">
									<div class="input-group mb-3">
										<div class="input-group-prepend">
											<span class="input-group-text" id="basic-addon1">
												<i class='fas fa-dungeon'></i>
											</span>
										</div>
										<input class="form-control" placeholder="Password" id="loginPassword" name="loginPassword" type="password">
									</div>
								</div>
								<div class="form-group">
									<asp:button runat="server" class="btn btn-lg btn-success btn-block submit" id="login_m" OnClick ="B1" Text="Sign in"></asp:button>
									<asp:button runat="server" class="btn btn-lg btn-info btn-block submit" id="Button2" OnClick ="B2" Text="Sign up"></asp:button>
								</div>
								<div class="alert alert-danger alert-dismissible fade show" role="alert" id="div1" runat="server">
								 <% if (Error.Length > 0) { Response.Write(Error); } %>
								<button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
							</div>
							
							</div>
						</div>
					<!-- <a href="#" onClick="">I forgot my password!</a> -->
					</form>
				</div>
			</div>
		</div>
	</div>
</div>
</body>
	
</html>
