using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FInalScore : MonoBehaviour
{

    public TextMeshProUGUI finalScore;
    public Transform endTrigger;
    void Update()
    {
        finalScore.text = endTrigger.position.z.ToString("0");
    }
}
