using System;
using System.Reflection;

namespace second_Webapi_using_C_sharp_and_SQL.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}