using UnityEngine;
using TMPro;

public class Betyg : MonoBehaviour
{
    [SerializeField] private GameObject betygPanel;
    [SerializeField] private TMP_Text betygText;

    // Swedish grades: A (highest) to F (not passed)
    public enum Betygsgrad { F, E, D, C, B, A }

    private Betygsgrad nuvarandeBetyg;

    public void SattBetyg(Betygsgrad betyg)
    {
        nuvarandeBetyg = betyg;

        if (betygText != null)
            betygText.text = "Betyg: " + betyg.ToString();

        VisaBetyg();
    }

    public void VisaBetyg()
    {
        if (betygPanel == null)
        {
            Debug.LogWarning("Betyg: betygPanel är inte tilldelat i Inspector.");
            return;
        }
        betygPanel.SetActive(true);
    }

    public void DoljBetyg()
    {
        if (betygPanel != null)
            betygPanel.SetActive(false);
    }

    public Betygsgrad HamtaBetyg()
    {
        return nuvarandeBetyg;
    }
}
