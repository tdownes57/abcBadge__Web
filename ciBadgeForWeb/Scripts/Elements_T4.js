


//
//Added 7/9/2019 & 6/26/2019 thomas downes
//
//var T4_moveable_text = document.getElementById("id__mydivheaderT4");

//var T4_textbox_TopEdge = document.getElementsByName('T4.TopEdgePositionPixels')[0];
//var T4_textbox_LeftEdge = document.getElementsByName('T4.LeftEdgePositionPixels')[0];

//var T4_textbox_HeightPixels = document.getElementsByName('T4.HeightPixels')[0];
//var T4_textbox_WidthLengthPixels = document.getElementsByName('T4.WidthLengthPixels')[0];
//var T4_textbox_BackgroundColor = document.getElementsByName('T4.BackgroundColor')[0];

//var T4_badge_back = document.getElementsByName('badge_back')[0];
//T4_badge_back = document.getElementById("badge_back");


//
//  https://stackoverflow.com/questions/7942398/nested-objects-in-javascript-best-practices
//
var T4 = {
    moveable_text = document.getElementById("id__mydivheaderT4"),

    textbox_TopEdge = document.getElementsByName('T4.TopEdgePositionPixels')[0],
    textbox_LeftEdge = document.getElementsByName('T4.TopEdgePositionPixels')[0],

    textbox_HeightPixels = document.getElementsByName('T4.HeightPixels')[0],
    textbox_WidthLengthPixels = document.getElementsByName('T4.WidthLengthPixels')[0],
    textbox_BackgroundColor = document.getElementsByName('T4.BackgroundColor')[0],
    textbox_FontSize = document.getElementsByName('T4.FontSize')[0],

    badge_back = document.getElementById('badge_back')
};

//
//  https://stackoverflow.com/questions/7942398/nested-objects-in-javascript-best-practices
//

//
// A parameter variable is declared by being listed as a parameter.
//
function T4_dragElement(parameter_element) {
    //  
    //Created 7/10/2019 thomas downes
    //

    //dragElement_T99('T4', parameter_element);

    dragElement_T99_T4(T4, parameter_element);

}


//
//  A temporary copy of function dragElement_T99, for Elements_T2.js to 
//       temporarily reference.    ----7/10/2019 thomas downes 
//
function dragElement_T99_T4(par_T99, parameter_element) {

    var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
    var boolResize = false;  //true; // false;//Added 5/26/2019 td

    //var box_topedge = $("#T4_TopEdgePositionPixels");
    //var box_leftedge = jQuery("#T4_LeftEdgePositionPixels");
    //var elem_TEXT = document.getElementsByName('T4.TopEdgePositionPixels')[0].value;

    //var boxHeightPixels = document.getElementsByName('T4.HeightPixels')[0];
    //var boxWidthLengthPixels = document.getElementsByName('T4.WidthLengthPixels')[0];
    //var badge_back = document.getElementById("badge_back");

    var intLeftEdge = 20;
    var intTopEdge = 20;

    //console.log('Is it found or not?  0 < TopEdgePositionPixels.Length = ' + $('#T4_TopEdgePositionPixels').length)
    //console.log('Is it found or not?  0< LeftEdgePositionPixels.Length = ' + $('#T4_LeftEdgePositionPixels').length)
    //console.log('Is it found or not?  0 < badge_back.Length = ' + $('#badge_back').length)
    //console.log('Is it found or not?  0 < box_topedge.Length = ' + box_topedge.Length);

    parameter_element.onmousedown = dragMouseDown;

    //Is the programmer declaring a function __inside__ function dragElement?  yes its legal
    //
    function dragMouseDown(par_event_e) {

        //if (boolResize | true) {

        //}
        //else {
        par_event_e = par_event_e || window.event;
        par_event_e.preventDefault();

        // get the mouse cursor position at startup:
        pos3 = par_event_e.clientX;
        pos4 = par_event_e.clientY;

        document.onmouseup = closeDragElement;
        // call a function whenever the cursor moves:
        document.onmousemove = elementDrag;
        //}
    }

    //Is the programmer declaring a function __inside__ function dragElement?  yes it's legal
    //
    function elementDrag(event_e) {
        event_e = event_e || window.event;
        event_e.preventDefault();

        // calculate the new cursor position:
        pos1 = pos3 - event_e.clientX;
        pos2 = pos4 - event_e.clientY;

        pos3 = event_e.clientX;
        pos4 = event_e.clientY;

        // set the element's new position:
        if (boolResize) {
            //Resize the element.
            //   -----5/26/2019 td
            //parameter_element.style.height = (parameter_element.offsetTop - pos2 ) + "px";
            //parameter_element.style.width = (parameter_element.offsetLeft - pos1 ) + "px";

            //parameter_element.style.height = "100px";
        }
        else {
            //Move the element.
            parameter_element.style.top = (parameter_element.offsetTop - pos2) + "px";
            parameter_element.style.left = (parameter_element.offsetLeft - pos1) + "px";

            // 6/26 td//var badge_back = document.getElementById('badge_back');   // Added 6/24/2019 thomas downes.
            //Added 6/26/2019 td 
            //var badge_back = document.getElementsByName('badge_back')[0];
            //badge_back = document.getElementById("badge_back");

            //Added 6/23/2019 thomas d.
            var intTopEdge = (parameter_element.offsetTop);  // - badge_back.offsetTop);
            var intLeftEdge = (parameter_element.offsetLeft); // - badge_back.offsetLeft);

            //Added 6/23/2019 thomas d.
            intTopEdge = (parameter_element.offsetTop - par_T99.badge_back.offsetTop);
            intLeftEdge = (parameter_element.offsetLeft - par_T99.badge_back.offsetLeft);

            intTopEdge = (parameter_element.offsetTop - par_T99.badge_back.offsetTop);
            intLeftEdge = (parameter_element.offsetLeft - par_T99.badge_back.offsetLeft);

            //document.getElementsByName('T4.TopEdgePositionPixels')[0].value = intTopEdge;
            //document.getElementsByName('T4.LeftEdgePositionPixels')[0].value = intLeftEdge;

            par_T99.textbox_TopEdge = intTopEdge;
            par_T99.textbox_LeftEdge = intLeftEdge;

            //box_topedge.value = intTopEdge; // parameter_element.offsetTop - badge_back.offsetTop;
            //box_leftedge.value = intLeftEdge; // parameter_element.offsetLeft - badge_back.offsetLeft;

            //box_topedge.text = intTopEdge; 
            //box_leftedge.text = intLeftEdge; 

            //console.log('intTopEdge = ' + intTopEdge);
            //console.log('intLeftEdge = ' + intLeftEdge);
            //console.log('badge_back.offsetLeft = ' + badge_back.offsetLeft);
            //console.log('Current value of TopEdge = ' + box_topedge.value)

            // $("input[name='TopEdgePositionPixels']").value = 'Testing my javacript.....'; //intTopEdge;
            //elem.value = "Testing....";
            //console.log('Is it found or not?  ' + $('#id').length)


        }
    }

    //Is the programmer declaring a function __inside__ function dragElement?
    //
    function closeDragElement() {
        /* stop moving when mouse button is released:*/
        document.onmouseup = null;
        document.onmousemove = null;

        //Added 7/10/2019 thomas downes
        global_elementLastTouched = par_T99;

        //var box_topedge = $("#TopEdgePositionPixels");
        //var box_leftedge = jQuery("#LeftEdgePositionPixels");

        //box_topedge.val = this.dragElement.offsetTop;
        //box_leftedge.val = this.dragElement.offsetLeft;

        //6/28 td---if (intTopEdge < 0 && intLeftEdge < 0) {
        if (intTopEdge > 0 && intLeftEdge < 0) {

            //parameter_element.style.height = changedHeightPX(10);
            //parameter_element.style.height = changedHeightPX(-10);
            parameter_element.style.height = changedHeightPX(+10);
        }

        //Added 6/28/2019 thomas D.
        if (intTopEdge < 0 && intLeftEdge > 0) {

            parameter_element.style.width = changedWidthPX(-10);
        }

        ////Added 6/28/2019 thomas D.
        if (intTopEdge > (badge_back.offsetHeight) && intLeftEdge > 0) {

            parameter_element.style.width = changedWidthPX(+10);
        }

        ////Added 6/28/2019 thomas D.
        if (intTopEdge > 0 && intLeftEdge > (badge_back.offsetWidth)) {

            parameter_element.style.height = changedHeightPX(+10);
        }

    }

    function changedHeightPX(intAmount) {
        //
        //  Added 6/28/2019 Thomas DOWNES
        //
        var intHeight = parseInt(parameter_element.style.height, 10);
        var intHeight_new = (intHeight + intAmount);
        if (Number.isNaN(intHeight_new)) { intHeight_new = 40; }
        boxHeightPixels.value = intHeight_new;
        return (intHeight_new + "px");
    }

    function changedWidthPX(intAmount) {
        //
        //  Added 6/28/2019 Thomas DOWNES
        //
        var intWidth = parseInt(parameter_element.style.width, 10);
        var intWidth_new = (intWidth + intAmount);

        if (Number.isNaN(intWidth_new)) { intWidth_new = 140; }
        boxWidthPixels.value = intWidth_new;
        return (intWidth_new + "px");

    }  //End of "function changedWidthPX(intAmount)"

}


