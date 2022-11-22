Public Class ModalRegistro

    Public Property Data As Dictionary(Of String, String)
    Public Property Title As String
    Private indexA As Integer = 25
    Private indexB As Integer = 45

    Private Sub createOption(ByVal key As String, ByVal name As String)
        Dim label = New Label()
        label.Text = name
        label.Location = New Point(20, indexA)
        Dim textBox = New TextBox
        textBox.Tag = key
        textBox.Location = New Point(20, indexB)
        textBox.Size = New Size(100, 20)
        Me.Controls.Add(textBox)
        Me.Controls.Add(label)
        indexA += 45
        indexB += 45
    End Sub

    Private Sub ModalRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        titleLabel.Text = Title
        For Each pair As KeyValuePair(Of String, String) In Data
            createOption(pair.Key, pair.Value)
        Next
    End Sub

    Private Sub ModalRegistro_UnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Data = New Dictionary(Of String, String)()
        Title = ""
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Data = New Dictionary(Of String, String)()
        Me.Hide()
    End Sub
End Class