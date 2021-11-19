using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
// Anonymous Types 
//
// https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
//
namespace ciBadgeForWeb.Models
{
    public class Anonymous_Type_Tutorial
    {
        //
        // Anonymous Types 
        //
        // https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
        //
        //
        //  See file \Views\Fields\Simple.cshtml, and/or search the project for "new {".
        //
        //    <td>
        //       @*@Html.ActionLink("Edit", "Edit", new { id = item.FieldIndex })*@
        //            <!--                                                  -->
        //            <!-- Anonymous Type.... new { id = item.FieldIndex }  -->
        //            <!--                                                  -->
        //            @Html.ActionLink("Edit This Field", "Edit",
        //                new { id = item.FieldIndex, isAnonymousType = true })
        //
        //
        public Anonymous_Type_Tutorial()
        {
            //
            // https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
            //
            //Example: Access Anonymous Type
            //
            //  [Below, I added "isAnonymousType = true" just to be a smart-aleck.)
            //
            var student = new { Id = 1, FirstName = "James", LastName = "Bond", isAnonymousType = true };
            
            Console.WriteLine(student.Id); //output: 1
            Console.WriteLine(student.FirstName); //output: James
            Console.WriteLine(student.LastName); //output: Bond

            //student.Id = 2;//Error: cannot chage value
            //student.FirstName = "Steve";//Error: cannot chage value

            //
            //  [Below, I added "isAnonymousType = true" just to be a smart-aleck.)
            //
            var edit_info = new { id = 5, isAnonymousType = true };
            Console.WriteLine(edit_info.id); //output: 1


        }



    }
}