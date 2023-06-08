using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanTouchController : MonoBehaviour
{
    public float throwForce = 5.0f;

    void Start() {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android) {
            if (Input.touchCount == 1) {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Ended) {
                    Vector3 touchPosition = transform.gameObject.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10f));

                    RaycastHit hit;
                    if (Physics.Raycast(transform.position, touchPosition - transform.position, out hit)) {
                        if (hit.collider.transform.gameObject.CompareTag("Can")) {
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * throwForce, ForceMode.Impulse);
                        }
                    }
                }
            }
        }
        else {
            if (Input.GetMouseButtonUp(0)) {
                Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
                mousePosition = transform.gameObject.GetComponent<Camera>().ScreenToWorldPoint(mousePosition);

                RaycastHit hit;
                if (Physics.Raycast(transform.position, mousePosition - transform.position, out hit)) {
                    if (hit.collider.transform.gameObject.CompareTag("Can")) {
                        hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * throwForce, ForceMode.Impulse);
                    }
                }
            }
        }
    }
}
