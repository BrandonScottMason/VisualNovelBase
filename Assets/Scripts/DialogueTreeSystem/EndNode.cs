using UnityEngine;

[CreateAssetMenu(fileName = "EndNode", menuName = "Scriptable Objects/EndNode")]
public class EndNode : BaseNode
{
    /// <summary>
    /// Finalizes the scene and ends the current conversation in the narrative sequence.
    /// Will be responsible for returning us to the main scene/menu/gameplay loop.
    /// </summary>
}
