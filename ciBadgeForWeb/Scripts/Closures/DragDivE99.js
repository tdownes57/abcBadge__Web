//
//  R Software Consulting 123, Thomas C. Downes..  ----6/22/2019 td
//
//-----4/28/2020 thomas downes------<script>

    if (EL1) {
        MakeClosure_dragElement(EL1);
        MakeClosure_dragElement(EL2);
        MakeClosure_dragElement(EL3);
        MakeClosure_dragElement(EL4);

        MakeClosure_dragElement(EL5);
        MakeClosure_dragElement(EL6);
        MakeClosure_dragElement(EL7);
        MakeClosure_dragElement(EL8);

        MakeClosure_dragElement(EL9);
        MakeClosure_dragElement(EL10);
        MakeClosure_dragElement(EL11);
        MakeClosure_dragElement(EL12);
    }
    else {
        //Unfortunately, our [0] syntax fails for identifying the IMAGE element.
        alert("We could not find the Element #1....Sad!");
    }


    if (EL1) {
        MakeClosure_dragElement(EL1);
        MakeClosure_dragElement(EL2);
        MakeClosure_dragElement(EL3);
        MakeClosure_dragElement(EL4);

        MakeClosure_dragElement(EL5);
        MakeClosure_dragElement(EL6);
        MakeClosure_dragElement(EL7);
        MakeClosure_dragElement(EL8);

        MakeClosure_dragElement(EL9);
        MakeClosure_dragElement(EL10);
        MakeClosure_dragElement(EL11);
        MakeClosure_dragElement(EL12);
    }
    else {
        //Unfortunately, our [0] syntax fails for identifying the IMAGE element.
        alert("We could not find the Element #1....Sad!");
    }


    if (EL1) {
        //
        // Images - Include Mode      ---3/29/2020 thomas downes
        //
        MakeClosure_clickElement(EL1);
        MakeClosure_clickElement(EL2);
        MakeClosure_clickElement(EL3);
        MakeClosure_clickElement(EL4);

        MakeClosure_clickElement(EL5);
        MakeClosure_clickElement(EL6);
        MakeClosure_clickElement(EL7);
        MakeClosure_clickElement(EL8);

        MakeClosure_clickElement(EL9);
        MakeClosure_clickElement(EL10);
        MakeClosure_clickElement(EL11);
        MakeClosure_clickElement(EL12);
    }
    else {
        //Unfortunately, our [0] syntax fails for identifying the IMAGE element.
        alert("We could not find the Element #1....Sad!");
    }

    // Added 3/20/2020 thomas downes
    EL1.style.left = my_JSON_object_Left["EL1_Left"];
    EL2.style.left = my_JSON_object_Left["EL2_Left"];
    EL3.style.left = my_JSON_object_Left["EL3_Left"];
    EL4.style.left = my_JSON_object_Left["EL4_Left"];
    EL5.style.left = my_JSON_object_Left["EL5_Left"];
    EL6.style.left = my_JSON_object_Left["EL6_Left"];
    EL7.style.left = my_JSON_object_Left["EL7_Left"];
    EL8.style.left = my_JSON_object_Left["EL8_Left"];
    EL9.style.left = my_JSON_object_Left["EL9_Left"];
    EL10.style.left = my_JSON_object_Left["EL10_Left"];
    EL11.style.left = my_JSON_object_Left["EL11_Left"];
    EL12.style.left = my_JSON_object_Left["EL12_Left"];

        // Added 3/20/2020 thomas downes
    EL1.style.top = my_JSON_object_Top["EL1_Top"];
    EL2.style.top = my_JSON_object_Top["EL2_Top"];
    EL3.style.top = my_JSON_object_Top["EL3_Top"];
    EL4.style.top = my_JSON_object_Top["EL4_Top"];
    EL5.style.top = my_JSON_object_Top["EL5_Top"];
    EL6.style.top = my_JSON_object_Top["EL6_Top"];
    EL7.style.top = my_JSON_object_Top["EL7_Top"];
    EL8.style.top = my_JSON_object_Top["EL8_Top"];
    EL9.style.top = my_JSON_object_Top["EL9_Top"];
    EL10.style.top = my_JSON_object_Top["EL10_Top"];
    EL11.style.top = my_JSON_object_Top["EL11_Top"];
    EL12.style.top = my_JSON_object_Top["EL12_Top"];

    // Added 3/29/2020 thomas downes
    //
    //-----------------------------
    //  WH #4
    //-----------------------------
    //
    EL1_im.width = my_JSON_object_Width["EL1_Width"];
    EL2_im.width = my_JSON_object_Width["EL2_Width"];
    EL3_im.width = my_JSON_object_Width["EL3_Width"];
    EL4_im.width = my_JSON_object_Width["EL4_Width"];
    EL5_im.width = my_JSON_object_Width["EL5_Width"];
    EL6_im.width = my_JSON_object_Width["EL6_Width"];
    EL7_im.width = my_JSON_object_Width["EL7_Width"];
    EL8_im.width = my_JSON_object_Width["EL8_Width"];
    EL9_im.width = my_JSON_object_Width["EL9_Width"];
    EL10_im.width = my_JSON_object_Width["EL10_Width"];
    EL11_im.width = my_JSON_object_Width["EL11_Width"];
    EL12_im.width = my_JSON_object_Width["EL12_Width"];

    //Added 3/3/2020 td
    if (document.getElementById("div_Width2x")) {
        //Added 3/30/2020 thomas downes
        document.getElementById("div_Width2x").addEventListener('click',
            event => { makeElementWidth_2x(event) });
    }
    else {
        //Added 3/30/2020 thomas downes
        alert("We cannot find element div_Width2x.");
    }

    //Added  3/26/2020 thomas downes
    const FormJson_Left = document.getElementById("JsonTextContent_Left");
    const FormJson_Top = document.getElementById("JsonTextContent_Top");

    //
    //-----------------------------
    //  WH #5
    //-----------------------------
    //
    const FormJson_Width = document.getElementById("JsonTextContent_Width");
    const FormJson_Height = document.getElementById("JsonTextContent_Height");

    //Added  3/26/2020 thomas downes
    const ViewJson_Left = document.getElementById("p_JSON_Left");
    const ViewJson_Top = document.getElementById("p_JSON_Top");

    //
    //-----------------------------
    //  WH #6
    //-----------------------------
    //
    const ViewJson_Width = document.getElementById("p_JSON_Width");
    const ViewJson_Height = document.getElementById("p_JSON_Height");

    //Added  3/26/2020 thomas downes
    if (ViewJson_Left.style != "hidden") {
        ViewJson_Left.innerText = my_JSON_string_Left;
        ViewJson_Top.innerText = my_JSON_string_Top;
    }
    //-----------------------------
    //  WH #7
    //-----------------------------
    //
    if (ViewJson_Width.style != "hidden") {
        ViewJson_Width.innerText = my_JSON_string_Width;
        ViewJson_Height.innerText = my_JSON_string_Height;
    }

        //Added 3/20/2020 thomas downes
        let mod_JS_mode = "Move"; // "drag"; //---"click";
        let mod_array_elementIDs = [];
    let i_limitMessages = 0;  //Added 3/22/2020 td

    //Connect the Click event to the function function_ToggleMode.
    //   ---3/20/2020
    document.getElementById("hyperlinkToggleMode").onclick = function_ToggleMode;

        //
        //Added 3/20/2020 thomas downes
        //
        function function_ToggleMode(par_e_EventClick) {
        //
        // Switch from Click-to-Include to Click-and-Drag, and back again.
        //  ----3/20/2020 thomas downes
        //
        par_e_EventClick = par_e_EventClick || window.event;
            par_e_EventClick.preventDefault();

            if ("Move" == mod_JS_mode) {
        //Drag-to-Click
        mod_JS_mode = "Include";
                //document.getElementById("paragraphToggleMode").innerHTML = "Include Mode - Click and release, for selecting elements to include as a group.  <a> Click here to change to Drag Mode. </a>";
                document.getElementById("paragraphToggleMode").innerText = "Include Mode - Click and release, for selecting elements to include as a group.";
                document.getElementById("hyperlinkToggleMode").innerText = "Click here to change to Click/Drag Mode.";
                // 3/30/2020 thomas d.
                document.getElementById("div_Width2x").style.visibility = "visible";
                //----#1--document.getElementById("width2x").onclick = function_Width2x;
                //document.getElementById("width2x").addEventListener('click', event => {
        //    function_Width2x(event);
        //  });
    }
            else if ("Include" == mod_JS_mode) {
        //Click-to-Drag
        mod_JS_mode = "Move";
                //document.getElementById("paragraphToggleMode").innerHTML = "Move Mode - Click and hold the mouse button down while moving the DIV element. <a >Click here to switch to Include Mode.</a>";
                document.getElementById("paragraphToggleMode").innerText = "Click/Drag Mode - Click, press, & move; to move the element.";
                document.getElementById("hyperlinkToggleMode").innerText = "Click here to change to Include Mode.";
                // 3/30/2020 thomas d.
                //document.getElementById("width2x").style.visibility = "hidden";
                //document.getElementById("width2x").click = function_Width2x;
            }
        }


    function makeElementWidth_2x(par_e_EventClick) {
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

        //
        //Added 3/30/2020 td
        //
        SaveJsonToForm_objectsWidthHeight(my_JSON_object_Width, my_JSON_object_Height)

    }

    function makeElementWidth_2x_each(par_Element, index) {
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
        //my_image.width = (2 * my_image.width);
        my_image.width = (1.5 * my_image.width);

        //---my_JSON_object_Width[par_Element.id + "_width"] = my_image.width;
        //---my_JSON_object_Height[par_Element.id + "_height"] = my_image.height;

        my_JSON_object_Width[par_Element.id + "_Width"] = my_image.width;
        my_JSON_object_Height[par_Element.id + "_Height"] = my_image.height;

        //par_sJsonString_Width = JSON.stringify(my_JSON_object_Width);
        //par_sJsonString_Height = JSON.stringify(my_JSON_object_Height);

        if (ViewJson_Width.style != "hidden") {
        par_sJsonString_Width = JSON.stringify(my_JSON_object_Width);
            ViewJson_Width.innerText = par_sJsonString_Width;
            //ViewJson_Height.innerText = par_sJsonString_Height;
        }

    }

        //
        // Added 3/20/2020 Thomas Downes
        //
        function function_PropagateMoveToGroup(par_intLeftX, par_intTopY, par_omit_elmntDiv, par_styleLeft) {
        //
        // Added 3/20/2020 thomas downes
        //
        //
        // Let's iterate through the selected Elements.
        //
        //for (each_ElementID in mod_array_elementIDs) {
        //mod_array_elementIDs.forEach(each_ElementID => {

        intElemIndex = mod_array_elementIDs.indexOf(par_omit_elmntDiv);

            boolMovingGroup = (intElemIndex >= 0);

            if (boolMovingGroup) {
        mod_array_elementIDs.forEach(each_Element => {
            // We are iterating through the selected Elements.
            //-----tempElem = document.getElementById(each_ElementID);
            if (each_Element != par_omit_elmntDiv) {
                //Call the element-specific (as one of the group elements) encapsulation.
                function_PropagateMoveToGroup_Item(par_intLeftX, par_intTopY, each_Element);
            }
        });
            }

            //
            //   https://forums.asp.net/t/2080584.aspx?Populate+mvc+model+field+using+Javascript+Jqeury
            //
            //document.getElementById('#@*@Html.IdFor(m => m.JsonTextContent_Left*@)').val(v);
            //
            //alert("Before: " + document.getElementById('JsonTextContent').innerText);

            //document.getElementById("JsonTextContent").innerText =
            //    document.getElementById("p_JSON").innerText;

            //Added 3/22/2020 thomas downes
            //if (i_limitMessages < 0) {
            if (par_styleLeft == "1px" || par_styleLeft == "2px") {
        i_limitMessages++;
                //
                // Left & Top
                //
                SaveJsonToForm_objectsLeftTop(my_JSON_object_Left, my_JSON_object_Top);
                //
                //-----------------------------
                //  WH #8
                //-----------------------------
                // Width & Height
                //
                SaveJsonToForm_objectsWidthHeight(my_JSON_object_Width, my_JSON_object_Height);
            }

        }

        function function_PropagateMoveToGroup_Item(par_intLeftX, par_intTopY, par_elementDiv) {
        //
        // Added 3/20/2020 thomas downes
        //
        //
        // Set the element's new position:
        //
        par_elementDiv.style.left = (par_elementDiv.offsetLeft - par_intLeftX) + "px";  // px = pixels
            par_elementDiv.style.top = (par_elementDiv.offsetTop - par_intTopY) + "px";  //  px = pixels

            //Added 3/20/2020 td
            //---my_JSON_object[par_elementDiv.id + "_Left"] = par_elementDiv.style.left;
            //---my_JSON_object[par_elementDiv.id + "_Top"] = par_elementDiv.style.top;
            my_JSON_object_Left[par_elementDiv.id + "_Left"] = par_elementDiv.style.left;
            my_JSON_object_Top[par_elementDiv.id + "_Top"] = par_elementDiv.style.top;

            //Added 3/22/2020 td
            //elementImage = document.getElementById(par_elementDiv + '_i');
            //my_JSON_object[par_elementDiv.id + "_width"] = elementImage.width;
            //my_JSON_object[par_elementDiv.id + "_height"] = elementImage.height;

        }


    function SaveJsonToForm_stringsLeftTop(par_sJsonString_Left, par_sJsonString_Top) {
        //
        //Added 3/22/2020 thomas downes
        //
        //document.getElementById("JsonTextContent").innerText = strCurrentJSON;
        //document.getElementById("JsonTextContent")[0].innerText = strCurrentJSON;

        //  http://javascript-coder.com/javascript-form/javascript-set-form-field.phtml

        FormJson_Left.value = par_sJsonString_Left;
        FormJson_Top.value = par_sJsonString_Top;

        if (ViewJson_Left.style != "hidden") {
        ViewJson_Left.innerText = par_sJsonString_Left;
            ViewJson_Top.innerText = par_sJsonString_Top;
        }
    }

    function SaveJsonToForm_objectsLeftTop(par_oJson_Left, par_oJson_Top) {

        // let strCurrentJSON_Left = JSON.stringify(my_JSON_object_Left);
        // let strCurrentJSON_Top = JSON.stringify(my_JSON_object_Top);
        FormJson_Left.value = JSON.stringify(par_oJson_Left);
        FormJson_Top.value = JSON.stringify(par_oJson_Top);

        if (ViewJson_Left.style != "hidden") {
        ViewJson_Left.innerText = FormJson_Left.value;
            ViewJson_Top.innerText = FormJson_Top.value;
        }

        //  document.getElementById("p_JSON").innerText;

    }

    function SaveJsonToForm_objectsWidthHeight(par_oJson_Width, par_oJson_Height) {
        //
        //Added 3/30/2020 Thomas Downes
        //
        FormJson_Width.value = JSON.stringify(par_oJson_Width);
        FormJson_Height.value = JSON.stringify(par_oJson_Height);

        if (ViewJson_Width.style != "hidden") {
        ViewJson_Width.innerText = FormJson_Width.value;
            ViewJson_Height.innerText = FormJson_Height.value;
        }

        //  document.getElementById("p_JSON").innerText;

    }


        //-------------------------------------------------------------------------------------------
        // MakeClosure Function closure_clickElement
        //-------------------------------------------------------------------------------------------
        //
        //---import {MakeClosure_clickElement} from "ExportClosures.js";
        function MakeClosure_clickElement(par_elmntDiv) {
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
                let boolGroupHasItAlready = (0 <= index_of_element);
                if (boolGroupHasItAlready) {
        //
        // Remove the Element ID from the selection group.
        //
        closure_DivElement.style.borderWidth = 'thick';  // 'thin' ;
                    closure_DivElement.style.borderBottomColor = 'gray';
                    closure_DivElement.style.color = '';
                    closure_DivElement.style.backgroundColor = '';
                    //mod_array_elementIDs.pop(closure_DivElement.id); // Pop = Remove
                    mod_array_elementIDs.splice(index_of_element, 1);  // This will delete the element.
                }
                else {
        //
        // Add the closure element to the selection group.
        //
        closure_DivElement.style.borderWidth = 'thick';
                    closure_DivElement.style.borderBottomColor = 'blue';
                    closure_DivElement.style.color = 'blue';
                    closure_DivElement.style.backgroundColor = 'blue';
                    clo.closure_DivElement.style.padding = "25px";
                    //mod_array_elementIDs.push(closure_DivElement.id); //Push = Insert
                    mod_array_elementIDs.push(closure_DivElement); //Push = Insert
                }



            }

        }

        //-------------------------------------------------------------------------------------------
        // MakeClosure Function closure_dragElement
        //-------------------------------------------------------------------------------------------
        //
        //---import {MakeClosure_dragElement} from "ExportClosures.js";
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
//-----</script>


