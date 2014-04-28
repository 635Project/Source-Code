Public Class Category
    Private _CategoryID As Integer
    Private _CategoryName As String
    Private _Active As Boolean



    Public Overrides Function ToString() As String
        Return _CategoryName
    End Function


    Public Sub New(categoryId As Integer, categoryName As String, active As Boolean)
        Me._CategoryID = categoryId
        Me._CategoryName = categoryName
        Me._Active = active

    End Sub

    Public Property CategoryID() As Integer
        Get
            Return Me._CategoryID
        End Get
        Set(ByVal value As Integer)
            Me._CategoryID = value
        End Set
    End Property



    Public Property CategoryName() As String
        Get
            Return Me._CategoryName
        End Get
        Set(ByVal value As String)
            Me._CategoryName = value
        End Set
    End Property



    Public Property Active() As Boolean
        Get
            Return Me._Active
        End Get
        Set(ByVal value As Boolean)
            Me._Active = value
        End Set
    End Property



End Class

''' <summary>
''' A Collection of Products
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class CategoryCollection : Inherits System.Collections.ObjectModel.Collection(Of Category)

End Class

