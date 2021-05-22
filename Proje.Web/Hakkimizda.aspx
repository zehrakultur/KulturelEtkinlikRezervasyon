<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="Proje.Web.Hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<!-- breadcrumb area start -->
		<%--<section class="breadcrumb-area">
			<div class="container">
				<div class="row">
					<div class="col-lg-12">
						<div class="breadcrumb-area-content">
							<h1>HAKKIMIZDA</h1>
						</div>
					</div>
				</div>
			</div>
		</section>--%><!-- breadcrumb area end -->


    <!-- transformers area start -->
		<%--<section class="transformers-area">
			<div class="container">
				<div class="transformers-box">
					<div class="row flexbox-center">
						<div class="col-lg-5 text-lg-left text-center">
							<div class="transformers-content">
								<img src="Tasarim/assets/img/yeniLogo.png" alt="about" />
							</div>
						</div>
						<div class="col-lg-7">
							<div class="transformers-content mtr-30">
								<h2>KÜLTÜR FİLM</h2>
								<ul>
									<li>
										<div class="transformers-left">
											Height:
										</div>
										<div class="transformers-right">
											5.7”
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Weight:
										</div>
										<div class="transformers-right">
											1136LB
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Eye Color:
										</div>
										<div class="transformers-right">
											Black
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Hair Color: 
										</div>
										<div class="transformers-right">
											Black
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Birthday:
										</div>
										<div class="transformers-right">
											1985.Jun.20
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Language:
										</div>
										<div class="transformers-right">
											English, Russian
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Hobby:
										</div>
										<div class="transformers-right">
											Base Ball, Gaming, Exploring, Baook Reading
										</div>
									</li>
									<li>
										<div class="transformers-left">
											Follow:
										</div>
										<div class="transformers-right">
											<a href="#"><i class="icofont icofont-social-facebook"></i></a>
											<a href="#"><i class="icofont icofont-social-twitter"></i></a>
											<a href="#"><i class="icofont icofont-social-google-plus"></i></a>
											<a href="#"><i class="icofont icofont-youtube-play"></i></a>
										</div>
									</li>
								</ul>
							</div>
						</div>
					</div>
				</div>
			</div>
		</section>--%><!-- transformers area end -->
		<!-- details area start -->



	<!-- breadcrumb area start -->
		<section class="breadcrumb-area">
			<div class="container">
				<div class="row">
					<div class="col-lg-12">
						<div class="breadcrumb-area-content">
							
						</div>
					</div>
				</div>
			</div>
		</section><!-- breadcrumb area end -->
		<!-- portfolio section start -->
		<section class="portfolio-area pt-60">
			<div class="container">
				<div class="row flexbox-center">
					<div class="col-lg-6 text-center text-lg-left">
					    <div class="section-title">
							<h1><i class="icofont icofont-movie"></i>Tüm Filmler</h1>
						</div>
					</div>
				</div>
				<hr />
				<div class="row portfolio-item">
					<asp:Repeater ID="rptTumFilm" runat="server">
	<AlternatingItemTemplate>
					<div class="col-lg-3 col-md-4 col-sm-6 soon released">

						<div class="single-portfolio">
							<div class="single-portfolio-img">
							<img src="Tasarim/assets/img/<%# Eval("Resim") %>" alt="about" />	
							</div>
							<div class="portfolio-content">
								<h2><%# Eval("FilmAdi") %></h2>
								<div class="transformers-content mtr-30">
								<ul>
								<li>
										<div class="transformers-left">
											Süre:
										</div>
										<div class="transformers-right">
											<p><%# Eval("Sure") %></p>
										</div>
									</li>
									</ul>
									</div>
							</div>
						</div>
						</div>
		</AlternatingItemTemplate>
	</asp:Repeater>
					
				</div>
			</div>
				<hr />
		</section><!-- portfolio section end -->

</asp:Content>
