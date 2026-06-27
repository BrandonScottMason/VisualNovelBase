using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseConversation", menuName = "Scriptable Objects/BaseConversation")]
/// <summary>
/// A conversation is a collection of narrative nodes that are connected to each other in a dialogue tree. A conversation is not restricted to a set number of participants or a single interaction.
/// It's more of a line of though that can be followed by the player, and can branch off into different directions based on the choices the player makes.
/// </summary>
public class BaseConversation : ScriptableObject
{
    [SerializeField] public List<BaseNarrativeNode> narrativeNodes = new List<BaseNarrativeNode>();
}
