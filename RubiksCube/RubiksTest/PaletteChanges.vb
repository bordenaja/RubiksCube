Module PaletteChanges
    Public currentpalettecolour As Color
    Public Sub PaletteY_click(ByRef faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.Yellow
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletcolour
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub PaletteW_click(ByVal faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.White
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletface
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub PaletteB_click(ByVal faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.Blue
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletface
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub PaletteG_click(ByVal faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.Green
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletface
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub PaletteR_click(ByVal faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.Red
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletface
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub PaletteO_click(ByVal faceletface As String, ByRef paletteselected As Boolean,
                       ByRef FaceY As Face, ByRef FaceW As Face,
                       ByRef FaceB As Face, ByRef FaceG As Face,
                       ByRef FaceR As Face, ByRef FaceO As Face)
        Dim i As Integer
        Dim j As Integer
        Dim faceletcolour As Char
        currentpalettecolour = Color.Orange
        If faceletface = "" Then
            paletteselected = True
        Else
            faceletcolour = Mid(faceletface, 1, 1)
            i = Int(Mid(faceletface, 2, 1))
            j = Int(Mid(faceletface, 3, 1))
            Select Case faceletface
                Case "Y"
                    FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "W"
                    FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        End If
    End Sub

    Public Sub faceletclicked(faceinitial As Char, i As Integer, j As Integer)
        If Form1.paletteselected = True Then
            Select Case faceinitial
                Case "W"
                    Form1.FaceW.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "Y"
                    Form1.FaceY.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "B"
                    Form1.FaceB.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "G"
                    Form1.FaceG.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "R"
                    Form1.FaceR.faceletsArray(i, j).BackColor = currentpalettecolour
                Case "O"
                    Form1.FaceO.faceletsArray(i, j).BackColor = currentpalettecolour
            End Select
        Else
            Form1.faceletface = faceinitial + Str(i) + Str(j)
        End If
    End Sub
End Module
