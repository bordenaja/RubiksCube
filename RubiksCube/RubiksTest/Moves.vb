Module Moves

    Public Sub reset(Cube(,,) As Cubie,
                     FaceW As Face, FaceY As Face,
                     FaceG As Face, FaceB As Face,
                     FaceR As Face, FaceO As Face)

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim CubiesColours(2, 2, 2) As String 'actually a constant
        CubiesColours = AssignCubiesArray(CubiesColours)

        For cubienumber = 0 To 26
            i = cubienumber Mod 3
            j = Math.Floor((i Mod 9) / 3)
            k = Math.Floor(cubienumber / 9)
            'this prevents three nested loops inside each other and uses logic instead

            Cube(i, j, k).SetPermutation(0)
            Cube(i, j, k).SetColours(CubiesColours(i, j, k)) 'assigns each cubie's colours
        Next

        For faceletnumber = 0 To 8
            i = Math.Floor(faceletnumber / 3)
            j = faceletnumber Mod 3
            FaceW.faceletsArray(i, j).BackColor = Color.White
            FaceY.faceletsArray(i, j).BackColor = Color.Yellow
            FaceG.faceletsArray(i, j).BackColor = Color.Green
            FaceB.faceletsArray(i, j).BackColor = Color.Blue
            FaceR.faceletsArray(i, j).BackColor = Color.Red
            FaceO.faceletsArray(i, j).BackColor = Color.Orange
        Next

    End Sub

    Private Function AssignCubiesArray(Cube(,,) As String)
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim currentcubiecolours As String = ""

        For cubienumber = 0 To 26
            i = cubienumber Mod 3
            j = Math.Floor((i Mod 9) / 3)
            k = Math.Floor(cubienumber / 9)
            'this prevents three nested loops inside each other and uses logic instead

            If i = 0 Then
                currentcubiecolours = currentcubiecolours + "O"
            ElseIf i = 2 Then
                currentcubiecolours = currentcubiecolours + "R"
            End If
            If j = 0 Then 'front face
                currentcubiecolours = currentcubiecolours + "Y"
            ElseIf j = 2 Then
                currentcubiecolours = currentcubiecolours + "W"
            End If
            If k = 0 Then
                currentcubiecolours = currentcubiecolours + "B"
            ElseIf k = 2 Then
                currentcubiecolours = currentcubiecolours + "G"
            End If

            Cube(i, j, k) = currentcubiecolours
            currentcubiecolours = ""
        Next

        Return Cube
    End Function


    Public Sub L(Cube(,,) As Cubie, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        'FaceL corners
        Dim tempcolor As Color = FaceL.faceletsArray(2, 2).BackColor 'FLD facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceL.faceletsArray(2, 0).BackColor
        FaceL.faceletsArray(2, 0).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = tempcolor

        'FaceL edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = tempcolor

        'UL other faces
        tempcolor = FaceF.faceletsArray(0, 0).BackColor 'FLU facing front
        FaceF.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(0, 0).BackColor
        FaceU.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(0, 0).BackColor
        FaceD.faceletsArray(0, 0).BackColor = tempcolor

        'DL other faces
        tempcolor = FaceF.faceletsArray(0, 2).BackColor 'BLU facing front
        FaceF.faceletsArray(0, 2).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceF.faceletsArray(0, 1).BackColor 'FL facing front
        FaceF.faceletsArray(0, 1).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub R(Cube(,,) As Cubie, FaceR As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        'FaceR corners
        Dim tempcolor As Color = FaceR.faceletsArray(2, 2).BackColor 'BRD facing right
        FaceR.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = tempcolor

        'FaceR edges
        tempcolor = FaceR.faceletsArray(1, 0).BackColor 'RUE facing right
        FaceR.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = tempcolor

        'UR other faces
        tempcolor = FaceF.faceletsArray(2, 0).BackColor 'FRU facing front
        FaceF.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = tempcolor

        'DR other faces
        tempcolor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(0, 0).BackColor
        FaceB.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub U(Cube(,,) As Cubie, FaceU As Face,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'FaceU corners
        Dim tempcolor As Color = FaceU.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = tempcolor

        'FaceU edges
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'UB facing up
        FaceU.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = tempcolor

        'UL other faces
        tempcolor = FaceL.faceletsArray(0, 0).BackColor 'BLU facing left
        FaceL.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(0, 0).BackColor
        FaceF.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(0, 0).BackColor
        FaceB.faceletsArray(0, 0).BackColor = tempcolor

        'UR other faces
        tempcolor = FaceL.faceletsArray(2, 0).BackColor 'FLU facing left
        FaceL.faceletsArray(2, 0).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(1, 0).BackColor
        FaceF.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(1, 0).BackColor
        FaceR.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(1, 0).BackColor
        FaceB.faceletsArray(1, 0).BackColor = tempcolor

    End Sub

    Public Sub D(Cube(,,) As Cubie, FaceD As Face,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'FaceD corners
        Dim tempcolor As Color = FaceD.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceD.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = tempcolor

        'FaceD edges
        tempcolor = FaceD.faceletsArray(1, 0).BackColor 'UB facing up
        FaceD.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = tempcolor

        'DL other faces
        tempcolor = FaceL.faceletsArray(0, 2).BackColor 'BLU facing left
        FaceL.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = tempcolor

        'DR other faces
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLU facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(2, 2).BackColor
        FaceR.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = tempcolor

        'other faces D edges
        tempcolor = FaceL.faceletsArray(1, 2).BackColor 'UL facing left
        FaceL.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = tempcolor

    End Sub

    Public Sub F(Cube(,,) As Cubie, FaceF As Face,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'FaceF corners
        Dim tempcolor As Color = FaceF.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceF.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = tempcolor

        'FaceF edges
        tempcolor = FaceF.faceletsArray(1, 0).BackColor 'UB facing up
        FaceF.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = tempcolor

        'DR other faces from L
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLD facing front
        FaceL.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = tempcolor

        'UR other faces from L
        tempcolor = FaceL.faceletsArray(2, 0).BackColor 'FLU facing front
        FaceL.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(0, 0).BackColor
        FaceD.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = tempcolor

        'other faces edges from L
        tempcolor = FaceL.faceletsArray(2, 1).BackColor 'FL facing front
        FaceL.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(1, 0).BackColor
        FaceD.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = tempcolor

    End Sub

    Public Sub B(Cube(,,) As Cubie, FaceB As Face,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'FaceB corners
        Dim tempcolor As Color = FaceB.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceB.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = tempcolor

        'FaceB edges
        tempcolor = FaceB.faceletsArray(1, 0).BackColor 'UB facing up
        FaceB.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = tempcolor

        'UL other faces from U
        tempcolor = FaceU.faceletsArray(0, 0).BackColor 'UBL facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = tempcolor

        'UR other faces from U
        tempcolor = FaceU.faceletsArray(2, 0).BackColor 'FLU facing front
        FaceU.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(2, 2).BackColor
        FaceR.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = tempcolor

        'other faces edges from U
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'FL facing front
        FaceU.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub E(Cube(,,) As Cubie,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'centres start from F
        Dim tempcolor As Color = FaceF.faceletsArray(1, 1).BackColor
        FaceF.faceletsArray(1, 1).BackColor = FaceR.faceletsArray(1, 1).BackColor
        FaceR.faceletsArray(1, 1).BackColor = FaceB.faceletsArray(1, 1).BackColor
        FaceB.faceletsArray(1, 1).BackColor = FaceL.faceletsArray(1, 1).BackColor
        FaceL.faceletsArray(1, 1).BackColor = tempcolor

        'L start from F
        tempcolor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = tempcolor

        'R start from F
        tempcolor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub S(Cube(,,) As Cubie,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'centres start from U
        Dim tempcolor As Color = FaceU.faceletsArray(1, 1).BackColor
        FaceU.faceletsArray(1, 1).BackColor = FaceL.faceletsArray(1, 1).BackColor
        FaceL.faceletsArray(1, 1).BackColor = FaceD.faceletsArray(1, 1).BackColor
        FaceD.faceletsArray(1, 1).BackColor = FaceR.faceletsArray(1, 1).BackColor
        FaceR.faceletsArray(1, 1).BackColor = tempcolor

        'L start from U
        tempcolor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(1, 0).BackColor
        FaceR.faceletsArray(1, 0).BackColor = tempcolor

        'R start from U
        tempcolor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(1, 0).BackColor
        FaceL.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = tempcolor

    End Sub

    Public Sub M(Cube(,,) As Cubie,
                 FaceF As Face, FaceU As Face,
                 FaceB As Face, FaceD As Face)

        'centres start from F
        Dim tempcolor As Color = FaceF.faceletsArray(1, 1).BackColor
        FaceF.faceletsArray(1, 1).BackColor = FaceD.faceletsArray(1, 1).BackColor
        FaceD.faceletsArray(1, 1).BackColor = FaceB.faceletsArray(1, 1).BackColor
        FaceB.faceletsArray(1, 1).BackColor = FaceU.faceletsArray(1, 1).BackColor
        FaceU.faceletsArray(1, 1).BackColor = tempcolor

        'UM start from F
        tempcolor = FaceF.faceletsArray(1, 0).BackColor
        FaceF.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(1, 0).BackColor
        FaceD.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(1, 0).BackColor
        FaceU.faceletsArray(1, 0).BackColor = tempcolor

        'DM start from F
        tempcolor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(1, 0).BackColor
        FaceB.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = tempcolor

    End Sub


    Public Sub La(Cube(,,) As Cubie, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        'FaceL corners
        Dim tempcolor As Color = FaceL.faceletsArray(2, 2).BackColor 'FLD facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = FaceL.faceletsArray(2, 0).BackColor
        FaceL.faceletsArray(2, 0).BackColor = tempcolor

        'FaceL edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = tempcolor

        'UL other faces
        tempcolor = FaceF.faceletsArray(0, 0).BackColor 'FLU facing front
        FaceF.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(0, 0).BackColor
        FaceD.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(0, 0).BackColor
        FaceU.faceletsArray(0, 0).BackColor = tempcolor

        'DL other faces
        tempcolor = FaceF.faceletsArray(0, 2).BackColor 'BLU facing front
        FaceF.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceF.faceletsArray(0, 1).BackColor 'FL facing front
        FaceF.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub Ra(Cube(,,) As Cubie, FaceR As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        'FaceR corners
        Dim tempcolor As Color = FaceR.faceletsArray(2, 2).BackColor 'BRD facing right
        FaceR.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = tempcolor

        'FaceR edges
        tempcolor = FaceR.faceletsArray(1, 0).BackColor 'RUE facing right
        FaceR.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = tempcolor

        'UR other faces
        tempcolor = FaceF.faceletsArray(2, 0).BackColor 'FRU facing front
        FaceF.faceletsArray(2, 0).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = tempcolor

        'DR other faces
        tempcolor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(0, 0).BackColor
        FaceB.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub Ua(Cube(,,) As Cubie, FaceU As Face,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'FaceU corners
        Dim tempcolor As Color = FaceU.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = tempcolor

        'FaceU edges
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'UB facing up
        FaceU.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = tempcolor

        'UL other faces
        tempcolor = FaceL.faceletsArray(0, 0).BackColor 'BLU facing left
        FaceL.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(0, 0).BackColor
        FaceB.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(0, 0).BackColor
        FaceF.faceletsArray(0, 0).BackColor = tempcolor

        'UR other faces
        tempcolor = FaceL.faceletsArray(2, 0).BackColor 'FLU facing left
        FaceL.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = tempcolor

        'other faces edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(1, 0).BackColor
        FaceB.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(1, 0).BackColor
        FaceR.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(1, 0).BackColor
        FaceF.faceletsArray(1, 0).BackColor = tempcolor

    End Sub

    Public Sub Da(Cube(,,) As Cubie, FaceD As Face,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'FaceD corners
        Dim tempcolor As Color = FaceD.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceD.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = tempcolor

        'FaceD edges
        tempcolor = FaceD.faceletsArray(1, 0).BackColor 'UB facing up
        FaceD.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = tempcolor

        'DL other faces
        tempcolor = FaceL.faceletsArray(0, 2).BackColor 'BLU facing left
        FaceL.faceletsArray(0, 2).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = tempcolor

        'DR other faces
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLU facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(2, 2).BackColor
        FaceR.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = tempcolor

        'other faces D edges
        tempcolor = FaceL.faceletsArray(1, 2).BackColor 'UL facing left
        FaceL.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = tempcolor

    End Sub

    Public Sub Fa(Cube(,,) As Cubie, FaceF As Face,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'FaceF corners
        Dim tempcolor As Color = FaceF.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceF.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = tempcolor

        'FaceF edges
        tempcolor = FaceF.faceletsArray(1, 0).BackColor 'UB facing up
        FaceF.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = tempcolor

        'DR other faces from L
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLD facing front
        FaceL.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = tempcolor

        'UR other faces from L
        tempcolor = FaceL.faceletsArray(2, 0).BackColor 'FLU facing front
        FaceL.faceletsArray(2, 0).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(0, 0).BackColor
        FaceD.faceletsArray(0, 0).BackColor = tempcolor

        'other faces edges from L
        tempcolor = FaceL.faceletsArray(2, 1).BackColor 'FL facing front
        FaceL.faceletsArray(2, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(1, 0).BackColor
        FaceD.faceletsArray(1, 0).BackColor = tempcolor

    End Sub

    Public Sub Ba(Cube(,,) As Cubie, FaceB As Face,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'FaceB corners
        Dim tempcolor As Color = FaceB.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceB.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = tempcolor

        'FaceB edges
        tempcolor = FaceB.faceletsArray(1, 0).BackColor 'UB facing up
        FaceB.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = tempcolor

        'UL other faces from U
        tempcolor = FaceU.faceletsArray(0, 0).BackColor 'UBL facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = tempcolor

        'UR other faces from U
        tempcolor = FaceU.faceletsArray(2, 0).BackColor 'FLU facing front
        FaceU.faceletsArray(2, 0).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(2, 2).BackColor
        FaceR.faceletsArray(2, 2).BackColor = tempcolor

        'other faces edges from U
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'FL facing front
        FaceU.faceletsArray(1, 0).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub Ma(Cube(,,) As Cubie,
                 FaceF As Face, FaceU As Face,
                 FaceB As Face, FaceD As Face)

        'centres start from F
        Dim tempcolor As Color = FaceF.faceletsArray(1, 1).BackColor
        FaceF.faceletsArray(1, 1).BackColor = FaceU.faceletsArray(1, 1).BackColor
        FaceU.faceletsArray(1, 1).BackColor = FaceB.faceletsArray(1, 1).BackColor
        FaceB.faceletsArray(1, 1).BackColor = FaceD.faceletsArray(1, 1).BackColor
        FaceD.faceletsArray(1, 1).BackColor = tempcolor

        'UM start from F
        tempcolor = FaceF.faceletsArray(1, 0).BackColor
        FaceF.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(1, 0).BackColor
        FaceU.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(1, 0).BackColor
        FaceD.faceletsArray(1, 0).BackColor = tempcolor

        'DM start from F
        tempcolor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(1, 0).BackColor
        FaceB.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = tempcolor

    End Sub

    Public Sub Ea(Cube(,,) As Cubie,
                 FaceF As Face, FaceB As Face,
                 FaceR As Face, FaceL As Face)

        'centres start from F
        Dim tempcolor As Color = FaceF.faceletsArray(1, 1).BackColor
        FaceF.faceletsArray(1, 1).BackColor = FaceL.faceletsArray(1, 1).BackColor
        FaceL.faceletsArray(1, 1).BackColor = FaceB.faceletsArray(1, 1).BackColor
        FaceB.faceletsArray(1, 1).BackColor = FaceR.faceletsArray(1, 1).BackColor
        FaceR.faceletsArray(1, 1).BackColor = tempcolor

        'L start from F
        tempcolor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = tempcolor

        'R start from F
        tempcolor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub Sa(Cube(,,) As Cubie,
                 FaceU As Face, FaceD As Face,
                 FaceR As Face, FaceL As Face)

        'centres start from U
        Dim tempcolor As Color = FaceU.faceletsArray(1, 1).BackColor
        FaceU.faceletsArray(1, 1).BackColor = FaceR.faceletsArray(1, 1).BackColor
        FaceR.faceletsArray(1, 1).BackColor = FaceD.faceletsArray(1, 1).BackColor
        FaceD.faceletsArray(1, 1).BackColor = FaceL.faceletsArray(1, 1).BackColor
        FaceL.faceletsArray(1, 1).BackColor = tempcolor

        'L start from U
        tempcolor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(1, 0).BackColor
        FaceR.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = tempcolor

        'R start from U
        tempcolor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(1, 0).BackColor
        FaceL.faceletsArray(1, 0).BackColor = tempcolor

    End Sub


    Public Sub x(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            tempcolor = FaceF.faceletsArray(column, row).BackColor
            FaceF.faceletsArray(column, row).BackColor = FaceD.faceletsArray(column, row).BackColor
            FaceD.faceletsArray(column, row).BackColor = FaceB.faceletsArray(2 - column, 2 - row).BackColor
            FaceB.faceletsArray(2 - column, 2 - row).BackColor = FaceU.faceletsArray(column, row).BackColor
            FaceU.faceletsArray(column, row).BackColor = tempcolor
        Next

        'La and R

        'FaceL corners
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLD facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = FaceL.faceletsArray(2, 0).BackColor
        FaceL.faceletsArray(2, 0).BackColor = tempcolor
        'FaceL edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = tempcolor


        'FaceR corners
        tempcolor = FaceR.faceletsArray(2, 2).BackColor 'BRD facing right
        FaceR.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = tempcolor
        'FaceR edges
        tempcolor = FaceR.faceletsArray(1, 0).BackColor 'RUE facing right
        FaceR.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub y(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            tempcolor = FaceF.faceletsArray(column, row).BackColor
            FaceF.faceletsArray(column, row).BackColor = FaceR.faceletsArray(column, row).BackColor
            FaceR.faceletsArray(column, row).BackColor = FaceB.faceletsArray(column, row).BackColor
            FaceB.faceletsArray(column, row).BackColor = FaceL.faceletsArray(column, row).BackColor
            FaceL.faceletsArray(column, row).BackColor = tempcolor
        Next

        'U and Da

        'FaceU corners
        tempcolor = FaceU.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = tempcolor
        'FaceU edges
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'UB facing up
        FaceU.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = tempcolor

        'FaceD corners
        tempcolor = FaceD.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceD.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = tempcolor
        'FaceD edges
        tempcolor = FaceD.faceletsArray(1, 0).BackColor 'UB facing up
        FaceD.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub z(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            'from L
            tempcolor = FaceL.faceletsArray(column, row).BackColor
            FaceL.faceletsArray(column, row).BackColor = FaceD.faceletsArray(row, 2 - column).BackColor
            FaceD.faceletsArray(row, 2 - column).BackColor = FaceR.faceletsArray(2 - column, 2 - row).BackColor
            FaceR.faceletsArray(2 - column, 2 - row).BackColor = FaceU.faceletsArray(row, 2 - column).BackColor
            FaceU.faceletsArray(row, 2 - column).BackColor = tempcolor
        Next

        'F and Ba

        'FaceF corners
        tempcolor = FaceF.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceF.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = tempcolor
        'FaceF edges
        tempcolor = FaceF.faceletsArray(1, 0).BackColor 'UB facing up
        FaceF.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = tempcolor

        'FaceB corners
        tempcolor = FaceB.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceB.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = tempcolor
        'FaceB edges
        tempcolor = FaceB.faceletsArray(1, 0).BackColor 'UB facing up
        FaceB.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub xa(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            tempcolor = FaceF.faceletsArray(column, row).BackColor
            FaceF.faceletsArray(column, row).BackColor = FaceU.faceletsArray(column, row).BackColor
            FaceU.faceletsArray(column, row).BackColor = FaceB.faceletsArray(2 - column, 2 - row).BackColor
            FaceB.faceletsArray(2 - column, 2 - row).BackColor = FaceD.faceletsArray(column, row).BackColor
            FaceD.faceletsArray(column, row).BackColor = tempcolor
        Next

        'L and Ra

        'FaceL corners
        tempcolor = FaceL.faceletsArray(2, 2).BackColor 'FLD facing left
        FaceL.faceletsArray(2, 2).BackColor = FaceL.faceletsArray(2, 0).BackColor
        FaceL.faceletsArray(2, 0).BackColor = FaceL.faceletsArray(0, 0).BackColor
        FaceL.faceletsArray(0, 0).BackColor = FaceL.faceletsArray(0, 2).BackColor
        FaceL.faceletsArray(0, 2).BackColor = tempcolor
        'FaceL edges
        tempcolor = FaceL.faceletsArray(1, 0).BackColor 'UL facing left
        FaceL.faceletsArray(1, 0).BackColor = FaceL.faceletsArray(0, 1).BackColor
        FaceL.faceletsArray(0, 1).BackColor = FaceL.faceletsArray(1, 2).BackColor
        FaceL.faceletsArray(1, 2).BackColor = FaceL.faceletsArray(2, 1).BackColor
        FaceL.faceletsArray(2, 1).BackColor = tempcolor

        'FaceR corners
        tempcolor = FaceR.faceletsArray(2, 2).BackColor 'BRD facing right
        FaceR.faceletsArray(2, 2).BackColor = FaceR.faceletsArray(0, 2).BackColor
        FaceR.faceletsArray(0, 2).BackColor = FaceR.faceletsArray(0, 0).BackColor
        FaceR.faceletsArray(0, 0).BackColor = FaceR.faceletsArray(2, 0).BackColor
        FaceR.faceletsArray(2, 0).BackColor = tempcolor
        'FaceR edges
        tempcolor = FaceR.faceletsArray(1, 0).BackColor 'RUE facing right
        FaceR.faceletsArray(1, 0).BackColor = FaceR.faceletsArray(2, 1).BackColor
        FaceR.faceletsArray(2, 1).BackColor = FaceR.faceletsArray(1, 2).BackColor
        FaceR.faceletsArray(1, 2).BackColor = FaceR.faceletsArray(0, 1).BackColor
        FaceR.faceletsArray(0, 1).BackColor = tempcolor

    End Sub

    Public Sub ya(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            tempcolor = FaceF.faceletsArray(column, row).BackColor
            FaceF.faceletsArray(column, row).BackColor = FaceL.faceletsArray(column, row).BackColor
            FaceL.faceletsArray(column, row).BackColor = FaceB.faceletsArray(column, row).BackColor
            FaceB.faceletsArray(column, row).BackColor = FaceR.faceletsArray(column, row).BackColor
            FaceR.faceletsArray(column, row).BackColor = tempcolor
        Next

        'Ua and D

        'FaceU corners
        tempcolor = FaceU.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceU.faceletsArray(0, 0).BackColor = FaceU.faceletsArray(2, 0).BackColor
        FaceU.faceletsArray(2, 0).BackColor = FaceU.faceletsArray(2, 2).BackColor
        FaceU.faceletsArray(2, 2).BackColor = FaceU.faceletsArray(0, 2).BackColor
        FaceU.faceletsArray(0, 2).BackColor = tempcolor
        'FaceU edges
        tempcolor = FaceU.faceletsArray(1, 0).BackColor 'UB facing up
        FaceU.faceletsArray(1, 0).BackColor = FaceU.faceletsArray(2, 1).BackColor
        FaceU.faceletsArray(2, 1).BackColor = FaceU.faceletsArray(1, 2).BackColor
        FaceU.faceletsArray(1, 2).BackColor = FaceU.faceletsArray(0, 1).BackColor
        FaceU.faceletsArray(0, 1).BackColor = tempcolor

        'FaceD corners
        tempcolor = FaceD.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceD.faceletsArray(0, 0).BackColor = FaceD.faceletsArray(0, 2).BackColor
        FaceD.faceletsArray(0, 2).BackColor = FaceD.faceletsArray(2, 2).BackColor
        FaceD.faceletsArray(2, 2).BackColor = FaceD.faceletsArray(2, 0).BackColor
        FaceD.faceletsArray(2, 0).BackColor = tempcolor
        'FaceD edges
        tempcolor = FaceD.faceletsArray(1, 0).BackColor 'UB facing up
        FaceD.faceletsArray(1, 0).BackColor = FaceD.faceletsArray(0, 1).BackColor
        FaceD.faceletsArray(0, 1).BackColor = FaceD.faceletsArray(1, 2).BackColor
        FaceD.faceletsArray(1, 2).BackColor = FaceD.faceletsArray(2, 1).BackColor
        FaceD.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Sub za(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)

        Dim tempcolor As Color
        Dim row As Integer
        Dim column As Integer

        For i = 0 To 8
            row = i Mod 3
            column = Math.Floor(i / 3)

            'from L
            tempcolor = FaceL.faceletsArray(column, row).BackColor
            FaceL.faceletsArray(column, row).BackColor = FaceU.faceletsArray(row, 2 - column).BackColor
            FaceU.faceletsArray(row, 2 - column).BackColor = FaceR.faceletsArray(2 - column, 2 - row).BackColor
            FaceR.faceletsArray(2 - column, 2 - row).BackColor = FaceD.faceletsArray(row, 2 - column).BackColor
            FaceD.faceletsArray(row, 2 - column).BackColor = tempcolor
        Next

        'Fa and B

        'FaceF corners
        tempcolor = FaceF.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceF.faceletsArray(0, 0).BackColor = FaceF.faceletsArray(2, 0).BackColor
        FaceF.faceletsArray(2, 0).BackColor = FaceF.faceletsArray(2, 2).BackColor
        FaceF.faceletsArray(2, 2).BackColor = FaceF.faceletsArray(0, 2).BackColor
        FaceF.faceletsArray(0, 2).BackColor = tempcolor
        'FaceF edges
        tempcolor = FaceF.faceletsArray(1, 0).BackColor 'UB facing up
        FaceF.faceletsArray(1, 0).BackColor = FaceF.faceletsArray(2, 1).BackColor
        FaceF.faceletsArray(2, 1).BackColor = FaceF.faceletsArray(1, 2).BackColor
        FaceF.faceletsArray(1, 2).BackColor = FaceF.faceletsArray(0, 1).BackColor
        FaceF.faceletsArray(0, 1).BackColor = tempcolor

        'FaceB corners
        tempcolor = FaceB.faceletsArray(0, 0).BackColor 'ULB facing up
        FaceB.faceletsArray(0, 0).BackColor = FaceB.faceletsArray(0, 2).BackColor
        FaceB.faceletsArray(0, 2).BackColor = FaceB.faceletsArray(2, 2).BackColor
        FaceB.faceletsArray(2, 2).BackColor = FaceB.faceletsArray(2, 0).BackColor
        FaceB.faceletsArray(2, 0).BackColor = tempcolor
        'FaceB edges
        tempcolor = FaceB.faceletsArray(1, 0).BackColor 'UB facing up
        FaceB.faceletsArray(1, 0).BackColor = FaceB.faceletsArray(0, 1).BackColor
        FaceB.faceletsArray(0, 1).BackColor = FaceB.faceletsArray(1, 2).BackColor
        FaceB.faceletsArray(1, 2).BackColor = FaceB.faceletsArray(2, 1).BackColor
        FaceB.faceletsArray(2, 1).BackColor = tempcolor

    End Sub

    Public Function CheckSolvable(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face) As String
        Dim myarray() As Integer = {0, 0, 0, 0, 0, 0}
        Dim returnstring As String = ""
        Dim booleanarray() As Boolean = {False, False, False, False, False, False}
        Dim i As Integer

        Dim solved As Boolean = Form1.CheckSolved("")
        If solved = True Then
            Return "The cube is already solved."
        End If

        If FaceU.faceletsArray(1, 1).BackColor <> Color.Yellow Then
            booleanarray(0) = True
        ElseIf FaceD.faceletsArray(1, 1).BackColor <> Color.white Then
            booleanarray(1) = True
        ElseIf Facef.faceletsArray(1, 1).BackColor <> Color.blue Then
            booleanarray(2) = True
        ElseIf Faceb.faceletsArray(1, 1).BackColor <> Color.Green Then
            booleanarray(3) = True
        ElseIf Facer.faceletsArray(1, 1).BackColor <> Color.red Then
            booleanarray(4) = True
        ElseIf Facel.faceletsArray(1, 1).BackColor <> Color.Orange Then
            booleanarray(5) = True
        End If
        Dim iWrongCentres As Integer = 0
        For i = 0 To 5
            If booleanarray(i) = True Then
                iWrongCentres = iWrongCentres + 1
            End If
        Next
        i = 0
        If iWrongCentres <> 0 Then
            returnstring = "The "
            While iWrongCentres > 0

                If booleanarray(i) = True Then
                    Select Case i
                        Case 0
                            returnstring = returnstring + "yellow"
                        Case 1
                            returnstring = returnstring + "white"
                        Case 2
                            returnstring = returnstring + "blue"
                        Case 3
                            returnstring = returnstring + "green"
                        Case 4
                            returnstring = returnstring + "red"
                        Case 5
                            returnstring = returnstring + "orange"
                    End Select
                    If iWrongCentres > 1 Then
                        returnstring = returnstring + ", "
                    End If
                End If

                iWrongCentres = iWrongCentres - 1
                i = i + 1
            End While
            returnstring = returnstring + " centres are in the wrong place."
            Return returnstring
        End If

        myarray = checkface(FaceF, myarray)
        myarray = checkface(FaceB, myarray)
        myarray = checkface(FaceR, myarray)
        myarray = checkface(FaceL, myarray)
        myarray = checkface(FaceU, myarray)
        myarray = checkface(FaceD, myarray)
        For i = 0 To 5
            If myarray(i) <> 9 Then
                If returnstring <> "" Then
                    returnstring = "The number of facelets of each colour does not match.
"
                End If
                Select Case i
                    Case 0
                        returnstring = returnstring + "Yellow:" + Str(myarray(0)) + " "
                    Case 1
                        returnstring = returnstring + "White:" + Str(myarray(1)) + " "
                    Case 2
                        returnstring = returnstring + "Blue:" + Str(myarray(2)) + " "
                    Case 3
                        returnstring = returnstring + "Green:" + Str(myarray(3)) + " "
                    Case 4
                        returnstring = returnstring + "Red:" + Str(myarray(4)) + " "
                    Case 5
                        returnstring = returnstring + "Orange:" + Str(myarray(5)) + " "
                End Select

                Return returnstring
            End If
        Next

        Return ""
    End Function

    Private Function checkface(ByVal myface As Face, ByRef myarray() As Integer)
        Dim i As Integer
        Dim j As Integer

        For faceletnumber = 0 To 8
            i = Math.Floor(faceletnumber / 3)
            j = faceletnumber Mod 3

            Select Case myface.faceletsArray(i, j).BackColor
                Case Color.Yellow
                    myarray(0) = myarray(0) + 1
                Case Color.White
                    myarray(1) = myarray(1) + 1
                Case Color.Blue
                    myarray(2) = myarray(2) + 1
                Case Color.Green
                    myarray(3) = myarray(3) + 1
                Case Color.Red
                    myarray(4) = myarray(4) + 1
                Case Color.Orange
                    myarray(5) = myarray(5) + 1
            End Select
        Next
        Return myarray
    End Function

    Public Sub SOLVE(Cube(,,) As Cubie,
                 FaceR As Face, FaceL As Face,
                 FaceF As Face, FaceB As Face,
                 FaceU As Face, FaceD As Face)
        MsgBox("Solve algorithm")
    End Sub

End Module
