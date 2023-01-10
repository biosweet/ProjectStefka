<%@ Application Language="VB" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    Sub Application_Start(sender As Object, e As EventArgs)

        System.Web.Optimization.BundleTable.Bundles.Add(New System.Web.Optimization.ScriptBundle("~/bundle/js")  
.Include("~/Scripts/*.js"));  
System.Web.Optimization.BundleTable.Bundles.Add(New System.Web.Optimization.ScriptBundle("~/bundle/css")  
.Include("~/Styles/*.css"));
    End Sub

</script>

