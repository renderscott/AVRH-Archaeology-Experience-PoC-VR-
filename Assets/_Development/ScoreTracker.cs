using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public static ScoreTracker Instance;
    [SerializeField] private TMP_Text ui_text;

    private List<GameObject> ui_interacted = new List<GameObject>();
    private int ui_total;

    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui_total = FindObjectsByType<DisplayInformationIfHovered>().Length;
        updateText();
    }

    public void triggerInteraction(GameObject obj)
    {
        if(!ui_interacted.Contains(obj)) {
            ui_interacted.Add(obj);
            updateText();
        }
    }

    private void updateText()
    {
        ui_text.text = ui_interacted.Count + " / " + ui_total;
    }
}
