<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Pizza Delicious | Sign Up</title>
	
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:300,400">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/materialize.min.css">
    <link rel="stylesheet" href="css/tooplate.css">

    <link rel="stylesheet" href="css/flaticon.css">

    <link rel="icon" href="images/pizza.png" type="image/png">
</head>

<body id="register">
    <div class="container">
        <div class="row">
            <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                <header class="mb-5" align="center">
                    <h3 class="mt-0 white-text">Sign-up Form</h3>
                    <p class="grey-text mb-4">

                        <a class="navbar-brand" href="index.html"><span class="flaticon-pizza-1 mr-1"></span>Pizza<br><small>Delicous </small></a>
                    </p>
                    <p class="grey-text">Speak With The Test  &#128523;</p>

                    <p class="grey-text" style="font-size: 12px">Your personal data will be used to support your experience throughout this website, to manage access to your account, and for other purposes described in our privacy policy.</p>

                    <p style="color: gold">Already Have An Account ? &ensp; &ensp;<a href="login.html" class="btn btn-lg btn-danger btn-outline-danger">LogIn</a></p>

                </header>
            </div>
            <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                
                    <form id="form2" runat="server" method="post" class="tm-bg-black p-5 h-100">

                    <div class="input-field">
                        
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Username"></asp:TextBox>

                    </div>
                    <div class="input-field">
                       
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Password"></asp:TextBox>
                    </div>
                    <div class="input-field">
                        
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Re-type Password"></asp:TextBox>
                    </div>
                    <div class="input-field">
                        
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Email" ></asp:TextBox>
                    </div>
                    <div class="input-field">
                        
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Phone"></asp:TextBox>
                    </div>
                    <div class="text-right mt-4">
                        <asp:Button ID="Button2" runat="server" type="submit"  Text="Log In" class="waves-effect btn-large btn-large-white px-4 black-text rounded-3" OnClick="Button2_Click1" />
                        
                </form>
            </div>
        </div>
        <footer class="row tm-mt-big mb-3">
            <div class="col-xl-12">
                
            </div>
        </footer>
    </div>

    <script src="js/jquery-3.2.1.slim.min.js"></script>
    <script src="js/materialize.min.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $('select').formSelect();
        });
    </script>
</body>

</html>
