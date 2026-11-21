using TMPro;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float time;

    void Update()
    {
        time += Time.deltaTime;
        textMeshPro.text = Mathf.Round(time).ToString();
    }
}
