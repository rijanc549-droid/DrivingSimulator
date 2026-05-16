using UnityEngine;
using System.Collections;

public class TrafficLightController : MonoBehaviour
{
    public Renderer redLight1;
    public Renderer yellowLight1;
    public Renderer greenLight1;

    public Renderer redLight2;
    public Renderer yellowLight2;
    public Renderer greenLight2;

    public Material redMat;
    public Material yellowMat;
    public Material greenMat;
    public Material offMat;

    void Start()
    {
        StartCoroutine(TrafficCycle());
    }

    IEnumerator TrafficCycle()
    {
        while (true)
        {
            // SIDE 1 GREEN
            greenLight1.material = greenMat;
            yellowLight1.material = offMat;
            redLight1.material = offMat;

            redLight2.material = redMat;
            yellowLight2.material = offMat;
            greenLight2.material = offMat;

            yield return new WaitForSeconds(5f);

            // SIDE 1 YELLOW
            greenLight1.material = offMat;
            yellowLight1.material = yellowMat;
            redLight1.material = offMat;

            yield return new WaitForSeconds(2f);

            // SIDE 2 GREEN
            redLight1.material = redMat;
            yellowLight1.material = offMat;
            greenLight1.material = offMat;

            redLight2.material = offMat;
            yellowLight2.material = offMat;
            greenLight2.material = greenMat;

            yield return new WaitForSeconds(5f);

            // SIDE 2 YELLOW
            greenLight2.material = offMat;
            yellowLight2.material = yellowMat;
            redLight2.material = offMat;

            yield return new WaitForSeconds(2f);
        }
    }
}
