Imports System.IO



Module mMain

    Public AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory() & IIf(Right(System.AppDomain.CurrentDomain.BaseDirectory(), 1) = "\", "", "\")



    Public Sub DownloadFile(ByVal _URL As String, ByVal _SaveAs As String)
        Try
            Dim _WebClient As New System.Net.WebClient()
            ' Downloads the resource with the specified URI to a local file.
            _WebClient.DownloadFile(_URL, _SaveAs)
        Catch _Exception As Exception
            ' Error

            ' Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try
    End Sub

End Module
