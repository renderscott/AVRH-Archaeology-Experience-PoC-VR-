using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisplayInformationIfHovered : MonoBehaviour
{
    [SerializeField] private GameObject m_informationPanelCanvas;
    
    public void OnFirstHoverEnter(HoverEnterEventArgs args)
    {
        if(!m_informationPanelCanvas.activeSelf)
            m_informationPanelCanvas.SetActive(true);
        ScoreTracker.Instance.triggerInteraction(gameObject);
    }
    
    public void OnLastHoverExit(HoverExitEventArgs args)
    {
        if(m_informationPanelCanvas.activeSelf)
            m_informationPanelCanvas.SetActive(false);
    }
}
