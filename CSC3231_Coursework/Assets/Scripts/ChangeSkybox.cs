using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{

    [SerializeField]
    private Material daySkybox;
    [SerializeField]
    private Material nightSkybox;
    [SerializeField]
    private Material transitionSkybox;

    //updates the skybox based on the input number.
    public void SetSkybox(int skyboxNumber)
    {
        switch (skyboxNumber)
        {
            case 1:
                RenderSettings.skybox = daySkybox;
                break;
            case 2:
                RenderSettings.skybox = nightSkybox;
                break;
            case 3:
                RenderSettings.skybox = transitionSkybox;
                break;
            default:
                Debug.Log("Skybox not set.");
                break;
        }
    }

}
