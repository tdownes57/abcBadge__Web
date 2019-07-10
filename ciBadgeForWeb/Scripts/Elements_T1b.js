
//
//Added 7/10/2019 thomas downes
//

//dragElement(moveable_text);
//dragElement_T99(moveable_text);
//dragElement_T99_T1(moveable_text);
//dragElement_T1(moveable_text);

T1_dragElement(T1.moveable_text);

var T1_intPosTop = 20;
var T1_intPosLeft = 20;

//
//Added 7/10/2019 thomas downes
//
//T1_moveable_text.offsetTop = document.getElementsByName('T1.TopEdgePositionPixels')[0].value; // = intTopEdge;
//T1_moveable_text.offsetLeft = document.getElementsByName('T1.LeftEdgePositionPixels')[0].value; // = intLeftEdge;  

T1.moveable_text.offsetTop = T1.textbox_TopEdge.value; // = intTopEdge;
T1.moveable_text.offsetLeft = T1.textbox_LeftEdge.value; // = intLeftEdge;  

//
//Added 6/26/2019 thomas downes
//
//moveable_text.offsetLeft = textbox_LeftEdge.value;
//moveable_text.offsetTop = textbox_TopEdge.value;

T1_intPosLeft = (T1.badge_back.offsetLeft + Number(T1.textbox_LeftEdge.value));
T1.moveable_text.style.left = (T1_intPosLeft) + "px";

T1_intPosTop = (T1.badge_back.offsetTop + Number(T1.textbox_TopEdge.value));
T1.moveable_text.style.top = (T1_intPosTop) + "px";

//Added 6/28/2019 td
T1.moveable_text.style.height = (T1.textbox_HeightPixels.value) + "px";
T1.moveable_text.style.width = (T1.textbox_WidthLengthPixels.value) + "px";
T1.moveable_text.style.backgroundColor = (T1.textbox_BackgroundColor.value);

//dragElement(document.getElementById("id__mydivheader2"));
//dragElement(document.getElementById("id__mydivheader3"));
//dragElement(document.getElementById("id__mydivheader4"));
//dragElement(document.getElementById("id__mydivheader5"));

var T1_curr_heightButton = 100;
T1_curr_heightButton = 10;
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

