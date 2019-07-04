
//
//   How to create Better Tooltips with plain JavaScript and CSS
//
//   http://michaelsoriano.com/better-tooltips-with-plain-javascript-css/
//


//var links = document.links;
//for (var i = 0; i & lt; links.length; i++) {
//    var a = links[i];
//    if (a.title !== '') {
//        a.addEventListener('mouseover', createTip);
//        a.addEventListener('mouseout', cancelTip);
//    }
//    //  console.log(a);
//} 


function createTip_ByPercentage(ev) {
    var title = this.title;
    var my_decimal = 0.15;
    var my_percent = 15;
    this.title = 'Increase by ' + my_percent + '%';
    this.setAttribute("tooltip", title);
}

 

function createTip(ev) {
    var title = this.title;
    this.title = '';
    this.setAttribute("tooltip", title);
}

function cancelTip(ev) {
    var title = this.getAttribute("tooltip");
    this.title = title;
    this.removeAttribute("tooltip");
}
