using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private Light sun;
    [SerializeField] private Material skyboxMaterial;
    [SerializeField] private float dayDuration = 1200f; // in seconds

    private void Update()
    {
        float timeOfDay = Mathf.Repeat(Time.time / dayDuration, 1f);
        UpdateSun(timeOfDay);
        UpdateSkybox(timeOfDay);
    }

    private void UpdateSun(float timeOfDay)
    {
        sun.transform.localRotation = Quaternion.Euler(timeOfDay * 360f, 45f, 0f);
    }

    private void UpdateSkybox(float timeOfDay)
    {
        // Adjust skybox properties based on time of day
        Color skyColor = Color.Lerp(Color.black, Color.blue, timeOfDay);
        skyboxMaterial.SetColor("_SkyTint", skyColor);

        // Debug information
        Debug.Log("Time of Day: " + timeOfDay);
        Debug.Log("Sky Color: " + skyColor);
    }
}
