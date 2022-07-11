Public Class ComRegDeploy

    Public Sub CtiRegistor()
        pathChk(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
        FileChk(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
    End Sub

    Private Sub pathChk(ByVal prgpath As String)
        If System.IO.Directory.Exists(prgpath & "\PowerCCSSoftPhone") Then
            '' 디렉토리가 없는 경우에는 생성한다.
        Else
            System.IO.Directory.CreateDirectory(prgpath & "\PowerCCSSoftPhone")
        End If
    End Sub

    Private Sub FileChk(ByVal prgpath As String)

        If System.IO.File.Exists(prgpath & "\PowerCCSSoftPhone" & "\libRDBClient.dll") Then
            '' 파일이 없는 경우 복사하고 등록한다.
        Else
            System.IO.File.Copy("CTI_DLL\libRDBClient.dll", prgpath & "\PowerCCSSoftPhone" & "\libRDBClient.dll")
        End If

        If System.IO.File.Exists(prgpath & "\PowerCCSSoftPhone" & "\libPowerCCSX.dll") Then
            '' 파일이 없는 경우 복사하고 등록한다.
        Else
            System.IO.File.Copy("CTI_DLL\libPowerCCSX.dll", prgpath & "\PowerCCSSoftPhone" & "\libPowerCCSX.dll")
        End If

        If System.IO.File.Exists(prgpath & "\PowerCCSSoftPhone" & "\libPowerCCSClient.dll") Then
            '' 파일이 없는 경우 복사하고 등록한다.
        Else
            System.IO.File.Copy("CTI_DLL\libPowerCCSClient.dll", prgpath & "\PowerCCSSoftPhone" & "\libPowerCCSClient.dll")
        End If

        If System.IO.File.Exists(prgpath & "\PowerCCSSoftPhone" & "\PowerCCSX.ocx") Then
            '' 파일이 없는 경우 복사하고 등록한다.
        Else
            System.IO.File.Copy("CTI_DLL\PowerCCSX.ocx", prgpath & "\PowerCCSSoftPhone" & "\PowerCCSX.ocx")
        End If

        Dim assameblyFile As String() = {prgpath & "\PowerCCSSoftPhone" & "\PowerCCSX.ocx"}
        Register(assameblyFile)



    End Sub

    Private Sub Register(ByVal assemblyNames As String())


        Dim proc As Process = New Process()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo("Regsvr32.exe", " /s " + """" + assemblyNames(0) + """")
        startInfo.CreateNoWindow = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardInput = True
        startInfo.RedirectStandardError = True
        startInfo.RedirectStandardOutput = True
        proc.StartInfo = startInfo

        proc.Start()

        proc.Close()


    End Sub
End Class
