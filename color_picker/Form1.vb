Public Class Form1

    Private colors As New ColorDialog
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click

        Try
            If (colors.ShowDialog() = DialogResult.OK) Then
                Me.Panel1.BackColor = colors.Color
                If (Me.CheckBox1.Checked = True) Then
                    Me.TextBox1.Text = colors.Color.Name
                    Me.TextBox2.Text = colors.Color.R.ToString() + ", " + colors.Color.G.ToString() + ", " + colors.Color.B.ToString() + ", " + colors.Color.A.ToString()
                    Me.TextBox3.Text = Decimal.ToDouble(colors.Color.R / 255).ToString() + ", " + Decimal.ToDouble(colors.Color.G / 255).ToString() + ", " + Decimal.ToDouble(colors.Color.B / 255).ToString() + ", " + Decimal.ToDouble(Convert.ToInt32(Me.TextBox4.Text) / 255).ToString()
                Else
                    Me.TextBox1.Text = colors.Color.Name
                    Me.TextBox2.Text = colors.Color.A.ToString() + ", " + colors.Color.R.ToString() + ", " + colors.Color.G.ToString() + ", " + colors.Color.B.ToString()
                    Me.TextBox3.Text = Decimal.ToDouble(Convert.ToInt32(Me.TextBox4.Text) / 255).ToString() + ", " + Decimal.ToDouble(colors.Color.R / 255).ToString() + ", " + Decimal.ToDouble(colors.Color.G / 255).ToString() + ", " + Decimal.ToDouble(colors.Color.B / 255).ToString()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.TextBox1.TextLength() > 0 And Me.TextBox2.TextLength() > 0 And Me.TextBox3.TextLength() > 0 And Me.TextBox4.TextLength() > 0) Then
            If (RadioButton1.Checked = True) Then
                My.Computer.Clipboard.SetText(Me.TextBox1.Text)
            ElseIf (RadioButton2.Checked = True) Then
                My.Computer.Clipboard.SetText(Me.TextBox2.Text)
            ElseIf (RadioButton3.Checked = True) Then
                My.Computer.Clipboard.SetText(Me.TextBox3.Text)
            End If
        End If
    End Sub
End Class
