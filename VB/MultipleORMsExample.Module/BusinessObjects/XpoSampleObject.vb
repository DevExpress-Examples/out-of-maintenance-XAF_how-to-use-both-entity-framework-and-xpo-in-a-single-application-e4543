Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace MultipleORMsExample.Module.BusinessObjects

    <DefaultClassOptions>
    Public Class XpoSampleObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private nameField As String

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", nameField, value)
            End Set
        End Property

        Private descriptionField As String

        <Size(SizeAttribute.Unlimited)>
        Public Property Description As String
            Get
                Return descriptionField
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Description", descriptionField, value)
            End Set
        End Property
    End Class
End Namespace
