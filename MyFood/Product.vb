Public Class Product


    Private _ProductID As Integer
    Private _Unit As Unit
    Private _ExpirationDate As DateTime?
    Private _NotificationDays As Integer
    Private _Quantity As Integer
    Private _StorageLocation As String
    Private _ProductDetail As ProductDetail
    Private _Category As Category


    Public Property ProductID() As Integer
        Get
            Return Me._ProductID
        End Get
        Set(ByVal value As Integer)
            Me._ProductID = value
        End Set
    End Property

    Public Property Unit() As Unit
        Get
            Return Me._Unit
        End Get
        Set(ByVal value As Unit)
            Me._Unit = value
        End Set
    End Property


    Public Property ExpirationDate() As DateTime?
        Get
            Return Me._ExpirationDate
        End Get
        Set(ByVal value As DateTime?)
            Me._ExpirationDate = value
        End Set
    End Property

    Public Property NotificationDays() As Integer
        Get
            Return Me._NotificationDays
        End Get
        Set(ByVal value As Integer)
            Me._NotificationDays = value
        End Set
    End Property
    Public Property Quantity() As Integer
        Get
            Return Me._Quantity
        End Get
        Set(ByVal value As Integer)
            Me._Quantity = value
        End Set
    End Property


    Public Property StorageLocation() As String
        Get
            Return Me._StorageLocation
        End Get
        Set(ByVal value As String)
            Me._StorageLocation = value
        End Set
    End Property



    Public Property ProductDetail() As ProductDetail
        Get
            Return Me._ProductDetail
        End Get
        Set(ByVal value As ProductDetail)
            Me._ProductDetail = value
        End Set
    End Property

    Public Property Category() As Category
        Get
            Return Me._Category
        End Get
        Set(ByVal value As Category)
            Me._Category = value
        End Set
    End Property


End Class

''' <summary>
''' A Collection of Products
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ProductCollection : Inherits System.Collections.ObjectModel.Collection(Of Product)

End Class