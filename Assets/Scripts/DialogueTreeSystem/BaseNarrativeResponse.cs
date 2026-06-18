using System;
using UnityEngine;

public interface INarrativeResponse
{
    void StartResponse();
    void StopResponse();
}
[CreateAssetMenu(fileName = "BaseNarrativeResponse", menuName = "Scriptable Objects/BaseNarrativeResponse")]
public class BaseNarrativeResponse : ScriptableObject, INarrativeResponse
{
    [SerializeField] string responseText; // Text to display on a button
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
