<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Yonetici.aspx.cs" Inherits="Proje.Web.Yonetici" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="breadcrumb-area">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb-area-content">
                        <h1>YÖNETİCİ İLETİŞİM</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- breadcrumb area end -->


    <section class="details-area">
        <div class="container">
            <div class="row">
                <div class="col-lg-9">
                    <div class="details-content">
                        <div class="details-overview">
                            <h2>Yöneticiye Mesaj Gönderin</h2>
                            <p>Aşağıdaki formu doldurarak eklenmesini istediğiniz film bilgilerini (film adı, yönetmeni, türü, açıklama, süre ve afiş) mesaj bölümüne yazarak yöneticiye iletebilirsiniz. Girdiğiniz bilgiler onaylanırsa sisteme kaydedilecektir.</p>
                        </div>
                        <div class="details-reply">
                            <form action="#">
                                <div class="row">
                                    <div class="col-lg-4">
                                        <div class="select-container">

                                            <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" ForeColor="White"></asp:TextBox>
                                            <i class="icofont icofont-ui-user"></i>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div class="select-container">
                                            <asp:TextBox ID="TextBox2" runat="server" placeholder="E-Mail" ForeColor="White"></asp:TextBox>
                                            <i class="icofont icofont-envelope"></i>
                                        </div>
                                    </div>
                                    <div class="col-lg-4">
                                        <div class="select-container">
                                            <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" ForeColor="White"></asp:TextBox>
                                            <i class="icofont icofont-phone"></i>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="textarea-container">
                                            <asp:TextBox ID="TextBox4" runat="server" placeholder="Mesajınızı Buraya Yazınız" ForeColor="White" Height="125px" Width="830px"></asp:TextBox>
                                        </div>
                                        <br/>
                                        <asp:Button ID="Button1" runat="server" Text="GÖNDER" BackColor="#eb315a" ForeColor="White" Width="339px" BorderColor="#eb315a" OnClick="Button1_Click" />
                                        <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
                                        <br/>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
