Public Class Face
    Dim colour As Color
    Public faceletsArray(2, 2) As Facelet
    Private Sub Face_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim j As Integer
        For faceletnumber = 0 To 8
            i = faceletnumber Mod 3
            j = Math.Floor(faceletnumber / 3)
            faceletsArray(i, j) = New Facelet
            faceletsArray(i, j).i = i
            faceletsArray(i, j).j = j
            faceletsArray(i, j).Left = i * 30
            faceletsArray(i, j).Top = j * 30
            Me.Controls.Add(faceletsArray(i, j))
        Next
    End Sub

    Public Sub changefaceletcolour(i, j)
        faceletsArray(i, j).BackColor = PaletteChanges.currentpalettecolour
    End Sub
End Class
