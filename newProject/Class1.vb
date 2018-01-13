Public Class clsWordOpt
    Private m_WordApp As Object
    Private m_WordDoc As Object

    Public Sub Create()
        Dim objWordType As Type

        Try
            objWordType = Type.GetTypeFromProgID("Word.Application")
            m_WordApp = Activator.CreateInstance(objWordType)
            objWordType = Type.GetTypeFromProgID("Word.Document")
            m_WordDoc = Activator.CreateInstance(objWordType)
        Catch e As Exception
            'MessageBox.Show(e.ToString)
        End Try
    End Sub
    Public Sub Open(fn As String)
        Try
            m_WordDoc = m_WordApp.Documents.Open(fn, , False)
            m_WordDoc.Activate()
        Catch e As Exception
            'MessageBox.Show(e.ToString)
        End Try
    End Sub
    Public Sub Replace(s1 As String, s2 As String)
        Try
            m_WordDoc.Range.Find.Execute(s1, False, False, False, False, False, True, 1, False, s2, 2)
            For Each os In m_WordDoc.Sections
                For Each oh In os.Headers
                    oh.Range.Find.Execute(s1, False, False, False, False, False, True, 1, False, s2, 2)
                Next
            Next
        Catch e As Exception
            'MessageBox.Show(e.ToString)
        End Try
    End Sub
    Public Sub Save()
        Try
            m_WordDoc.Save()
        Catch e As Exception
            'MessageBox.Show(e.ToString)
        End Try
    End Sub
    Public Sub SaveAs(fn As String)
        Try
            m_WordDoc.SaveAs2(fn)
        Catch e As Exception
            Try
                m_WordDoc.SaveAs(fn)
            Catch e2 As Exception
            End Try
        End Try
    End Sub
    Public Sub Close()
        On Error Resume Next
        m_WordDoc.Close()
    End Sub
    Public Sub Quit()
        m_WordApp.Quit()
    End Sub
End Class
