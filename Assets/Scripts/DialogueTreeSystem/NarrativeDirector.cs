using UnityEngine;

public class NarrativeDirector : MonoBehaviour
{
    public StartNode StartNode;

    private void Awake()
    {
        if (StartNode == null)
        {
            Debug.LogError("StartNode is not assigned in the NarrativeDirector.");
        }
        else
        {
            // Do any initalization in the StartNode if needed

        }
    }
}
