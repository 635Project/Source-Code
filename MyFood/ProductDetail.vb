Public Class ProductDetail
    Private _ProductDetailID As Integer
    Private _Manufactor As String
    Private _UPC As String
    Private _ProductDetailName As String

    Public Property ProductDetailID() As Integer
        Get
            Return Me._ProductDetailID
        End Get
        Set(ByVal value As Integer)
            Me._ProductDetailID = value
        End Set
    End Property

    Public Property MANUFACTOR() As String
        Get
            Return Me._Manufactor
        End Get
        Set(ByVal value As String)
            Me._Manufactor = value
        End Set
    End Property

    Public Property UPC() As String
        Get
            Return Me._UPC
        End Get
        Set(ByVal value As String)
            Me._UPC = value
        End Set
    End Property

    Public Property ProductDetailName() As String
        Get
            Return Me._ProductDetailName
        End Get
        Set(ByVal value As String)
            Me._ProductDetailName = value
        End Set
    End Property

    Public Sub updateDetail()

    End Sub
End Class
''' <summary>
''' A Collection of ProductDetail
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ProductDetailCollection : Inherits System.Collections.ObjectModel.Collection(Of ProductDetail)

End Class