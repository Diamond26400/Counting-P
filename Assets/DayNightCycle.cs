using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private Renderer skyRenderer;
    [SerializeField] private Texture[] dayTextures;
    [SerializeField] private Texture[] nightTextures;
    [SerializeField] private float dayDuration = 1200f; // in seconds

    private void Update()
    {
        float timeOfDay = Mathf.Repeat(Time.time / dayDuration, 1f);
        UpdateSky(timeOfDay);
    }

    private void UpdateSky(float timeOfDay)
    {
        int textureIndex = Mathf.FloorToInt(timeOfDay * dayTextures.Length);

        if (IsDaytime(timeOfDay))
        {
            skyRenderer.material.mainTexture = dayTextures[textureIndex];
            RenderSettings.skybox = skyRenderer.material; // Set the skybox material for day
        }
        else
        {
            skyRenderer.material.mainTexture = nightTextures[textureIndex];
            RenderSettings.skybox = skyRenderer.material; // Set the skybox material for night
        }
    }

    private bool IsDaytime(float timeOfDay)
    {
        // Adjust the threshold to determine when it's daytime or nighttime
        return timeOfDay < 0.5f;
    }
}
