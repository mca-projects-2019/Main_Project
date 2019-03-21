

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <style>
        td{
            text-align: left;
        }
        
        .va
        {
         padding-left: 5px;
            display:none;
            color:red;
        }
    </style>
    <%
       String f="",l="",e="",u="",sp="",du="",dq="";
       if(request.getAttribute("msg")!=null)
       {
           f=request.getParameter("t1");
          l= request.getParameter("t2");
           e=request.getParameter("t3");
          u= request.getParameter("t4");
          sp= request.getParameter("t5");
          du=request.getParameter("t6");
          dq=request.getParameter("t7");
          
       }
               
        
    %>
    <body>
        <div style="background: #00acef;width:300px;color: white;padding:5px "><h1>Sign Up Here</h1></div>
        
        <br>
          
       
        <form method="post" action="signup" >
        <table>
            <tr><td> First Name :</td><td><input type="text" name="t1" value="<%=f%>" class="form-control" title="Enter Your FirstName Here" onblur="check(this,'fn')"></td><td><span class="va" id="fn">Invalid Fullname</span></td></tr>
            <tr><td>Last Name :</td><td><input type="text" name="t2" value="<%=l%>" class="form-control" title="Enter Your LastName Here" onblur="check(this,'ln')" ></td><td><span class="va" id="ln">Invalid Lastname</span></td></tr>
            <tr><td> Email    :</td><td><input type="text" name="t3" value="<%=e%>" class="form-control" title="Enter Your Email Id" onblur="check1(this,'ema')"><td><span class="va" id="ema">Email should contain letters,special characters,number</span></td></tr>
            <tr><td>Username :</td><td><input type="text" name="t4" value="<%=u%>" class="form-control" title="Enter Username"  onblur="check2(this,'un')"><td><span class="va" id="un">Please fill username field</span></td></tr>
            <tr><td>Security Password :</td><td><input type="password" value="<%=sp%>" name="t5" class="form-control" title="Enter Security Password" onblur="check3(this,'pas')"><td><span class="va" id="pas">Password length Should be 8 characters </span></td></tr>
            <tr><td>User Type</td><td><input type="radio" name="r" value="Search User">Search User<input type="radio" name="r" value="Owner">Data Owner</td></tr>
         </table>
            <br>
       <input type="submit" value="Submit" class="submit">
      
        </form>
                  
                 
              
              
                <script>
                    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#blah')
                    .attr('src', e.target.result)
                    .width(120)
                    .height(100);
            };

            reader.readAsDataURL(input.files[0]);
        }
    }
                    </script>
        
        </div>
   
  
    <script>
        function check(t,un)
        {
           
            var letter= /^[a-zA-Z]+$/;
            if(t.value.match(letter))
            {
                hid(un);
            }
            else
            {
                dis(un);
                t.value="";
               t.focus();
               
        
            }
        }
        function dis(x)
        {
               document.getElementById(x).style.display='block';
            
        }  
        function hid(x)
        {
               document.getElementById(x).style.display='none';
            
        }
        
        function check1(t,un)
        {
            var em=/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/
            if(t.value.match(em))
            {
                hid(un);
            }
            else
            {
                 dis(un);
                t.value="";
               t.focus();
        
            }
        }
       function check2(t,un) 
       {
          if(t.value==="")
          {
              dis(un);
                t.value="";
               t.focus();
        
          }
          else
          {
                hid(un);
                
          }
       }
       function check3(t,un)
       {
           if( t.value.length<8)
           {
               dis(un);
                t.value="";
               t.focus();
           }
           else
          {
                hid(un);
               
          }
       }
    </script>
      </body>
</html>
