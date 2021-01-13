<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillInfo.aspx.cs" Inherits="RENT_A_BIKE_WEB.BillInfo" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">


    <!-- Title Page-->
    <title> Rent A Bike</title>

    <!-- Icons font CSS-->
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

    <!-- Vendor CSS-->
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="css/main2.css" rel="stylesheet" media="all">
</head>

<body>
    <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
        <div class="wrapper wrapper--w680">
            <div class="card card-4" style="background-color:orange;">
                <div class="card-body" style="text-align:center">
                    <h2 class="title">Rent Info</h2>
                    <form id ="form1" runat="server" class="text-center">
                        
                        <div class="text-center" style="text-align:center">
                           <p class="col-4" id="adults" runat="server"></p>
                            <br />
                            <p class="col-4" id="children" runat="server"></p>
                         <br />
                        <p class="col-4" id="date" runat="server"></p>
                            <br />
                            <p class="col-4" id="hours" runat="server"></p>

                        <br />
                        <p class="col-4" id="type" runat="server"></p>
                            <br />
                            <p class="col-4" id="totalp" runat="server"></p>
                        </div>
                            
               
                        
                        <div class="p-t-15">
                            <button id="checkout" onserverclick="checkout_ServerClick" runat="server" style="text-align:center"  class="btn btn--radius-2 btn--blue mx-auto d-block" type="submit">Checkout</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <!-- Jquery JS-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <!-- Vendor JS-->
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>

    <!-- Main JS-->
    <script src="js/global.js"></script>

</body>

</html>
