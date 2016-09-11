Public Class MainForm


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub btnHombre_Click(sender As Object, e As EventArgs) Handles btnHombre.Click
        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btnCalzados_Click(sender As Object, e As EventArgs) Handles btnCalzados.Click
        btnMujeres.ForeColor = Color.Black
        btnCalzados.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btnAccesorio_Click(sender As Object, e As EventArgs) Handles btnAccesorio.Click
        btnCalzados.ForeColor = Color.Black
        btnAccesorio.ForeColor = Color.SteelBlue
        btnHombre.ForeColor = Color.Black

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        lblTituloProducto.Text = "Camisa de Algodon"
        lblTitulo.Text = "$120"
        lblTalla.Text = "Talla "

        pbCover.Image = ilProductos.Images.Item(0)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        lblTituloProducto.Text = "Blazer Mezcla de Lana"
        lblTitulo.Text = "$240"
        lblTalla.Text = "Talla "

        pbCover.Image = ilProductos.Images.Item(1)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblTituloProducto.Text = "Jersey Cuello Pico"
        lblTitulo.Text = "$160"
        lblTalla.Text = "Talla "

        pbCover.Image = ilProductos.Images.Item(2)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblTituloProducto.Text = "Polo Cuello Redondo"
        lblTitulo.Text = "$70"
        lblTalla.Text = "Talla "

        pbCover.Image = ilProductos.Images.Item(3)
    End Sub
End Class