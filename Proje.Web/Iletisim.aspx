<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="Proje.Web.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	<!-- breadcrumb area start -->
		<section class="breadcrumb-area">
			<div class="container">
				<div class="row">
					<div class="col-lg-12">
						<div class="breadcrumb-area-content">
							<h1>İLETİŞİM</h1>
						</div>
					</div>
				</div>
			</div>
		</section><!-- breadcrumb area end -->


    <section class="details-area">
			<div class="container">
				<div class="row">
					<div class="col-lg-9">
						<div class="details-content">
							<div class="details-reply">
								<h2>Bilgi Edinme Formu</h2>
								<form action="#">
									<div class="row">
										<div class="col-lg-4">
											<div class="select-container">
												<input type="text" placeholder="Ad Soyad"/>
												<i class="icofont icofont-ui-user"></i>
											</div>
										</div>
										<div class="col-lg-4">
											<div class="select-container">
												<input type="text" placeholder="Email"/>
												<i class="icofont icofont-envelope"></i>
											</div>
										</div>
										<div class="col-lg-4">
											<div class="select-container">
												<input type="text" placeholder="Telefon"/>
												<i class="icofont icofont-phone"></i>
											</div>
										</div>
										<div class="col-lg-12">
											<div class="textarea-container">
												<textarea placeholder="Mesajınız"></textarea>
												<button><i class="icofont icofont-send-mail"></i></button>
											</div>
										</div>
									</div>
								</form>
							</div>
						</div>
					</div>
				</div>
			</div>
		</section><!-- details area end -->

</asp:Content>
