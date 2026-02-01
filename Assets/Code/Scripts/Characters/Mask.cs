using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public TextMeshProUGUI text;

    public string MaskName;

    public void ActiveText(ref int i)
    {
        if (text.text == MaskName) return;
        text.text = MaskName;
        i++;
    }
}