Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Info_Click(sender As Object, e As EventArgs) Handles Info.Click
        MsgBox("Develop by IOXhop (www.ioxhop.com)")
    End Sub

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        If Connect.Text = "Connect" Then
            APIAuth.Enabled = False
            AppId.Enabled = False
            Connect.Text = "Disconnect"
            Connect.BackColor = Color.Red
            Status.Text = "wait data"
            UpdateColorTimer_Tick(sender, e)
        Else
            UpdateColorTimer.Enabled = False
            APIAuth.Enabled = True
            AppId.Enabled = True
            Connect.Text = "Connect"
            Connect.BackColor = Color.FromArgb(41, 128, 185)
            Status.Text = "wait connect"
        End If
    End Sub

    Private Sub UpdateColorTimer_Tick(sender As Object, e As EventArgs) Handles UpdateColorTimer.Tick
        UpdateColorTimer.Enabled = False
        Dim wrGETURL As WebRequest = WebRequest.Create("https://api.netpie.io/topic/" & AppId.Text & "/color?auth=" & APIAuth.Text)
        Dim objStream As Stream
        Try
            objStream = wrGETURL.GetResponse.GetResponseStream()
        Catch ex As Exception
            ' Console.WriteLine("Error !: " & ex.Message)
            UpdateColorTimer.Enabled = True
            Return
        End Try

        Dim objReader As New StreamReader(objStream)
        Dim ros As String = objReader.ReadToEnd
        ' Console.WriteLine("Ros: {0}", ros)

        Dim mc As Match = New Regex("""payload"":""([0-9]+),([0-9]+),([0-9]+)""", RegexOptions.IgnoreCase).Match(ros)
        If mc.Success Then
            Dim red As Int16 = mc.Groups(1).Value
            Dim green As Int16 = mc.Groups(2).Value
            Dim blue As Int16 = mc.Groups(3).Value
            ' Console.WriteLine("Color: {0},{1},{2}", red, green, blue)
            ColorView.BackColor = Color.FromArgb(red, green, blue)
            RGBBox.Text = red & "," & green & "," & blue
            HexBox.Text = "#"
            If red < 15 Then HexBox.Text = HexBox.Text & "0"
            HexBox.Text = HexBox.Text & Hex(red)
            If green < 15 Then HexBox.Text = HexBox.Text & "0"
            HexBox.Text = HexBox.Text & Hex(green)
            If blue < 15 Then HexBox.Text = HexBox.Text & "0"
            HexBox.Text = HexBox.Text & Hex(blue)

            Status.Text = "data update"
        End If
        UpdateColorTimer.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True

        ' APIAuth.Text = "p1xDit4PaF2Xtsn:ehvPbFM43NuxgNsHO4Z6UBvMU"
        ' AppId.Text = "IOXEyedropper"

        ' Connect_Click(sender, e)
    End Sub

    Private Sub RGBCopy_Click(sender As Object, e As EventArgs) Handles RGBCopy.Click
        My.Computer.Clipboard.SetText(RGBBox.Text)
    End Sub

    Private Sub HexCopy_Click(sender As Object, e As EventArgs) Handles HexCopy.Click
        My.Computer.Clipboard.SetText(HexBox.Text)
    End Sub
End Class
