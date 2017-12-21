<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFServiceWithJquery._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
           <div class="jumbotron">
        <input type="button" value="Work" onclick="DoWork(); return false" /><br />
               <input type="text" id="txtVal" name="Value" />
               <button onclick="DoSquare(); return false">DoSquare</button><br />
                <input type="text" id="val1" name="val1" />  <input type="text" id="val2" name="val2" />
               <button onclick="DoAdd(); return false">DoAdd</button><br />


    </div>
    <script type="text/javascript">
        function DoWork() {
            //console.log("Hello");
            $.ajax({

                url: "Service/WorkService.svc/DoWork",
                type: "GET",
                dataType: "json",
                success: function (response) {
                    console.info(response);
                },
                error: function (response) {
                    alert(response);
                }

            });
        }

        function DoSquare() {
            var value1 = $("#txtVal").val();
            if (isNaN(value1)) {
                alert("Enter a number");
            }
            else {
                $.ajax({

                    url: "Service/WorkService.svc/DoSquare",
                    type: "POST",
                    data: JSON.stringify(value1),
                    dataType: "json",
                    contentType: "application/json",                   
                    success: function (response) {
                        console.info(response);
                    },
                    error: function (response) {
                        alert(response);
                    }

                });
            }
            
        }
        function DoAdd() {
            var val1 = $("#val1").val();
            var val2 = $("#val2").val();
            var values = {
                "value1": val1,
                "value2": val2
            }
            if (isNaN(val1) && isNaN(val2)) {
                alert("Enter a number");
            }
            else {
                $.ajax({

                    url: "Service/WorkService.svc/Add",
                    type: "POST",
                    data: JSON.stringify(values),
                    dataType: "json",
                    contentType: "application/json",
                    success: function (response) {
                        alert(response);
                    },
                    error: function (response) {
                        alert(response);
                    }

                });

            }

        }

    </script>

    </section>
</asp:Content>

