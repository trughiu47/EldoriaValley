using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject statusPanel;
    [SerializeField] GameObject toolbarPanel;
    [SerializeField] GameObject additionalPanel;
    [SerializeField] GameObject storePanel;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (additionalPanel.activeInHierarchy == true || storePanel.activeInHierarchy == true)
            {
                panel.SetActive(true);
                statusPanel.SetActive(true);
                toolbarPanel.SetActive(false);
                additionalPanel.SetActive(false);
                storePanel.SetActive(false);
            }
            else
            {
                panel.SetActive(!panel.activeInHierarchy);
                statusPanel.SetActive(!statusPanel.activeInHierarchy);
                toolbarPanel.SetActive(!toolbarPanel.activeInHierarchy);
            }
        }
    }

    public void Open()
    {
        panel.SetActive(true);
        //statusPanel.SetActive(true);
        toolbarPanel.SetActive(false);
    }

    public void Close()
    {
        panel.SetActive(false);
        //statusPanel.SetActive(false);
        toolbarPanel.SetActive(true);
        additionalPanel.SetActive(false);
    }
}
