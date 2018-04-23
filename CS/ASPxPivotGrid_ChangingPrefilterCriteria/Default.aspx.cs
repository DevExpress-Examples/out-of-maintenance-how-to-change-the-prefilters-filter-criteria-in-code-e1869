using System;
using System.Web.UI;

namespace ChangingPrefilterCriteria {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxPivotGrid1.Prefilter.CriteriaString = "[" + fieldCountry.PrefilterColumnName + 
                "] == 'UK' OR [" + fieldCountry.PrefilterColumnName + "] == 'USA'";
        }
    }
}
