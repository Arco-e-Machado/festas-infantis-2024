using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloItem;

public class CustomCheckedListBox : CheckedListBox
{
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (e.Index < 0) { return; }

        CheckBoxItem item = Items[e.Index] as CheckBoxItem;

        e.DrawBackground();

        bool isChecked = GetItemChecked(e.Index);
        bool isEnabled = !GetItemDisabled(e.Index);

        CheckBoxState state = isEnabled
            ? (isChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal)
            : (isChecked ? CheckBoxState.CheckedDisabled : CheckBoxState.UncheckedDisabled);

        Size CheckBoxSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, state);
        Point CheckBoxLocation = new Point(e.Bounds.Left, e.Bounds.Top + (e.Bounds.Height - CheckBoxSize.Height) / 2);

        CheckBoxRenderer.DrawCheckBox(e.Graphics, CheckBoxLocation, state);

        Rectangle iRect = e.Bounds;
        iRect.X += CheckBoxSize.Width;
        iRect.Width -= CheckBoxSize.Width;

        Color textColor = isEnabled ? SystemColors.ControlText : SystemColors.GrayText;
        TextRenderer.DrawText(e.Graphics, item.Text, this.Font, iRect, textColor);

        e.DrawFocusRectangle();
    }

    private bool GetItemDisabled(int index)
    {
        CheckBoxItem item = Items[index] as CheckBoxItem;
        return item != null && item.Enabled;
    }
}
