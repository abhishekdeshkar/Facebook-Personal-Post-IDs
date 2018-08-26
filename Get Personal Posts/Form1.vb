Imports System.Text.RegularExpressions

Public Class FacebookSpam

    Private Const BrowserKeyPath As String = "\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
    Public Sub CreateBrowserKey(Optional ByVal IgnoreIDocDirective As Boolean = False)
        Dim basekey As String = Microsoft.Win32.Registry.CurrentUser.ToString
        Dim value As Int32
        Dim thisAppsName As String = My.Application.Info.AssemblyName & ".exe"

        ' Value reference: http://msdn.microsoft.com/en-us/library/ee330730%28v=VS.85%29.aspx
        ' IDOC Reference:  http://msdn.microsoft.com/en-us/library/ms535242%28v=vs.85%29.aspx
        Select Case (New WebBrowser).Version.Major

            Case 11
                If IgnoreIDocDirective Then
                    value = 11001
                Else
                    value = 11000
                End If

            Case Else
                Exit Sub

        End Select

        Microsoft.Win32.Registry.SetValue(Microsoft.Win32.Registry.CurrentUser.ToString & BrowserKeyPath,
                                          Process.GetCurrentProcess.ProcessName & ".exe",
                                          value,
                                          Microsoft.Win32.RegistryValueKind.DWord)
    End Sub


    Private Sub FacebookSpam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBrowserKey()
    End Sub

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        Facebook.Navigate(txtURL.Text)
    End Sub

    Private Sub btnStartScroll_Click(sender As Object, e As EventArgs) Handles btnStartScroll.Click
        timerscroll.Enabled = True
        timerscroll.Interval = "500"
        timerscroll.Start()
    End Sub

    Private Sub btnStopScroll_Click(sender As Object, e As EventArgs) Handles btnStopScroll.Click
        timerscroll.Enabled = False
        timerscroll.Stop()
    End Sub

    Private Sub timerscroll_Tick(sender As Object, e As EventArgs) Handles timerscroll.Tick
        Facebook.Document.Window.ScrollTo(0, 100000)
    End Sub

    Private Sub btnFindIDs_Click(sender As Object, e As EventArgs) Handles btnFindIDs.Click

        Dim AllIDS As String = ""

        Dim allelements As HtmlElementCollection = Facebook.Document.All
        Try

            For Each webpageelement As HtmlElement In allelements
                If webpageelement.GetAttribute("classname") = "_5pcq" Then

                    Dim GetURLData As String = webpageelement.GetAttribute("href")

                    If GetURLData.Contains("fbid") Then

                        AllIDS = AllIDS + GetBetween(GetURLData, "fbid=", "&set=a.") & ","

                    End If

                    If GetURLData.Contains("posts") Then

                        AllIDS = AllIDS + After(GetURLData, "posts/") & ","

                    End If



                End If
            Next

            PostIDS.Text = AllIDS

        Catch ex As Exception

        End Try
    End Sub

    Function After(value As String, a As String) As String
        ' Get index of argument and return substring after its position.
        Dim posA As Integer = value.LastIndexOf(a)
        If posA = -1 Then
            Return ""
        End If
        Dim adjustedPosA As Integer = posA + a.Length
        If adjustedPosA >= value.Length Then
            Return ""
        End If
        Return value.Substring(adjustedPosA)
    End Function

    Function GetBetween(value As String, a As String,
                     b As String) As String
        ' Get positions for both string arguments.
        Dim posA As Integer = value.IndexOf(a)
        Dim posB As Integer = value.LastIndexOf(b)
        If posA = -1 Then
            Return ""
        End If
        If posB = -1 Then
            Return ""
        End If

        Dim adjustedPosA As Integer = posA + a.Length
        If adjustedPosA >= posB Then
            Return ""
        End If

        ' Get the substring between the two positions.
        Return value.Substring(adjustedPosA, posB - adjustedPosA)
    End Function


End Class
