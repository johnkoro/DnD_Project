<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DM_Home_Page.aspx.cs" Inherits="DnD_Project.DM_Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css">

<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js"></script>

<script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
<script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
<link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.5.0/css/all.css' integrity='sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU' crossorigin='anonymous'/>

    <title></title>
    <div class="header">
        <img src="Images/dndlogo.png" alt="logo" />
        <h3>Welcome <%Response.Write(Username);%> </h3>
        <h1>DM's Portal</h1>
        
    </div>
    <hr style="clear: both;"/>
    
    <link rel="stylesheet" href="CSS/DM.css">
   <script src="Scripts/ErrorMessage.js"></script>
</head>
<body>
     <nav class="navbar navbar-expand-lg navbar-black bg-black">
  <a class="navbar-brand"  style="color:red;">My Campaigns</a>
  <asp:button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation" >
    <span class="navbar-toggler-icon"></span>
  </asp:button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="#" style="color:red;">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#" style="color:red;">Link</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#" style="color:red;">Disabled</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0" runat="server">
      <asp:LinkButton runat="server" type="button" CSSClass="btn btn-danger btn-sm" style="color:black;" OnClick="LogOut_Button">            
      <svg xmlns="http://www.w3.org/2000/svg" enable-background="new 0 0 24 24" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000"><g><rect fill="none" height="24" width="24" y="0"/></g><g><path d="M19.48,12.35c-1.57-4.08-7.16-4.3-5.81-10.23c0.1-0.44-0.37-0.78-0.75-0.55C9.29,3.71,6.68,8,8.87,13.62 c0.18,0.46-0.36,0.89-0.75,0.59c-1.81-1.37-2-3.34-1.84-4.75c0.06-0.52-0.62-0.77-0.91-0.34C4.69,10.16,4,11.84,4,14.37 c0.38,5.6,5.11,7.32,6.81,7.54c2.43,0.31,5.06-0.14,6.95-1.87C19.84,18.11,20.6,15.03,19.48,12.35z M10.2,17.38 c1.44-0.35,2.18-1.39,2.38-2.31c0.33-1.43-0.96-2.83-0.09-5.09c0.33,1.87,3.27,3.04,3.27,5.08C15.84,17.59,13.1,19.76,10.2,17.38z"/></g></svg>
           Log Out
        </asp:LinkButton>
  </div>
         
</nav>
    
  <ul class="nav flex-column" id="sidebar">
         <asp:TextBox ID="tb1" runat="server" TextMode="MultiLine"  style="position:absolute; right:10px; color:red; background-color:black; height:500px; " />
      <br />
  <li class="nav-button" >
     <asp:LinkButton runat="server" type="button" OnClick="D20" style="color:red; font-size: 25px;">
     <asp:Timer ID="Timerd10" runat="server" Interval="1000" OnTick="Timer10" Enabled="false"></asp:Timer>
     <asp:Timer ID="Timerd11" runat="server" Interval="1500" OnTick="Timer11" Enabled="false"></asp:Timer>
     <i class="fas fa-dice-d20"></i>
          </asp:LinkButton>
  </li>
      <br />
  <li class="nav-button">
     <asp:LinkButton runat="server" type="button" OnClick="D6" style="color:red; font-size: 25px;">
     <asp:Timer ID="Timerd6" runat="server" Interval="1000" OnTick="Timer6" Enabled="false"></asp:Timer>
     <asp:Timer ID="Timerd7" runat="server" Interval="1500" OnTick="Timer7" Enabled="false"></asp:Timer>
     <i class="fas fa-dice-six"></i>
         </asp:LinkButton>
  </li>
      <br />
  <li class="nav-button">
      <asp:LinkButton runat="server" type="button" OnClick="D4" style="color:red; font-size: 25px;">
      <asp:Timer ID="Timerd4" runat="server" Interval="1000" OnTick="Timer4" Enabled="false"></asp:Timer>
      <asp:Timer ID="Timerd5" runat="server" Interval="1500" OnTick="Timer5" Enabled="false"></asp:Timer>
      <i class="fas fa-dice-four"></i>
          </asp:LinkButton>
  </li>
      <br />
  <li class="nav-button">
      <asp:ScriptManager id="ScriptManager" runat="server" EnablePageMethods="false" EnablePartialRendering="true" EnableScriptGlobalization="false" EnableScriptLocalization="true" />
      <asp:LinkButton runat="server" type="button" OnClick="D12" style="color:red; font-size: 25px;">
      <asp:Timer ID="Timer" runat="server" Interval="1000" OnTick="Timer1" Enabled="false"></asp:Timer>
      <asp:Timer ID="Timer3" runat="server" Interval="1500" OnTick="Timer2" Enabled="false"></asp:Timer>
    <i class="fas fa-dice-six"></i><i class="fas fa-dice-six"></i>
          </asp:LinkButton>
  </li>
      <br />
  <li class="nav-button">
      <asp:LinkButton runat="server" type="button" OnClick="D10" style="color:red; font-size: 25px;">
      <asp:Timer ID="Timerd8" runat="server" Interval="1000" OnTick="Timer8" Enabled="false"></asp:Timer>
      <asp:Timer ID="Timerd9" runat="server" Interval="1500" OnTick="Timer9" Enabled="false"></asp:Timer>
      <i class="fas fa-dice-six"></i><i class="fas fa-dice-four"></i>
          </asp:LinkButton>
  </li>
 
</ul>
   
    </br>
<select name="no" id="multy" style ="background-color:black; color:red;" runat="server">
  <option value="1">1</option>
  <option value="2">2</option>
  <option value="3">3</option>
  <option value="4">4</option>
  <option value="5">5</option>
  <option value="6">6</option>
  <option value="7">7</option>
  <option value="8">8</option>
  <option value="9">9</option>
  <option value="10">10</option>
  <option value="11">11</option>
  <option value="12">12</option>
</select>
    </br>
    </br>
    <div class="input-group input-group-sm mb-3" id="res"  runat="server" visible="false" style="width: 5%;">
  <div class="input-group-prepend">
    <span class="input-group-text" id="inputGroup-sizing-sm" >Result</span>
  </div>
  <input type="text" id ="resu" runat="server"  class="form-control" aria-label="Small" aria-describedby="inputGroup-sizing-sm" disabled="disabled"  ></input>
  <asp:Timer ID="Timer12" runat="server" Interval="1500" OnTick="Timer13" Enabled="false"></asp:Timer>
</div>
   </form>  
       
    <div id="div0" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12roll.gif" />
    </div>
     <div id="div1" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result1.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div2" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result2.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div3" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result3.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div4" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div5" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result5.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div6" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result6.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div7" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result7.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div8" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result8.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div9" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result9.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div10" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result10.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div11" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result11.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
     <div id="div12" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d12result12.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div13" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div14" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d4 result 1.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div15" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d4 result 2.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div16" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d4 result 3.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div17" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d4 result 4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div18" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div19" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 1.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div20" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 2.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div21" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 3.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div22" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div23" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 5.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div24" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d6 result 6.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div25" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div26" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 1.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div27" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 2.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div28" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 3.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div29" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div30" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 5.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div31" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 6.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div32" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 7.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div33" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 8.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div34" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 9.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div35" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d10 result 10.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div36" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div37" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 1.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div38" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 2.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div39" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 3.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div40" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 4.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div41" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 5.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div42" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 6.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div43" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 7.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div44" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 8.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div45" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 9.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div46" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 10.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div47" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 11.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div48" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 12.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div49" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 13.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div50" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 14.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div51" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 15.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div52" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 16.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div53" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 17.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div54" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 18.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div55" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 19.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
    <div id="div56" runat="server" class="div1" role="alert" style=" position:absolute; top:50%; right:40%; transform: translate(0, -50%);">
        <img src="Images/d20 result 20.gif" />
         <button type="button" class="close" data-dismiss="alert" aria-label="Close">x</button>
    </div>
</body>
</html>
