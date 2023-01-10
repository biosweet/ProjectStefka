<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
      
            <div style="font-size:x-large" align="center"><h1>Travel Planner Form</h1></div>
       <br />

       <div style="font-size:x-large" align="center"><h2>Keep notes of your future trips</h2></div>

      <div>
          <asp:Button runat="server" Text="Search" ForeColor="White" ID="button4" BorderColor="#3333CC" BackColor="#6699FF" Width="125px"></asp:Button></div> 
        <br />
        
        <table style="width: 100%;">
           <tr>
               <td>Destination ID</td>
               <td>
                   <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Destination Name</td>
               <td> <asp:TextBox runat="server"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>Hotel</td>
               <td><asp:TextBox runat="server"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
            <tr>
               <td>Days</td>
               <td><asp:TextBox runat="server"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
             <tr>
               <td>Budget</td>
               <td><asp:TextBox runat="server"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
             <tr>
               <td>Attraction</td>
               <td><asp:TextBox runat="server"></asp:TextBox></td>
               <td>&nbsp;</td>
           </tr>
             <tr>
               <td></td>
               <td><asp:Button runat="server" Text="Insert" ForeColor="White" ID="button1" BorderColor="#3333CC" BackColor="#6699FF" Width="125px"></asp:Button></td>
               <td>
                   <asp:Button runat="server" Text="Update" ForeColor="White" ID="button2" BorderColor="#3333CC" BackColor="#6699FF" Width="125px"></asp:Button></td>
               <td><asp:Button runat="server" Text="Delete" ForeColor="White" ID="button3" BorderColor="#3333CC" BackColor="#6699FF" Width="125px" OnClientClick="return confirm('Are you sure to delete')"></asp:Button></td>
               <td></td>
             </tr>
             <tr>
               <td></td>
               <td></td>
               <td></td>
           </tr>
               <tr>
               <td></td>
               <td>
                   <asp:GridView runat="server" Width="650px" ID="GridView1"></asp:GridView></td>
               <td></td>
           </tr>
       </table>
     

          </div>

</asp:Content>
