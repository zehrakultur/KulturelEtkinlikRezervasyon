<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="Proje.Web.GirisYap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Kültür Film - Giriş Yap</title>
    <!-- Favicon Icon -->
    <link rel="icon" type="image/png" href="Tasarim/assets/img/favcion.png" />
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/bootstrap.min.css" media="all" />
    <!-- Slick nav CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/slicknav.min.css" media="all" />
    <!-- Iconfont CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/icofont.css" media="all" />
    <!-- Owl carousel CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/owl.carousel.css">
    <!-- Popup CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/magnific-popup.css">
    <!-- Main style CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/style.css" media="all" />
    <!-- Responsive CSS -->
    <link rel="stylesheet" type="text/css" href="Tasarim/assets/css/responsive.css" media="all" />
    <!--[if lt IE 9]>
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body>
    <div id="preloader"></div>
    <!-- header section start -->
    <header class="header">
        <div class="container">
            <div class="header-area">
                <div class="logo">
                    <a href="index-2.html">
                        <img src="Tasarim/assets/img/yeniLogo.png" alt="logo" /></a>
                </div>
                <div class="header-right">
                    
                    <ul style="margin-left:auto">
                        <li><a href="#">Hoşgeldiniz !</a></li>
                        <li><a class="login-popup" href="#">Giriş Yap</a></li>
                        <li><a href="#">Kayıt Ol</a></li>
                    </ul>
                </div>
                <div class="menu-area">
                    <div class="responsive-menu"></div>
                    <div class="mainmenu">
                        <ul id="primary-menu">
                            <li><a class="active" href="Default.aspx">Ana Sayfa</a></li>
                            <li><a href="Hakkimizda.aspx">Hakkımızda</a></li>
                            <li><a href="Iletisim.aspx">İletişim</a></li>
                            <li><a class="theme-btn" href="#"><i class="icofont icofont-ticket"></i>Bilet Al</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <div class="login-area">
        <div class="login-box">
            <a href="#"><i class="icofont icofont-close"></i></a>
            <h2>GİRİŞ YAP</h2>
            <form id="form1" runat="server">
            <form action="#">
                <h6>Kullanıcı Adı / Email</h6>
                <asp:TextBox ID="TextBox1" runat="server" ForeColor="#eb315a"></asp:TextBox>  
                <h6>Şifre</h6>
                <asp:TextBox ID="TextBox2" runat="server" ForeColor="#eb315a" TextMode="Password"></asp:TextBox>
               <%-- <input type="text" />--%>
                <div class="login-remember">
                    <input type="checkbox" />
                    <span>Beni Hatırla</span>
                </div>
                <div class="login-signup">
                    <%--<span>KAYDOL</span>--%>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Giriş Yap" class="theme-btn" BackColor="#eb315a" BorderColor="#eb315a"/>
                <asp:Button ID="Button2" runat="server" Text="Kayıt Ol" class="theme-btn" BackColor="#eb315a" BorderColor="#eb315a"/>
                <%--<a href="#" class="theme-btn">Giriş Yap</a>
                <a href="#" class="theme-btn">Kayıt Ol</a>--%>
            </form>
                </form>
        </div>
    </div>
    

</body>
</html>
