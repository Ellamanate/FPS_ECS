//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if (_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public GameplayContext gameplay { get; set; }
    public GameStateContext gameState { get; set; }
    public InputContext input { get; set; }
    public UIContext uI { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { gameplay, gameState, input, uI }; } }

    public Contexts() {
        gameplay = new GameplayContext();
        gameState = new GameStateContext();
        input = new InputContext();
        uI = new UIContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach (var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string Id = "Id";
    public const string InSightId = "InSightId";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        gameplay.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameplayEntity, int>(
            Id,
            gameplay.GetGroup(GameplayMatcher.Id),
            (e, c) => ((LamaGamma.Components.Id)c).Value));

        gameplay.AddEntityIndex(new Entitas.EntityIndex<GameplayEntity, int>(
            InSightId,
            gameplay.GetGroup(GameplayMatcher.InSightId),
            (e, c) => ((LamaGamma.Components.InSightId)c).Value));
    }
}

public static class ContextsExtensions {

    public static GameplayEntity GetEntityWithId(this GameplayContext context, int Value) {
        return ((Entitas.PrimaryEntityIndex<GameplayEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(Value);
    }

    public static System.Collections.Generic.HashSet<GameplayEntity> GetEntitiesWithInSightId(this GameplayContext context, int Value) {
        return ((Entitas.EntityIndex<GameplayEntity, int>)context.GetEntityIndex(Contexts.InSightId)).GetEntities(Value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContextObservers() {
        try {
            CreateContextObserver(gameplay);
            CreateContextObserver(gameState);
            CreateContextObserver(input);
            CreateContextObserver(uI);
        } catch(System.Exception) {
        }
    }

    public void CreateContextObserver(Entitas.IContext context) {
        if (UnityEngine.Application.isPlaying) {
            var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
            UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
        }
    }

#endif
}
