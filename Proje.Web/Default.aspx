<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proje.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero-area" id="home">
        <div class="container">
            <div class="hero-area-slider">
                <asp:Repeater ID="rptFilm" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="row hero-area-slide">
                            <div class="col-lg-6 col-md-5">
                                <div class="hero-area-content">
                                    <img src="Tasarim/assets/img/<%# Eval("Resim") %>" alt="about" />
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-7">
                                <div class="hero-area-content pr-50">
                                    <h2><%# Eval("FilmAdi") %></h2>
                                    <div class="review">
                                        <div class="author-review">
                                            <i class="icofont icofont-star"></i>
                                            <i class="icofont icofont-star"></i>
                                            <i class="icofont icofont-star"></i>
                                            <i class="icofont icofont-star"></i>
                                            <i class="icofont icofont-star"></i>
                                        </div>
                                        <h4><%# Eval("FilmYonetmeni") %></h4>
                                    </div>
                                    <p><%# Eval("Aciklama") %></p>

                                    <div class="slide-trailor">
                                        <h3>Watch Trailer</h3>
                                        <a class="theme-btn theme-btn2" href="#"><i class="icofont icofont-play"></i>Tickets</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>



                    <AlternatingItemTemplate>
                    </AlternatingItemTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div class="hero-area-thumb">
                        <div class="thumb-prev">
                            <div class="row hero-area-slide">
                                <div class="col-lg-6">
                                    <div class="hero-area-content">
                                        <asp:Image ID="Image2" runat="server" /> 
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <div class="hero-area-content pr-50">
                                        <h2><asp:Label ID="filmPrevAdi" runat="server" Text="Label"></asp:Label></h2>
                                        <div class="review">
                                            <div class="author-review">
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                            </div>
                                            <h4><asp:Label ID="filmYonetmenPrev" runat="server" Text="Label"></asp:Label></h4>
                                        </div>
                                        <p><asp:Label ID="filmPrevAciklama" runat="server" Text="Label"></asp:Label></p>
                                        <div class="slide-trailor">
                                            <h3>Watch Trailer</h3>
                                            <a class="theme-btn theme-btn2" href="#"><i class="icofont icofont-play"></i>Tickets</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                  
                        <div class="thumb-next">
                            <div class="row hero-area-slide">
                                <div class="col-lg-6">
                                    <div class="hero-area-content">
                                        <asp:Image ID="Image1" runat="server" />  
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <div class="hero-area-content pr-50">
                                        <h2>
                                            <asp:Label ID="filmNextAdi" runat="server" Text="Label"></asp:Label></h2>
                                        <div class="review">
                                            <div class="author-review">
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                                <i class="icofont icofont-star"></i>
                                            </div>
                                            <h4>
                                                <asp:Label ID="filmNextYonetmen" runat="server" Text="Label"></asp:Label></h4>
                                        </div>
                                        <p>
                                            <asp:Label ID="filmNextAciklama" runat="server" Text="Label"></asp:Label></p>
                                        <div class="slide-trailor">
                                            <h3>Watch Trailer</h3>
                                            <a class="theme-btn theme-btn2" href="#"><i class="icofont icofont-play"></i>Tickets</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                  
            </div>
        </div>
    </section>
    <!-- hero area end -->
</asp:Content>
