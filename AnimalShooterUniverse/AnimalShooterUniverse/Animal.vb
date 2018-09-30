Public Class Animal
    Private mstrhp As Integer
    Private mstrdamage As Integer


    Public Sub New(newhp As Integer, newdamage As Integer)
        mstrhp = newhp
        mstrdamage = newdamage
    End Sub


    Public Property Life() As Integer
        Get
            Return mstrhp
        End Get
        Set(ByVal value As Integer)
            mstrhp = value
        End Set
    End Property

    Public Property Damage() As Integer
        Get
            Return mstrdamage
        End Get
        Set(ByVal value As Integer)
            mstrdamage = value
        End Set
    End Property

End Class
