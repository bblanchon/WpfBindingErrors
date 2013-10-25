namespace SampleWpfApplication
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Main = new MainWindowViewModel();
        }

        public MainWindowViewModel Main
        {
            get;
            private set;
        }
    }
}
