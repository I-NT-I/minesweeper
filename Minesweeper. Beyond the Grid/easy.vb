﻿Public Class easy
    Dim FielSize As Integer = 5
    Dim MineAmount As Integer = 3
    Dim Feld(FielSize, FielSize) As Boolean
    Dim rdm As New Random
    Dim MinePosX As String
    Dim MinePosY As String
    Dim EingabeX As Integer
    Dim EingabeY As Integer
    Dim Around As Integer
    Dim GameTime As Integer
    Dim Score As Integer
    Dim placedMines As New HashSet(Of String)()
    Dim SetBomb As Boolean = True
    Dim FieldsLeft As Integer = FielSize * FielSize - MineAmount
    Dim Lost As Boolean = False
    Dim GEnabled As Boolean = True




    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To FielSize
            For i1 = 0 To FielSize
                Feld(i, i1) = False
            Next

        Next
        Name_.Text = Main.EingabeName
        Label7.Text = MineAmount

    End Sub

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\music_fx_an_old_computer_game_arcade_music_for_mineswe.wav")
    End Sub
















    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        CountMinesAround(0, 0, sender)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CountMinesAround(1, 0, sender)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        CountMinesAround(2, 0, sender)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        CountMinesAround(3, 0, sender)

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        CountMinesAround(4, 0, sender)

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        CountMinesAround(0, 1, sender)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CountMinesAround(1, 1, sender)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        CountMinesAround(2, 1, sender)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CountMinesAround(3, 1, sender)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        CountMinesAround(4, 1, sender)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CountMinesAround(0, 2, sender)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CountMinesAround(1, 2, sender)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        CountMinesAround(2, 2, sender)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        CountMinesAround(3, 2, sender)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        CountMinesAround(4, 2, sender)

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        CountMinesAround(0, 3, sender)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        CountMinesAround(1, 3, sender)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        CountMinesAround(2, 3, sender)

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        CountMinesAround(3, 3, sender)

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        CountMinesAround(4, 3, sender)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CountMinesAround(0, 4, sender)
        ' Button6.BackgroundImage = Image.FromFile()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        CountMinesAround(1, 4, sender)

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        CountMinesAround(2, 4, sender)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        CountMinesAround(3, 4, sender)

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        CountMinesAround(4, 4, sender)

    End Sub




    Public Function CountMinesAround(ByVal x As Integer, ByVal y As Integer, ByVal sender As Object) As Integer

        FieldsLeft = FieldsLeft - 1
        Debug.Print(FieldsLeft)
        Do While GEnabled = True
            PlayBackgroundSoundFile()

            GEnabled = False
        Loop


        Do While SetBomb = True
            For i As Integer = 1 To MineAmount

                Do
                    MinePosX = rdm.Next(0, FielSize)
                    MinePosY = rdm.Next(0, FielSize)
                Loop While placedMines.Contains(MinePosX & "," & MinePosY) Or (MinePosX = x And MinePosY = y)

                placedMines.Add(MinePosX & "," & MinePosY)
                Debug.Print("X: " & MinePosX & " Y: " & MinePosY)
                Feld(MinePosX, MinePosY) = True
            Next




            Timer1.Enabled = True
            Timer2.Enabled = True
            Score = 1000
            For i = 0 To FielSize
                For i1 = 0 To FielSize
                    'Debug.Print(Feld(i, i1))
                Next


            Next
            SetBomb = False
        Loop




        Dim mines As Integer = 0
        For i As Integer = -1 To 1
            For j As Integer = -1 To 1
                If Not (i = 0 And j = 0) Then
                    Dim checkX As Integer = x + i
                    Dim checkY As Integer = y + j
                    If checkX >= 0 And checkX < FielSize And checkY >= 0 And checkY < FielSize Then
                        If Feld(checkX, checkY) Then
                            mines += 1
                        End If
                    End If
                End If
            Next
        Next

        If Feld(x, y) = True Then
            ' Sicherstellen, dass sender ein Button ist
            If TypeOf sender Is Button Then
                Dim btn As Button = CType(sender, Button)
                btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\Bombe Rot.png") ' Setzen der Hintergrundfarbe auf Rot
                If Lost = False Then
                    MsgBox("GAME OVER!")

                End If
                Timer1.Enabled = False
                Timer2.Enabled = False
                Lost = True
                My.Computer.Audio.Stop()

            End If
            Debug.Print("jjjj")
        Else
            ' Keine Bombe gefunden, ändere das Hintergrundbild
            If TypeOf sender Is Button Then
                Dim btn As Button = CType(sender, Button)
                ' Ändern Sie das Hintergrundbild des Buttons hier
                If mines = 1 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\1200px-Minesweeper_1.svg.png") ' Pfade entsprechend anpassen
                End If
                If mines = 2 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\1200px-Minesweeper_2.svg.png")
                End If
                If mines = 3 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\Minesweeper_3.svg.png")

                End If
                If mines = 4 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\Minesweeper_4.svg.png")

                End If
                If mines = 5 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\Minesweeper_5.svg.png")

                End If
                If mines = 6 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\1200px-Minesweeper_6.svg.png")

                End If
                If mines = 0 Then
                    btn.BackgroundImage = Image.FromFile("E:\mine projekt\Minesweeper. Beyond the Grid\Minesweeper. Beyond the Grid\Resources\Clear box 40x40 pressed.png")
                End If
                btn.Enabled = False

            End If

            Debug.Print("nnnn")
        End If

        If FieldsLeft = 0 And Lost = False Then
            MsgBox("U Won")
            My.Computer.Audio.Stop()
        End If


    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        Main.Show()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GameTime = GameTime + 1
        Label1.Text = GameTime

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Score = Score - 1
        Label2.Text = Score - 1
    End Sub


End Class





















































