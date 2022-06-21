Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System.Configuration
Imports DevExpress.ExpressApp.EF
Imports MultipleORMsExample.Module.BusinessObjects

Namespace MultipleORMsExample.Win

    Public Partial Class MultipleORMsExampleWindowsFormsApplication
        Inherits WinApplication

        Public Sub New()
            InitializeComponent()
            DelayedViewItemsInitialization = True
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProviders.Add(New XPObjectSpaceProvider(ConfigurationManager.ConnectionStrings("ConnectionStringXpo").ConnectionString, Nothing))
            args.ObjectSpaceProviders.Add(New EFObjectSpaceProvider(GetType(MyDbContext), ConfigurationManager.ConnectionStrings("ConnectionStringEF").ConnectionString))
        End Sub

        Private Sub MultipleORMsExampleWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Microsoft.VisualBasic.Constants.vbCrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Microsoft.VisualBasic.Constants.vbCrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & Microsoft.VisualBasic.Constants.vbCrLf & "Anyway, refer to the 'Update Application and Database Versions' help topic at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm " & "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/")
            End If
        End Sub

        Private Sub MultipleORMsExampleWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs)
            Dim userLanguageName As String = Threading.Thread.CurrentThread.CurrentUICulture.Name
            If Not Equals(userLanguageName, "en-US") AndAlso e.Languages.IndexOf(userLanguageName) = -1 Then
                e.Languages.Add(userLanguageName)
            End If
        End Sub
    End Class
End Namespace
