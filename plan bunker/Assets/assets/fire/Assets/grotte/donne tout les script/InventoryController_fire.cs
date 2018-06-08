using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryController_fire : MonoBehaviour {

	GraphicRaycaster graphicRaycaster;
	PointerEventData pointerEventData;
	List<RaycastResult> raycastResults;

	GameObject draggedItem;
	Transform draggedItemParent;

	// Use this for initialization
	void Start () {
		graphicRaycaster = GameObject.Find("Canvas").GetComponent<GraphicRaycaster>();
		pointerEventData = new PointerEventData(null);
		raycastResults = new List<RaycastResult>();

        //set the Cancel button
        transform.Find("Background/Buttons/Cancel").GetComponent<Button>().onClick.AddListener(() => {
            StartCoroutine(ToggleOff());
        });
	}

    IEnumerator ToggleOff() {
        yield return new WaitForEndOfFrame();
        gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		DragItems();
	}

	void DragItems(){
		if(Input.GetMouseButtonDown(0)){
			pointerEventData.position = Input.mousePosition;
			graphicRaycaster.Raycast(pointerEventData, raycastResults);
			if(raycastResults.Count > 0) {
                if (raycastResults[0].gameObject.GetComponent<item_fire>()) {
                    draggedItem = raycastResults[0].gameObject;
                    draggedItemParent = draggedItem.transform.parent;
                    draggedItem.transform.SetParent(UIManager_fire.instance.canvas);
                }
                //if raycast result is not an item
                else {
                    raycastResults.Clear();
                }
			}
		}

        //check if dragged item is null
        if (draggedItem == null) return;

		//Item follows mouse
		if(draggedItem != null){
			draggedItem.GetComponent<RectTransform>().localPosition = UIManager_fire.instance.ScreenToCanvasPoint(Input.mousePosition);
		}

		//End Dragging
		if(Input.GetMouseButtonUp(0)){
			pointerEventData.position = Input.mousePosition;
			raycastResults.Clear();
			graphicRaycaster.Raycast(pointerEventData, raycastResults);

			//Set old parent
			draggedItem.transform.SetParent(draggedItemParent);

			if(raycastResults.Count > 0){
				foreach(var result in raycastResults){
					//Skip the draggedItem when it is the result
					if(result.gameObject == draggedItem) continue;

					//Empty Slot
					if(result.gameObject.CompareTag("Slot")){
						//Set New Parent
						draggedItem.transform.SetParent(result.gameObject.transform);
						break;
					}
					//Another Item
					if(result.gameObject.CompareTag("ItemIcon")){
						//Swap Items
						if(result.gameObject.name != draggedItem.name){
							draggedItem.transform.SetParent(result.gameObject.transform.parent);
							result.gameObject.transform.SetParent(draggedItemParent);
							result.gameObject.transform.localPosition = Vector3.zero;
							break;
						}
						//Stack items (IF THE ARE THE SAME)
						else {
							result.gameObject.GetComponent<item_fire>().quantity += draggedItem.GetComponent<item_fire>().quantity;
							result.gameObject.transform.Find("QuantityText").GetComponent<Text>().text = result.gameObject.GetComponent<item_fire>().quantity.ToString();
							GameObject.Destroy(draggedItem);
							draggedItem = null;
							raycastResults.Clear();
							return;
						}
					}
				}
			}
			//Reset position to zero
			draggedItem.transform.localPosition = Vector3.zero;
			draggedItem = null;
		}

		raycastResults.Clear();
	}
}
