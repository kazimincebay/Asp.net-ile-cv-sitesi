<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="cv.WebForm21" %>
<!DOCTYPE html>
<html>
<head>
	<title>Login Page</title>
   <!--Made with love by Mutiullah Samim -->
   
	<!--Bootsrap 4 CDN-->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    
    <!--Fontawesome CDN-->
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

	<!--Custom styles-->
    <link href="LoginDosyalar/style.css" rel="stylesheet" />
</head>
<body>
<div class="container">
	<div class="d-flex justify-content-center h-100">
		<div class="card">
			<div class="card-header">
				<h3>Oturum Aç</h3>
				<div class="d-flex justify-content-end social_icon">
					<span>
						<asp:HyperLink ID="HyperLink1" runat="server" CssClass="text-white" NavigateUrl="https://www.linkedin.com/in/kazimincebay" Target="_blank"><i class="fab fa-linkedin"></i></asp:HyperLink></span>
					<span>
						<asp:HyperLink ID="HyperLink2" runat="server" CssClass="text-white" NavigateUrl="https://www.github.com/kazimincebay" Target="_blank"><i class="fab fa-github"></i></asp:HyperLink></span>
				</div>
			</div>
			<div class="card-body">
				<form runat="server">
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-user"></i></span>
						</div>
						<%--<input type="text" class="form-control" placeholder="username">--%>
						 <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Kullanıcı Adı"></asp:TextBox>
					</div>
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-key"></i></span>
						</div>
						<%--<input type="password" class="form-control" placeholder="password">--%>
						<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" PlaceHolder="Parola" TextMode="Password"></asp:TextBox>
					</div>
					<div class="row align-items-center remember">
						<input type="checkbox">Beni Hatırla
					</div>
					<div class="form-group">
						<%--<input type="submit" value="Login" class="btn float-right login_btn">--%>
						<asp:Button ID="Button1" runat="server" Text="Oturum Aç" CssClass="btn float-right login_btn" OnClick="Button1_Click" />
					</div>
				</form>
			</div>
			<div class="card-footer">
				<div class="d-flex justify-content-center links">
					Hesabın yok mu?<a href="#">Kayıt Ol</a>
				</div>
				<div class="d-flex justify-content-center">
					<a href="#">Şifremi Unuttum</a>
				</div>
			</div>
		</div>
	</div>
</div>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</body>
</html>