namespace Atividade2Aula5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Motor poupa = new Motor(1600,"yamaha");
            List<Motor> MotorList = new List<Motor>();
            MotorList.Add(poupa);
            Barco navio = new Barco(22, MotorList);
            Motor poupa2 = navio.motor[0];
            MessageBox.Show(navio.motor[0].marca.ToString());
            
        }   
    }
}