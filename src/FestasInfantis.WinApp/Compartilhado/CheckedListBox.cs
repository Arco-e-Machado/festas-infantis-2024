using FestasInfantis.WinApp.ModuloItem;

public class CheckBoxItem : Item
{
    public string Text { get; set; }
    public bool Enabled { get; set; }

    public CheckBoxItem(Item Item)
    {
        Text = Item.Descricao;
        Enabled = Item.Locado;
    }

    public override string ToString()
    {
        return Text;
    }

}

