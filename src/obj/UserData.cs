namespace MKVmergeBatcher.src.obj
{
    class UserData
    {
        public Window windows = new Window();
        public ModelCreator modelCreator = new ModelCreator();

        public class Window
        {
            public int WindowWidth { get; set; }

        }
        public class ModelCreator
        {
            public string Name { get; set; } = "Bazzu";

        }
    }
}
