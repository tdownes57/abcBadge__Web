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

// Completed by TCD: COMMENT OUT THESE LINES 2-9 BELOW.
// An array of URLs to the memes.
//var memeUrls = [
//  "http://res.cloudinary.com/baolocdo/image/upload/v1494196596/meme1_ldhisb.jpg",
//  "http://res.cloudinary.com/baolocdo/image/upload/v1494196602/meme2_fcgumx.jpg",
//  "http://res.cloudinary.com/baolocdo/image/upload/v1494196604/meme3_r4ke3j.jpg"
//];
//
//var memeTitles = ["I have no idea why", "Welcome mat", "Happiness"];

/***********************************************************************
          DO NOT CHANGE ANYTHING BETWEEN THESE LINE BELOW!!!
************************************************************************/
class Meme {
    // Constructs the meme with the provided URL.
    constructor(memeID, url, title, likeNumber = 0) {
        this._url = url;

        // The numer of likes.
        this._likeNumber = likeNumber;

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

class MemeController {
    constructor(memes, currentMemeID) {
        this._memes = memes;
        this._currentMeme = memes[currentMemeID];

        this.setCurrentMeme(memes[currentMemeID]);

        // Set the handler for the Next button. It will go to the next meme.
        // Use self to capture the this object.
        // Otherwise, this will refer to the button object, not the controlle 
        //   object! This is why knowing Scope & Closure is important!
        //
        self = this;
        $("#next-image-id").click(function () {
            self.nextMeme();
        });
        $("#prev-image-id").click(function () {
            self.previousMeme();
        });
        $("#like-button-id").click(function () {
            self.like();
        });
        $("#dislike-button-id").click(function () {
            self.dislike();
        });
    }

    setCurrentMeme(meme) {
        this._currentMeme = meme;

        // Get the element with the ID "meme-image-id" and replace the
        // source with the URL of the current meme.
        $("#meme-image-id").attr("src", meme.URL);

        // UNTESTED: Set the title of the current meme.
        $("#meme-title-id").text(meme.title);

        // Call updateLikeNumberElement with the current meme's likeNumber.
        this.updateLikeNumberElement(this._currentMeme.likeNumber);
    }

    updateLikeNumberElement(likeNumber) {
        $("#meme-likes-id").text(likeNumber + " Likes");
    }

    // Set the next meme.
    nextMeme() {
        // The next meme ID. It will go back to the first one if the
        // current one is the last one in the list.
        var nextMemeID = (this._currentMeme.ID + 1) % this._memes.length;
        var nextMeme = this._memes[nextMemeID];
        if (nextMeme) {
            this.setCurrentMeme(nextMeme);
        }
        else {
            // Added 3/31/2020 thomas downes  
            alert("this doesn't have a non-null meme object");
        }

    }

    // Set the previous meme.
    previousMeme() {
        // The previous meme ID. It will go back to the last one if the
        // current one is the first one in the list.

        //  var nextMemeID = (this._currentMeme.ID - 1) % this._memes.length;
        //console.log(nextMemeID);
        //var nextMeme = this._memes[nextMemeID];
        //
        //if (nextMeme) {
        //  this.setCurrentMeme(nextMeme);
        //  }

        var prevMemeID = (this._currentMeme.ID - 1) % this._memes.length;
        var prevMeme = this._memes[prevMemeID];
        if (prevMeme) {
            this.setCurrentMeme(prevMeme);
        }
        else {
            alert("this doesn't have a non-null meme");
        }

    }

    like() {
        // Update the like number.
        this._currentMeme.likeNumber++;
        var likeNumber = this._currentMeme.likeNumber;
        // TODO: update the like number of the "#meme-likes-id" element.
        this.updateLikeNumberElement(likeNumber);
    }

    dislike() {
        // Update the like number.
        this._currentMeme.likeNumber--;
        var likeNumber = this._currentMeme.likeNumber;
        // TODO: update the like number of the "#meme-likes-id" element.
        this.updateLikeNumberElement(likeNumber);
    }
}

// The memeCtrl.
var memeCtrl;

// Set up memes.
var memes = [];

/***********************************************************************
       END OF UNEDITABLE CODE. YOU CAN CHANGE THE CODE BELOW THIS.
************************************************************************/

var i_memeIndex = 0;

function ProcessData(data) {

    // Iterate through the data. The data is a JSON object that has dictionary
    // of key of <a string> and value of <meme information>.
    // As before, the memeID must be an integer starting from 0 and incremented
    // by 1 for each meme in the array.
    //
    for (var id in data) {
        // UNTESTED: 
        //   Get the meme information out of the object.
        //
        //var meme = {}; // Replace this with the correct object from "data".
        //var meme = id;
        //var meme = id;  //data[id];
        var meme = data[id]; // "meme1", "meme2", "meme3"  

        //i_memeIndex++;  

        // UNTESTED: get the URL. It has the key "url" in the JSON.
        //memeURL = meme['']; // Replace this with correct object from the correct key.
        memeURL = meme["url"];

        // UNTESTED: get the title. It has the key "title" in the JSON.
        //memeTitle = {}; // Replace this with correct object from the correct key from "meme". 
        memeTitle = meme["title"];

        // UNTESTED: get the like count. It has the key "like_count" in the JSON.
        //memeLikeNumber = {}; // Replace this with correct object from the correct key from meme.
        memeLikeNumber = meme["like_count"];

        // UNTESTED: Create a new Meme object with the title, URL and like number. Look at the
        //     constructor of the Meme class above for correct order of argument.
        // var aMeme = {}; // Replace this line with correct object.
        //memeID = meme.id;

        //aMeme = Meme(memeID, memeURL, memeTitle, memeLikeNumber);
        aMeme = new Meme(i_memeIndex, memeURL, memeTitle, memeLikeNumber);

        // UNTESTED: Add the new Meme object to the list of memes "memes".
        memes.push(aMeme);

        i_memeIndex += 1; //Added 3/31/2020 

    }
}

// Completed by TCD: COMMENT OUT THESE LINES 147-152 BELOW
//for (var i = 0; i < memeUrls.length; i++) {
//  // Create a new meme with the ID is i, meme URL and meme title.
//  memes.push(new Meme(i, memeUrls[i], memeTitles[i]));
//}
//memeCtrl = new MemeController(memes, 0)

// In progress by TCD: FINISH THE AJAX GET REQUEST BELOW.
$.ajax({
    // Done but not tested: 
    //    Add correct URL.
    url: "https://javascriptclass-22d93.firebaseio.com/memes.json",

    success: function (data) {
        // Print out the data to console to see the structure of the response.
        // Use Console or open the Inspector to see it.
        console.log(data);

        //Encapsulated 3/31/2020 thomas downes
        ProcessData(data);

        // Set up the controller here because this function is only called
        // after the response is received. Since we only create the controller after
        // processing all the information, we set up the controller here.
        // SET UP THE CONTROLLER
        memeCtrl = new MemeController(memes, 0);
    }

});

