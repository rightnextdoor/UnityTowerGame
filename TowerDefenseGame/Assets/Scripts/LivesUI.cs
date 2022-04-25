using UnityEngine;
using TMPro;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI liveText;
        
    void Update()
    {
        liveText.text = PlayerStats.Lives + " LIVES";
    }
}
