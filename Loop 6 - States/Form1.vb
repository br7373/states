Public Class Form1
    Private Sub lstStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedIndexChanged
        Dim state As String 'declaring local variables
        Dim length As String

        'selected item from text box is in the state variable
        state = lstStates.Text
        'the length of the text in the state variable is put into the length variable
        length = state.Length
        'lbllength is equal to the value of length
        lblLength.Text = length

        length.ToString()


    End Sub
End Class

