<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitim.aspx.cs" Inherits="cv.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Üniversite Adı</th>
                <th>Bölüm</th>
                <th>Açıklama</th>
                <th>Tarih</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id")  %></td>
                            <td><%# Eval("Baslik")  %></td>
                            <td><%# Eval("AltBaslik")  %></td>
                            <td><%# Eval("Aciklama")  %></td>
                            <td style="width:10%;"><%# Eval("Tarih")  %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<% # "AdminEgitimGuncelle.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<% # "AdminEgitimSil.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                

            </tbody>

        </table>
    <asp:HyperLink ID="HyperLink3" CssClass="btn btn-success" NavigateUrl="AdminEgitimEkle.Aspx" runat="server">Yeni Eğitim Bilgisi Ekle</asp:HyperLink>
</asp:Content>
