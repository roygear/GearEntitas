//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class Test2Matcher {

    static IMatcher<Test2Entity> _matcherMyNamespaceMyNamespace;

    public static IMatcher<Test2Entity> MyNamespaceMyNamespace {
        get {
            if(_matcherMyNamespaceMyNamespace == null) {
                var matcher = (Matcher<Test2Entity>)Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.MyNamespaceMyNamespace);
                matcher.componentNames = Test2ComponentsLookup.componentNames;
                _matcherMyNamespaceMyNamespace = matcher;
            }

            return _matcherMyNamespaceMyNamespace;
        }
    }
}
