
//
//Added 7/10/2019 thomas downes
//

//dragElement(moveable_text);
//dragElement_T99(moveable_text);
//dragElement_T99_T3(moveable_text);
//dragElement_T3(moveable_text);

T3_dragElement(T3.moveable_text);

var T3_intPosTop = 20;
var T3_intPosLeft = 20;

//
//Added 7/10/2019 thomas downes
//
//T3_moveable_text.offsetTop = document.getElementsByName('T3.TopEdgePositionPixels')[0].value; // = intTopEdge;
//T3_moveable_text.offsetLeft = document.getElementsByName('T3.LeftEdgePositionPixels')[0].value; // = intLeftEdge;  

T3.moveable_text.offsetTop = T3.textbox_TopEdge.value; // = intTopEdge;
T3.moveable_text.offsetLeft = T3.textbox_LeftEdge.value; // = intLeftEdge;  

//
//Added 6/26/2019 thomas downes
//
//moveable_text.offsetLeft = textbox_LeftEdge.value;
//moveable_text.offsetTop = textbox_TopEdge.value;

T3_intPosLeft = (T3.badge_back.offsetLeft + Number(T3.textbox_LeftEdge.value));
T3.moveable_text.style.left = (T3_intPosLeft) + "px";

T3_intPosTop = (T3.badge_back.offsetTop + Number(T3.textbox_TopEdge.value));
T3.moveable_text.style.top = (T3_intPosTop) + "px";

//Added 6/28/2019 td
T3.moveable_text.style.height = (T3.textbox_HeightPixels.value) + "px";
T3.moveable_text.style.width = (T3.textbox_WidthLengthPixels.value) + "px";
T3.moveable_text.style.backgroundColor = (T3.textbox_BackgroundColor.value);

//dragElement(document.getElementById("id__mydivheader2"));
//dragElement(document.getElementById("id__mydivheader3"));
//dragElement(document.getElementById("id__mydivheader4"));
//dragElement(document.getElementById("id__mydivheader5"));

var T3_curr_heightButton = 100;
T3_curr_heightButton = 10;
//var curr_widthButton = 100;

//function heightButtonMore() {
//    //Added 5/26/2019 td
//    curr_heightButton = (curr_heightButton + 5);
//    return (curr_heightButton);
//}

//function heightButtonLess() {
//    //Added 5/26/2019 td
//    curr_heightButton = (curr_heightButton - 5);
//    return (curr_heightButton);
//}

//function widthButtonMore() {
//    //Added 5/26/2019 td
//    curr_widthButton = (curr_widthButton + 5);
//    return (curr_widthButton);
//}

//function widthButtonLess() {
//    //Added 5/26/2019 td
//    curr_widthButton = (curr_widthButton - 5);
//    return (curr_widthButton);
//}

