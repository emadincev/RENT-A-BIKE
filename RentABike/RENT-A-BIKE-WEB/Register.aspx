﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RENT_A_BIKE_WEB.Register" %>

<!DOCTYPE html>

<html lang="en">
  <head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="fonts/icomoon/style.css">

    <link rel="stylesheet" href="css/owl.carousel.min.css">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    
    <!-- Style -->
    <link rel="stylesheet" href="css/style.css">

    <title>Register</title>
  </head>
  <body>
  

  <div class="d-lg-flex half">
    <div class="bg order-1 order-md-2" style="background-image: url('images/bg_1.jpg');"></div>
    <div class="contents order-2 order-md-1">

      <div class="container">
        <div class="row align-items-center justify-content-center">
          <div class="col-md-7">
            <h3 class="mb-4">Register to <strong>Rent A Bike</strong></h3>
            <form id="form1" runat="server">
              <div class="form-group first">
                <input type="text" class="form-control" placeholder="Name" id="username" runat="server">
              </div>
                 <div class="form-group first">
                <input type="text" class="form-control" placeholder="Surname" id="Surname" runat="server">
              </div>
                 <div class="form-group first">
                <input type="text" class="form-control" placeholder="Adress" id="Adress" runat="server">
              </div>
                 <div class="form-group first">
                <input type="text" class="form-control" placeholder="Phone" id="Phone" runat="server">
              </div>
                 <div class="form-group first">
                <input type="text" class="form-control" placeholder="E-mail" id="email" runat="server">
              </div>
              <div class="form-group last mb-3">
                <input type="password" class="form-control" placeholder="Your Password" id="password" runat="server">
              </div>
              
             

              <button runat="server" id="register" onserverclick="register_ServerClick" value="Log In" class="btn btn-block btn-primary">Log in</button>
            </form>
          </div>
        </div>
      </div>
    </div>

    
  </div>
    
    

    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main.js"></script>
  </body>
</html>