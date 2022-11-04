<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Kibernum.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script type="text/javascript">
        function MostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</head>
<body>
    <br />
    <form id="form1" runat="server">
        <div class="row">
            <div class="container">
                <div class="row">
                    <div class="col">
                        Documento de identidad : 
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Nombres : 
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Apellidos : 
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Fecha de nacimiento:
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Números telefónicos:
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtNumerosTelefonicos" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Direcciones de correo electrónico:
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        Direcciones físicas:
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtDirecciones" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
