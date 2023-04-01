using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace second_Webapi_using_C_sharp_and_SQL.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}