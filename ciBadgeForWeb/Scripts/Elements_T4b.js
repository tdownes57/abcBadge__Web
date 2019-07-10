
//
//Added 7/10/2019 thomas downes
//

//dragElement(moveable_text);
//dragElement_T99(moveable_text);
//dragElement_T99_T4(moveable_text);
//dragElement_T4(moveable_text);

T4_dragElement(T4.moveable_text);

var T4_intPosTop = 20;
var T4_intPosLeft = 20;

//
//Added 7/10/2019 thomas downes
//
//T4_moveable_text.offsetTop = document.getElementsByName('T4.TopEdgePositionPixels')[0].value; // = intTopEdge;
//T4_moveable_text.offsetLeft = document.getElementsByName('T4.LeftEdgePositionPixels')[0].value; // = intLeftEdge;  

T4.moveable_text.offsetTop = T4.textbox_TopEdge.value; // = intTopEdge;
T4.moveable_text.offsetLeft = T4.textbox_LeftEdge.value; // = intLeftEdge;  

//
//Added 6/26/2019 thomas downes
//
//moveable_text.offsetLeft = textbox_LeftEdge.value;
//moveable_text.offsetTop = textbox_TopEdge.value;

T4_intPosLeft = (T4.badge_back.offsetLeft + Number(T4.textbox_LeftEdge.value));
T4.moveable_text.style.left = (T4_intPosLeft) + "px";

T4_intPosTop = (T4.badge_back.offsetTop + Number(T4.textbox_TopEdge.value));
T4.moveable_text.style.top = (T4_intPosTop) + "px";

//Added 6/28/2019 td
T4.moveable_text.style.height = (T4.textbox_HeightPixels.value) + "px";
T4.moveable_text.style.width = (T4.textbox_WidthLengthPixels.value) + "px";
T4.moveable_text.style.backgroundColor = (T4.textbox_BackgroundColor.value);

//dragElement(document.getElementById("id__mydivheader2"));
//dragElement(document.getElementById("id__mydivheader3"));
//dragElement(document.getElementById("id__mydivheader4"));
//dragElement(document.getElementById("id__mydivheader5"));

var T4_curr_heightButton = 100;
T4_curr_heightButton = 10;
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

