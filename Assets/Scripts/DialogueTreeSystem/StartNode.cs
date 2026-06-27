using UnityEngine;

[CreateAssetMenu(fileName = "StartNode", menuName = "Scriptable Objects/StartNode")]
public class StartNode : BaseNode
{
    /// <summary>
    /// Initalizes the scene and starts the first conversation in the narrative sequence.
    /// Responsible for retrieving all data for characters, dialog assets, and any other scene-specific content.
    /// MAYBE: Have this handle removing the loading screen?
    /// MAYBE: Move BaseNarrativeSequence data/functionality into this class.
    /// </summary>

    [SerializeField] public BaseNarrativeSequence NarrativeSequence; // This scene's narrative sequence
}
