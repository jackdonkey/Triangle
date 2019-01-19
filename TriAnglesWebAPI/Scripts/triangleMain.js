


$(document).ready(function () {
    var HtmlHolder = "";
    var i, x;
  // var itemLetter = "";
  //  var itemNumberA = 1;
  //  var itemNumberB = 1;
    for (i = 0; i < 6; i++) {

    }

    for (i = 0; i < 6; i++) {
        // switch(i) {
        //     case 0:
        //         itemLetter = "A";
        //         break;
        //     case 1:
        //         itemLetter = "B";
        //         break;
        //     case 2:
        //         itemLetter = "C";
        //         break;
        //     case 3:
        //         itemLetter = "D";
        //         break;
        //     case 4:
        //         itemLetter = "E";
        //         break;
        //     case 5:
        //         itemLetter = "F";
        //         break;
        //
        //     default:
        //         itemLetter = "";
        // }
        for (x = 0; x < 6; x++) {
            HtmlHolder +=  buildHTMLWithIds(i, x);
        }
    }

    
    $("#wrapper").html(HtmlHolder);



    $("#wrapper").on("click", ".triangleWrapper", function () {
        

        $(".leftTriangle, .rightTriangle").removeClass("fillColorLeft").removeClass("fillColorRight");

        $(this).find(".leftTriangle").addClass("fillColorLeft");
        $(this).find(".rightTriangle").addClass("fillColorRight");


        var triPosTop = $(this).position().left;
        var triPosRightLeft = $(this).position().left;
        var triPosRightRight = $(this).position().left +  $(this).width();
        var triPosBottom = $(this).position().left +  $(this).height();

        var positionRow  = $(this).find(".leftTriangle").data("row") + 1;
        var positionCol  = $(this).find(".leftTriangle").data("col") + 1;

        var leftTriangle = positionRow + "," +  positionCol + " - Positions Left Triangle:  Top  &nbsp;" + triPosTop + "px Right " + triPosRightLeft + "px Bottom " + triPosBottom + "px <br />" +
            "Positions Right Triangle:  Top " + triPosTop + "px Right " + triPosRightRight + "px Bottom " + triPosBottom + "px <br />";

        $("#Position").html(leftTriangle);



    });


    function buildHTMLWithIds(cordX, cordY) {
        var itemLetterNumber =  cordX +1
        return "    <div class='triangleWrapper'>\n" +
            "        <div class='leftTriangle  cordA' data-row='" + cordX +"'data-col='" + cordY + "'></div>\n" +
            "        <div class='rightTriangle  cordB' data-row='" + cordX +"'data-col='" + cordY + "'></div>\n" +
            "    </div>";
    }







    $("#triangleSubmit").on("click", function (event) {
        event.preventDefault();


        $("#triangleResults").html("");


        var uriVaules = "";
        var v1 = $("#V1").val().trim();
        var v2 = $("#V2").val().trim();
        var v3 = $("#V3").val().trim();

        uriVaules = "?value=" + v1 + "_" + v2 + "_" + v3;

        var apiURL = "http://localhost:60328/api/Triangles" + uriVaules;

//        $.get(apiURL, function (data) {
//            $("#triangleResults").html(data);
//        });



        $.ajax({
            url: apiURL,
            type: "POST",
            dataType: "json",
            success: function (data, textStatus, jQxhr) {
                console.log(jQxhr);
                $("#triangleResults").html("The Triangle space: " + jQxhr.responseJSON);
            }, error: function (jqXhr, textStatus, errorThrown) {
                $("#triangleResults").html("Error: " + errorThrown);
             }
        });


    });



    




}); // ready





