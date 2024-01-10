//
//  R Software Consulting 123, Thomas C. Downes..  ----6/22/2019 td
//
//-------------------------------------------------------------------------------------------
// MakeClosure Function closure_dragElement
//-------------------------------------------------------------------------------------------
//
// Exported to Javascript file ~/Scripts/Closures/DragClosure.js
//    on 4/28/2020 thomas downes 
//
//---import {MakeClosure_dragElement} from "ExportClosures.js";
    // 
    // Search the Views\Shared\_LayoutClosures.cshtml document for the following: 
    //    (!!!! near the top of the document !!!)
    //
    //    @Scripts.Render("~/Scripts/Closures/ClickClosure.js")
    //    @Scripts.Render("~/Scripts/Closures/DragClosure.js")
    //
    // Search the Views\Shared\_LayoutClosures.cshtml document for the following: 
    //    (!!!! near the bottom of the document !!!)
    //
    //     @Scripts.Render("~/Scripts/Closures/LinkUpClosures.js")
    //
function MakeClosure_dragElement(par_elmntDiv) {
    //
    //This is a Javascript closure.
    //
    var closure_DivElement; // = par_elmnt;
    var closure_pos1_x = 0;
    var closure_pos2_y = 0;

    var closure_pos3_xPrior = 0;
    var closure_pos4_yPrior = 0;

    //Added 3/20/2020
    closure_DivElement = par_elmntDiv;

    // Added 3/17/2020 thomas downes
    const c_useHeaderToMove = false; // Turn off the header functionality.

    if (c_useHeaderToMove && document.getElementById(closure_DivElement.id + "header")) {
        /* if present, the header is where you move the DIV from:*/
        document.getElementById(closure_DivElement.id + "header").onmousedown = subClosFun_dragMouseDown;
    }
    else {
        /* otherwise, move the DIV from anywhere inside the DIV:*/
        closure_DivElement.onmousedown = subClosFun_dragMouseDown;
    }

    function subClosFun_dragMouseDown(par_e_EventMD) {
        //
        //Uses closure variables:
        //
        //    closure_pos1_x
        //    closure_pos2_y
        //    closure_pos3_xPrior
        //    closure_pos4_yPrior
        //    closure_DivElement
        //
        if (mod_JS_mode != "Move") { return; }  // Exit if we are "out of mode".

        par_e_EventMD = par_e_EventMD || window.event;
        par_e_EventMD.preventDefault();

        // get the "prior" mouse cursor position at startup:
        //
        closure_pos3_xPrior = par_e_EventMD.clientX;
        closure_pos4_yPrior = par_e_EventMD.clientY;

        //
        // Document-Level
        //
        document.onmouseup = subClosFun_closeDragElement;

        // call a function whenever the cursor moves:
        //
        document.onmousemove = subClosFun_elementDrag;
    }

    function subClosFun_elementDrag(par_e_EventDrag) {
        //
        //Uses closure variables:
        //    closure_pos1_x
        //    closure_pos2_y
        //    closure_pos3_xPrior
        //    closure_pos4_yPrior
        //    closure_DivElement
        //
        if (mod_JS_mode != "Move") { return; }  // Exit if we are "out of mode".

        par_e_EventDrag = par_e_EventDrag || window.event;
        par_e_EventDrag.preventDefault();

        // calculate the new cursor position:
        closure_pos1_x = closure_pos3_xPrior - par_e_EventDrag.clientX;
        closure_pos2_y = closure_pos4_yPrior - par_e_EventDrag.clientY;

        // Prepare for next call.
        closure_pos3_xPrior = par_e_EventDrag.clientX;
        closure_pos4_yPrior = par_e_EventDrag.clientY;

        // Set the element's new position:
        closure_DivElement.style.left = (closure_DivElement.offsetLeft - closure_pos1_x) + "px";  // px = pixels
        closure_DivElement.style.top = (closure_DivElement.offsetTop - closure_pos2_y) + "px";  //  px = pixels

        // Added 3/20/2020 thomas downes
        //----mod_record_all_positions[closure_DivElement.id + "_Left"] = closure_DivElement.style.left;
        //----mod_record_all_positions[closure_DivElement.id + "_Top"] = closure_DivElement.style.top;
        my_JSON_object_Left[closure_DivElement.id + "_Left"] = closure_DivElement.style.left;
        my_JSON_object_Top[closure_DivElement.id + "_Top"] = closure_DivElement.style.top;

        //Record the position.
        //if (document.getElementById(closure_DivElement.id + "header")) {
        //    /* if present, the header is where you move the DIV from:*/
        //    document.getElementById(closure_DivElement.id + "header").innerHTML = "Hello, " + closure_DivElement.id + "header";
        //}

        //Propagate the move.
        //function_PropagateMoveToGroup_NoUse(closure_DivElement.style.left, closure_DivElement.style.top, closure_DivElement);

        //Added 3/20/220 Thomas Downes
        function_PropagateMoveToGroup(closure_pos1_x, closure_pos2_y, closure_DivElement,
            closure_DivElement.style.left);

    }

    function subClosFun_closeDragElement() {
        /* stop moving when mouse button is released:*/
        document.onmouseup = null;
        document.onmousemove = null;

        //Added 3/20/2020 thomas downes
        //---document.getElementById('p_JSON').innerHTML = JSON.stringify(mod_record_all_positions);
        //document.getElementById('p_JSON').innerHTML = JSON.stringify(my_JSON_object);

        // Added 3/22/2020 thomas downes
        //let strCurrentJSON = JSON.stringify(my_JSON_object);
        let strCurrentJSON_Left = JSON.stringify(my_JSON_object_Left);
        let strCurrentJSON_Top = JSON.stringify(my_JSON_object_Top);

        //document.getElementById('p_JSON').innerText = strCurrentJSON;  // JSON.stringify(my_JSON_object);
        //document.getElementById('p_JSON_Left').innerText = strCurrentJSON_Left;  // JSON.stringify(my_JSON_object);
        //document.getElementById('p_JSON_Top').innerText = strCurrentJSON_Top;  // JSON.stringify(my_JSON_object);

        //document.getElementById("JsonTextContent").innerText = strCurrentJSON;
        //document.getElementById("JsonTextContent")[0].innerText = strCurrentJSON;

        //  http://javascript-coder.com/javascript-form/javascript-set-form-field.phtml
        //document.getElementById('JsonTextContent')[0].value = strCurrentJSON;
        //jQuery('JsonTextContent').value = strCurrentJSON;
        //  document.getElementById("p_JSON").innerText;

        //ADded 3/22/2020
        //SaveJsonToForm(strCurrentJSON);  //Added 3/22/2020 td
        SaveJsonToForm_stringsLeftTop(strCurrentJSON_Left, strCurrentJSON_Top);  //Added 3/22/2020 td

    }
}
