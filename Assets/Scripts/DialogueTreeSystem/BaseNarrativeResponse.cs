using System;
using Unity.VisualScripting;
using UnityEngine;

public interface INarrativeResponse
{
    void StartResponse();
    void StopResponse();
}
[CreateAssetMenu(fileName = "BaseNarrativeResponse", menuName = "Scriptable Objects/BaseNarrativeResponse")]
public class BaseNarrativeResponse : ScriptableObject, INarrativeResponse
{
    [SerializeField] public string responseText; // Text to display on a button
    [SerializeField] public BaseNode nextNode; // The node to transition to when this response is selected

    #region ScriptableObject Methods
    private void Awake()
    {
    }

    private void Start()
    {
    }
    #endregion

    #region INarrativeResponse Implementation
    public void StartResponse()
    {
        // Implementation for starting the response
    }
    public void StopResponse()
    {
        // Implementation for stopping the response
    }
    #endregion
}
