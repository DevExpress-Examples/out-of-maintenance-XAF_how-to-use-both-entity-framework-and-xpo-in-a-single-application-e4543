Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports MultipleORMsExample.Module.BusinessObjects

Namespace MultipleORMsExample.Module

    Public NotInheritable Partial Class MultipleORMsExampleModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            Call Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of MyDbContext)())
        End Sub

        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() {updater}
        End Function
    End Class
End Namespace
