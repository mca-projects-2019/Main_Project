

<%@page contentType="text/html" pageEncoding="UTF-8"%>
  <%
  response.setHeader("Cache-Control","no-cache");
  response.setHeader("Cache-Control","no-store");
  response.setHeader("Pragma","no-cache");
  response.setDateHeader ("Expires", 0);

  if(session.getAttribute("uname")==null)
  {}
else
      session.removeAttribute("uname");
  %> 
<!DOCTYPE html>

        <nav id="navigation"> <a href="#" class="nav-btn">HOME<span></span></a>
        <ul>
          <li class="active"><a href="Index.jsp">home</a></li>
            
            <li><a href="Index.jsp?pg=cont">Contacts</a></li>
            <li><a href="Index.jsp?pg=abt">About Us</a></li>
       
        </ul>
     
           <div>
               <%
               String pg="";
               if(request.getParameter("pg")!=null)
               {
               pg=request.getParameter("pg");
               }
               if(pg.equals("rg"))
               {
               %>
               <%@include file="SignUp.jsp" %>
               <%
               } 
               if(pg.equals("abt")){
                  %>
                  <%@include file="about.jsp" %>
               <%
               }
              
                if(pg.equals("cont")){
                  %>
                  <%@include file="contact.jsp" %>
               <%
               }
               
               if(request.getAttribute("msg")!=null)
                   out.print("<script>alert('"+request.getAttribute("msg")+"');</script>");
               %>
    </div>
          </div>
      <%--    <div class="col">
            <h3>We’re Hiring</h3>
            <img src="css/images/col-img.png" alt="" class="left"/>
            <h5>Lorem ipsum dolor sit amet, consectetur adipiscing elit. </h5>
            <div class="cl">&nbsp;</div>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dui ipsum, cursus ut adipiscing porta, vestibulum quis turpis adispicing amet sit. <br />
              <a href="#" class="more">view more</a></p>
          </div>--%>
      
      <br>
          <div class="col">
          <div class="col2">
              <form action="LoginServlet" method="post">
                  <h3 style="background:#029cdb;width:200px;padding-top:10px;text-align:center;color:white;">Login Here</h3>
               <table class="style1">
    <tr>
        <td>
            Username</td>
        <td>
            <input type="text" ID="TextBox1" name="t1" CssClass="field">
        </td>
    </tr>
    <tr>
        <td>
            Password</td>
        <td>
             <input type="password" ID="TextBox2" name="t2" CssClass="field"/>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <Button ID="Button1" type="submit" value="Login Now" class="submit"
                    >Login</button>
            <a href="Index.jsp?pg=rg">SignUp</a>
        </td>
    </tr>
</table>
              </form>
</div>
<br />
