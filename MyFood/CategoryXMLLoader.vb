Public Class CategoryXMLLoader

    Private _CategoryCollection As CategoryCollection

  
    Public Property CategoryCollection() As CategoryCollection
        Get
            Return _CategoryCollection
        End Get
        Set(ByVal value As CategoryCollection)
            _CategoryCollection = CategoryCollection
        End Set
    End Property


    '********************************************
    ' New
    '********************************************
    Public Sub New(xmlFile As IO.FileInfo)
        _CategoryCollection = New CategoryCollection


        If Not xmlFile Is Nothing Then
            If xmlFile.Exists Then
                Dim XmlDocument As New System.Xml.XmlDocument
                XmlDocument.Load(xmlFile.FullName)
                'Check if <RrfXml> Node exists
                If XmlDocument.Item("categorytable") IsNot Nothing Then
                    Dim xmlDoc As New System.Xml.XmlDocument
                    xmlDoc.Load(xmlFile.FullName)

                    Dim categoryList As System.Xml.XmlNodeList = xmlDoc.GetElementsByTagName("category")
                    Dim i As Integer = 0
                    For Each category As System.Xml.XmlNode In categoryList
                        i = i + 1
                        Dim categoryToAdd As New Category(CInt(category.Item("CategoryID").InnerText), category.Item("CategoryName").InnerText, CBool(category.Item("Active").InnerText))

                        _CategoryCollection.Add(categoryToAdd)






                    Next

                    Console.WriteLine(_CategoryCollection.Count.ToString)

                End If
            End If
        End If
    End Sub
End Class
