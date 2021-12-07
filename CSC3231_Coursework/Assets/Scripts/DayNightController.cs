using UnityEngine;

public class DayNightController : MonoBehaviour
{

    [SerializeField]
    private ChangeLightColour lightChanger;

    [SerializeField]
    [Range(0,20)]
    private float dayNightLength;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        //always reducing the timer.
        //if the timer hits 0, need to transition time of day.
        if (timer >= 0f)
        {
            timer -= Time.deltaTime;
        } else if (!lightChanger.GetTransitioning())
        {
            //transition to other daytime.
            lightChanger.SetTransition();
        }
        
    }

    public void ResetTimer()
    {
        timer = dayNightLength;
    }

}
