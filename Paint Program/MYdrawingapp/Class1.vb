Public Class MyRect
    Public Property pen As Pen
    Public Property fill As Boolean
    Public Property color1 As Color
    Public Property color2 As Color
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            If fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(100, 10),
                                color1,
                                color2)


                g.FillRectangle(lingrBrush, m_a.X, m_a.Y, 500, 100)
            Else
                g.DrawRectangle(pen, m_a.X, m_a.Y, 500, 100)
            End If

        End Using
    End Sub

End Class
