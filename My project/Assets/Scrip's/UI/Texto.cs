using UnityEngine;
using TMPro;


public class Texto : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ganasteText, perdisteText;
    // Start is called before the first frame update
    void Start()
    {
        ganasteText.enabled = false;
        perdisteText.enabled = false;
    }
}
