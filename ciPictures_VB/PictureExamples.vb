Option Explicit On
Option Strict On
''
''Added 6/13/2019 td  
''
Imports System.Drawing ''Added 6/13/2019 td  
Imports System.Windows.Forms ''added 6/13 td

Public Class PictureExamples
    ''
    ''Added 6/13/2019 td  
    ''
    Private Shared mod_images As List(Of Image)

    Public Shared Function GetExample() As Image  ''6/13/2019 td''As System.Drawing.Image
        ''
        ''Added 6/13/2019 td  
        ''
        Static s_intCallIndex As Integer
        Dim output_image As Image

        ''Moved here from below. 6/15/2019
        If (mod_images Is Nothing) Then mod_images = GetListOfImages()

        ''See bottom.''s_intCallIndex += 1
        If (s_intCallIndex >= mod_images.Count) Then s_intCallIndex = 0

        ''Moved up. 6/15 td ''If (mod_images Is Nothing) Then mod_images = GetListOfImages()

        output_image = mod_images(s_intCallIndex)

ExitHandler:

        s_intCallIndex += 1

        ''6/17/2019 td''Return mod_images(s_intCallIndex)
        Return output_image

        ''6/17 td''ExitHandler:
        ''6/17 td''        s_intCallIndex += 1

    End Function

    Private Shared Function GetListOfImages() As List(Of Image)
        ''
        ''Added 6/13/2019 thomas downes 
        ''
        Dim strPathToFolderWithPics As String
        Dim all_Jpegs As IEnumerable(Of System.IO.FileInfo)
        Dim picture_box As New System.Windows.Forms.PictureBox
        Dim output_list = New List(Of Image)

        ''6/16/2019 td''strPathToFolderWithPics = My.Application.Info.DirectoryPath & "\PictureExamples"
        ''6/22/2019 td''strPathToFolderWithPics = "C:\Users\Jane\source\repos\ciBadgeForWeb\ciPictures_VB\PictureExamples"
        strPathToFolderWithPics = "C:\CI Solutions\CI Badge Web\ciPictures_VB\PictureExamples"

        all_Jpegs = (New System.IO.DirectoryInfo(strPathToFolderWithPics)).EnumerateFiles()

        For Each each_file As System.IO.FileInfo In all_Jpegs

            ''With picture_box
            ''    .ImageLocation = each_file.FullName
            ''    .Visible = True
            ''    ''6/16/2019 td''.Refresh()
            ''    .Load()
            ''    If (.Image IsNot Nothing) Then output_list.Add(.Image)
            ''End With

            Dim each_image As Image ''Added 6/16/2019 Thomas DOWNES  

            each_image = (New Bitmap(each_file.FullName))
            output_list.Add(each_image)

        Next each_file

        Return output_list

    End Function ''End of "Private Shared Function GetListOfImages() As List(Of Image)"

End Class  ''End of "Public Class PictureExamples"




