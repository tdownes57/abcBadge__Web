


//
//Added 7/9/2019 & 6/26/2019 thomas downes
//
//var EL_moveable_text = document.getElementById("id__mydivheader1");

//var EL_textbox_TopEdge = document.getElementsByName('TopEdgePositionPixels')[0];
//var EL_textbox_LeftEdge = document.getElementsByName('LeftEdgePositionPixels')[0];

//var EL_textbox_HeightPixels = document.getElementsByName('HeightPixels')[0];
//var EL_textbox_WidthLengthPixels = document.getElementsByName('WidthLengthPixels')[0];
//var EL_textbox_BackgroundColor = document.getElementsByName('BackgroundColor')[0];
//var EL_textbox_FontSize = document.getElementsByName('FontSize')[0];

//var EL_badge_back = document.getElementsByName('badge_back')[0];

//
//  https://stackoverflow.com/questions/7942398/nested-objects-in-javascript-best-practices
//
var EL = {
    moveable_text = document.getElementById("id__mydivheader1"),

    textbox_TopEdge = document.getElementsByName('TopEdgePositionPixels')[0],
    textbox_LeftEdge = document.getElementsByName('TopEdgePositionPixels')[0],

    textbox_HeightPixels = document.getElementsByName('HeightPixels')[0],
    textbox_WidthLengthPixels = document.getElementsByName('WidthLengthPixels')[0],
    textbox_BackgroundColor = document.getElementsByName('BackgroundColor')[0],
    textbox_FontSize = document.getElementsByName('FontSize')[0],

    badge_back = document.getElementsByName('badge_back')[0]

};

//
//  https://stackoverflow.com/questions/7942398/nested-objects-in-javascript-best-practices
//

//Added 7/10/2019 thomas downes
var global_elementLastTouched = EL.moveable_text; //Default. 



