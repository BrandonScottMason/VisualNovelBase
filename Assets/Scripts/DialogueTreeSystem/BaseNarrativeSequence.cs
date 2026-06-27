using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseNarrativeSequence", menuName = "Scriptable Objects/BaseNarrativeSequence")]

/// <summary>
/// This is the top-level container for a scene's narrative content. A basic sequence will typically have a single conversation, but more complex ones can have multiple, layered, conversations.
/// The Narrative Sequence is responsible for keeping track of and managaging each conversation.
/// </summary>
public class BaseNarrativeSequence : ScriptableObject
{
    [SerializeField] public List<BaseConversation> conversations = new List<BaseConversation>();
    [SerializeField] public float VersionNumber; // This number may cause more trouble than it's worth. It's intended to prevent the player from loading a save file that is incompatible with the current version of the game.
                                          // However, it may be better to just have a "Save File Version" field in the save file itself, and check that against the current version of the game when loading a save file.
                                          // This would allow us to change the narrative sequence without having to worry about breaking save files.
}
