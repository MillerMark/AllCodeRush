using System;
using System.Threading.Tasks;

namespace AllCodeRush.Code.DeadCode {
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Remove Redundant Type Specification.
        
      Use Case: Removes redundant type specifications from 
      lambda expression parameters.

      Available: When the caret is within a lambda expression 
      parameters list that includes type specifiers.
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
  public class RemoveRedundantTypeSpecification : Form {
    public RemoveRedundantTypeSpecification ()
    {
      InitializeComponent();
      btnLoad.Click += async (object sender, EventArgs e) => {
        await LoadListboxChoicesAsync();
        base.txtStatus.Text += "Button clicked.";
      };
    }

    #region Support
    async Task LoadListboxChoicesAsync ()
    {
      await Task.Delay(1000);
    }
    #endregion
  }
}
