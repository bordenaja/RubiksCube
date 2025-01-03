Public Class Facelet
    Public i As Integer
    Public j As Integer
    Public Sub clicked() Handles Me.Click
        Dim parentface As Face = Me.Parent
        If Form1.checkEditingMode() = True Then
            parentface.changefaceletcolour(i, j)
        End If
    End Sub
End Class
