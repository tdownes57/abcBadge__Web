
//
//CI Solutions, Thomas C. Downes..  ----6/22/2019 td  
//

var a;
a = 5;
alert("This is TextMover1  !!");

//Make the DIV element draggable:
//
dragElement(document.getElementById("id__mydivheader1"));
dragElement(document.getElementById("id__mydivheader2"));
dragElement(document.getElementById("id__mydivheader3"));
dragElement(document.getElementById("id__mydivheader4"));
dragElement(document.getElementById("id__mydivheader5"));

var curr_heightButton = 100;
var curr_widthButton = 100;

function heightButtonMore() {
    //Added 5/26/2019 td
    curr_heightButton = (curr_heightButton + 5);
    return (curr_heightButton);
}

function heightButtonLess() {
    //Added 5/26/2019 td
    curr_heightButton = (curr_heightButton - 5);
    return (curr_heightButton);
}

function widthButtonMore() {
    //Added 5/26/2019 td
    curr_widthButton = (curr_widthButton + 5);
    return (curr_widthButton);
}

function widthButtonLess() {
    //Added 5/26/2019 td
    curr_widthButton = (curr_widthButton - 5);
    return (curr_widthButton);
}


//A parameter variable is declared by being listed as a parameter.
//
function dragElement(parameter_element) {
    var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
    var boolResize = true; // false;//Added 5/26/2019 td

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

            parameter_element.style.height = "100px";
        }
        else {
            //Move the element.
            parameter_element.style.top = (parameter_element.offsetTop - pos2) + "px";
            parameter_element.style.left = (parameter_element.offsetLeft - pos1) + "px";
        }
    }

    //Is the programmer declaring a function __inside__ function dragElement?
    //
    function closeDragElement() {
        /* stop moving when mouse button is released:*/
        document.onmouseup = null;
        document.onmousemove = null;
    }
}


button_printpositions.addEventListener('click', function (event) {
    //
    // Click event-handler for the Save button.
    //
    var output_box = document.getElementById("textarea_values");

    var moveable_div1 = document.getElementById("id__mydivheader1");
    var moveable_div2 = document.getElementById("id__mydivheader2");
    var moveable_div3 = document.getElementById("id__mydivheader3");
    var moveable_div4 = document.getElementById("id__mydivheader4");
    var moveable_div5 = document.getElementById("id__mydivheader5");

    output_box.value = "mydivheader1, OffsetLeft: " + moveable_div1.offsetLeft + "  " +
        " , OffsetTop:  " + moveable_div1.offsetTop + " \n  " +
        "mydivheader1, ClientHeight: " + moveable_div1.clientHeight + " \n " +
        " , ClientWidth:  " + moveable_div1.clientWidth + " \n " +
        "mydivheader2, OffsetLeft: " + moveable_div2.offsetLeft + "  \n " +
        " , OffsetTop:  " + moveable_div2.offsetTop + " \n  "

    //alert("Div #1  Left coordinate: " + moveable_div1.offsetLeft + ", Top coordinate: " + moveable_div1.offsetTop);
    //var m oveable_div2 = document.getElementById("mydiv2");
    //alert("Div #2  Left coordinate: " + moveable_div2.offsetLeft + ", Top coordinate: " + moveable_div2.offsetTop);
});


buttonBtnHeightMore.addEventListener('click', function (event) {
    //
    // Click event-handler for the Save button.
    //
    var moveable_div5 = document.getElementById("id__mydivheader5");
    moveable_div5.style.height = heightButtonMore() + "px";
});
                  
buttonBtnHeightLess.addEventListener('click', function (event) {
    //
    // Click event-handler for the Save button.
    //
    var moveable_div5 = document.getElementById("id__mydivheader5");
    moveable_div5.style.height = heightButtonLess() + "px";
});
                            
buttonBtnWidthMore.addEventListener('click', function (event) {
    //
    // Click event-handler for the Save button.
    //
    var moveable_div5 = document.getElementById("id__mydivheader5");
    moveable_div5.style.height = heightButtonMore() + "px";
});



