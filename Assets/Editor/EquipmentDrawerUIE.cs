/*using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEditor;


[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawerUIE : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        // Create property container element.
        var container = new VisualElement();

        // Create property fields.
        var AttackField = new PropertyField(property.FindPropertyRelative("Attack"));
        var DefenseField = new PropertyField(property.FindPropertyRelative("Defense"));
        var nameField = new PropertyField(property.FindPropertyRelative("name"), "Fancy Name");

        // Add fields to the container.
        container.Add(AttackField);
        container.Add(DefenseField);
        container.Add(nameField);

        return container;
    }
}
*/