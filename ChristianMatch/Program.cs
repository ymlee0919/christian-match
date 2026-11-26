using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChristianMatch
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ChristianMatch.Baseball.GameScene());
            Application.Run(new MainForm());
            /*
            WalkingUp.GameScene scene = new WalkingUp.GameScene();
            
            scene.Team1 = "david";
            scene.Team2 = "josue";
            
            WalkingUp.Config c = new WalkingUp.Config();
            c.Steps = 30;
            c.LimitedTime = true;
            c.Questionarie = "Generales";
            c.ShowPossibleAnswers = true;
            c.Time = 20;
            
            scene.Config = c;

            Application.Run(scene);
             */
        }
    }
}
