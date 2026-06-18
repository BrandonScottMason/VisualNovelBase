using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseConversation", menuName = "Scriptable Objects/BaseConversation")]
public class BaseConversation : ScriptableObject
{
    [SerializeField] List<BaseNarrativeNode> narrativeNodes = new List<BaseNarrativeNode>();
}
