
//
//Adjustment_Click.js
//
//    This is referenced by Adjustment_Master.js  
//
//     ---Added 7/14/2019 Thomas C. Downes  
//
//  Populate the numeric & string properties of the object which will allow
//  the Adjustment_Master.js script to implement the modifications specified 
//  in the object. ---7/14/2019 thomas d.
//
//   W = Width
//   H = Height
//   C = Color  
//

var adjustmentWHC = {
    adjustmentTypeWHC = "_",   /* W = Width, H = Height C = Color */          
    newColorRBG = "#000000",
    newWidth = 0,   
    newHeight= 0
};

var


//
//The following function is called by Adjustment_Master.js, 
//    in order to populate object var. adjustmentWHC.  
//
function AdjustmentWHC_Click_V101(par_inputInfo) {
    //
    //  Version 101   <<< Version ties to the version of the 
    //        corresponding graphic, which is
    //        Images\AdjustWHColor_V101.jpg.  
    //
    //
    currentTitleOfGraphic = "AdjustWHColor_V101.jpg";
    currentVersionOfGraphic = "V101";
    mspaintPixelWidthOfGraphic = 999;  // not really
    currentWidthOfGraphicInBrowser = par_inputInfo.currentWidthOfGraphic;
    currentScaling = (currentWidthOfGraphicInBrowser / mspaintPixelWidthOfGraphic);





    //
    //Return value:  adjustmentWHC  
    //

}











