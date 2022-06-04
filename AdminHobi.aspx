<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobi.aspx.cs" Inherits="cv.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered">
            <tr>
                <th>Id</th>
                <th>Hobi Adı</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID")  %></td>
                            <td><%# Eval("Hobi")  %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<% # "AdminHobiGuncelle.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<% # "AdminHobiSil.Aspx?Id=" + Eval("Id")  %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink></td>
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                

            </tbody>

        </table>
    <asp:HyperLink ID="HyperLink3" CssClass="btn btn-success" NavigateUrl="AdminHobiEkle.Aspx" runat="server">Yeni Hobi Bilgisi Ekle</asp:HyperLink>

</asp:Content>
