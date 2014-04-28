Public Class Unit
    Private _UnitID As Integer
    Private _UnitName As String
    Private _UnitDescription As String

    Public Property UnitID() As Integer
        Get
            Return Me._UnitID
        End Get
        Set(ByVal value As Integer)
            Me._UnitID = value
        End Set
    End Property

    Public Property UnitName() As String
        Get
            Return Me._UnitName
        End Get
        Set(ByVal value As String)
            Me._UnitName = value
        End Set
    End Property

    Public Property UnitDescription() As String
        Get
            Return Me._UnitDescription
        End Get
        Set(ByVal value As String)
            Me._UnitDescription = value
        End Set
    End Property
End Class

''' <summary>
''' A Collection of Unit
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class UnitCollection : Inherits System.Collections.ObjectModel.Collection(Of Unit)

End Class

