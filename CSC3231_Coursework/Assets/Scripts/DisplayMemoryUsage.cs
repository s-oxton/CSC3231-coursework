using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMemoryUsage : MonoBehaviour
{

    [SerializeField]
    private Text memoryText;

    ProfilerRecorder usedMemory;

    // Start is called before the first frame update
    void Start()
    {
        usedMemory = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "Total Used Memory");
    }

    // Update is called once per frame
    void Update()
    {
        memoryText.text = "Memory Usage: " + usedMemory.LastValue.ToString();
    }
}
