namespace Interfaces
{
    internal interface ISelectable
    {
        void Select();
        void Deselect();
        void Toggle();

        bool IsSelected { get; }
    }

    class RadioButton : ISelectable
    {
        bool isSelected;
        public bool IsSelected => isSelected;

        public void Deselect()
        {
            isSelected = false;
        }

        public void Select()
        {
            isSelected = true;
        }

        public void Toggle()
        {
            isSelected = !isSelected;
        }
    }
}
