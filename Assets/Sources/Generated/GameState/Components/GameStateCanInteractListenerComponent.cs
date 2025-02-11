//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public CanInteractListenerComponent canInteractListener { get { return (CanInteractListenerComponent)GetComponent(GameStateComponentsLookup.CanInteractListener); } }
    public bool hasCanInteractListener { get { return HasComponent(GameStateComponentsLookup.CanInteractListener); } }

    public void AddCanInteractListener(System.Collections.Generic.List<ICanInteractListener> newValue) {
        var index = GameStateComponentsLookup.CanInteractListener;
        var component = (CanInteractListenerComponent)CreateComponent(index, typeof(CanInteractListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCanInteractListener(System.Collections.Generic.List<ICanInteractListener> newValue) {
        var index = GameStateComponentsLookup.CanInteractListener;
        var component = (CanInteractListenerComponent)CreateComponent(index, typeof(CanInteractListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCanInteractListener() {
        RemoveComponent(GameStateComponentsLookup.CanInteractListener);
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

    static Entitas.IMatcher<GameStateEntity> _matcherCanInteractListener;

    public static Entitas.IMatcher<GameStateEntity> CanInteractListener {
        get {
            if (_matcherCanInteractListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.CanInteractListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherCanInteractListener = matcher;
            }

            return _matcherCanInteractListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public void AddCanInteractListener(ICanInteractListener value) {
        var listeners = hasCanInteractListener
            ? canInteractListener.value
            : new System.Collections.Generic.List<ICanInteractListener>();
        listeners.Add(value);
        ReplaceCanInteractListener(listeners);
    }

    public void RemoveCanInteractListener(ICanInteractListener value, bool removeComponentWhenEmpty = true) {
        var listeners = canInteractListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveCanInteractListener();
        } else {
            ReplaceCanInteractListener(listeners);
        }
    }
}
