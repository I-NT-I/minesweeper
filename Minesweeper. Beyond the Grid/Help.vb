Public Class Help

   
    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Label deklarieren
        Dim lblInstructions As New Label

        ' Label-Eigenschaften festlegen
        lblInstructions.Text = "Minesweeper Anleitung" & vbCrLf & _
                              "Spielziel" & vbCrLf & _
                              "Das Ziel von Minesweeper ist es, alle Felder auf einem Spielfeld aufzudecken, ohne dabei auf eine Mine zu stoßen." & vbCrLf & _
                              vbCrLf & _
                              "Spielvorbereitung" & vbCrLf & _
                              "1. Wähle eine Schwierigkeitsstufe: Easy, Medium oder Hard. Jede Schwierigkeitsstufe hat eine andere Anzahl von Feldern und Minen." & vbCrLf & _
                              "2. Gib einen Namen ein." & vbCrLf & _
                              "3. Das Spielfeld wird als quadratisches Raster mit verdeckten Feldern angezeigt." & vbCrLf & _
                              vbCrLf & _
                              "Spielablauf" & vbCrLf & _
                              "1. Das Spiel beginnt, wenn du auf ein beliebiges Feld klickst." & vbCrLf & _
                              "2. Aufgedeckte Felder zeigen entweder:" & vbCrLf & _
                              "    * Eine Zahl: Diese gibt an, wie viele Minen in den acht angrenzenden Feldern versteckt sind." & vbCrLf & _
                              "    * Ein leeres Feld: Du kannst weitermachen, indem du auf ein benachbartes Feld klickst." & vbCrLf & _
                              "    * Eine Mine: Das Spiel ist verloren!" & vbCrLf & _
                              "3. Nutze die Zahlen und Markierungen, um die Position der Minen zu ermitteln und sichere Felder aufzudecken." & vbCrLf & _
                              "4. Gewinne das Spiel, indem du alle Felder aufdeckst, ohne auf eine Mine zu stoßen." & vbCrLf & _
                              vbCrLf & _
                              "Tipps" & vbCrLf & _
                              "1. Achte auf die Muster der Zahlen: Die Anzahl der Minen in der Nähe eines Feldes kann dir helfen, die Position der anderen Minen einzugrenzen." & vbCrLf & _
                              "2. Markiere alle \verdächtigen Minen\: So behältst du den Überblick und vermeidest es, versehentlich auf eine Mine zu klicken." & vbCrLf & _
                              "3. Nutze den Doppelklick, um Zeit zu sparen: Wenn du sicher bist, dass alle Felder um ein mit einer Zahl gekennzeichnetes Feld leer sind, kannst du den Doppelklick verwenden, um sie alle gleichzeitig aufzudecken." & vbCrLf & _
                              "4. Sei geduldig und logisch: Minesweeper erfordert Geduld und logisches Denken. Überstürze deine Entscheidungen nicht und analysiere die Situation sorgfältig, bevor du ein Feld aufdeckst." & vbCrLf & _
                              vbCrLf & _
                              "## Zusätzliche Informationen ##" & vbCrLf & _
                              "1. Es gibt ein Power Up: Minenscanner (Scannt ein Feld nach einer Mine)." & vbCrLf & _
                              "2. Viel Spaß beim Spielen!" & vbCrLf & _
                              vbCrLf & _
                              "Ende"

        ' Label zum Formular hinzufügen
        Me.Controls.Add(lblInstructions)

        ' Label-Positionierung anpassen
        lblInstructions.Location = New Point(10, 10)
        lblInstructions.Width = Me.Width - 20
        lblInstructions.Height = 500
        lblInstructions.AutoSize = True
        'lblInstructions.WordWrap = True
        lblInstructions.Font = New Font("Arial", 10, FontStyle.Regular)
    End Sub
End Class