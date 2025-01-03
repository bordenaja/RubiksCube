Public Class Form1
    Public Cube(2, 2, 2) As Cubie
    Public FaceW As New Face
    Public FaceY As New Face
    Public FaceB As New Face
    Public FaceG As New Face
    Public FaceR As New Face
    Public FaceO As New Face
    Dim sLogString As String = "Log:

"
    Public paletteselected As Boolean = False
    Public faceletface As String = ""
    Dim movessequence As String

    Private Sub Scramble_Click(sender As Object, e As EventArgs) Handles btnScramble.Click
        Dim ScrambleMovesNumber As Integer = udScramble.Value

        Dim value As Integer
        Dim cubesolved As Boolean = True

        Do While cubesolved = True
            For i = 1 To ScrambleMovesNumber
                Randomize()
                value = CInt(Int((33 * Rnd()) + 1))
                Select Case value
                    Case 1
                        Moves.x(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 2
                        Moves.y(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 3
                        Moves.z(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 4
                        Moves.xa(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 5
                        Moves.ya(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 6
                        Moves.za(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 7
                        Moves.R(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
                    Case 8
                        Moves.L(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 9
                        Moves.U(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
                    Case 10
                        Moves.D(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
                    Case 11
                        Moves.F(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
                    Case 12
                        Moves.B(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
                    Case 13
                        Moves.M(Cube, FaceB, FaceY, FaceG, FaceW)
                    Case 14
                        Moves.E(Cube, FaceB, FaceG, FaceR, FaceO)
                    Case 15
                        Moves.S(Cube, FaceY, FaceW, FaceR, FaceO)
                    Case 16
                        Moves.Ra(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
                    Case 17
                        Moves.La(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 18
                        Moves.Ua(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
                    Case 19
                        Moves.Da(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
                    Case 20
                        Moves.Fa(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
                    Case 21
                        Moves.Ba(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
                    Case 22
                        Moves.Ma(Cube, FaceB, FaceY, FaceG, FaceW)
                    Case 23
                        Moves.Ea(Cube, FaceB, FaceG, FaceR, FaceO)
                    Case 24
                        Moves.Sa(Cube, FaceY, FaceW, FaceR, FaceO)
                    Case 25
                        Moves.R(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
                        Moves.R(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
                    Case 26
                        Moves.L(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
                        Moves.L(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
                    Case 27
                        Moves.U(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
                        Moves.U(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
                    Case 28
                        Moves.D(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
                        Moves.D(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
                    Case 29
                        Moves.F(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
                        Moves.F(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
                    Case 30
                        Moves.B(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
                        Moves.B(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
                    Case 31
                        Moves.M(Cube, FaceB, FaceY, FaceG, FaceW)
                        Moves.M(Cube, FaceB, FaceY, FaceG, FaceW)
                    Case 32
                        Moves.E(Cube, FaceB, FaceG, FaceR, FaceO)
                        Moves.E(Cube, FaceB, FaceG, FaceR, FaceO)
                    Case 33
                        Moves.S(Cube, FaceY, FaceW, FaceR, FaceO)
                        Moves.S(Cube, FaceY, FaceW, FaceR, FaceO)
                End Select
                cubesolved = CheckSolved("")
            Next
        Loop

        If movessequence <> "" Then
            sLogString = sLogString + "
"
        End If
        movessequence = ""
        sLogString = sLogString + "Cube scrambled using " + Trim(Str(ScrambleMovesNumber)) + " moves.
"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 800
        Me.Height = 500

        ArrangeButtons()

        udScramble.Maximum = 30
        udScramble.Left = 630
        udScramble.Top = 290
        btnScramble.Left = 670
        btnScramble.Top = 290
        btnLog.Left = 170
        btnLog.Top = 30
        btnLog.Text = "Log"
        btnHelp.Top = 12
        btnHelp.Left = 697
        txtPalette.ReadOnly = True
        movessequence = ""

        Me.Controls.Add(PaletteY)
        Me.Controls.Add(PaletteW)
        Me.Controls.Add(PaletteB)
        Me.Controls.Add(PaletteG)
        Me.Controls.Add(PaletteR)
        Me.Controls.Add(PaletteO)
        PaletteY.BackColor = Color.Yellow
        PaletteW.BackColor = Color.White
        PaletteB.BackColor = Color.Blue
        PaletteG.BackColor = Color.Green
        PaletteR.BackColor = Color.Red
        PaletteO.BackColor = Color.Orange
        PaletteY.Top = 80
        PaletteY.Left = 15
        PaletteW.Top = 80
        PaletteW.Left = 75
        PaletteB.Top = 140
        PaletteB.Left = 15
        PaletteG.Top = 140
        PaletteG.Left = 75
        PaletteR.Top = 200
        PaletteR.Left = 15
        PaletteO.Top = 200
        PaletteO.Left = 75
        PaletteY.Text = ""
        PaletteW.Text = ""
        PaletteB.Text = ""
        PaletteG.Text = ""
        PaletteR.Text = ""
        PaletteO.Text = ""

        Me.Controls.Add(FaceW)
        FaceW.Left = 310
        FaceW.Top = 210

        Me.Controls.Add(FaceY)
        FaceY.Left = 310
        FaceY.Top = 30

        Me.Controls.Add(FaceB)
        FaceB.Left = 310
        FaceB.Top = 120

        Me.Controls.Add(FaceG)
        FaceG.Left = 490
        FaceG.Top = 120

        Me.Controls.Add(FaceR)
        FaceR.Left = 400
        FaceR.Top = 120

        Me.Controls.Add(FaceO)
        FaceO.Left = 220
        FaceO.Top = 120

        For i = 0 To 2
            For j = 0 To 2
                For k = 0 To 2
                    Cube(i, j, k) = New Cubie
                    If i <> 1 And j <> 1 And k <> 1 Then
                        Cube(i, j, k).SetCubieType(3) 'corner
                    ElseIf (i = 1 And j <> 1 And k <> 1) Or (i <> 1 And j <> 1 And k = 1) Or (i <> 1 And j = 1 And k <> 1) Then
                        Cube(i, j, k).SetCubieType(2) 'edge
                    ElseIf (i = 1 And j = 1 And k <> 1) Or (i <> 1 And j = 1 And k = 1) Or (i = 1 And j <> 1 And k = 1) Then
                        Cube(i, j, k).SetCubieType(1) 'centre
                    End If
                Next
            Next
        Next
        Cube(1, 1, 1).SetCubieType(0) 'middle middle middle

        Moves.reset(Cube, FaceW, FaceY, FaceG, FaceB, FaceR, FaceO)

        sLogString = sLogString + "Session started.
"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Moves.reset(Cube,
                     FaceW, FaceY,
                     FaceG, FaceB,
                     FaceR, FaceO)
        If movessequence <> "" Then
            sLogString = sLogString + "
"
        End If
        movessequence = ""
        sLogString = sLogString + "Cube resetted.
"
    End Sub

    Private Sub L_Click(sender As Object, e As EventArgs) Handles btnL.Click
        Moves.L(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("L")
    End Sub

    Private Sub R_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Moves.R(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("R")
    End Sub

    Private Sub U_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Moves.U(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("U")
    End Sub

    Private Sub D_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Moves.D(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("D")
    End Sub

    Private Sub F_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Moves.F(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("F")
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Moves.B(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("B")
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles btnM.Click
        Moves.M(Cube, FaceB, FaceY, FaceG, FaceW)
        Dim cubesolved As Boolean = CheckSolved("M")
    End Sub

    Private Sub E_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Moves.E(Cube,
                 FaceB, FaceG,
                 FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("E")
    End Sub

    Private Sub S_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Moves.S(Cube,
                 FaceY, FaceW,
                 FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("S")
    End Sub

    Private Sub btnLa_Click(sender As Object, e As EventArgs) Handles btnLa.Click
        Moves.La(Cube, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("L'")
    End Sub

    Private Sub btnRa_Click(sender As Object, e As EventArgs) Handles btnRa.Click
        Moves.Ra(Cube, FaceR, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("R'")
    End Sub

    Private Sub btnUa_Click(sender As Object, e As EventArgs) Handles btnUa.Click
        Moves.Ua(Cube, FaceY, FaceB, FaceG, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("U'")
    End Sub

    Private Sub btnDa_Click(sender As Object, e As EventArgs) Handles btnDa.Click
        Moves.Da(Cube, FaceW, FaceB, FaceG, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("D'")
    End Sub

    Private Sub btnFa_Click(sender As Object, e As EventArgs) Handles btnFa.Click
        Moves.Fa(Cube, FaceB, FaceY, FaceW, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("F'")
    End Sub

    Private Sub btnBa_Click(sender As Object, e As EventArgs) Handles btnBa.Click
        Moves.Ba(Cube, FaceG, FaceY, FaceW, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("B'")
    End Sub

    Private Sub btnMa_Click(sender As Object, e As EventArgs) Handles btnMa.Click
        Moves.Ma(Cube, FaceB, FaceY, FaceG, FaceW)
        Dim cubesolved As Boolean = CheckSolved("M'")
    End Sub

    Private Sub btnEa_Click(sender As Object, e As EventArgs) Handles btnEa.Click
        Moves.Ea(Cube,
                 FaceB, FaceG,
                 FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("E'")
    End Sub

    Private Sub btnSa_Click(sender As Object, e As EventArgs) Handles btnSa.Click
        Moves.Sa(Cube, FaceY, FaceW, FaceR, FaceO)
        Dim cubesolved As Boolean = CheckSolved("S'")
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        Moves.x(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("x")
    End Sub

    Private Sub btny_Click(sender As Object, e As EventArgs) Handles btny.Click
        Moves.y(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("y")
    End Sub

    Private Sub btnz_Click(sender As Object, e As EventArgs) Handles btnz.Click
        Moves.z(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("z")
    End Sub

    Private Sub btnxa_Click(sender As Object, e As EventArgs) Handles btnxa.Click
        Moves.xa(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("x'")
    End Sub

    Private Sub btnya_Click(sender As Object, e As EventArgs) Handles btnya.Click
        Moves.ya(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("y'")
    End Sub

    Private Sub btnza_Click(sender As Object, e As EventArgs) Handles btnza.Click
        Moves.za(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Dim cubesolved As Boolean = CheckSolved("z'")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim helpstring As String = "Help box.

Moves:
R - Turns the right face clockwise by 90
L - Turns the left face clockwise
U - Turns the up face clockwise
D - Turns the down face clockwise
F - Turns the front face clockwise
B - Turns the back face clockwise
Rotations:
x - Rotates the cube from down to up
y - Rotates the cube from right to left
z - Rotates the cube clockwise around the front
If the button has a ', it turns the corresponding face or rotation anticlockwise.

To use the palette, either:
1. Select the colour from the palette that you wish to put on the cube
2. Select the face;et you wish to change colour
Or:
1. Select the facelet you wish to edit the colour of.
2. Select the colour from the palette that you wish to put on the selected facelet.

The scramble has a maximum limit of 30 and includes 180 moves and rotations.
The reset button resets the cube.

Have a nice day!"
        MsgBox(helpstring)
    End Sub

    Private Sub ArrangeButtons()

        'top row buttons
        btnL.Top = 315
        btnL.Left = 358 - 3 * 81
        btnR.Top = 315
        btnR.Left = 358 - 2 * 81
        btnU.Top = 315
        btnU.Left = 358 - 1 * 81
        btnD.Top = 315
        btnD.Left = 358 + 0 * 81
        btnF.Top = 315
        btnF.Left = 358 + 1 * 81
        btnB.Top = 315
        btnB.Left = 358 + 2 * 81

        '2nd row buttons
        btnLa.Top = 315 + 29
        btnLa.Left = 358 - 3 * 81
        btnRa.Top = 315 + 29
        btnRa.Left = 358 - 2 * 81
        btnUa.Top = 315 + 29
        btnUa.Left = 358 - 1 * 81
        btnDa.Top = 315 + 29
        btnDa.Left = 358 + 0 * 81
        btnFa.Top = 315 + 29
        btnFa.Left = 358 + 1 * 81
        btnBa.Top = 315 + 29
        btnBa.Left = 358 + 2 * 81

        '3rd row buttons
        btnM.Top = 315 + 29 * 2
        btnM.Left = 358 - 3 * 81
        btnE.Top = 315 + 29 * 2
        btnE.Left = 358 - 2 * 81
        btnS.Top = 315 + 29 * 2
        btnS.Left = 358 - 1 * 81
        btnx.Top = 315 + 29 * 2
        btnx.Left = 358 + 0 * 81
        btny.Top = 315 + 29 * 2
        btny.Left = 358 + 1 * 81
        btnz.Top = 315 + 29 * 2
        btnz.Left = 358 + 2 * 81

        '4th row buttons
        btnMa.Top = 315 + 29 * 3
        btnMa.Left = 358 - 3 * 81
        btnEa.Top = 315 + 29 * 3
        btnEa.Left = 358 - 2 * 81
        btnSa.Top = 315 + 29 * 3
        btnSa.Left = 358 - 1 * 81
        btnxa.Top = 315 + 29 * 3
        btnxa.Left = 358 + 0 * 81
        btnya.Top = 315 + 29 * 3
        btnya.Left = 358 + 1 * 81
        btnza.Top = 315 + 29 * 3
        btnza.Left = 358 + 2 * 81

        btnL.Text = "L"
        btnR.Text = "R"
        btnU.Text = "U"
        btnD.Text = "D"
        btnF.Text = "F"
        btnB.Text = "B"
        btnLa.Text = "L'"
        btnRa.Text = "R'"
        btnUa.Text = "U'"
        btnDa.Text = "D'"
        btnFa.Text = "F'"
        btnBa.Text = "B'"
        btnM.Text = "M"
        btnE.Text = "E"
        btnS.Text = "S"
        btnx.Text = "x"
        btny.Text = "y"
        btnz.Text = "z"
        btnMa.Text = "M'"
        btnEa.Text = "E'"
        btnSa.Text = "S'"
        btnxa.Text = "x'"
        btnya.Text = "y'"
        btnza.Text = "z'"

    End Sub

    Public Function CheckSolved(moveinitial As String)
        Dim cubesolved As Boolean = True
        Dim i As Integer
        Dim j As Integer
        Dim faceletnumber As Integer = 0

        Do While cubesolved = True And faceletnumber < 9
            i = Math.Floor(faceletnumber / 3)
            j = faceletnumber Mod 3
            If FaceW.faceletsArray(i, j).BackColor <> Color.White Then
                cubesolved = False
            ElseIf FaceY.faceletsArray(i, j).BackColor <> Color.Yellow Then
                cubesolved = False
            ElseIf FaceB.faceletsArray(i, j).BackColor <> Color.Blue Then
                cubesolved = False
            ElseIf FaceG.faceletsArray(i, j).BackColor <> Color.Green Then
                cubesolved = False
            ElseIf FaceR.faceletsArray(i, j).BackColor <> Color.Red Then
                cubesolved = False
            ElseIf FaceO.faceletsArray(i, j).BackColor <> Color.Orange Then
                cubesolved = False
            End If
            faceletnumber = faceletnumber + 1
        Loop

        If moveinitial <> "" Then
            If movessequence = "" Then
                sLogString = sLogString + "Moves: " + moveinitial
            Else
                sLogString = sLogString + ", " + moveinitial
            End If
        End If

        movessequence = movessequence + moveinitial

        If cubesolved = True And moveinitial <> "" Then
            MsgBox("Congratulations! You have solved the cube.")
            sLogString = sLogString + "
Cube solved.
"
            movessequence = ""
        End If


        Return cubesolved
    End Function

    Private Sub ShowLog() Handles btnLog.Click
        MsgBox(sLogString)
    End Sub

    Private Sub PaletteY_Click(sender As Object, e As EventArgs) Handles PaletteY.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteY_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            MsgBox("You are not in editing mode!")
        End If
    End Sub

    Private Sub PaletteW_Click(sender As Object, e As EventArgs) Handles PaletteW.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteW_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            msgbox("You are not in editing mode!")
        End If
    End Sub

    Private Sub PaletteB_Click(sender As Object, e As EventArgs) Handles PaletteB.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteB_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            MsgBox("You are not in editing mode!")
        End If
    End Sub

    Private Sub PaletteG_Click(sender As Object, e As EventArgs) Handles PaletteG.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteG_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            MsgBox("You are not in editing mode!")
        End If
    End Sub

    Private Sub PaletteR_Click(sender As Object, e As EventArgs) Handles PaletteR.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteR_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            MsgBox("You are not in editing mode!")
        End If
    End Sub

    Private Sub PaletteO_Click(sender As Object, e As EventArgs) Handles PaletteO.Click
        If chkEditingMode.Checked = True Then
            PaletteChanges.PaletteO_click(faceletface, paletteselected,
                       FaceY, FaceW,
                       FaceB, FaceG,
                       FaceR, FaceO)
        Else
            MsgBox("You are not in editing mode!")
        End If
    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Dim returnstring As String = Moves.CheckSolvable(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        If returnstring = "" Then
            Moves.SOLVE(Cube, FaceR, FaceO, FaceB, FaceG, FaceY, FaceW)
        Else
            MsgBox(returnstring)
        End If
        If movessequence <> "" Then
            sLogString = sLogString + "
"
        End If
        movessequence = ""
        sLogString = sLogString + "Solve asked for.
"
    End Sub


    Public Function checkEditingMode() As Boolean
        Return chkEditingMode.Checked
    End Function
End Class
