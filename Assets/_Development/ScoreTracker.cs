using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public static ScoreTracker Instance;
    [SerializeField] private TMP_Text _uiText;

    private List<GameObject> _uiInteracted = new List<GameObject>();
    private int _uiTotal;

    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _uiTotal = FindObjectsByType<DisplayInformationIfHovered>().Length;
        updateText();
    }

    public void triggerInteraction(GameObject obj)
    {
        if(!_uiInteracted.Contains(obj)) {
            _uiInteracted.Add(obj);
            updateText();
        }
    }

    private void updateText()
    {
        _uiText.text = "Information found:\n" + _uiInteracted.Count + " / " + _uiTotal;
    }
}
