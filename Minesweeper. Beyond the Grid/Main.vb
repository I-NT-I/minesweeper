Public Class Main
    Public Shared EingabeName As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            easy.Show()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            medium.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            hard.Show()
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        EingabeName = TextBox1.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            easy_dark.Show()
        End If
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            medium_dark.Show()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Then
            MsgBox("Geben Sie einen Namen ein")
        Else
            Me.Visible = False
            hard_dark.Show()
        End If
    End Sub
End Class
