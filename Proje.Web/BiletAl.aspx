<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="BiletAl.aspx.cs" Inherits="Proje.Web.BiletAl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <fieldset> 
        <tr>
            <td class="auto-style4">Ad ve Soyad</td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="181px"></asp:TextBox>
            </td>
        </tr>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<br/><br/>
        <tr>
            <td class="auto-style4">Telefon</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="181px"></asp:TextBox>
            </td>
        </tr>
			<br/><br/>
        <tr>
            <td class="auto-style4">Tarih</td>
            <td>
                &nbsp;<br />
                <asp:Calendar ID="Calendar1" runat="server" Width="279px"></asp:Calendar>
            </td>
        </tr>
			Saat</td>
            <td><br/>
        <tr>
            <td class="auto-style4">Başlangıç Saati&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>10:00</asp:ListItem>
                <asp:ListItem>11:00</asp:ListItem>
                <asp:ListItem>12:00</asp:ListItem>
                <asp:ListItem>13:00</asp:ListItem>
                <asp:ListItem>14:00</asp:ListItem>
                <asp:ListItem>15:00</asp:ListItem>
                <asp:ListItem>16:00</asp:ListItem>
                <asp:ListItem>17:00</asp:ListItem>
                <asp:ListItem>18:00</asp:ListItem>
                <asp:ListItem>19:00</asp:ListItem>
                <asp:ListItem>20:00</asp:ListItem>
                <asp:ListItem>21:00</asp:ListItem>
                <asp:ListItem>22:00</asp:ListItem>
                <asp:ListItem>23:00</asp:ListItem>
          
                
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; Bitiş Saati&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList2" runat="server" >
                <asp:ListItem>10:00</asp:ListItem>
                <asp:ListItem>11:00</asp:ListItem>
                <asp:ListItem>12:00</asp:ListItem>
                <asp:ListItem>13:00</asp:ListItem>
                <asp:ListItem>14:00</asp:ListItem>
                <asp:ListItem>15:00</asp:ListItem>
                <asp:ListItem>16:00</asp:ListItem>
                <asp:ListItem>17:00</asp:ListItem>
                <asp:ListItem>18:00</asp:ListItem>
                <asp:ListItem>19:00</asp:ListItem>
                <asp:ListItem>20:00</asp:ListItem>
                <asp:ListItem>21:00</asp:ListItem>
                <asp:ListItem>22:00</asp:ListItem>
                <asp:ListItem>23:00</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="Button2" runat="server" Height="36px" OnClick="Button2_Click" Text="Saha Seç" Width="86px" CssClass="auto-style3" />
            </td>
        </tr>
			<br/><br/>	
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="16px" Visible="False" Width="172px">
                    <asp:ListItem>Güven Spor</asp:ListItem>
                    <asp:ListItem>Turkuaz Halı Saha</asp:ListItem>
                    <asp:ListItem>Sports Port</asp:ListItem>
                    <asp:ListItem>Özdemir Spor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
		
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" Height="41px" OnClick="Button3_Click" Text="Rezervasyon Yap" Width="134px" />
            </td>
        </tr>
   
        <br />
        


    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
		</fieldset>


</asp:Content>
