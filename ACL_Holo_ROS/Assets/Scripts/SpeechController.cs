using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.SpatialMapping;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechController : MonoBehaviour, ISpeechHandler
{
    public TextMesh text;
    public EventHandler OnMappingFinished;  // public event notifying subscribers when mapping has finished

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        Debug.Log(eventData.RecognizedText);
        text.text = eventData.RecognizedText;

        switch (eventData.RecognizedText.ToLower())
        {
            case "ready":
                MappingFinished();
                break;
            default:
                break;
        }
    }

    private void MappingFinished()
    {
        OnMappingFinished(this, null);
        SpatialMappingManager.Instance.DrawVisualMeshes = false;
        SpatialMappingManager.Instance.StopObserver();  // stop updating the mesh
        // Make planes here
    }
}
