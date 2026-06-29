using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NarrativeDirector : MonoBehaviour
{
    public StartNode StartNode;
    public GameObject DialogueWindowPrefab;

    private List<GameObject> instantiatedObjects = new();

    private void Awake()
    {
        if (StartNode == null)
        {
            Debug.LogError("StartNode is not assigned in the NarrativeDirector.");
        }
    }

    private void Start()
    {
        if (StartNode == null)
        {
            Debug.LogError("StartNode is not assigned in the NarrativeDirector.");
            return;
        }
        else if (DialogueWindowPrefab == null)
        {
            Debug.LogError("DialogueWindowPrefab is not assigned in the NarrativeDirector.");
            return;
        }
        else if (StartNode.NarrativeSequence == null || StartNode.NarrativeSequence.conversations == null || StartNode.NarrativeSequence.conversations.Count == 0)
        {
            Debug.LogError("Narrative Sequence and/or its conversations have not been set up properly.");
            return;
        }

        BaseNarrativeNode currentNode = StartNode.NarrativeSequence.conversations.First().narrativeNodes.First();

        if(currentNode is BaseNarrativeNode)
        {
            var dialogueWindow = Instantiate(DialogueWindowPrefab);
            dialogueWindow.GetComponent<DialogueWindow>().Initialize(currentNode as BaseNarrativeNode);
            instantiatedObjects.Add(dialogueWindow);
        }
    }
}
