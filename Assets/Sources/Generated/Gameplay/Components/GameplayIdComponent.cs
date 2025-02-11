//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameplayEntity {

    public LamaGamma.Components.Id id { get { return (LamaGamma.Components.Id)GetComponent(GameplayComponentsLookup.Id); } }
    public bool hasId { get { return HasComponent(GameplayComponentsLookup.Id); } }

    public void AddId(int newValue) {
        var index = GameplayComponentsLookup.Id;
        var component = (LamaGamma.Components.Id)CreateComponent(index, typeof(LamaGamma.Components.Id));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceId(int newValue) {
        var index = GameplayComponentsLookup.Id;
        var component = (LamaGamma.Components.Id)CreateComponent(index, typeof(LamaGamma.Components.Id));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveId() {
        RemoveComponent(GameplayComponentsLookup.Id);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameplayMatcher {

    static Entitas.IMatcher<GameplayEntity> _matcherId;

    public static Entitas.IMatcher<GameplayEntity> Id {
        get {
            if (_matcherId == null) {
                var matcher = (Entitas.Matcher<GameplayEntity>)Entitas.Matcher<GameplayEntity>.AllOf(GameplayComponentsLookup.Id);
                matcher.componentNames = GameplayComponentsLookup.componentNames;
                _matcherId = matcher;
            }

            return _matcherId;
        }
    }
}
