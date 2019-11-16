using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;


public class Order : MonoBehaviour
{
    [SerializeField] private Text liquid;
    [SerializeField] private Text topping;
    [SerializeField] private FloatMug mug;
    public SkinnedMeshRenderer bs;

    private bool win = false;
    private bool lose = false;
    private List<string> liquids;
    private List<string> toppings;
    private List<string> order;
    // Start is called before the first frame update
    private void Awake()
    {
        
        liquids = new List<string>();
        
        liquids.Add("PEPTO");
        liquids.Add("ROOT BEER");
        liquids.Add("PEE PEE");
        
        toppings = new List<string>();
        
        toppings.Add("POOPIE");
        toppings.Add("RADIATION");
        toppings.Add("TAR");
        toppings.Add("SEA WATER");

        order = new List<string>();
        
        order.Add(liquids[Random.Range(0, liquids.Count)]);
        order.Add(toppings[Random.Range(0, toppings.Count)]);
        liquid.text = order[0];
        topping.text = order[1];
    }

    private void OnMouseDown()
    {
        if (mug.ingredients.Contains(order[0]))
        {
            if (mug.ingredients.Contains(order[1]))
            {
                win = true;
                Debug.Log("win");
                
                StartCoroutine(Smile());
            }
        }
        else
        {
            lose = true;
            Debug.Log("lose");
            SceneManager.LoadScene("SampleScene");
            
        }
    }

    private IEnumerator Smile()
    {
        float count = 0;
        while (count < 100)
        {
            count += 10;
            bs.SetBlendShapeWeight(0, count);
            
            yield return null;
        }
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("endscene");
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
