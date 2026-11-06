using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisplayInformationIfHovered : MonoBehaviour
{
    [SerializeField] private GameObject _informationPanelCanvas;
    
    public void OnFirstHoverEnter(HoverEnterEventArgs args)
    {
        if(!_informationPanelCanvas.activeSelf)
            _informationPanelCanvas.SetActive(true);
        ScoreTracker.Instance.TriggerInteraction(gameObject);
    }
    
    public void OnLastHoverExit(HoverExitEventArgs args)
    {
        if(_informationPanelCanvas.activeSelf)
            _informationPanelCanvas.SetActive(false);
    }
}