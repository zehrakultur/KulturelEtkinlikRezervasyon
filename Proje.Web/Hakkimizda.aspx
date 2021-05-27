<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="Proje.Web.Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- breadcrumb area start -->
    <section class="breadcrumb-area">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb-area-content">
                        <h1>Tüm Filmler</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- breadcrumb area end -->
    <!-- portfolio section start -->
    <section class="portfolio-area pt-60">
        <div class="container">
            <div class="row portfolio-item">
                <asp:Repeater ID="rptTumFilm" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-4 col-sm-6 soon released">

                            <div class="single-portfolio">
                                <div class="single-portfolio-img">
                                    <img src="Tasarim/assets/img/<%# Eval("Resim") %>" alt="about" />
                                </div>
                                <div class="portfolio-content">
                                    <h2><%# Eval("FilmAdi") %></h2>
                                    <%--<div class="transformers-content mtr-30">
								<ul>
								<li>
										<div class="transformers-left">
											Süre:
										</div>
										<div class="transformers-right">--%>
                                    <%--<p><%# Eval("Sure") %></p>--%>
                                    <%--</div>
									</li>
									</ul>
									</div>--%>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <div class="col-lg-3 col-md-4 col-sm-6 soon released">

                            <div class="single-portfolio">
                                <div class="single-portfolio-img">
                                    <img src="Tasarim/assets/img/<%# Eval("Resim") %>" alt="about" />
                                </div>
                                <div class="portfolio-content">
                                    <h2><%# Eval("FilmAdi") %></h2>
                                    <%--<div class="transformers-content mtr-30">
								<ul>
								<li>
										<div class="transformers-left">
											Süre:
										</div>
										<div class="transformers-right">
											<%--<p><%# Eval("Sure") %></p>--%>
                                    <%--</div>
									</li>
									</ul>
									</div>--%>
                                </div>
                            </div>
                        </div>
                    </AlternatingItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </section>
    <!-- portfolio section end -->

</asp:Content>
