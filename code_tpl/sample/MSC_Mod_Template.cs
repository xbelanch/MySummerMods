using MSCLoader;

namespace MSC_Mod_Template
{
    public class MSC_Mod_Template : Mod
    {
        public override string ID => "MSC_TPL";
        public override string Name => "Simple MSC Template";
        public override string Author => "Kosola";
        public override string Version => "1.0";
        public override string Description => "Just a simple MSC Mod Template";

        public override void MenuOnLoad()
        {
            base.MenuOnLoad();
            if (ModLoader.CurrentScene == CurrentScene.MainMenu)
            {
                ModPrompt.CreatePrompt("Hello MSC World!", "That's the way");
            }
        }
    }
}
