using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueWindow : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI DialgoueText;
    public Button ResponseButton;

    private List<Button> responseButtons = new List<Button>();

    public void Initialize(BaseNarrativeNode node)
    {
        // Implementation for initializing the dialogue window with the narrative node
        NameText.text = node.speakerName;
        DialgoueText.text = node.speakerDialogue;
        foreach (var response in node.responses)
        {
            Debug.Log("Setting up first response button: " + response.responseText);

            // When we Initalize there will always be a single response button in the scene, so we can use that for the first response.
            if (response == node.responses.First())
            {
                ResponseButton.GetComponentInChildren<TextMeshProUGUI>().text = response.responseText;
                ResponseButton.onClick.AddListener(() => HandleResponseOnClick(response));
                responseButtons.Add(ResponseButton);
            }
            else
            {
                Button responseBttn = Instantiate(ResponseButton, ResponseButton.transform.parent);
                responseBttn.name = "Option" + node.responses.IndexOf(response);
                responseBttn.GetComponentInChildren<TextMeshProUGUI>().text = response.responseText;
                responseBttn.onClick.RemoveAllListeners();
                responseBttn.onClick.AddListener(() => HandleResponseOnClick(response));
            }
        }   
    }

    public void HandleResponseOnClick(BaseNarrativeResponse response)
    {
        // Implementation for handling the selected response
        BaseNarrativeNode node = response.nextNode as BaseNarrativeNode;

        if (node != null)
        {
            NameText.text = node.speakerName;
            DialgoueText.text = node.speakerDialogue;

            foreach (var r in node.responses)
            {
                Button responseBttn = ResponseButton.transform.parent.Find("Option" + node.responses.IndexOf(r))?.GetComponent<Button>();
                if (responseBttn != null)
                {
                    responseBttn.GetComponentInChildren<TextMeshProUGUI>().text = r.responseText;
                    responseBttn.onClick.RemoveAllListeners();
                    responseBttn.onClick.AddListener(() => HandleResponseOnClick(r));
                }
                else
                {
                    Button newResponseBttn = Instantiate(ResponseButton, ResponseButton.transform.parent);
                    newResponseBttn.name = "Option" + node.responses.IndexOf(r);
                    newResponseBttn.GetComponentInChildren<TextMeshProUGUI>().text = r.responseText;
                    newResponseBttn.onClick.RemoveAllListeners();
                    newResponseBttn.onClick.AddListener(() => HandleResponseOnClick(r));
                }
            }
        }
        else if(response.nextNode is EndNode)
        {
            // Handle end of conversation
            Debug.Log("End of conversation reached.");
        }
    }


}
