<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/User.Master" CodeBehind="AboutUs.aspx.cs" Inherits="PreShop.AboutUs.AboutUs" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
  <!--  about-page -->
	<div class="about">
		<div class="container"> 
			<h3 class="w3ls-title w3ls-title1">About Preshop</h3>
			<div class="about-text">	
               <p> <asp:Label runat="server" ID="lblabout"></asp:Label></p>
					<div class="col-md-3 ftr-top-left about-text-grids">
					<i class="fa fa-shopping-basket" aria-hidden="true"></i>
					<h4>10 Million+ <br>Products</h4>
				</div>
				<div class="col-md-3 ftr-top-left about-text-grids">
					<i class="fa fa-users" aria-hidden="true"></i>
					<h4>50,000 <br> Sellers </h4>
				</div>
				<div class="col-md-3 ftr-top-left about-text-grids">
					<i class="fa fa-credit-card" aria-hidden="true"></i>
					<h4>5 Million <br>Shipments</h4>
				</div>
				<div class="col-md-3 ftr-top-left about-text-grids">
					<i class="fa fa-globe" aria-hidden="true"></i>
					<h4>4000+ <br>Cities</h4>
				</div>
				<div class="clearfix"> </div>
			</div>
			<div class="history">
				<h3 class="w3ls-title">Our Mission</h3>
                <asp:Label runat="server" ID="lblMission"></asp:Label>
				<h3 class="w3ls-title">Our History</h3>
                <asp:Label runat="server" ID="lblhistory"></asp:Label>
				</div>
		</div>
	</div>
	<!-- //about-page --> 
</asp:Content>
