Public Class cAction
    Private m_ID As Int32
    Private m_GUID As Guid

    Private Sub New()
        m_GUID = Guid.NewGuid
    End Sub

    Public Sub New(ByVal id As Int32)
        MyBase.New()
        m_ID = id
    End Sub

End Class
