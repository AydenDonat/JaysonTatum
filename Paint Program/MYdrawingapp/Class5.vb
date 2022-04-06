Public Class polygon
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point


    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            '  g.DrawLine(Pen, m_a, m_b)
            'g.DrawArc(Pen, m_a.X, m_a.Y, 100, 100, 0, 90)
            '  g.DrawPie(Pen, m_a.X, m_a.Y, 100, 100, 0, 90)
            '  g.DrawRectangle(Pen, m_a.X, m_a.Y, 100, 100)
            Dim points(3) As Point
            points(0) = New Point(m_a.X, m_a.Y)
            points(1) = New Point(m_a.X, m_a.Y + 50)
            points(3) = New Point(m_a.X + 50, m_a.Y)
            points(2) = New Point(m_a.X + 50, m_a.Y + 50)
            g.DrawPolygon(Pen, points)
            'g.FillRectangle(New SolidBrush(Pen.Color), m_a.X, m_a.Y, 100, 100)
        End Using
    End Sub
End Class


