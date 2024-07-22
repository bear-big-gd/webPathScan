using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abinjcWebPathBrute
{
  using System;
  using System.Windows.Forms;
  using System.IO;
  using System.Xml.Serialization;
  using System.Collections.Generic;

  public class FormStateSaver
  {
    private const string STATE_FILE = "formState.xml";

    public static void SaveFormState(Form form)
    {
      var state = new FormState
      {
        FormName = form.Name,
        Controls = new List<ControlState>()
      };

      SaveControlsState(form.Controls, state.Controls);

      using (var writer = new StreamWriter(STATE_FILE))
      {
        var serializer = new XmlSerializer(typeof(FormState));
        serializer.Serialize(writer, state);
      }
    }

    public static void RestoreFormState(Form form)
    {
      if (!File.Exists(STATE_FILE)) return;

      using (var reader = new StreamReader(STATE_FILE))
      {
        var serializer = new XmlSerializer(typeof(FormState));
        var state = (FormState)serializer.Deserialize(reader);

        if (state.FormName != form.Name) return;

        RestoreControlsState(form.Controls, state.Controls);
      }
    }

    private static void SaveControlsState(Control.ControlCollection controls, List<ControlState> states)
    {
      foreach (Control control in controls)
      {
        var state = new ControlState { Name = control.Name };

        if (control is TextBox textBox)
        {
          state.Value = textBox.Text;
        }
        else if (control is CheckBox checkBox)
        {
          state.Value = checkBox.Checked.ToString();
        }
        else if (control is ComboBox comboBox)
        {
          state.Value = comboBox.SelectedIndex.ToString();
        }
        // Add more control types as needed

        states.Add(state);

        if (control.HasChildren)
        {
          state.ChildControls = new List<ControlState>();
          SaveControlsState(control.Controls, state.ChildControls);
        }
      }
    }

    private static void RestoreControlsState(Control.ControlCollection controls, List<ControlState> states)
    {
      foreach (var state in states)
      {
        var control = controls.Find(state.Name, true).FirstOrDefault();
        if (control == null) continue;

        if (control is TextBox textBox)
        {
          textBox.Text = state.Value;
        }
        else if (control is CheckBox checkBox)
        {
          checkBox.Checked = bool.Parse(state.Value);
        }
        else if (control is ComboBox comboBox)
        {
          comboBox.SelectedIndex = int.Parse(state.Value);
        }
        // Add more control types as needed

        if (state.ChildControls != null && control.HasChildren)
        {
          RestoreControlsState(control.Controls, state.ChildControls);
        }
      }
    }
  }

  [Serializable]
  public class FormState
  {
    public string FormName { get; set; }
    public List<ControlState> Controls { get; set; }
  }

  [Serializable]
  public class ControlState
  {
    public string Name { get; set; }
    public string Value { get; set; }
    public List<ControlState> ChildControls { get; set; }
  }
}
