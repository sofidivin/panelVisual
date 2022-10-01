namespace panelVisual
{
    static class Program
    {

        public static String Ruta_Base;

        public static String Entorno="";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if(Entorno == "escuela")
            {
                Ruta_Base = @"C:\Users\Alumno\Desktop\WindowsFormsApp1\";
            }
            else
            {
                Ruta_Base = @"C:\Users\LukaiN\source\repos\sofidivin\panelVisual\panelVisual\";
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}