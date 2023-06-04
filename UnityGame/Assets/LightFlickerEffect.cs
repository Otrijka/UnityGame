using UnityEngine;
using System.Collections.Generic;

public class LightFlickerEffect : MonoBehaviour {
    [Tooltip("External light to flicker; you can leave this null if you attach script to a light")]
    public new Light light;
    [Tooltip("Minimum random light intensity")]
    public float minIntensity = 0f;
    [Tooltip("Maximum random light intensity")]
    public float maxIntensity = 1f;
    [Tooltip("Delay (ms)")]
    public float delay = 0f;

    float time = 0f;
    void Start() {
         if (light == null) {
            light = GetComponent<Light>();
         }
    }

    void Update() {
        if (light == null)
            return;

        time = time + 1f * Time.deltaTime;
        if (time >= delay){

        light.intensity = (light.intensity == minIntensity) ? maxIntensity : minIntensity;
        time = 0f;
        }
    }

}