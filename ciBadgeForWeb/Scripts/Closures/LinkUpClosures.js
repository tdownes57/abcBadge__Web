
    //-------------------------------------------------------------------------------------------
    // Execute MakeClosure commands.
    //-------------------------------------------------------------------------------------------
    //
    // Exported to Javascript file ~/Scripts/Closures/LinkUpClosure.js
    //    on 4/28/2020 thomas downes 
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
    //

    //   In Javascript, a null value is "falsy", i.e. is evaluated as a Boolean value of False in Boolean-centric circumstances.
    //if (EL1) {
    if (EL1)  MakeClosure_dragElement(EL1);
    if (EL2)  MakeClosure_dragElement(EL2);
    if (EL3)  MakeClosure_dragElement(EL3);
    if (EL4)  MakeClosure_dragElement(EL4);

    if (EL5)  MakeClosure_dragElement(EL5);
    if (EL6)  MakeClosure_dragElement(EL6);
    if (EL7)  MakeClosure_dragElement(EL7);
    if (EL8)  MakeClosure_dragElement(EL8);

    if (EL9)  MakeClosure_dragElement(EL9);
    if (EL10)  MakeClosure_dragElement(EL10);
    if (EL11)  MakeClosure_dragElement(EL11);
    if (EL12)  MakeClosure_dragElement(EL12);

        //Added 11/18/2021 td
    if (EL15)  MakeClosure_dragElement(EL15);
    if (EL16)  MakeClosure_dragElement(EL16);
    if (EL17)  MakeClosure_dragElement(EL17);
    if (EL18)  MakeClosure_dragElement(EL18);
    if (EL19)  MakeClosure_dragElement(EL19);
    
    //else {
    //    //Unfortunately, our [0] syntax fails for identifying the IMAGE element.
    //    alert("We could not find the Element #1....Sad!");
    //}

    //}
    //else {
    ////Unfortunately, our [0] syntax fails for identifying the IMAGE element.
    //alert("We could not find the Element #1....Sad!");
    //}


    //if (EL1) {
        //
        // Images - Include Mode      ---3/29/2020 thomas downes
        //
        //   In Javascript, a null value is "falsy", i.e. is evaluated as a Boolean value of False in Boolean-centric circumstances.
        if (EL1) MakeClosure_clickElement(EL1);
        if (EL2) MakeClosure_clickElement(EL2);
        if (EL3) MakeClosure_clickElement(EL3);
        if (EL4) MakeClosure_clickElement(EL4);

        if (EL5) MakeClosure_clickElement(EL5);
        if (EL6) MakeClosure_clickElement(EL6);
        if (EL7) MakeClosure_clickElement(EL7);
        if (EL8) MakeClosure_clickElement(EL8);

        if (EL9) MakeClosure_clickElement(EL9);
        if (EL10) MakeClosure_clickElement(EL10);
        if (EL11) MakeClosure_clickElement(EL11);
        if (EL12) MakeClosure_clickElement(EL12);

                //Added 11/18/2021 td
        if (EL15) MakeClosure_clickElement(EL15);
        if (EL16) MakeClosure_clickElement(EL16);
        if (EL17) MakeClosure_clickElement(EL17);
        if (EL18) MakeClosure_clickElement(EL18);
        if (EL19) MakeClosure_clickElement(EL19);

    //}
    //else {
    ////Unfortunately, our [0] syntax fails for identifying the IMAGE element.
    //alert("We could not find the Element #1....Sad!");
    //}

    // Added 3/20/2020 thomas downes
    //   In Javascript, a null value is "falsy", i.e. is evaluated as a Boolean value of False in Boolean-centric circumstances.
    if (EL1) EL1.style.left = my_JSON_object_Left["EL1_Left"];
    if (EL2) EL2.style.left = my_JSON_object_Left["EL2_Left"];
    if (EL3) EL3.style.left = my_JSON_object_Left["EL3_Left"];
    if (EL4) EL4.style.left = my_JSON_object_Left["EL4_Left"];
    if (EL5) EL5.style.left = my_JSON_object_Left["EL5_Left"];
    if (EL6) EL6.style.left = my_JSON_object_Left["EL6_Left"];
    if (EL7) EL7.style.left = my_JSON_object_Left["EL7_Left"];
    if (EL8) EL8.style.left = my_JSON_object_Left["EL8_Left"];
    if (EL9) EL9.style.left = my_JSON_object_Left["EL9_Left"];
    if (EL10) EL10.style.left = my_JSON_object_Left["EL10_Left"];
    if (EL11) EL11.style.left = my_JSON_object_Left["EL11_Left"];
    if (EL12) EL12.style.left = my_JSON_object_Left["EL12_Left"];

    //Added 11/18/2021 thomas downes
    //  Four(4) of the 1st 4 custom fields, 
    //   field indices 15 to 19.
    if (EL15) EL15.style.left = my_JSON_object_Left["EL15_Left"];
    if (EL16) EL16.style.left = my_JSON_object_Left["EL16_Left"];
    if (EL17) EL17.style.left = my_JSON_object_Left["EL17_Left"];
    if (EL18) EL18.style.left = my_JSON_object_Left["EL18_Left"];
    if (EL19) EL19.style.left = my_JSON_object_Left["EL19_Left"];

    // Added 3/20/2020 thomas downes
    if (EL1) EL1.style.top = my_JSON_object_Top["EL1_Top"];
    if (EL2) EL2.style.top = my_JSON_object_Top["EL2_Top"];
    if (EL3) EL3.style.top = my_JSON_object_Top["EL3_Top"];
    if (EL4) EL4.style.top = my_JSON_object_Top["EL4_Top"];
    if (EL5) EL5.style.top = my_JSON_object_Top["EL5_Top"];
    if (EL6) EL6.style.top = my_JSON_object_Top["EL6_Top"];
    if (EL7) EL7.style.top = my_JSON_object_Top["EL7_Top"];
    if (EL8) EL8.style.top = my_JSON_object_Top["EL8_Top"];
    if (EL9) EL9.style.top = my_JSON_object_Top["EL9_Top"];
    if (EL10) EL10.style.top = my_JSON_object_Top["EL10_Top"];
    if (EL11) EL11.style.top = my_JSON_object_Top["EL11_Top"];
    if (EL12) EL12.style.top = my_JSON_object_Top["EL12_Top"];

    //Added 11/18/2021 thomas downes
    //  Four(4) of the 1st 4 custom fields, 
    //   field indices 15 to 19.
    if (EL15) EL15.style.top = my_JSON_object_Top["EL15_Top"];
    if (EL16) EL16.style.top = my_JSON_object_Top["EL16_Top"];
    if (EL17) EL17.style.top = my_JSON_object_Top["EL17_Top"];
    if (EL18) EL18.style.top = my_JSON_object_Top["EL18_Top"];
    if (EL19) EL19.style.top = my_JSON_object_Top["EL19_Top"];

    // Added 3/29/2020 thomas downes
    //
    //-----------------------------
    //  WH #4
    //-----------------------------
    //
    if (EL1) EL1_im.width = my_JSON_object_Width["EL1_Width"];
    if (EL2) EL2_im.width = my_JSON_object_Width["EL2_Width"];
    if (EL3) EL3_im.width = my_JSON_object_Width["EL3_Width"];
    if (EL4) EL4_im.width = my_JSON_object_Width["EL4_Width"];
    if (EL5) EL5_im.width = my_JSON_object_Width["EL5_Width"];
    if (EL6) EL6_im.width = my_JSON_object_Width["EL6_Width"];
    if (EL7) EL7_im.width = my_JSON_object_Width["EL7_Width"];
    if (EL8) EL8_im.width = my_JSON_object_Width["EL8_Width"];
    if (EL9) EL9_im.width = my_JSON_object_Width["EL9_Width"];
    if (EL10) EL10_im.width = my_JSON_object_Width["EL10_Width"];
    if (EL11) EL11_im.width = my_JSON_object_Width["EL11_Width"];
    if (EL12) EL12_im.width = my_JSON_object_Width["EL12_Width"];

    //Added 11/18/2021 thomas downes
    //  Four(4) of the 1st 4 custom fields, 
    //   field indices 15 to 19.
    //
    if (EL15) EL15_im.width = my_JSON_object_Width["EL15_Width"];
    if (EL16) EL16_im.width = my_JSON_object_Width["EL16_Width"];
    if (EL17) EL17_im.width = my_JSON_object_Width["EL17_Width"];
    if (EL18) EL18_im.width = my_JSON_object_Width["EL18_Width"];
    if (EL19) EL19_im.width = my_JSON_object_Width["EL19_Width"];

    //Added 12/10/2021 thomas downes
    //if (EL41_rotated) EL41_im.width = my_JSON_object_Height["EL41_Width"];
    //if (EL42_rotated) EL42_im.width = my_JSON_object_Height["EL42_Width"];
    //if (EL43_rotated) EL43_im.width = my_JSON_object_Height["EL43_Width"];
    //if (EL44_rotated) EL44_im.width = my_JSON_object_Height["EL44_Width"];
    //if (EL45_rotated) EL45_im.width = my_JSON_object_Height["EL45_Width"];

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
    //document.getElementById("paragraphToggleMode").innerHTML = "Move Mode - Click and hold the mouse button down while moving the DIV element. <a>Click here to switch to Include Mode.</a>";
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

        boolRotated = false; //Added 12/10/2021 thomas downes 
        if (boolRotated) {
            // 
            // Switch Height & Width.
            //
            my_JSON_object_Width[par_Element.id + "_Width"] = my_image.height;  // my_image.width;
            my_JSON_object_Height[par_Element.id + "_Height"] = my_image.width; // my_image.height; 
        }
        else {
            my_JSON_object_Width[par_Element.id + "_Width"] = my_image.width;
            my_JSON_object_Height[par_Element.id + "_Height"] = my_image.height;
        }

        //par_sJsonString_Width = JSON.stringify(my_JSON_object_Width);
        //par_sJsonString_Height = JSON.stringify(my_JSON_object_Height);

        if (ViewJson_Width.style != "hidden") {
            par_sJsonString_Width = JSON.stringify(my_JSON_object_Width);
            ViewJson_Width.innerText = par_sJsonString_Width;
            //ViewJson_Height.innerText = par_sJsonString_Height;
        }

        //
        // End of "function makeElementWidth_2x_each"
        //
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
            //
            // Start of "if (boolMovingGroup)"
            //
            mod_array_elementIDs.forEach(each_Element => {
                //
                // We are iterating through the selected Elements.
                //
                //-----tempElem = document.getElementById(each_ElementID);
                if (each_Element != par_omit_elmntDiv) {
                    //
                    //Call the element - specific(as one of the group elements) encapsulation.
                    //
                    function_PropagateMoveToGroup_OneItem(par_intLeftX, par_intTopY, each_Element);

                    //
                    // End of "if (each_Element != par_omit_elmntDiv)"
                    //
                }
                //
                // End of "We are iterating through the selected Elements."
                //
            });    //End of "mod_array_elementIDs.forEach(....)"

            //
            // End of "if (boolMovingGroup)"
            //
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

            //
            // End of "if (par_styleLeft == "1px" || par_styleLeft == "2px")"
            //
        }

        //
        // End of "function function_PropagateMoveToGroup"
        //
    }

function function_PropagateMoveToGroup_OneItem(par_intLeftX, par_intTopY, par_elementDiv) {
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

function SaveJsonToForm_objectsWidthHeight(par_oJson_Width, par_oJson_Height)
{
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

