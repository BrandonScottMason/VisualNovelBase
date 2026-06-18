using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseNarrativeSequence", menuName = "Scriptable Objects/BaseNarrativeSequence")]

/// <summary>
/// This is the top-level container for a scene's narrative content. A basic sequence will typically have a single conversation, but more complex ones can have multiple, layered, conversations.
/// The Narrative Sequence is responsible for keeping track of and managaging each conversation.
/// </summary>
public class BaseNarrativeSequence : ScriptableObject
{
    [SerializeField] List<BaseConversation> conversations = new List<BaseConversation>();
    [SerializeField] float VersionNumber;
}
