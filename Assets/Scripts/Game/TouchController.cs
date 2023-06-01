using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public bool referenceParent = true;

    void Update() {
        if (Application.platform == RuntimePlatform.Android) {
            if (Input.touchCount == 1) {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Ended) {
                    Vector3 touchPosition = transform.parent.gameObject.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10f));

                    RaycastHit hit;
                    if (Physics.Raycast(transform.position, touchPosition - transform.position, out hit)) {
                        if (hit.collider.transform.parent.gameObject.CompareTag("Target")) {
                            Destroy(hit.collider.transform.parent.gameObject);
                        }
                    }
                }
            }
        }
        else {
            if (Input.GetMouseButtonUp(0)) {
                Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
                mousePosition = transform.parent.gameObject.GetComponent<Camera>().ScreenToWorldPoint(mousePosition);

                RaycastHit hit;
                if (Physics.Raycast(transform.position, mousePosition - transform.position, out hit)) {
                    if (hit.collider.transform.parent.gameObject.CompareTag("Target")) {
                        Destroy(hit.collider.transform.parent.gameObject);
                    }
                }
            }
        }
    }
}
