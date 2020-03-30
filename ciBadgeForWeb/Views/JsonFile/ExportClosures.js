
//-------------------------------------------------------------------------------------------
// MakeClosure Function closure_clickElement
//-------------------------------------------------------------------------------------------
//
export function exp_makeElementWidth_2x(par_e_EventClick) {
    //    //
    //    // Double the width of all selected items.
    //    //     ----3/30/2020 thomas downes
    //    //
    par_e_EventClick = par_e_EventClick || window.event;
    par_e_EventClick.preventDefault();
    //
    //Iterate through the selected elements.  
    //
    mod_array_elementIDs.forEach(makeElementWidth_2x_each);

}

export function exp_makeElementWidth_2x_each(par_Element, index) {
    //     //   
    //     //Specify the child Image element.  Don't,  repeat
    //     //   do //NOT// use the ".style" property. 
    //        //
    //       

    //EL1_im.width = (2 * EL1_im.width);
    //EL2_im.width = (2 * EL2_im.width);

    //if (each_Element.hasChildNodes) {
    //    //if (each_Element.childNodes[0]) {
    //    //    each_Element.childNodes[0].width = (2 * each_Element.childNodes[0].width);
    //    //}
    //    let my_image = each_Element.getElementsByTagName('img')[0];
    //    my_image.width = (2 * my_image.width);
    //}
    //else {
    //    //Inform user of lack of 1st child node (Image).
    //    alert(';;;;;;;;;;;;;;;;;;;;;;;; No child nodes ;;;;;;;;;;;');
    //}

    let my_image = par_Element.OnlyImage; //Let's leverage our made-up property ("OnlyImage").
    my_image.width = (2 * my_image.width);

}


export function exp_MakeClosure_clickElement(par_elmntDiv) {
    //
    //This is a Javascript closure.
    //   ---3/20/2020 Thomas Downes
    //

    var closure_DivElement; // = par_elmntDiv;

    closure_DivElement = par_elmntDiv;

    //closure_DivElement.onclick = subClosFun_click;
    //closure_DivElement.onclick = subClosFun_click;
    closure_DivElement.addEventListener('click', event => {
        subClosFun_click(event);
    });

    function subClosFun_click(par_e_EventC) {
        //
        //Uses closure variables:
        //
        par_e_EventC = par_e_EventC || window.event;
        par_e_EventC.preventDefault();

        if (mod_JS_mode != "Include") { return; }  // Exit if we are "out of mode".

        //
        // Is this element already in the group of elements?
        //
        //let strElementID = closure_DivElement.id;
        //let index_of_element = mod_array_elementIDs.indexOf(strElementID);
        let index_of_element = mod_array_elementIDs.indexOf(closure_DivElement);
        let boolHasItAlready = (0 <= index_of_element);
        if (boolHasItAlready) {
            //
            // Remove the Element ID from the selection group.
            //
            closure_DivElement.style.borderWidth = '';  // 'thin';
            closure_DivElement.style.color = '';
            closure_DivElement.style.backgroundColor = '';
            //mod_array_elementIDs.pop(closure_DivElement.id); // Pop = Remove
            mod_array_elementIDs.splice(index_of_element, 1);  // This will delete the element.
        }
        else {
            //
            // Add the closure element to the selection group.
            //
            closure_DivElement.style.borderWidth = '';  //'thick';
            closure_DivElement.style.color = 'blue';
            closure_DivElement.style.backgroundColor = 'blue';
            //mod_array_elementIDs.push(closure_DivElement.id); //Push = Insert
            mod_array_elementIDs.push(closure_DivElement); //Push = Insert
        }



    }

}

//-------------------------------------------------------------------------------------------
// MakeClosure Function closure_dragElement
//-------------------------------------------------------------------------------------------
//
export function exp_MakeClosure_dragElement(par_elmntDiv) {
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
