<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenek.aspx.cs" Inherits="cv.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Yetenek Adı</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID")  %></td>
                            <td><%# Eval("Yetenek")  %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<% # "AdminYetenekGuncelle.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<% # "AdminYetenekSil.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                

            </tbody>

        </table>
    <asp:HyperLink ID="HyperLink3" CssClass="btn btn-success" NavigateUrl="AdminYetenekEkle.Aspx" runat="server">Yeni Yetenek Bilgisi Ekle</asp:HyperLink>

</asp:Content>
