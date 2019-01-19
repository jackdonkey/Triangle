$( document ).ready(function() {
    var HtmlHolder = "";

    var i, x;
    for (i = 0; i < 6; i++) {
        for (x = 0; x < 6; x++) {
            HtmlHolder +=  buildHTMLWithIds(i, x);
        }
    }


    $("#wrapper").html(HtmlHolder);



    $( "#wrapper" ).on( "click", ".triangleWrapper", function(event) {

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
      return "    <div class='triangleWrapper'>\n" +
            "        <div class='leftTriangle  cordA' data-row='" + cordX +"'data-col='" + cordY + "'></div>\n" +
            "        <div class='rightTriangle  cordB' data-row='" + cordX +"'data-col='" + cordY + "'></div>\n" +
            "    </div>";
    }

});

