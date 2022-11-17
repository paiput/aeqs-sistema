Public Class Modal_REmpleados

    Public Property Data As Dictionary(Of String, String)
    Public Property Title As String
    Private index As Integer = 4

    Private Sub createOption(ByVal key As String, ByVal name As String)
        index += 26
        Dim label = New Label()
        label.Text = name
        label.Location = New Point(20, index)
        Dim textBox = New TextBox
        textBox.Tag = key
        textBox.Location = New Point(70, index)
        textBox.Size = New Size(100, 20)
        Me.Controls.Add(textBox)
        Me.Controls.Add(label)
    End Sub

    Private Sub Modal_REmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        titleLabel.text = Title
        For Each pair As KeyValuePair(Of String, String) In Data
            createOption(pair.Key, pair.Value)
        Next
    End Sub

    Private Sub Modal_REmpleados_UnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Data = New Dictionary(Of String, String)()
        Title = ""
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Data = New Dictionary(Of String, String)()
        Me.Hide()
    End Sub
End Class