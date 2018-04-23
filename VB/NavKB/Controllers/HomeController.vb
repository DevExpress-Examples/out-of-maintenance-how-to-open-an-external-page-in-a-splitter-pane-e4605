Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace NavKB.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function NavBar() As ActionResult
			Return View("NavBar")
		End Function
		Public Function Menu() As ActionResult
			Return View("Menu")
		End Function
		Public Function TreeView() As ActionResult
			Return View("TreeView")
		End Function

		Public Function Content1() As ActionResult
			Return View("ContentPage1")
		End Function
		Public Function Content2() As ActionResult
			Return View("ContentPage2")
		End Function
	End Class
End Namespace