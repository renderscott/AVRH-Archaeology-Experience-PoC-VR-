using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisplayInformationIfHovered : MonoBehaviour
{
    [SerializeField] private GameObject m_informationPanel;
    
    public void OnFirstHoverEnter(HoverEnterEventArgs args)
    {
        if(!m_informationPanel.activeSelf)
            m_informationPanel.SetActive(true);
    }
    
    public void OnLastHoverExit(HoverExitEventArgs args)
    {
        if(m_informationPanel.activeSelf)
            m_informationPanel.SetActive(false);
    }
}
