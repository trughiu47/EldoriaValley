using UnityEngine;
using UnityEngine.UI;

public class FontChanger : MonoBehaviour
{
    [SerializeField] Font customFont;

    void Start()
    {
        Text[] allTexts = FindObjectsOfType<Text>();
        foreach (Text text in allTexts)
        {
            text.font = customFont;
        }
    }
}