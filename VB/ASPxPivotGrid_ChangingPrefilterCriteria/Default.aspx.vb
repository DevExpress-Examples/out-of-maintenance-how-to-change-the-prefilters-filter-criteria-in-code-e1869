Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Namespace ChangingPrefilterCriteria
	Partial Public Class _Default
		Inherits Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxPivotGrid1.Prefilter.CriteriaString = "[" & fieldCountry.PrefilterColumnName & "] == 'UK' OR [" & fieldCountry.PrefilterColumnName & "] == 'USA'"
		End Sub
	End Class
End Namespace
