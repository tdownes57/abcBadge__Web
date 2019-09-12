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
    Private Shared mod_images_Jpegs As List(Of Image)
    Private Shared mod_images_PNGs As List(Of Image) ''Added 7/8/2019 td

    Private Shared mod_imageForNoPicture As Image ''Added 7/8/2019 td 
    Private Shared mod_imageSusanSample As Image ''Added 7/10/2019 td 

    Public Shared PathToFolderOfImages As String = "" ''Added 8/20/2019 td  

    Public Shared Function GetImageByIndex(par_indexImage As Integer,
                                           Optional pref_errMessage As String = "") As Image
        ''
        ''Added 8/13/2019  
        ''
        ''8/20/2019 td''If (mod_images_Jpegs Is Nothing) Then mod_images_Jpegs = GetListOfImages_Jpegs()

        If (mod_images_Jpegs Is Nothing) Then mod_images_Jpegs = GetListOfImages_Jpegs(PathToFolderOfImages)

        Return mod_images_Jpegs(par_indexImage)

    End Function ''End of "Public Shared Function GetImageByIndex() As Image"


    Public Shared Function GetExample() As Image
        ''
        ''Added 7/9/2019  
        ''
        ''8/20/2019 td''Return GetExample_Jpeg()
        Return GetExample_Jpeg(PathToFolderOfImages)

    End Function ''End of "Public Shared Function GetExample() As Image"

    Public Shared Function GetExample_Jpeg(par_pathToJpegsFolder As String) As Image  ''6/13/2019 td''As System.Drawing.Image
        ''8/20/2019 td'' Public Shared Function GetExample_Jpeg(par_pathToJpegsFolder As String) As Image
        ''7/9/2019 td''Public Shared Function GetExample() As Image
        ''
        ''Added 6/13/2019 td  
        ''
        Static s_intCallIndex As Integer
        Dim output_image As Image

        ''Moved here from below. 6/15/2019
        ''7/8/2019 td''If (mod_images_Jpegs Is Nothing) Then mod_images_Jpegs = GetListOfImages()
        '' 8/20/2019 td''If (mod_images_Jpegs Is Nothing) Then mod_images_Jpegs = GetListOfImages_Jpegs()
        If (mod_images_Jpegs Is Nothing) Then mod_images_Jpegs = GetListOfImages_Jpegs(par_pathToJpegsFolder)

        ''See bottom.''s_intCallIndex += 1
        If (s_intCallIndex >= mod_images_Jpegs.Count) Then s_intCallIndex = 0

        ''Moved up. 6/15 td ''If (mod_images Is Nothing) Then mod_images = GetListOfImages()

        output_image = mod_images_Jpegs(s_intCallIndex)

ExitHandler:

        s_intCallIndex += 1

        ''6/17/2019 td''Return mod_images(s_intCallIndex)
        Return output_image

        ''6/17 td''ExitHandler:
        ''6/17 td''        s_intCallIndex += 1

    End Function ''End of "Public Shared Function GetExample_Jpeg() As Image"

    Public Shared Function GetExample_PNG() As Image
        ''
        ''Added 7/09/2019 td  
        ''
        Static s_intCallIndex As Integer
        Dim output_image As Image

        If (mod_images_PNGs Is Nothing) Then mod_images_PNGs = GetListOfImages_PNGs()

        If (s_intCallIndex >= mod_images_PNGs.Count) Then s_intCallIndex = 0

        output_image = mod_images_Jpegs(s_intCallIndex)

ExitHandler:
        s_intCallIndex += 1
        Return output_image
    End Function ''End of "Public Shared Function GetExample_PNG() As Image"

    Public Shared Function GetImageWithNoPicture() As Image
        ''
        ''Added 7/8/2019 thomas downes 
        '' 
        If (mod_images_Jpegs Is Nothing) Then
            ''
            ''The following function looks for the image "NoPic.jpg".  ---7/10/2019 td
            ''
            ''8/20/2019 td''mod_images_Jpegs = GetListOfImages_Jpegs()
            mod_images_Jpegs = GetListOfImages_Jpegs(PathToFolderOfImages)

        End If ''End of "If (mod_images_Jpegs Is Nothing) Then"

        Return mod_imageForNoPicture

    End Function ''End of "Public Shared Function GetImageWithNoPicture() As Image"

    Public Shared Function GetImageSusanSample() As Image
        ''
        ''Added 7/10/2019 thomas downes 
        '' 
        If (mod_images_Jpegs Is Nothing) Then
            ''
            ''The following function looks for the image "Sample.jpg".  ---7/10/2019 td
            ''
            '' 8/20/2019 td''mod_images_Jpegs = GetListOfImages_Jpegs()
            mod_images_Jpegs = GetListOfImages_Jpegs(PathToFolderOfImages)

        End If ''End of "If (mod_images_Jpegs Is Nothing) Then"

        Return mod_imageSusanSample

    End Function ''End of "Public Shared Function GetImageSusanSample() As Image"

    Private Shared Function GetListOfImages_Jpegs(par_pathToJpegsFolder As String) As List(Of Image)
        ''  8/20 td'' Private Shared Function GetListOfImages_Jpegs() As List(Of Image) 
        '' 7/8 td''Private Shared Function GetListOfImages() As List(Of Image)
        '' 
        ''Added 6/13/2019 thomas downes 
        ''
        Dim strPathToFolderWithPics As String
        Dim all_Jpegs As IEnumerable(Of System.IO.FileInfo) = Nothing
        Dim picture_box As New System.Windows.Forms.PictureBox
        Dim output_list = New List(Of Image)

        ''6/16/2019 td''strPathToFolderWithPics = My.Application.Info.DirectoryPath & "\PictureExamples"
        ''6/22/2019 td''strPathToFolderWithPics = "C:\Users\Jane\source\repos\ciBadgeForWeb\ciPictures_VB\PictureExamples"
        ''#1 8/20/2019 td''strPathToFolderWithPics = "C:\CI Solutions\CI Badge Web\ciPictures_VB\PictureExamples"
        '' #2 8/20/2019 td''strPathToFolderWithPics = (My.Application.Info.DirectoryPath & "\Images\PictureExamples")
        strPathToFolderWithPics = par_pathToJpegsFolder ''(My.Application.Info.DirectoryPath & "\Images\PictureExamples")

        For intTry As Integer = 1 To 2

            '' 7/8/2019 td''all_Jpegs = (New System.IO.DirectoryInfo(strPathToFolderWithPics)).EnumerateFiles()
            If (intTry = 1) Then all_Jpegs = (New System.IO.DirectoryInfo(strPathToFolderWithPics)).EnumerateFiles("*.jpg")
            If (intTry = 2) Then all_Jpegs = (New System.IO.DirectoryInfo(strPathToFolderWithPics)).EnumerateFiles("*.jpeg")

            For Each each_file As System.IO.FileInfo In all_Jpegs

                ''Added 7/8/2019 thomas downes
                If (each_file.Name.StartsWith("NoPic")) Then
                    mod_imageForNoPicture = (New Bitmap(each_file.FullName))
                    Continue For
                End If ''End of "If (each_file.Name.StartsWith("NoPic")) Then"

                ''Added 7/10/2019 thomas downes
                If (each_file.Name.StartsWith("Sample")) Then
                    mod_imageSusanSample = (New Bitmap(each_file.FullName))
                    Continue For
                End If ''End of "If (each_file.Name.StartsWith("Sample")) Then"

                ''7/8/2019 td''With picture_box
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

        Next intTry

        Return output_list

    End Function ''End of "Private Shared Function GetListOfImages_Jpegs() As List(Of Image)"

    Private Shared Function GetListOfImages_PNGs() As List(Of Image)
        '' 
        ''Added 7/08/2019 thomas downes 
        ''
        Dim strPathToFolderWithPics As String
        Dim all_PNGs As IEnumerable(Of System.IO.FileInfo) = Nothing
        Dim picture_box As New System.Windows.Forms.PictureBox
        Dim output_list = New List(Of Image)

        strPathToFolderWithPics = "C:\CI Solutions\CI Badge Web\ciPictures_VB\PictureExamples"

        all_PNGs = (New System.IO.DirectoryInfo(strPathToFolderWithPics)).EnumerateFiles("*.png")

        For Each each_file As System.IO.FileInfo In all_PNGs

            Dim each_image As Image ''Added 6/16/2019 Thomas DOWNES  
            each_image = (New Bitmap(each_file.FullName))
            output_list.Add(each_image)

        Next each_file

        Return output_list

    End Function ''End of "Private Shared Function GetListOfImages_PNGs() As List(Of Image)"


End Class  ''End of "Public Class PictureExamples"




