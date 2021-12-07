using System.Collections;
using UnityEngine;

public class ChangeLightColour : MonoBehaviour
{

    [SerializeField]
    private ChangeSkybox skyboxChanger;
    [SerializeField]
    private DayNightController dayNightController;

    [SerializeField]
    private Color dayColour;
    [SerializeField]
    private Color nightColour;
    [SerializeField]
    private float colourTransitionRate;

    private Light light;

    private bool isDay;
    private bool transitioning;

    public bool GetTransitioning()
    {
        return transitioning;
    }

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        isDay = true;
        transitioning = false;
    }

    public void SetTransition()
    {
        if (isDay)
        {
            //transition to night
            skyboxChanger.SetSkybox(3);
        }
        else
        {
            //transition to day
            skyboxChanger.SetSkybox(3);
        }
        //change daytime
        isDay = !isDay;
        transitioning = true;
    }

    private void Update()
    {
        if (transitioning)
        {
            if (isDay)
            {
                //transition to daytime
                light.color = Color.Lerp(light.color, dayColour, colourTransitionRate * Time.deltaTime);
            }
            else
            {
                //transition to nighttime
                light.color = Color.Lerp(light.color, nightColour, colourTransitionRate * Time.deltaTime);
            }
            //if finished lerping
            if ((isDay && light.color == dayColour) || (!isDay && light.color == nightColour))
            {
                //finalise changes to lighting
                if (isDay)
                {
                    light.color = dayColour;
                    skyboxChanger.SetSkybox(1);
                } else
                {
                    light.color = nightColour;
                    skyboxChanger.SetSkybox(2);
                }
                dayNightController.ResetTimer();
                transitioning = false;
            }
        }
    }

}
