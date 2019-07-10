
//
//Added 7/10/2019 thomas downes
//

//dragElement(moveable_text);
//dragElement_T99(moveable_text);
//dragElement_T99_T2(moveable_text);
//dragElement_T2(moveable_text);

T2_dragElement(T2.moveable_text);

var T2_intPosTop = 20;
var T2_intPosLeft = 20;

//
//Added 7/10/2019 thomas downes
//
//T2_moveable_text.offsetTop = document.getElementsByName('T2.TopEdgePositionPixels')[0].value; // = intTopEdge;
//T2_moveable_text.offsetLeft = document.getElementsByName('T2.LeftEdgePositionPixels')[0].value; // = intLeftEdge;  

T2.moveable_text.offsetTop = T2.textbox_TopEdge.value; // = intTopEdge;
T2.moveable_text.offsetLeft = T2.textbox_LeftEdge.value; // = intLeftEdge;  

//
//Added 6/26/2019 thomas downes
//
//moveable_text.offsetLeft = textbox_LeftEdge.value;
//moveable_text.offsetTop = textbox_TopEdge.value;

T2_intPosLeft = (T2.badge_back.offsetLeft + Number(T2.textbox_LeftEdge.value));
T2.moveable_text.style.left = (T2_intPosLeft) + "px";

T2_intPosTop = (T2.badge_back.offsetTop + Number(T2.textbox_TopEdge.value));
T2.moveable_text.style.top = (T2_intPosTop) + "px";

//Added 6/28/2019 td
T2.moveable_text.style.height = (T2.textbox_HeightPixels.value) + "px";
T2.moveable_text.style.width = (T2.textbox_WidthLengthPixels.value) + "px";
T2.moveable_text.style.backgroundColor = (T2.textbox_BackgroundColor.value);

//dragElement(document.getElementById("id__mydivheader2"));
//dragElement(document.getElementById("id__mydivheader3"));
//dragElement(document.getElementById("id__mydivheader4"));
//dragElement(document.getElementById("id__mydivheader5"));

var T2_curr_heightButton = 100;
T2_curr_heightButton = 10;
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

