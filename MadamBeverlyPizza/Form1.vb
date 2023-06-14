Public Class Form1

    
    Private Sub Button_Order_Click(sender As Object, e As EventArgs) Handles Button_Order.Click
        Order_Form.Show()   'shows the second form
        Me.Hide()           'hide this form, why not choose close? because it will end the application..
    End Sub
End Class
