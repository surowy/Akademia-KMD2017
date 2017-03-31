using MvvmCross.Platform.IoC;

namespace HelloWorld.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize ()
        {
            CreatableTypes ()
                .EndingWith ("Service")
                .AsInterfaces ()
                .RegisterAsLazySingleton ();

            RegisterAppStart<ViewModels.FirstViewModel> ();


            // nowy kod 
            // nowy kod 
            // 2 kod 
            // 2 kod 
            // nowy kod 
            // nowy kod 
            // nowy kod 

            // zmiana w 1 miejscu 
        }
    }
}
