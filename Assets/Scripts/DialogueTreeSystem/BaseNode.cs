using UnityEngine;

/// <summary>
/// BaseNode is the base class for all nodes in the dialogue tree. It contains common properties and methods that all nodes will share.
/// </summary>
public class BaseNode : ScriptableObject
{
    public string NodeID; // Unique identifier for the node, used for saving/loading and referencing nodes in the dialogue tree. May be auto-generated.
}
