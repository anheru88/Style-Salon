Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Module GlobalFunctions

    Public Function Byte2Image(ByVal ByteArr() As Byte) As Image
        '
        Dim ImageStream As MemoryStream
        Dim NewImage As Image

        Try
            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                NewImage = Image.FromStream(ImageStream)
            Else
                NewImage = Nothing
            End If
        Catch ex As Exception
            NewImage = Nothing
        End Try

        Return NewImage

    End Function

    Public Function Image2Byte(ByRef NewImage As Image) As Byte()
        '
        Dim ImageStream As MemoryStream
        Dim ByteArr As Byte()

        Try
            ReDim ByteArr(0)
            If NewImage IsNot Nothing Then
                ImageStream = New MemoryStream
                NewImage.Save(ImageStream, ImageFormat.Jpeg)
                ReDim ByteArr(CInt(ImageStream.Length - 1))
                ImageStream.Position = 0
                ImageStream.Read(ByteArr, 0, CInt(ImageStream.Length))
            End If
        Catch ex As Exception
            ByteArr = Nothing
        End Try

        Return ByteArr

    End Function

    Public Function testConnection() As SqlClient.SqlConnection

        Dim t_connection As New SqlClient.SqlConnection(vg_connectionString)
        Try
            t_connection.Open()
            Return t_connection
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Provides functions to capture the entire screen, or a particular window, and save it to a file.
    ''' </summary>

    Public Function MinutesToTime(ByVal value As Double) As String
        Dim t_seconds As Double = value / 60
        Return FormatDateTime(DateAdd("s", t_seconds, "00:00:00"), DateFormat.LongTime)
    End Function

    Public Class ScreenCapture

        ''' <summary>
        ''' Creates an Image object containing a screen shot of the entire desktop
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function CaptureScreen() As Image
            Return CaptureWindow(User32.GetDesktopWindow())
        End Function

        ''' <summary>
        ''' Creates an Image object containing a screen shot of a specific window
        ''' </summary>
        ''' <param name="handle">The handle to the window. (In windows forms, this is obtained by the Handle property)</param>
        ''' <returns></returns>
        Public Shared Function CaptureWindow(ByVal handle As IntPtr) As Image
            ' get te hDC of the target window
            Dim hdcSrc As IntPtr = User32.GetWindowDC(handle)
            ' get the size
            Dim windowRect As New User32.RECT()
            User32.GetWindowRect(handle, windowRect)

            Dim width As Integer = windowRect.right - windowRect.left
            Dim height As Integer = windowRect.bottom - windowRect.top

            ' create a device context we can copy to
            Dim hdcDest As IntPtr = GDI32.CreateCompatibleDC(hdcSrc)
            ' create a bitmap we can copy it to,
            ' using GetDeviceCaps to get the width/height
            Dim hBitmap As IntPtr = GDI32.CreateCompatibleBitmap(hdcSrc, width, height)
            ' select the bitmap object
            Dim hOld As IntPtr = GDI32.SelectObject(hdcDest, hBitmap)
            ' bitblt over
            GDI32.BitBlt(hdcDest, 1, 1, width, height, hdcSrc, _
             0, 0, GDI32.SRCCOPY)
            ' restore selection
            GDI32.SelectObject(hdcDest, hOld)
            ' clean up 
            GDI32.DeleteDC(hdcDest)
            User32.ReleaseDC(handle, hdcSrc)
            ' get a .NET image object for it
            Dim img As Image = Image.FromHbitmap(hBitmap)
            ' free up the Bitmap object
            GDI32.DeleteObject(hBitmap)
            Return img
        End Function

        Public Shared Function CaptureWindow2(ByVal handle As IntPtr) As Image
            ' get te hDC of the target window
            Dim hdcSrc As IntPtr = User32.GetWindowDC(handle)
            ' get the size
            Dim windowRect As New User32.RECT()
            User32.GetWindowRect(handle, windowRect)

            Dim width As Integer = windowRect.right - windowRect.left
            Dim height As Integer = windowRect.bottom - windowRect.top

            ' create a device context we can copy to
            Dim hdcDest As IntPtr = GDI32.CreateCompatibleDC(hdcSrc)
            ' create a bitmap we can copy it to,
            ' using GetDeviceCaps to get the width/height
            Dim hBitmap As IntPtr = GDI32.CreateCompatibleBitmap(hdcSrc, width, height)
            ' select the bitmap object
            Dim hOld As IntPtr = GDI32.SelectObject(hdcDest, hBitmap)
            ' bitblt over
            GDI32.BitBlt(hdcDest, 1, 1, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY)
            ' restore selection
            GDI32.SelectObject(hdcDest, hOld)
            ' clean up 
            GDI32.DeleteDC(hdcDest)
            User32.ReleaseDC(handle, hdcSrc)
            ' get a .NET image object for it
            Dim img As Image = Image.FromHbitmap(hBitmap)

            ' free up the Bitmap object
            GDI32.DeleteObject(hBitmap)
            Return img
        End Function

        ''' <summary>
        ''' Captures a screen shot of a specific window, and saves it to a file
        ''' </summary>
        ''' <param name="handle"></param>
        ''' <param name="filename"></param>
        ''' <param name="format"></param>
        Public Shared Sub CaptureWindowToFile(ByVal handle As IntPtr, ByVal filename As String, ByVal format As ImageFormat)
            Dim img As Image = CaptureWindow(handle)
            img.Save(filename, format)
        End Sub

        ''' <summary>
        ''' Captures a screen shot of the entire desktop, and saves it to a file
        ''' </summary>
        ''' <param name="filename"></param>
        ''' <param name="format"></param>
        Public Shared Sub CaptureScreenToFile(ByVal filename As String, ByVal format As ImageFormat)
            Dim img As Image = CaptureScreen()
            img.Save(filename, format)
        End Sub

        ''' <summary>
        ''' Helper class containing Gdi32 API functions
        ''' </summary>
        Private Class GDI32

            Public Const SRCCOPY As Integer = &HCC0020
            ' BitBlt dwRop parameter
            <DllImport("gdi32.dll")> _
            Public Shared Function BitBlt(ByVal hObject As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hObjectSource As IntPtr, _
    ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Boolean
            End Function
            <DllImport("gdi32.dll")> _
            Public Shared Function CreateCompatibleBitmap(ByVal hDC As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As IntPtr
            End Function
            <DllImport("gdi32.dll")> _
            Public Shared Function CreateCompatibleDC(ByVal hDC As IntPtr) As IntPtr
            End Function
            <DllImport("gdi32.dll")> _
            Public Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean
            End Function
            <DllImport("gdi32.dll")> _
            Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
            End Function
            <DllImport("gdi32.dll")> _
            Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
            End Function
        End Class

        ''' <summary>
        ''' Helper class containing User32 API functions
        ''' </summary>
        Private Class User32
            <StructLayout(LayoutKind.Sequential)> _
            Public Structure RECT
                Public left As Integer
                Public top As Integer
                Public right As Integer
                Public bottom As Integer
            End Structure
            <DllImport("user32.dll")> _
            Public Shared Function GetDesktopWindow() As IntPtr
            End Function
            <DllImport("user32.dll")> _
            Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
            End Function
            <DllImport("user32.dll")> _
            Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As IntPtr
            End Function
            <DllImport("user32.dll")> _
            Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef rect As RECT) As IntPtr
            End Function
        End Class

    End Class

End Module

Public Enum FormButtonType

    Save = 0
    Add = 1
    Search = 2
    Edit = 3
    Delete = 4

End Enum