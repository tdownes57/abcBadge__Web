
//-------------------------------------------------------------------------------------------
// ClickClosure Function closure_clickElement
//-------------------------------------------------------------------------------------------
//
// Exported to Javascript file ~/Scripts/Closures/ClickClosure.js
//    on 4/28/2020 thomas downes 
//
//---import {MakeClosure_clickElement} from "ExportClosures.js";
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
function MakeClosure_clickElement(par_elmntDiv) {
    //
    //This is a Javascript closure.
    //   ---3/20/2020 Thomas Downes
    //
    "use strict";

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
            closure_DivElement.style.padding = "2px";
            //mod_array_elementIDs.push(closure_DivElement.id); //Push = Insert
            mod_array_elementIDs.push(closure_DivElement); //Push = Insert
        }

    }

}
