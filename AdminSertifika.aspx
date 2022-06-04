<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifika.aspx.cs" Inherits="cv.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Sertifika Adı</th>
                <th>Alınan Kurum</th>
                <th>Alınan Tarih</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID")  %></td>
                            <td><%# Eval("Sertifikaadi")  %></td>
                            <td><%# Eval("Alinankurum")  %></td>
                            <td><%# Eval("Alinantarih")  %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<% # "AdminSertifikaGuncelle.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<% # "AdminSertifikaSil.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                

            </tbody>

        </table>
    <asp:HyperLink ID="HyperLink3" CssClass="btn btn-success" NavigateUrl="AdminSertifikaEkle.Aspx" runat="server">Yeni Sertifika Bilgisi Ekle</asp:HyperLink>
</asp:Content>
