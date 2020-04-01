
//
// Basic Meme App  
//
// Homework Assignment for Alexandra Do's Javascript class 
//    (Spring 2020, Orange Coast College)
//
// By far, most (say, 95%) credit for the code below belongs to 
//     Professor Alexandra Do.  
//   ---3/14/2020 Thomas Downes  
//
//"use strict";

// --------------------------------------------------------------
// SETUP. DO NOT CHANGE THESE LINES. SEE EXERCISE SECTION BELOW.
// --------------------------------------------------------------
// An array of URLs to the memes.
var memeUrls = [
    "https://res.cloudinary.com/baolocdo/image/upload/v1494196596/meme1_ldhisb.jpg",
    "https://res.cloudinary.com/baolocdo/image/upload/v1494196602/meme2_fcgumx.jpg",
    "https://res.cloudinary.com/baolocdo/image/upload/v1494196604/meme3_r4ke3j.jpg"
];
var memeTitles = ["I have no idea why", "Welcome mat", "Happiness"];
class Meme {
    // Constructs the meme with the provided URL.
    constructor(memeID, url, title) {
        this._url = url;
        // The numer of likes.
        this._likeNumber = 0;
        // The title of the meme.
        this._title = title;
        // The ID of the meme.
        this._id = memeID;
    }
    // Returns the ID of the meme.
    get ID() {
        return this._id;
    }
    // Returns the URL of the meme.
    get URL() {
        return this._url;
    }
    // Returns the number of likes.
    get likeNumber() {
        return this._likeNumber;
    }
    // Update the like number.
    set likeNumber(likeNumber) {
        this._likeNumber = likeNumber;
    }
    // Returns the title of the meme.
    get title() {
        return this._title;
    }
}
// --------------------------------------------------------------
// END SETUP
// --------------------------------------------------------------
// --------------------------------------------------------------
// EXERCISE: COMPLETE THE TODO'S BELOW
// --------------------------------------------------------------
class MemeController {
    constructor(memes, currentMemeID) {

        // "use strict"; //Added 3/14/2020 td 

        this._memes = memes;
        this._currentMeme = memes[currentMemeID];
        this.setCurrentMeme(memes[currentMemeID]);
        // Use self to capture the this object.
        // Otherwise, this will refer to the button object, not the controlle object! This is why knowing Scope & Closure is important!
        var self = this;

        // Set the handler for the Next button. It will go to the next meme.
        if ($("#next-image-id").length) {
            $("#next-image-id").click(function () {
                // If you use 'this' inside this function, it refers to the button "Next", not
                // the MemeController instance when this function is called as the button is clicked. 
                // Use 'self' instead because it already captures the MemeController instance before.
                self.nextMeme();
            });
        }
        else {
            // Added 3/14/2020 thomas downes
            //throw "Click function has not been assigned!";
            alert ("Click function has not been assigned!");
        }
            

        // ATTEMPTING: Add handler for previous meme. The element is the button 
        // with the ID "#prev-image-id". See the example above.
        // Set the handler for the Prev button. It will go to the previous meme.
        if ($("#prev-image-id").length) {
            $("#prev-image-id").click(function () {
                // Use 'self' instead because it already captures the MemeController instance before.
                self.previousMeme();
            });
        }
        else {
            // Added 3/14/2020 thomas downes
            //throw "Click function has not been assigned!";
            alert("Click function has not been assigned!");
        }

        // ATTEMPTING: Add handler for clicking Like button. The element is the button
        // with the ID "#like-button-id". See the example above.
        // Set the handler for the Like button. It will increment the Likes.
        if ($("#like-button-id").length) {
            $("#like-button-id").click(function () {
                // Use 'self' instead because it already captures the MemeController instance before.
                self.like();
            });
        }
        else {
            // Added 3/14/2020 thomas downes
            //throw "Click function has not been assigned!";
            alert("Click function has not been assigned!");
        }

        // ATTEMPTED: Add handler for clicking dislike button. The element is the button
        // with the ID "#dislike-button-id". See the example above.
        if ($("#dislike-button-id").length) {
            $("#dislike-button-id").click(function () {
                // Use 'self' instead because it already captures the MemeController instance before.
                self.dislike();
            });
        }
        else {
            // Added 3/14/2020 thomas downes
            //throw "Click function has not been assigned!";
            alert("Click function has not been assigned!");
        }

    }
    // Set the current meme to the provided meme, and update the image to the meme's img
    // source, its title and the like number.
    setCurrentMeme(meme) {
        this._currentMeme = meme;
        // Get the element with the ID "#meme-image-id" and replace the
        // source with the URL of the current meme.
        $("#meme-image-id").attr("src", meme.URL);
        // ATTEMPTING: Set the title of the current meme.
        $("#meme-title-id").text(meme.title);


        // Call updateLikeNumberElement with the current meme's likeNumber.
        this.updateLikeNumberElement(this._currentMeme.likeNumber);

    }


    // Updates the Like Number DOM element with the provided likeNumber.
    updateLikeNumberElement(likeNumber) {
        // ATTEMPTING: Set the number of likes by updating the text of the element with the ID
        // "#meme-likes-id".
        //-----------$("#meme-likes-id").text(meme.likeNumber());
        $("#meme-likes-id").text(likeNumber);
    }

    // Sets the next meme.
    nextMeme() {
        // The next meme ID. It will go back to the first one if the
        // current one is the last one in the list.
        var nextMemeID = (this._currentMeme.ID + 1) % this._memes.length;
        var nextMeme = this._memes[nextMemeID];
        if (nextMeme) {
            this.setCurrentMeme(nextMeme);
        }
        else {
            alert("this doesn't have a non-null meme");
        }
    }

    // Sets the previous meme.
    previousMeme() {
        // ATTEMPTING: Complete this function. It should be similar to the nextMeme() function above.
        //var prevMemeID = 2; // (this._currentMeme.ID - 1) % this._memes.length;
        var prevMemeID = (this._currentMeme.ID - 1) % this._memes.length;
        var prevMeme = this._memes[prevMemeID];
        if (prevMeme) {
            this.setCurrentMeme(prevMeme);
        }
        else {
            alert("this doesn't have a non-null meme");
        }
    }
    // Updates the likeNumber of the current meme when it is liked.
    like() {
        // Update the like number.
        this._currentMeme.likeNumber++;
        var likeNumber = this._currentMeme.likeNumber;
        // ATTEMPTING: update the like number of the "#meme-likes-id" element.
        this.updateLikeNumberElement(likeNumber);
    }
    // Updates the dislikeNumber of the current meme when it is disliked.
    dislike() {
        // ATTEMPTING: Complete this function. It should be similar to the like() function above.
        // Decrement the like number.
        this._currentMeme.likeNumber--;
        var likeNumber = this._currentMeme.likeNumber;
        // ATTEMPTING: update the like number of the "#meme-likes-id" element.
        this.updateLikeNumberElement(likeNumber);
    }
}
// --------------------------------------------------------------
// END EXERCISE
// --------------------------------------------------------------
// --------------------------------------------------------------
// NOTE: DO NOT CHANGE THE LINES BELOW!!!
// --------------------------------------------------------------
// Set up memes.
var memes = [];
for (var i = 0; i < memeUrls.length; i++) {
    // Create a new meme with the ID is i, meme URL and meme title.
    var aMeme = new Meme(i, memeUrls[i], memeTitles[i]);
    memes.push(aMeme);
    console.log(aMeme);
}
// SET UP THE CONTROLLER
var memeCtrl = new MemeController(memes, 0);


