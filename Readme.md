<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128594150/21.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4543)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [EntityFrameworkSampleObject.cs](./CS/MultipleORMsExample.Module/BusinessObjects/EntityFrameworkSampleObject.cs) (VB: [EntityFrameworkSampleObject.vb](./VB/MultipleORMsExample.Module/BusinessObjects/EntityFrameworkSampleObject.vb))
* [XpoSampleObject.cs](./CS/MultipleORMsExample.Module/BusinessObjects/XpoSampleObject.cs) (VB: [XpoSampleObject.vb](./VB/MultipleORMsExample.Module/BusinessObjects/XpoSampleObject.vb))
* [Updater.cs](./CS/MultipleORMsExample.Module/DatabaseUpdate/Updater.cs) (VB: [Updater.vb](./VB/MultipleORMsExample.Module/DatabaseUpdate/Updater.vb))
* [WebApplication.cs](./CS/MultipleORMsExample.Web/WebApplication.cs) (VB: [WebApplication.vb](./VB/MultipleORMsExample.Web/WebApplication.vb))
* **[WinApplication.cs](./CS/MultipleORMsExample.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/MultipleORMsExample.Win/WinApplication.vb))**
<!-- default file list end -->
# OBSOLETE - How to: Use both Entity Framework 6 and XPO in a Single Application

>**NOTE**: We encourage our Entity Framework 6 (EF 6) users to consider Entity Framework Core (EF Core) for new XAF's Blazor and WinForms .NET Core projects.
Microsoft has moved EF 6 into maintenance mode, and as such, EF 6 will not mirror XAF’s .NET 5+ offering. At present, EF Core supports key XAF technologies/capabilities including advanced security and comprehensive audit trail support. EF Core also offers better performance when compared to EF 6. For more information, see [Porting from EF 6 to EF Core](https://docs.microsoft.com/en-us/ef/efcore-and-ef6/porting/) | [XAF Business Model Design with Entity Framework Core](https://docs.devexpress.com/eXpressAppFramework/401886/business-model-design-orm/business-model-design-with-entity-framework-core).

<p>This example demonstrates how to create a simple XAF application that uses both Entity Framework (EF 6) and eXpress Persistent Objects (XPO) business models. For instance, this approach can be required if you want to reuse the Entity Framework model from a non-XAF application in your existing XPO-based XAF project. As a result, your application will access two databases, the first one via XPO and the second - via EF.</p><p>The complete description is available in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3476"><u>How to: Use both Entity Framework and XPO in a Single Application</u></a> topic.</p><br />
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-both-entity-framework-and-xpo-in-a-single-application-e4543/21.2.8+/media/6316e026-5868-492b-9687-c12ad1d08118.png"><br />
<strong>See also:</strong> <br />
<a href="https://www.devexpress.com/Support/Center/p/E1150">How to prevent altering the legacy database schema when creating an XAF application</a><u><br />
</u><a href="https://www.devexpress.com/Support/Center/p/E4896">How to implement XPO data models connected to different databases within a single application</a></p>

<br/>


