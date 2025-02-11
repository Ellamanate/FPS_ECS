//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity stateEntity { get { return GetGroup(GameStateMatcher.State).GetSingleEntity(); } }

    public bool isState {
        get { return stateEntity != null; }
        set {
            var entity = stateEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isState = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    static readonly LamaGamma.Components.State stateComponent = new LamaGamma.Components.State();

    public bool isState {
        get { return HasComponent(GameStateComponentsLookup.State); }
        set {
            if (value != isState) {
                var index = GameStateComponentsLookup.State;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : stateComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherState;

    public static Entitas.IMatcher<GameStateEntity> State {
        get {
            if (_matcherState == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.State);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherState = matcher;
            }

            return _matcherState;
        }
    }
}
