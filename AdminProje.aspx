<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProje.aspx.cs" Inherits="cv.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Proje Adı</th>
                <th>Proje Alt Başlığı</th>
                <th>Proje Açıklaması</th>
                <th>Proje Yapım Tarihi</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID")  %></td>
                            <td><%# Eval("Baslik")  %></td>
                            <td><%# Eval("Altbaslik")  %></td>
                            <td><%# Eval("Aciklama")  %></td>
                            <td><%# Eval("Tarih")  %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<% # "AdminProjeGuncelle.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<% # "AdminProjeSil.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                

            </tbody>

        </table>
    <asp:HyperLink ID="HyperLink3" CssClass="btn btn-success" NavigateUrl="AdminProjeEkle.Aspx" runat="server">Yeni Proje Bilgisi Ekle</asp:HyperLink>
</asp:Content>
