//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameStateComponentsLookup {

    public const int CanInteractListener = 0;
    public const int CanInteract = 1;
    public const int Pause = 2;
    public const int PlayerAlive = 3;
    public const int State = 4;
    public const int Window = 5;
    public const int WindowListener = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "CanInteractListener",
        "CanInteract",
        "Pause",
        "PlayerAlive",
        "State",
        "Window",
        "WindowListener"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(CanInteractListenerComponent),
        typeof(LamaGamma.Components.CanInteract),
        typeof(LamaGamma.Components.Pause),
        typeof(LamaGamma.Components.PlayerAlive),
        typeof(LamaGamma.Components.State),
        typeof(LamaGamma.Components.Window),
        typeof(WindowListenerComponent)
    };
}
