using UnityEngine;
using UnityEngine.UI;

public class DisplayFPS : MonoBehaviour
{
    [SerializeField]
    private Text fpsText;
    private float frameRate;

    // Update is called once per frame
    void Update()
    {
        frameRate = 1 / Time.deltaTime;
        frameRate = Mathf.Round(frameRate);

        fpsText.text = "FPS: " + frameRate;
    }
}
