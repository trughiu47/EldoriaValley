using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableControls : MonoBehaviour
{
    CharacterController characterController;
    ToolCharacterController toolsCharacter;
    InventoryController inventoryController;
    ToolbarController toolbarController;
    ItemContainerInteractController itemContainerInteractController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        toolsCharacter = GetComponent<ToolCharacterController>();
        inventoryController = GetComponent<InventoryController>();
        toolbarController = GetComponent<ToolbarController>();
        itemContainerInteractController = GetComponent<ItemContainerInteractController>();
    }

    public void DisableControl()
    {
        characterController.enabled = false;
        toolbarController.enabled = false;
        inventoryController.enabled = false;
        toolbarController.enabled = false;
        itemContainerInteractController.enabled = false;
    }

    public void EnableControl()
    {
        characterController.enabled = true;
        toolbarController.enabled = true;
        inventoryController.enabled = true;
        toolbarController.enabled = true;
        itemContainerInteractController.enabled = true;
    }
}
