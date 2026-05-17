using System.Collections;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    [Header("Light Renderers")]
    [Tooltip("Assign the MeshRenderer or Renderer component for each specific bulb.")]
    public Renderer redLightRenderer;
    public Renderer yellowLightRenderer;
    public Renderer greenLightRenderer;

    [Header("Materials")]
    public Material redMaterial;
    public Material yellowMaterial;
    public Material greenMaterial;
    public Material offMaterial; // Dark material for when the light is off

    [Header("Timing (Seconds)")]
    public float greenDuration = 5.0f;
    public float yellowDuration = 2.0f;
    public float redDuration = 5.0f;

    private void Start()
    {
        // Start the infinite loop for the traffic light sequence
        StartCoroutine(TrafficLightSequence());
    }

    private IEnumerator TrafficLightSequence()
    {
        while (true)
        {
            // --- GREEN LIGHT ON ---
            SetLights(greenMaterial, offMaterial, offMaterial);
            yield return new WaitForSeconds(greenDuration);

            // --- YELLOW LIGHT ON ---
            SetLights(offMaterial, yellowMaterial, offMaterial);
            yield return new WaitForSeconds(yellowDuration);

            // --- RED LIGHT ON ---
            SetLights(offMaterial, offMaterial, redMaterial);
            yield return new WaitForSeconds(redDuration);
        }
    }

    private void SetLights(Material greenMat, Material yellowMat, Material redMat)
    {
        if (greenLightRenderer != null) greenLightRenderer.material = greenMat;
        if (yellowLightRenderer != null) yellowLightRenderer.material = yellowMat;
        if (redLightRenderer != null) redLightRenderer.material = redMat;
    }
}
