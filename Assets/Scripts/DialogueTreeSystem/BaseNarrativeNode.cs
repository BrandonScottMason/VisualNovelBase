using System.Collections.Generic;
using UnityEngine;

public interface INarrativeNode
{
    void Initialize();
    void EnterNode();
    void ExitNode();
}
[CreateAssetMenu(fileName = "BaseNarrativeNode", menuName = "Scriptable Objects/BaseNarrativeNode")]
public class BaseNarrativeNode : BaseNode, INarrativeNode
{
    [SerializeField] public string speakerName; // This will become an object once we have character scriptable objects setup.
    [SerializeField] public string speakerDialogue;

    // TODO: Add a "Task" field. A Task will lead to a mini-game or some sort of player interaction. If the task is null, then the node will just be a standard dialogue node.
    // Question: Should we instead create a child class called "TaskNarrativeNode" that inherits from BaseNarrativeNode and handles the task itself? This might be a cleaner way to handle it, as it would allow us to keep the BaseNarrativeNode focused on just dialogue-related content

    [SerializeField] public List<BaseNarrativeResponse> responses = new List<BaseNarrativeResponse>();

    #region ScriptableObject Methods
    private void Awake()
    {
        Initialize();
    }

    private void Start()
    {
        EnterNode();
    }
    #endregion

    #region INarrativeNode Implementation
    public virtual void Initialize()
    {
        // Initialize the node's data and state here.
    }
    public virtual void EnterNode()
    {
        // Logic for when the node is entered goes here.
    }
    public virtual void ExitNode()
    {
        // Logic for when the node is exited goes here.
    }
    #endregion
}
