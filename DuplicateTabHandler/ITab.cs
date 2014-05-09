namespace SimplifierSoftware.DuplicateTabHandler
{
    interface ITab
    {
        string FullyJustifiedFileName
        {
            get;
            set;
        }

        string VisibleTabName
        {
            get;
            set;
        }

        bool ExpandTabName();
    }
}
