<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href ="Content/bootstrap.min.css" rel ="stylesheet" type ="text/css" /> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <span class="border border-dark">
            <h3 class="text-center"> </h3>
            <p class="text-center"> &nbsp;</p>

            <div class="jumbotron alert alert-success shadow-lg p-3 mb-5 bg-white rounded ">
                <button type="button" class="close" aria-label="Close">
  <span aria-hidden="true">&times;</span>
</button>
  <h1 class="display-4 text-dark ">NutriFitness S.A</h1>
  <p class="lead text-dark ">NutriFitness es la mejor empresa en panama dedicada al bienestar humano, Nuestros nutricionistas son los mas capacitados para brindarle un excelente servicio
  </p>
  <hr class="my-4 text-dark">
  <p> Por favor, Deje sus datos para que uno de nuestros nutricionistas pueda contactarlo: </p>

                
            <div class="input-group mb-3  ">
             <asp:Label ID="Label1" for="exampleInputEmail1" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>

             <br />

             <asp:Label ID="Label2" runat="server" Text="Contacto:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>

             <br />

             <asp:Label ID="Label3" runat="server" Text="Estatura(cm):"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
                <div class="col-8">
                    
                    <asp:Button ID="Button1"  class="btn btn-success" runat="server" Text="Enviar datos " Height="44px" Width="144px" OnClick="Button1_Click" />
               </div>
                <p></p>
                <asp:Label ID="Label5" class="alert alert-warning" role="alert" runat="server" Text=" "></asp:Label>
                </div></span>

          
               
 
</div>



         







            
            <br />
        </div>
       
        <p>

                </p>
       
    </form>
</body>
</html>
