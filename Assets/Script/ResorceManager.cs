using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResorceManager : MonoBehaviour
{
 public int Budget;
public Text BudgetText;

 public bool DeductResources(int amount)
 {
  if (Budget >= amount)
        {
            Budget-= amount;
            return true; // Deduction successful
        }
        else
        {
            return false; // Not enough budget
        }
 }
 public void AddResources( int Ammount)
 {
     Budget += Ammount;

 }
 private void UpdateUI()
    {
        if (BudgetText != null)
        {
            BudgetText.text = "Budget: " + Budget;
        }
    }
}
